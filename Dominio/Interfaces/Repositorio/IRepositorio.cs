namespace MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;

public interface IRepositorio<T> where T : class
{
    IQueryable<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}