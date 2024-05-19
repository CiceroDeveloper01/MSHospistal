using MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace MSCadastroMedicoPacienteRepositorio;

public class Repositorio<TEntidade> : IRepositorio<TEntidade> where TEntidade : class 
{
    private readonly DbContext _context;

    public Repositorio(DbContext context)
    {
        _context = context ;
    }

    public IQueryable<TEntidade> GetAll()
    {
        return _context.Set<TEntidade>().AsQueryable();
    }

    public void Add(TEntidade entity)
    {
        _context.Set<TEntidade>().Add(entity);
    }

    public void Update(TEntidade entity)
    {
        _context.Set<TEntidade>().Update(entity);
    }

    public void Delete(TEntidade entity)
    {
        _context.Set<TEntidade>().Remove(entity);
    }
}