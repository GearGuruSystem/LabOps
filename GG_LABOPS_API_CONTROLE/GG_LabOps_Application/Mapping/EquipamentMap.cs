using Dapper;
using GG_LabOps_Domain.Entities;
using System.Data;

namespace GG_LabOps_Application.Mapping
{
    public class EquipamentMap : SqlMapper.TypeHandler<Equipament>
    {
        public override Equipament Parse(object value)
        {
            if(value is not IDataRecord record)
            {
                throw new ArgumentException("Dado invalido para tipo Equipamento");
            }

            return new Equipament
            {
                Id = (long)record["id_equip"],
                LaboratoryId = (int)record["laboratorioId"],
                Inventory = (string)record["inventario"],
                Hostname = (string)record["hostname"],
                SerialNumber = (string)record["numeroSerial"],
                IsActive = (bool)record["ativo"],
                DateRegister = (DateTime)record["dataRegistro"],
                Brand = new BrandEquipament
                {
                    Id = (int)record["id_marca"],
                    BrandName = (string)record["nomeMarca"],
                    LastUpdate = (DateTime)record["ultimaAtualizacao"]
                },
                TypeEquip = new TypeEquipament
                {
                    Id = (int)record["id_tipo"],
                    TypeName = (string)record["nomeTipo"],
                    LastUpdate = (DateTime)record["ultimaAtualizacao"]
                },
                Model = new ModelEquipament
                {
                    Id = (int)record["id_modelo"],
                    ModelName = (string)record["nomeModelo"],
                    LastUpdate = (DateTime)record["ultimaAtualizacao"]
                }
            };
        }

        public override void SetValue(IDbDataParameter parameter, Equipament? value)
        {
            throw new NotImplementedException();
        }
    }
}
