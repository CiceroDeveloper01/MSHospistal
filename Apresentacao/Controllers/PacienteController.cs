using Microsoft.AspNetCore.Mvc;
using MSCadastroMedicoPacienteDominio.Pacientes;

namespace MSCadastroMedicoPacienteApresentacao.Controllers;

public class PacienteController : AbstractController<PacienteRequisicao>
{
    public override Task<IActionResult> Add([FromBody] PacienteRequisicao domain)
    {
        throw new NotImplementedException();
    }

    public override Task<IActionResult> Delete([FromBody] PacienteRequisicao domain)
    {
        throw new NotImplementedException();
    }

    public override Task<IActionResult> GetAll([FromBody] PacienteRequisicao domain)
    {
        throw new NotImplementedException();
    }

    public override Task<IActionResult> GetId(int ID)
    {
        throw new NotImplementedException();
    }

    public override Task<IActionResult> Update([FromBody] PacienteRequisicao domain)
    {
        throw new NotImplementedException();
    }
}