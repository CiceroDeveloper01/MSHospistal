namespace MSCadastroMedicoPacienteDominio.Interfaces.Repositorio;

public interface IRepositorio<TEntidade> where TEntidade : class
{
    IQueryable<TEntidade> GetAll();
    void Add(TEntidade entity);
    void Update(TEntidade entity);
    void Delete(TEntidade entity);
}