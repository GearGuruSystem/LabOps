using LabOps.Application.DTO.DTO.Situacao;
using LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebAPI.Controllers
{
    public class SituacaoController : ControllerBase
    {
        private readonly IApplicationServiceSituacao applicationService;

        public SituacaoController(IApplicationServiceSituacao applicationService)
        {
            this.applicationService = applicationService;
        }

        [HttpGet("BuscarTodosComSituacaoAtiva")]
        public async Task<IActionResult> BuscaTodosComSituacaoAtiva(int pageNumber, int pageSize)
        {
            try
            {
                var dados = await applicationService.BuscaTodasSituacaoAtiva(pageNumber, pageSize);
                return Ok(dados);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("CadastraSituacao")]
        public IActionResult CadastraSituacao([FromBody] SituacaoDTO situacaoDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    applicationService.CadastraSituacao(situacaoDTO);
                    return Ok();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return BadRequest();
        }
    }
}
