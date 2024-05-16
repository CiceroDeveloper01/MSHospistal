using Microsoft.EntityFrameworkCore;

namespace MSCadastroMedicoPacienteRepositorio;

public class UnitOfWork : IUnitOfWork
{
    private readonly DbContext _context;
    private Dictionary<Type, object> _repositories;

    public UnitOfWork(DbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _repositories = new Dictionary<Type, object>();
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public IRepository<T> GetRepository<T>() where T : class
    {
        if (_repositories.ContainsKey(typeof(T)))
        {
            return _repositories[typeof(T)] as IRepository<T>;
        }

        var repository = new Repository<T>(_context);
        _repositories.Add(typeof(T), repository);
        return repository;
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}

