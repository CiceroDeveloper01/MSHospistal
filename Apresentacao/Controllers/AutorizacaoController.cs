using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSCadastroMedicoPacienteDominio.Usuarios;
using Swashbuckle.AspNetCore.Annotations;

namespace MSCadastroMedicoPacienteApresentacao.Controllers;

public class AutorizacaoController : Controller
{
    [HttpGet()]
    [Route("v1/medico/GetId")]
    [SwaggerResponse(200, "Exito no Trabalho")]
    [SwaggerResponse(400, "A solicitação foi inválida ou mal formatada")]
    [SwaggerResponse(401, "Caso Não Esteja Autorizado")]
    [SwaggerResponse(403, "Caso As Suas Pemissões Sejam Insuficientes")]
    [SwaggerResponse(500, "Informações Não Localizadas")]
    [Authorize]
    public Task<IActionResult> Autenticacao([FromBody] UsuarioRequisicao usuarioRequisicao)
    {
        throw new NotImplementedException();
    }
}