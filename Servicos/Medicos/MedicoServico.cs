using MSCadastroMedicoPacienteDominio.Interfaces.Servicos;
using MSCadastroMedicoPacienteDominio.Medicos;
using MSCadastroMedicoPacienteShared.Comandos.Interfaces;

public class MedicoServico : IServicoMedico
{
    public Task<IComandoResultado> Add(MedicoRequisicao requisicao)
    {
        throw new NotImplementedException();
    }

    public Task<IComandoResultado> Delete(MedicoRequisicao requisicao)
    {
        throw new NotImplementedException();
    }

    public Task<IComandoResultado> GetAll(MedicoRequisicao requisicao)
    {
        throw new NotImplementedException();
    }

    public Task<IComandoResultado> GetId(int ID)
    {
        throw new NotImplementedException();
    }

    public Task<IComandoResultado> Update(MedicoRequisicao requisicao)
    {
        throw new NotImplementedException();
    }
}