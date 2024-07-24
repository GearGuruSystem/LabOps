using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using LabOps.Application.DTO.DTO.Equipamentos;
using System.Text.Json.Serialization;
using LabOps.Application.DTO.DTO.CaracteristicaTipo;
using LabOps.Application.DTO.DTO.CaracteristicaValor;

namespace LabOps.Application.DTO.DTO.EquipamentoCaracteristica
{
    public class EquipamentoCaracteristicaDTO
    {
        public int Id { get; set; }

        public long IdEquipamento { get; set; }
        public EquipamentoDTO? Equipamento { get; set; }

        [JsonIgnore]
        public CaracteristicaTipoDTO CaracteristicaTipoDTO { get; set; }
        public int IdCaracteristicaTipo { get; set; }

        [JsonIgnore]
        public CaracteristicaValorDTO CaracteristicaValorDTO { get; set; }
        public int? IdCaracteristicaValor { get; set; }

        public string? ValorIndividual { get; set; }

        public string UsuarioAtualizacao { get; set; }

        [JsonIgnore]
        public DateTime AtualizadoEm { get; set; }
    }
}
