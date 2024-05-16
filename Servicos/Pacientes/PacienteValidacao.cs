using MSCadastroMedicoPacienteDominio.Interfaces.Servicos;
using MSCadastroMedicoPacienteDominio.Pacientes;
using MSCadastroMedicoPacienteShared.Comandos.Interfaces;

namespace MSCadastroMedicoPacienteServicos.Pacientes;

public class PacienteValidacao : IServicoPaciente
{
    public Task<IComandoResultado> Add(PacienteRequisicao requisicao)
    {
        throw new NotImplementedException();
    }

    public Task<IComandoResultado> Delete(PacienteRequisicao requisicao)
    {
        throw new NotImplementedException();
    }

    public Task<IComandoResultado> GetAll(PacienteRequisicao requisicao)
    {
        throw new NotImplementedException();
    }

    public Task<IComandoResultado> GetId(int ID)
    {
        throw new NotImplementedException();
    }

    public Task<IComandoResultado> Update(PacienteRequisicao requisicao)
    {
        throw new NotImplementedException();
    }
}