using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabOps.Domain.Entities
{
    public class Equipamento
    {
        [Key, Required, Column("Cl_IdEquipamento")]
        public long Id { get; set; }

        [Required, StringLength(120), Column("Cl_Nome")]
        public string Nome { get; private set; }

        [StringLength(20), Column("Cl_Hostname")]
        public string? Hostname { get; private set; }

        [StringLength(16), Column("Cl_Inventario")]
        public string? Inventario { get; private set; }

        [Required, StringLength(30), Column("Cl_NumeroSerial")]
        public string SerialNumber { get; private set; }

        [Required, Column("Cl_IdSituacao")]
        public int IdSituacao { get; private set; }
        public Situacao Situacao { get; private set; }

        [Required, Column("Cl_IdTipoEquipamento")]
        public int IdTipoEquipamento { get; private set; }
        public TipoEquipamento TipoEquipamento { get; set; }

        [Required, Column("Cl_IdFabricante")]
        public int IdFabricante { get; private set; }
        public Fabricante Fabricante { get; set; }

        [Required, StringLength(20), Column("Cl_UsuarioInsercao")]
        public string UsuarioInsercao { get; private set; }

        [Required, Column("Cl_AtualizadoEm")]
        public DateTime? AtualizadoEm { get; private set; }

        public Laboratorio Laboratorio { get; set; }
        public ICollection<EquipamentoCaracteristica> EquipamentoCaracteristicas { get; set; }

        public Equipamento()
        {
        }
        
        public Equipamento(string nome, string? hostname, string? inventario, string serialNumber,
            int idSituacao, int idTipoEquipamento, int idFabricante, string usuarioInsercao)
        {
            AdicionarEquipamento(nome,  hostname, inventario, serialNumber, idSituacao, 
                idTipoEquipamento, idFabricante, usuarioInsercao);
        }
        
        private void AdicionarEquipamento(string nome, string? hostname, string? inventario, string serialNumber,
            int idSituacao, int idTipoEquipamento, int idFabricante, string usuarioInsercao)
        {
            Nome = nome;
            Hostname = hostname;
            Inventario = inventario;
            SerialNumber = serialNumber;
            IdSituacao = idSituacao;
            IdTipoEquipamento = idTipoEquipamento;
            IdFabricante = idFabricante;
            UsuarioInsercao = usuarioInsercao;
            AtualizadoEm = DateTime.Now;
        }
    }
}