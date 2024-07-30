using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Tman.LabOps.Infrastructure.CrossCutting.DTOs.TiposEquipamentos;
using Tman.LabOps.Infrastructure.CrossCutting.Interfaces;
using Tman.LabOps.Infrastructure.CrossCutting.Response;

namespace Tman.LabOps.Infrastructure.Data.ControlApi.Services
{
    public class ServicesEquipmentType : IServicesEquipmentType
    {
        private readonly HttpClient _client;

        public ServicesEquipmentType(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("ApiControl");
        }

        public async Task<IEnumerable<TipoEquipamentoDTO>> GetAllEquipmentType()
        {
            var resultClient = await _client.GetAsync("api/v1/TipoEquipamento/BuscarTodosTiposDeEquipamentos");
            if (resultClient.IsSuccessStatusCode)
            {
                var jsonString = await resultClient.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<ApiResponse<TipoEquipamentoDTO>>(jsonString);
                return jsonData.Data;
            }
            throw new Exception(); //ToDo: Adicionar novos exceptions de retorno.
        }

        public async Task<TipoEquipamentoDTO> GetEquipmentTypeById(int id)
        {
            var resultClient = await _client.GetAsync($"api/v1/TipoEquipamento/BuscarTipoDeEquipamentoPorId/{id}");
            if (resultClient.IsSuccessStatusCode)
            {
                var jsonString = await resultClient.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<TipoEquipamentoDTO>(jsonString);
                return jsonData;
            }
            throw new Exception(); //ToDo: Adicionar novos exceptions de retorno.
        }

        public async Task<TipoEquipamentoDTO> RegisterEquipmentType(NewTipoEquipamentoDTO nTipoEquipamento)
        {
            var resultClient = await _client.PostAsJsonAsync("api/v1/TipoEquipamento/RegistroTipoEquipamento", nTipoEquipamento);
            if (resultClient.IsSuccessStatusCode)
            {
                return new TipoEquipamentoDTO();
            }
            throw new Exception(); //ToDo: Adicionar novos exceptions de retorno.
        }

        public async void UpdateEquipmentType(TipoEquipamentoDTO tipoEquipamento)
        {
            var resultClient = await _client.PutAsJsonAsync("api/v1/Fabricante/AtualizarTipoEquipamento", tipoEquipamento);
            if (!resultClient.IsSuccessStatusCode)
            {
                throw new Exception(); //ToDo: Adicionar novos exceptions de retorno.
            }
        }
    }
}
