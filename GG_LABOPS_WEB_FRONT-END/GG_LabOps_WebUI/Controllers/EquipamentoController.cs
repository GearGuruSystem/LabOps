using AutoMapper;
using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Equipamentos;
using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Fabricantes;
using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.Situacao;
using LabOps.Infra.Data.CrossCutting.Adapter.DTOs.TiposEquipamentos;
using LabOps.Infra.Data.CrossCutting.Adapter.Interfaces.ApiControle;
using LabOps.WebUI.Models.Equipamentos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.WebUI.Controllers
{
    public class EquipamentoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IServicesEquipament _servicesEquipamento;
        private readonly IServicesFabricante _servicesFabricante;
        private readonly IServicesTipoEquipamento _servicesTipoEquipamento;
        private readonly IServicesSituacao _servicesSituacao;

        public EquipamentoController(IMapper mapper, IServicesEquipament service, IServicesFabricante serviceFabricante,
            IServicesTipoEquipamento servicesTipoEquipamento, IServicesSituacao servicesSituacao)
        {
            _mapper = mapper;
            _servicesEquipamento = service;
            _servicesFabricante = serviceFabricante;
            _servicesTipoEquipamento = servicesTipoEquipamento;
            _servicesSituacao = servicesSituacao;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var dados = await _servicesEquipamento.GetAllEquipament();
            var model = _mapper.Map<IEnumerable<EquipamentosModel>>(dados);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Detalhes(int id)
        {
            var dados = await _servicesEquipamento.GetEquipamentById(id);
            var model = _mapper.Map<EquipamentosModel>(dados);
            return PartialView("_Detalhes", model);
        }

        [HttpGet]
        public async Task<IActionResult> Cadastro()
        {
            var vFabricante = await _servicesFabricante.BuscaTodosFabricantes();
            ViewBag.ValuesEquipamento = new SelectList(vFabricante, nameof(FabricanteDTO.Id), nameof(FabricanteDTO.Nome));

            var vTipoEquipamento = await _servicesTipoEquipamento.BuscaTodosTiposDeEquipamentos();
            ViewBag.ValuesTipoEquip = new SelectList(vTipoEquipamento, nameof(TipoEquipamentoDTO.Id), nameof(TipoEquipamentoDTO.Descricao));

            var vSituacao = await _servicesSituacao.BuscarTodasSituacoes();
            ViewBag.ValuesSituacao = new SelectList(vSituacao, nameof(SituacaoDTO.Id), nameof(SituacaoDTO.Descricao));

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastro(CriarNovoEModel criarNovoE)
        {
            await _servicesEquipamento.RegisterEquipament(_mapper.Map<CriarNovoEDTO>(criarNovoE));
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Editar(int id)
        {
            var equipEdit = await _servicesEquipamento.GetEquipamentById(id);
            var model = _mapper.Map<EditarEquipamentoModel>(equipEdit);

            var vFabricante = await _servicesFabricante.BuscaTodosFabricantes();
            ViewBag.ValuesEquipamento = new SelectList(vFabricante, nameof(FabricanteDTO.Id), nameof(FabricanteDTO.Nome), equipEdit.FabricanteDto.Id);

            var vTipoEquipamento = await _servicesTipoEquipamento.BuscaTodosTiposDeEquipamentos();
            ViewBag.ValuesTipoEquip = new SelectList(vTipoEquipamento, nameof(TipoEquipamentoDTO.Id), nameof(TipoEquipamentoDTO.Descricao), equipEdit.TipoEquipamentoDto.Id);

            var vSituacao = await _servicesSituacao.BuscarTodasSituacoes();
            ViewBag.ValuesSituacao = new SelectList(vSituacao, nameof(SituacaoDTO.Id), nameof(SituacaoDTO.Descricao), equipEdit.SituacaoDto.Id);

            return View(model);
        }

        [HttpPost]
        public IActionResult Editar(EditarEquipamentoModel editarEquipamentoModel)
        {
            var map = _mapper.Map<EquipamentoDTO>(editarEquipamentoModel);
            _servicesEquipamento.UpdateEquipament(map);
            return RedirectToAction(nameof(Index));
        }
    }
}
