using LabOps.Application.DTO.DTO.Situacao;
using LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebAPI.Controllers
{
    public class SituacaoController : ControllerBase
    {
        private readonly IApplicationServiceSituacao applicationService;
        private readonly ILogger<SituacaoController> logger;

        public SituacaoController(IApplicationServiceSituacao applicationService, ILogger<SituacaoController> logger)
        {
            this.applicationService = applicationService;
            this.logger = logger;
        }

        [HttpGet("BuscarTodasSituaçõesAtivas")]
        public async Task<IActionResult> BuscaTodasSituacaoAtiva()
        {
            logger.LogInformation("Iniciando processo para buscar informações no banco");
            try
            {
                var dados = await applicationService.BuscaTodasSituacaoAtiva();
                logger.LogInformation("Quantidade de dados retornados: {@Dados}", dados.Count());
                return Ok(dados);
            }
            catch (Exception ex)
            {
                logger.LogError("Ocorreu um erro: {@Mensagem}", ex.Message);
                return StatusCode(StatusCodes.Status400BadRequest, "Ocorreu um erro ao buscar as situações ativas.");
            }
        }
    }
}