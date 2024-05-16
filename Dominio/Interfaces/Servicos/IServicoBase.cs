using MSCadastroMedicoPacienteShared.Comandos.Interfaces;

namespace MSCadastroMedicoPacienteDominio.Interfaces.Servicos;

public interface IServicoBase<Requisicao>
{
    public Task<IComandoResultado> Add(Requisicao requisicao);
    public Task<IComandoResultado> GetId(int ID);
    public Task<IComandoResultado> GetAll(Requisicao requisicao);
    public Task<IComandoResultado> Update(Requisicao requisicao);
    public Task<IComandoResultado> Delete(Requisicao requisicao);
}