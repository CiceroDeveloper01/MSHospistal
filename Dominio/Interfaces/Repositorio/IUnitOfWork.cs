namespace MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;


public interface IUnitOfWork : IDisposable
{
    void SaveChanges();
    IRepositorio<T> GetRepository<T>() where T : class;
}