using FluentValidation;
using MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;
using MSCadastroMedicoPacienteDominio.Interfaces.Servicos.Usuarios;
using MSCadastroMedicoPacienteDominio.Usuarios;
using MSCadastroMedicoPacienteShared.Comandos.Dominio;
using MSCadastroMedicoPacienteShared.Comandos.Interfaces;
using MSCadastroMedicoPacienteShared.Enums;
using MSCadastroMedicoPacienteDominio.Usuarios.Mapeador;
using MSCadastroMedicoPacienteShared.Seguranca;
using System.Text.Json;
using System;

namespace MSCadastroMedicoPacienteServicos.Usuarios;

public class UsuarioAutenticacaoServico : IServicoUsuarioAutenticacao
{
    private readonly IRepositorioUsuario _repositorioUsuario;
    private readonly IValidator<UsuarioRequisicaoAutenticacao> _usuarioValidarAutenticacao;

    public UsuarioAutenticacaoServico(IValidator<UsuarioRequisicaoAutenticacao> usuarioValidarAutenticacao,
                                      IRepositorioUsuario repositorioUsuario)
    {
        _repositorioUsuario = repositorioUsuario;
        _usuarioValidarAutenticacao = usuarioValidarAutenticacao;
    }

    public async Task<IComandoResultado> Autenticacao(UsuarioRequisicaoAutenticacao usuarioRequisicao)
    {
        var validaAutenticacao = await _usuarioValidarAutenticacao.ValidateAsync(usuarioRequisicao);
        if (validaAutenticacao.IsValid)
        {
            var usuario = await _repositorioUsuario.Autenticacao(usuarioRequisicao);
            var usuuarioAutenticacao = usuario.UsuarioDominioParaUsuarioAutenticacao();
            return new CriandoObjetoResultado((int)ERetornosApi.Ok,
                                              true,
                                              Mensagens.
                                              Autenticacao.
                                              Value.
                                              Replace(Mensagens.NomeCampo, nameof(UsuarioRequisicaoAutenticacao)), CriarTokenAutenticacao.GerarToken(JsonSerializer.Serialize(usuuarioAutenticacao), DateTime.Now.AddHours(8)));
        }
        else
            return new CriandoObjetoResultado((int)ERetornosApi.NotAcceptable, 
                                              false, 
                                              Mensagens.
                                              AutenticacaoInvalida.
                                              Value.
                                              Replace(Mensagens.NomeCampo, nameof(UsuarioRequisicaoAutenticacao)), validaAutenticacao.Errors);
    }
}