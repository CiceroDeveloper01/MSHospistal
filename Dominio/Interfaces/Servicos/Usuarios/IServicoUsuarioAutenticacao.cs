using MSCadastroMedicoPacienteDominio.Usuarios;
using MSCadastroMedicoPacienteShared.Comandos.Interfaces;

namespace MSCadastroMedicoPacienteDominio.Interfaces.Servicos.Usuarios;

public interface IServicoUsuarioAutenticacao
{
    public Task<IComandoResultado> Autenticacao(UsuarioRequisicaoAutenticacao usuarioRequisicao);
}