using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabOps.Domain.Entities
{
    public class CaracteristicaValor
    {
        [Key, Required, Column("Cl_IdCaracteristicaValor")]
        public int Id { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, Column("Cl_Valor")]
        public string Valor { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, Column("Cl_UsuarioAtualizaco")]
        public string UsuarioAtualizacao { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, Column("Cl_AtualizadoEm")]
        public DateTime? AtualizadoEm { get; private set; }
        /*-------------------------------------------------------------------------------------------------*/
        public ICollection<EquipamentoCaracteristica> EquipamentoCaracteristicas { get; set; }
        /*-------------------------------------------------------------------------------------------------*/

        public CaracteristicaValor()
        {
        }

        public CaracteristicaValor(int id, string valor, string usuarioAtualizacao)
        {
            AddCaracteristicaValor(id, valor, usuarioAtualizacao);
        }

        private void AddCaracteristicaValor(int id, string valor, string usuarioAtualizacao)
        {
            Id = id;
            Valor = valor;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = DateTime.Now;
        }
    }
}