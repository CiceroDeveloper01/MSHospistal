using MSCadastroMedicoPacienteDominio.Usuarios;
using MSCadastroMedicoPacienteShared.Comandos.Interfaces;

namespace MSCadastroMedicoPacienteDominio.Interfaces.Servicos;

public interface IServicoUsuario
{
    public Task<IComandoResultado> Autenticacao(UsuarioRequisicao usuarioRequisicao);
}