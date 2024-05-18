using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSCadastroMedicoPacienteDominio.Interfaces.Servicos.Pacientes;
using MSCadastroMedicoPacienteDominio.Pacientes;
using Swashbuckle.AspNetCore.Annotations;

namespace MSCadastroMedicoPacienteApresentacao.Controllers;

public class PacienteController : AbstractController<PacienteRequisicao>
{
    private readonly IServicoPaciente _servicoPaciente;
    private readonly ILogger<PacienteController> _logger;

    public PacienteController(IServicoPaciente servicoPaciente, ILogger<PacienteController> logger)
    {
        _servicoPaciente = servicoPaciente;
        _logger = logger;
    }

    [HttpPost()]
    [Route("v1/paciente/add")]
    [SwaggerResponse(201, "Ao Criar Com Exito o Objeto")]
    [SwaggerResponse(202, "Uma requisição foi aceita para processamento, mas não foi concluída")]
    [SwaggerResponse(400, "A solicitação foi mal formatada ou inválida")]
    [SwaggerResponse(401, "Caso Não Esteja Autorizado")]
    [SwaggerResponse(403, "Caso As Suas Pemissões Sejam Insuficientes")]
    [SwaggerResponse(500, "Erro Interno, Tente Novamente Mais Tarde")]
    [Authorize]
    public override Task<IActionResult> Add([FromBody] PacienteRequisicao domain)
    {
        throw new NotImplementedException();
    }

    [HttpDelete()]
    [Route("v1/paciente/delete")]
    [SwaggerResponse(202, "Uma requisição foi aceita para processamento, mas não foi concluída")]
    [SwaggerResponse(204, "A solicitação foi concluída com sucesso, mas não há nenhum conteúdo a retornar")]
    [SwaggerResponse(400, "A solicitação foi mal formatada ou inválida")]
    [SwaggerResponse(401, "Caso Não Esteja Autorizado")]
    [SwaggerResponse(403, "Caso As Suas Pemissões Sejam Insuficientes")]
    [SwaggerResponse(500, "Erro Interno, Tente Novamente Mais Tarde")]
    [Authorize]
    public override Task<IActionResult> Delete([FromBody] PacienteRequisicao domain)
    {
        throw new NotImplementedException();
    }

    [HttpGet()]
    [Route("v1/paciente/GetAll")]
    [SwaggerResponse(200, "Exito no Trabalho")]
    [SwaggerResponse(204, "A solicitação foi concluída com sucesso, mas não há nenhum conteúdo a retornar")]
    [SwaggerResponse(400, "A solicitação foi inválida ou mal formatada")]
    [SwaggerResponse(404, "O recurso solicitado não foi encontrado")]
    [SwaggerResponse(401, "Caso Não Esteja Autorizado")]
    [SwaggerResponse(403, "Caso As Suas Pemissões Sejam Insuficientes")]
    [SwaggerResponse(500, "Informações Não Localizadas")]
    [Authorize]
    public override Task<IActionResult> GetAll([FromBody] PacienteRequisicao domain)
    {
        throw new NotImplementedException();
    }

    [HttpGet()]
    [Route("v1/paciente/GetId")]
    [SwaggerResponse(200, "Exito no Trabalho")]
    [SwaggerResponse(204, "A solicitação foi concluída com sucesso, mas não há nenhum conteúdo a retornar")]
    [SwaggerResponse(400, "A solicitação foi inválida ou mal formatada")]
    [SwaggerResponse(404, "O recurso solicitado não foi encontrado")]
    [SwaggerResponse(401, "Caso Não Esteja Autorizado")]
    [SwaggerResponse(403, "Caso As Suas Pemissões Sejam Insuficientes")]
    [SwaggerResponse(500, "Informações Não Localizadas")]
    [Authorize]
    public override Task<IActionResult> GetId(int ID)
    {
        throw new NotImplementedException();
    }

    [HttpPut()]
    [Route("v1/paciente/update")]
    [SwaggerResponse(200, "Exito no Trabalho")]
    [SwaggerResponse(204, "A solicitação foi concluída com sucesso, mas não há nenhum conteúdo a retornar")]
    [SwaggerResponse(400, "A solicitação foi mal formatada ou inválida")]
    [SwaggerResponse(401, "Caso Não Esteja Autorizado")]
    [SwaggerResponse(403, "Caso As Suas Pemissões Sejam Insuficientes")]
    [SwaggerResponse(404, "O recurso solicitado não foi encontrado")]
    [SwaggerResponse(409, "Houve uma conflito ao processar a solicitação")]
    [SwaggerResponse(500, "Erro Interno, Tente Novamente Mais Tarde")]
    [Authorize]
    public override Task<IActionResult> Update([FromBody] PacienteRequisicao domain)
    {
        throw new NotImplementedException();
    }
}