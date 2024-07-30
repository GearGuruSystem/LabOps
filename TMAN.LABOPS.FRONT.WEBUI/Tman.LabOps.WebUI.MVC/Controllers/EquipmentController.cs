using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Equipamento;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Fabricante;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.Situacao;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.TiposEquipamentos;
using Tman.LabOps.WebUI.Application.Interfaces;

#pragma warning disable IDE0290

namespace Tman.LabOps.WebUI.MVC.Controllers
{
    [Route("Equipamentos")]
    public class EquipmentController : Controller
    {
        private readonly IHandlersEquipment _handlerEquipment;
        private readonly IHandlerManufacturer _handlerManufacturer;
        private readonly IHandlerEquipmentType _handlerEquipmentType;
        private readonly IHandlerSituation _handlerSituation;

        public EquipmentController(IHandlersEquipment handlerEquipment, IHandlerManufacturer handlerManufacturer,
            IHandlerEquipmentType handlerEquipmentType, IHandlerSituation handlerSituation)
        {
            _handlerEquipment = handlerEquipment;
            _handlerManufacturer = handlerManufacturer;
            _handlerEquipmentType = handlerEquipmentType;
            _handlerSituation = handlerSituation;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var dados = await _handlerEquipment.GetAllEquipment();
            return View(dados);
        }

        [HttpGet("Detalhes")]
        public async Task<IActionResult> Details(int id)
        {
            var dados = await _handlerEquipment.GetEquipmentById(id);
            return PartialView("_Details", dados);
        }

        [HttpGet("Cadastro")]
        public async Task<IActionResult> Register()
        {
            var vManufacturers = await _handlerManufacturer.GetAllManufacturers();
            ViewBag.ValuesEquipment = new SelectList(vManufacturers, nameof(FabricanteDTO.Id), nameof(FabricanteDTO.Nome));

            var vEquipmentType = await _handlerEquipmentType.GetAllEquipmentType();
            ViewBag.ValuesEquipmentType = new SelectList(vEquipmentType, nameof(TipoEquipamentoDTO.Id), nameof(TipoEquipamentoDTO.Descricao));

            var vSituation = await _handlerSituation.GetAllSituation();
            ViewBag.ValuesSituation = new SelectList(vSituation, nameof(SituacaoDTO.Id), nameof(SituacaoDTO.Descricao));

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(NewEquipamentoDTO criarNovoE)
        {
            await _handlerEquipment.RegisterEquipment(criarNovoE);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Editar")]
        public async Task<IActionResult> Edit(int id)
        {
            var equipEdit = await _handlerEquipment.GetEquipmentById(id);

            var vManufacturers = await _handlerManufacturer.GetAllManufacturers();
            ViewBag.ValuesEquipment = new SelectList(vManufacturers, nameof(FabricanteDTO.Id), nameof(FabricanteDTO.Nome), equipEdit.FabricanteDto.Id);

            var vEquipmentType = await _handlerEquipmentType.GetAllEquipmentType();
            ViewBag.ValuesEquipmentType = new SelectList(vEquipmentType, nameof(TipoEquipamentoDTO.Id), nameof(TipoEquipamentoDTO.Descricao), equipEdit.TipoEquipamentoDto.Id);

            var vSituation = await _handlerSituation.GetAllSituation();
            ViewBag.ValuesSituation = new SelectList(vSituation, nameof(SituacaoDTO.Id), nameof(SituacaoDTO.Descricao), equipEdit.SituacaoDto.Id);

            return View(equipEdit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditEquipamentoDTO editEquipmentDTO)
        {
            _handlerEquipment.UpdateEquipment(editEquipmentDTO);
            return RedirectToAction(nameof(Index));
        }
    }
}
