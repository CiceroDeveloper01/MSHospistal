using MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;
using MSCadastroMedicoPacienteDominio.Interfaces.Servicos;
using MSCadastroMedicoPacienteDominio.Usuarios;
using MSCadastroMedicoPacienteShared.Comandos.Interfaces;

namespace MSCadastroMedicoPacienteServicos.Usuarios;

public class UsuarioServico : IServicoUsuario
{
    private readonly IRepositorioUsuario _repositorioUsuario;



    public Task<IComandoResultado> Autenticacao(UsuarioRequisicao usuarioRequisicao)
    {
        throw new NotImplementedException();
    }
}