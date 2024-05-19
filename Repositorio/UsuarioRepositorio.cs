using Microsoft.EntityFrameworkCore;
using MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;
using MSCadastroMedicoPacienteDominio.Usuarios;

namespace MSCadastroMedicoPacienteRepositorio;

public class UsuarioRepositorio : Repositorio<UsuarioDominio>, IRepositorioUsuario
{
    private readonly AppDbContext _context;

    public UsuarioRepositorio(AppDbContext context) : base(context) 
    {
        _context = context;
    }

    public async Task<UsuarioDominio> Autenticacao(UsuarioRequisicaoAutenticacao usuarioRequisicao)
    {
        return await _context.Usuario.Where(x => x.Email == usuarioRequisicao.Email
        && x.Senha == x.Senha).FirstOrDefaultAsync();
    }
}