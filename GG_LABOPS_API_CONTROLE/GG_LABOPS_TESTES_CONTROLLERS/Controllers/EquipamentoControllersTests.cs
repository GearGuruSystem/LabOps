using GG_LabOps_Application.Interfaces;
using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Exceptions;
using GG_LabOps_FakeData.EquipamentData;
using GG_LabOps_WebApi.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GG_LABOPS_TESTs.Controllers
{
    public class EquipamentoControllersTests
    {
        private readonly IEquipamentService _service;
        private readonly EquipamentController _controller;
        private readonly ViewEquipamentDTO _viewEquipament;
        private readonly List<ViewEquipamentDTO> _viewEquipamentData;
        private readonly CreateEquipamentDTO _createEquipament;

        public EquipamentoControllersTests()
        {
            _service = Substitute.For<IEquipamentService>();
            _controller = new EquipamentController(_service);

            _viewEquipament = new EquipamentViewFaker().Generate();
            _viewEquipamentData = new EquipamentViewFaker().Generate(50);
            _createEquipament = new CreateEquipamentFaker().Generate();
        }

        [Fact]
        public async Task BuscaTodosEquipamentos_OK()
        {
            var controller = new List<ViewEquipamentDTO>();
            _viewEquipamentData.ForEach(x => controller.Add(x.CloneTyped()));
            _service.GetEquipamentsAsync().Returns(_viewEquipamentData);

            var result = (ObjectResult)await _controller.BuscaTodosEquipamentos();

            await _service.Received().GetEquipamentsAsync();
            result.StatusCode.Should().Be(StatusCodes.Status200OK);
            result.Value.Should().BeEquivalentTo(controller);
        }

        [Fact]
        public async Task BuscaTodosEquipamentos_NotFound()
        {
            _service.GetEquipamentsAsync().Should().Throws<BancoDeDadosExceptions>();

            var result = (ObjectResult)await _controller.BuscaTodosEquipamentos();

            await _service.Received().GetEquipamentsAsync();
            result.StatusCode.Should().Be(StatusCodes.Status404NotFound);
        }

        [Fact]
        public async Task BuscaTodosEquipamento_BadRequest()
        {
            _service.GetEquipamentsAsync().Should().Throws<ErroGenericoException>();

            var result = (ObjectResult)await _controller.BuscaTodosEquipamentos();

            await _service.Received().GetEquipamentsAsync();
            result.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
        }

        [Fact]
        public async Task BuscaEquipamentosPeloId_Ok()
        {
            _service.GetEquipamentsAsync(Arg.Any<int>()).Returns(_viewEquipament.CloneTyped());

            var result = (ObjectResult)await _controller.BuscaEquipamentosPeloId((int)_viewEquipament.Id);

            await _service.Received().GetEquipamentsAsync(Arg.Any<int>());
            result.Value.Should().BeEquivalentTo(_viewEquipament);
            result.StatusCode.Should().Be(StatusCodes.Status200OK);
        }

        [Fact]
        public async Task BuscaEquipamentoPeloId_NotFound()
        {
            var idRandom = Arg.Any<int>();
            _service.GetEquipamentsAsync(idRandom).Should().Throws<BancoDeDadosExceptions>();

            var result = (ObjectResult)await _controller.BuscaEquipamentosPeloId(idRandom);

            await _service.Received().GetEquipamentsAsync(idRandom);
            result.StatusCode.Should().Be(StatusCodes.Status404NotFound);
        }

        [Fact]
        public async Task BuscaEquipamentoPeloId_BadRequest()
        {
            var idRandom = (int)_viewEquipament.Id;
            _service.GetEquipamentsAsync(idRandom).Should().Throws<ErroGenericoException>();

            var result = (ObjectResult)await _controller.BuscaEquipamentosPeloId(idRandom);

            await _service.Received().GetEquipamentsAsync(idRandom);
            result.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
        }

        [Fact]
        public async Task CadastraEquipamento_OK()
        {
            var createEquipamentDTO = _createEquipament.CloneTyped();
            var viewEquipamentDTO = _viewEquipament.CloneTyped();
            _service.RegisterEquipament(Arg.Any<CreateEquipamentDTO>()).Returns(viewEquipamentDTO);

            var result = (ObjectResult)await _controller.CadastraEquipamento(createEquipamentDTO);

            await _service.Received().RegisterEquipament(createEquipamentDTO);
            result.StatusCode.Should().Be(StatusCodes.Status201Created);
        }

        [Fact]
        public async Task CadastraEquipamento_BadRequest()
        {
            var createEquipamentDTO = _createEquipament.CloneTyped();
            _service.RegisterEquipament(createEquipamentDTO).Should().Throws<ErroGenericoException>();

            var result = (ObjectResult)await _controller.CadastraEquipamento(createEquipamentDTO);

            await _service.Received().RegisterEquipament(createEquipamentDTO);
            result.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
        }
    }
}
