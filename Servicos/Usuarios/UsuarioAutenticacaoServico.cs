﻿using FluentValidation;
using MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;
using MSCadastroMedicoPacienteDominio.Interfaces.Servicos.Usuarios;
using MSCadastroMedicoPacienteDominio.Usuarios;
using MSCadastroMedicoPacienteShared.Comandos.Dominio;
using MSCadastroMedicoPacienteShared.Comandos.Interfaces;
using MSCadastroMedicoPacienteShared.Enums;

namespace MSCadastroMedicoPacienteServicos.Usuarios;

public class UsuarioAutenticacaoServico : IServicoUsuarioAutenticacao
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IValidator<UsuarioRequisicaoAutenticacao> _usuarioValidarAutenticacao;

    public UsuarioAutenticacaoServico(IValidator<UsuarioRequisicaoAutenticacao> usuarioValidarAutenticacao,
                                      IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _usuarioValidarAutenticacao = usuarioValidarAutenticacao;
    }

    public async Task<IComandoResultado> Autenticacao(UsuarioRequisicaoAutenticacao usuarioRequisicao)
    {
        var validaAutenticacao = await _usuarioValidarAutenticacao.ValidateAsync(usuarioRequisicao);
        if (validaAutenticacao.IsValid)
        {
            var x = _unitOfWork._UsuariosRespositorio.Autenticacao(usuarioRequisicao);
            return new CriandoObjetoResultado((int)ERetornosApi.Ok,
                                              true,
                                              Mensagens.
                                              Autenticacao.
                                              Value.
                                              Replace(Mensagens.NomeCampo, nameof(UsuarioRequisicaoAutenticacao)), "Objeto DTO");
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