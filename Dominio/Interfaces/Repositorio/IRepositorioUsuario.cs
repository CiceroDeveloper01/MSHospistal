using MSCadastroMedicoPacienteDominio.Usuarios;

namespace MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;

public interface IRepositorioUsuario : IRepositorio<UsuarioDominio>
{
    Task<UsuarioDominio> Autenticacao(UsuarioRequisicao usuarioRequisicao);
}
