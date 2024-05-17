using Microsoft.EntityFrameworkCore;
using MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;
using MSCadastroMedicoPacienteDominio.Usuarios;

namespace MSCadastroMedicoPacienteRepositorio;

public class UsuarioRepositorio : Repositorio<UsuarioDominio>, IRepositorioUsuario
{
    public UsuarioRepositorio(DbContext context) : base(context) { }

    public Task<UsuarioDominio> Autenticacao(UsuarioRequisicao usuarioRequisicao)
    {
        throw new NotImplementedException();
    }
}