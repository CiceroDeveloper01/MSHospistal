namespace MSCadastroMedicoPacienteDominio.Interfaces.Repositorio


public interface IUnitOfWork : IDisposable
{
    void SaveChanges();
    IRepository<T> GetRepository<T>() where T : class;
}