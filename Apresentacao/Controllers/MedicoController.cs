using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSCadastroMedicoPacienteDominio.Medicos;
using Swashbuckle.AspNetCore.Annotations;

namespace MSCadastroMedicoPacienteApresentacao.Controllers;

public class MedicoController : AbstractController<MedicoRequisicao>
{
    [HttpPost()]
    [Route("v1/medico/add")]
    [SwaggerResponse(201, "Ao Criar Com Exito o Objeto")]
    [SwaggerResponse(202, "Ao Criar Com Exito o Objeto")]
    [SwaggerResponse(401, "Caso Não Esteja Autorizado")]
    [SwaggerResponse(403, "Caso As Suas Pemissões Sejam Insuficientes")]
    [SwaggerResponse(500, "Informações Não Localizadas")]
    [Authorize]
    public override Task<IActionResult> Add([FromBody] MedicoRequisicao domain)
    {
        throw new NotImplementedException();
    }


    [HttpDelete()]
    [Route("v1/medico/delete")]
    [SwaggerResponse(201, "Ao Criar Com Exito o Objeto")]
    [SwaggerResponse(202, "Ao Criar Com Exito o Objeto")]
    [SwaggerResponse(401, "Caso Não Esteja Autorizado")]
    [SwaggerResponse(403, "Caso As Suas Pemissões Sejam Insuficientes")]
    [SwaggerResponse(500, "Informações Não Localizadas")]
    public override Task<IActionResult> Delete([FromBody] MedicoRequisicao domain)
    {
        throw new NotImplementedException();
    }

    [HttpGet()]
    [Route("v1/medico/GetAll")]
    [SwaggerResponse(200, "Recurso Encontrado")]
    [SwaggerResponse(404, "Ao Criar Com Exito o Objeto")]
    [SwaggerResponse(401, "Caso Não Esteja Autorizado")]
    [SwaggerResponse(403, "Caso As Suas Pemissões Sejam Insuficientes")]
    [SwaggerResponse(500, "Informações Não Localizadas")]
    public override Task<IActionResult> GetAll([FromBody] MedicoRequisicao domain)
    {
        throw new NotImplementedException();
    }

    [HttpGet()]
    [Route("v1/medico/GetId")]
    [SwaggerResponse(201, "Ao Criar Com Exito o Objeto")]
    [SwaggerResponse(202, "Ao Criar Com Exito o Objeto")]
    [SwaggerResponse(401, "Caso Não Esteja Autorizado")]
    [SwaggerResponse(403, "Caso As Suas Pemissões Sejam Insuficientes")]
    [SwaggerResponse(500, "Informações Não Localizadas")]
    public override Task<IActionResult> GetId(int ID)
    {
        throw new NotImplementedException();
    }

    [HttpPut()]
    [Route("v1/medico/update")]
    [SwaggerResponse(201, "Ao Criar Com Exito o Objeto")]
    [SwaggerResponse(202, "Ao Criar Com Exito o Objeto")]
    [SwaggerResponse(401, "Caso Não Esteja Autorizado")]
    [SwaggerResponse(403, "Caso As Suas Pemissões Sejam Insuficientes")]
    [SwaggerResponse(500, "Informações Não Localizadas")]
    public override Task<IActionResult> Update([FromBody] MedicoRequisicao domain)
    {
        throw new NotImplementedException();
    }
}