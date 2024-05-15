using System.ComponentModel.DataAnnotations;

namespace LabOps.Domain.Entities
{
    public class Equipamento : BaseEntity
    {
        [StringLength(120)]
        public string? Nome { get; private set; }

        public Equipamento()
        {
        }

        public Equipamento(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentNullException(nome);
            }
            Nome = nome;
        }

        public void AlteraNomeEquipamento(string novoNome)
        {
            if(string.IsNullOrEmpty(novoNome))
            {
                throw new ArgumentNullException(novoNome);
            }
            Nome = novoNome;
        }
    }
}
