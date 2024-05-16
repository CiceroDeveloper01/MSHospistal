using Microsoft.AspNetCore.Mvc;

namespace MSCadastroMedicoPacienteApresentacao.Controllers;

[ApiController]
public abstract class AbstractController<Domain> : Controller
{
    public abstract Task<IActionResult> Add([FromBody] Domain domain);

    public abstract Task<IActionResult> GetId(int ID);

    public abstract Task<IActionResult> GetAll([FromBody] Domain domain);

    public abstract Task<IActionResult> Update([FromBody] Domain domain);

    public abstract Task<IActionResult> Delete([FromBody] Domain domain);
}
