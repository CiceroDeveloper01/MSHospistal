using Microsoft.AspNetCore.Mvc;
using MSCadastroMedicoPacienteDominio.Medicos;

namespace MSCadastroMedicoPacienteApresentacao.Controllers;

public class MedicoController : AbstractController<MedicoRequisicao>
{
    public override Task<IActionResult> Add([FromBody] MedicoRequisicao domain)
    {
        throw new NotImplementedException();
    }

    public override Task<IActionResult> Delete([FromBody] MedicoRequisicao domain)
    {
        throw new NotImplementedException();
    }

    public override Task<IActionResult> GetAll([FromBody] MedicoRequisicao domain)
    {
        throw new NotImplementedException();
    }

    public override Task<IActionResult> GetId(int ID)
    {
        throw new NotImplementedException();
    }

    public override Task<IActionResult> Update([FromBody] MedicoRequisicao domain)
    {
        throw new NotImplementedException();
    }
}
