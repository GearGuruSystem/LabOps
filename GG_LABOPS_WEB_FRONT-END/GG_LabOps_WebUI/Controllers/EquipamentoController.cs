using LabOps.Application.DTOs.Equipamentos;
using LabOps.Application.Interfaces.ApiControle;
using LabOps.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebUI.Controllers
{
    public class EquipamentoController : Controller
    {
        private readonly IServicesEquipamento _service;

        public EquipamentoController(IServicesEquipamento service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var dados = await _service.GetAllEquipament();
            var modelDados = new List<EquipamentosModel>();
            foreach (var item in dados)
            {
                var model = new EquipamentosModel()
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Hostname = item.Hostname,
                    SerialNumber = item.SerialNumber,
                    UsuarioInsercao = item.UsuarioInsercao,
                    AtualizadoEm = item.AtualizadoEm,
                    SituacaoDescricao = item.SituacaoDescricao,
                    TipoEquipamentoDescricao = item.TipoEquipamentoDescricao,
                    FabricanteNome = item.FabricanteNome
                };
                modelDados.Add(model);
            }
            return View(modelDados);
        }

        public async Task<IActionResult> Detalhes(int id)
        {
            var dados = await _service.GetEquipamentById(id);
            var model = new EquipamentosModel()
            {
                Id = dados.Id,
                Nome = dados.Nome,
                Hostname = dados.Hostname,
                SerialNumber = dados.SerialNumber,
                UsuarioInsercao = dados.UsuarioInsercao,
                AtualizadoEm = dados.AtualizadoEm,
                SituacaoDescricao = dados.SituacaoDescricao,
                TipoEquipamentoDescricao = dados.TipoEquipamentoDescricao,
                FabricanteNome = dados.FabricanteNome
            };
            return PartialView("_Detalhes", model);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastro(CriarNovoE criarNovoE)
        {
            await _service.RegisterEquipament(criarNovoE);
            return RedirectToAction(nameof(Index));
        }
    }
}
