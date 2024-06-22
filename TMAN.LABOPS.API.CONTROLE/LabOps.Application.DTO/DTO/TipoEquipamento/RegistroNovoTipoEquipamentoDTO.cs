using System.Text.Json.Serialization;

namespace LabOps.Application.DTO.DTO.TipoEquipamento
{
    public record RegistroNovoTipoEquipamentoDTO
    {
        public string Descricao { get; init; }
        public string UsuarioAtualizcao { get; init; }

        [JsonIgnore]
        public DateTime? AtualizadoEm { get; init; } = DateTime.Now;


        [JsonConstructor]
        public RegistroNovoTipoEquipamentoDTO(string descricao, string usuarioAtualizacao)
        {
            Descricao = descricao;
            UsuarioAtualizcao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now;
        }
    }
}
