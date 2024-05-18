using MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;

namespace MSCadastroMedicoPacienteRepositorio;

public class Repositorio<T> : IRepositorio<T> where T : class
{
    protected readonly ApplicationDbContext _context;

    public Repositorio(ApplicationDbContext context)
    {
        _context = context ;
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