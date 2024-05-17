using Microsoft.EntityFrameworkCore;
using MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;

namespace MSCadastroMedicoPacienteRepositorio;

public class Repositorio<T> : IRepositorio<T> where T : class
{
    private readonly DbContext _context;

    public Repositorio(DbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public IQueryable<T> GetAll()
    {
        return _context.Set<T>().AsQueryable();
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
}