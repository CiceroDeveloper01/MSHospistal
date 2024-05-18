using FluentValidation;
using MSCadastroMedicoPacienteDominio.Usuarios;
using MSCadastroMedicoPacienteShared.Comandos.Dominio;

namespace MSCadastroMedicoPacienteServicos.Usuarios.Validadores;

public class UsuarioValidarAutenticacao : AbstractValidator<UsuarioRequisicaoAutenticacao>
{
    public UsuarioValidarAutenticacao()
    {
        RuleFor(usuarioValidarAutenticacao => usuarioValidarAutenticacao.Email)
               .NotNull()
               .NotEmpty()
               .WithMessage(Mensagens.CampoObrigatorioNaoPreenchido.Value.Replace(Mensagens.NomeCampo, "E-Mail"));
        RuleFor(usuarioValidarAutenticacao => usuarioValidarAutenticacao.Senha)
               .NotNull()
               .NotEmpty()
               .WithMessage(Mensagens.CampoObrigatorioNaoPreenchido.Value.Replace(Mensagens.NomeCampo, "Senha"));
        RuleFor(usuarioValidarAutenticacao => usuarioValidarAutenticacao.Senha)
               .EmailAddress()
               .WithMessage(Mensagens.EmailInvalido.Value.Replace(Mensagens.NomeCampo, "Email"));

    }
}