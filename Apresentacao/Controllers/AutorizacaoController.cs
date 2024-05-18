using Microsoft.AspNetCore.Mvc;
using MSCadastroMedicoPacienteDominio.Interfaces.Servicos.Usuarios;
using MSCadastroMedicoPacienteDominio.Usuarios;
using MSCadastroMedicoPacienteShared.Comandos.Dominio;
using MSCadastroMedicoPacienteShared.Enums;
using Swashbuckle.AspNetCore.Annotations;

namespace MSCadastroMedicoPacienteApresentacao.Controllers;

public class AutorizacaoController : Controller
{
    private readonly IServicoUsuarioAutenticacao _servicoUsuario;
    private readonly ILogger<AutorizacaoController> _logger;

    public AutorizacaoController(IServicoUsuarioAutenticacao servicoUsuario, ILogger<AutorizacaoController> logger)
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
    public async Task<IActionResult> Autenticacao([FromBody] UsuarioRequisicaoAutenticacao usuarioRequisicao)
    {
        try
        {
            _logger.LogInformation($@"Iniciando a Controller de Autenticação");

            var resposta = await _servicoUsuario.Autenticacao(usuarioRequisicao);

            return StatusCode(resposta.CodigoRetorno, resposta);
        }
        catch(Exception ex) 
        {
            var retorno = new CriandoObjetoResultado((int)ERetornosApi.InternalServerError, false, "Erro Interno na API", null);
            return StatusCode(retorno.CodigoRetorno, retorno);
        }
    }
}