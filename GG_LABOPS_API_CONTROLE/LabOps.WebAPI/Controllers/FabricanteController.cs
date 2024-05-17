using LabOps.Application.DTO.DTO;
using LabOps.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FabricanteController : ControllerBase
    {
        private readonly IApplicationServiceFabricante applicationService;

        public FabricanteController(IApplicationServiceFabricante applicationService)
        {
            this.applicationService = applicationService;
        }

        [HttpGet("BuscarTodosFabricantes")]
        public async Task<IActionResult> BuscarTodosFabricantes()
        {
            try
            {
                var data = await applicationService.BuscaTodosFabricantes();
                return Ok(data);
            }
            catch (Exception)
            {
                return BadRequest();                
            }
        }

        [HttpGet("BuscarFabricantePeloId/{id:int}")]
        public async Task<IActionResult> BuscarFabricantePeloId(int id)
        {
            try
            {
                var data = await applicationService.BuscaFabricantesPeloId(id);
                return Ok(data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("CadastraFabricante")]
        public IActionResult CadastraFabricante([FromBody] FabricanteDTO fabricanteDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    applicationService.RegistraFabricante(fabricanteDTO);
                    return Created("api/v1/fabricante", fabricanteDTO);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest();
        }

        [HttpPut("AtualizaFabricante")]
        public IActionResult AtualizarFabricante([FromBody] FabricanteDTO fabricanteDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    applicationService.AtualizaFabricante(fabricanteDTO);
                    return Ok();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return BadRequest();
        }

        [HttpDelete("RemoveFabricante")]
        public IActionResult RemoveFabricante([FromBody] FabricanteDTO fabricanteDTO)
        {
            try
            {
                applicationService.RemoveFabricante(fabricanteDTO);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
