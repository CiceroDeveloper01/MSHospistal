using Microsoft.EntityFrameworkCore;
using MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;
using MSCadastroMedicoPacienteDominio.Usuarios;

namespace MSCadastroMedicoPacienteRepositorio;

public class UsuarioRepositorio : Repositorio<UsuarioDominio>, IRepositorioUsuario
{
    public UsuarioRepositorio(DbContext context) : base(context) { }

    public async Task<UsuarioDominio> Autenticacao(UsuarioRequisicaoAutenticacao usuarioRequisicao)
    {
        return await _context.Set<UsuarioDominio>().Where(x => x.Email == usuarioRequisicao.Email
        && x.Senha == x.Senha).FirstOrDefaultAsync();
    }
}