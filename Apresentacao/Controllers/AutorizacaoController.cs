using Microsoft.AspNetCore.Mvc;
using MSCadastroMedicoPacienteDominio.Interfaces.Servicos;
using MSCadastroMedicoPacienteDominio.Usuarios;
using Swashbuckle.AspNetCore.Annotations;

namespace MSCadastroMedicoPacienteApresentacao.Controllers;

public class AutorizacaoController : Controller
{
    private readonly IServicoUsuario _servicoUsuario;
    private readonly ILogger<AutorizacaoController> _logger;

    public AutorizacaoController(IServicoUsuario servicoUsuario, ILogger<AutorizacaoController> logger)
    {
        _servicoUsuario = servicoUsuario;
        _logger = logger;
    }

    [HttpPost()]
    [Route("v1/autorizacao")]
    [SwaggerResponse(200, "Exito no Trabalho")]
    [SwaggerResponse(400, "A solicitação foi inválida ou mal formatada")]
    [SwaggerResponse(401, "Caso Não Esteja Autorizado")]
    [SwaggerResponse(403, "Caso As Suas Permissões Sejam Insuficientes")]
    [SwaggerResponse(500, "Informações Não Localizadas")]
    public async Task<IActionResult> Autenticacao([FromBody] UsuarioRequisicao usuarioRequisicao)
    {
        try
        {
            _logger.LogInformation($@"Iniciando a Controller de Autenticação");

            var resposta = await _servicoUsuario.Autenticacao(usuarioRequisicao);
        }
        catch(Exception ex) 
        { 
        
        }
        
        
    }
}