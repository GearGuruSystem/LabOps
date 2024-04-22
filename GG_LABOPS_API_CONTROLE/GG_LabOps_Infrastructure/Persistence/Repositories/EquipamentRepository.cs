using Dapper;
using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infrastructure.DataAcess;
using GG_LabOps_Infrastructure.Queries;
using System.Data;

namespace GG_LabOps_Infrastructure.Persistence.Repositories
{
    public class EquipamentRepository : IEquipamentRepository
    {
        private readonly ISqlDataAcess sqlData;
        private readonly IDbConnection connection;

#pragma warning disable IDE0290 // Use primary constructor
        public EquipamentRepository(ISqlDataAcess sqlData, ISqlFactory factory)
        {
            this.sqlData = sqlData;
            connection = factory.CreateConnection();
        }

        public async Task<IEnumerable<ViewEquipamentDTO>> GetAllAsync()
        {
            return await sqlData.LoadDataAsync<ViewEquipamentDTO, dynamic>("[dbo].[LABOPS_CONSULTA_TODAS_MAQUINAS]", new { });
        }

        public async Task<ViewEquipamentDTO> GetByIdAsync(int id)
        {
            QueryModel query = EquipamentQueries.GetEquipamentById(id);
            IEnumerable<ViewEquipamentDTO> response = await connection.QueryAsync<ViewEquipamentDTO>(query.Query, query.Parameters);
            return response.FirstOrDefault();
        }

        public async void CreateAsync(CreateEquipamentDTO equipament)
        {
            await sqlData.SaveDataAsync("[dbo].[LABOPS_CADASTRA_MAQUINATESTE]", new 
            { 
                inventario = equipament.Inventario.Trim().ToUpper(),
                hostname = equipament.Hostname.Trim().ToUpper(),
                numeroSerie = equipament.NumeroSerie.Trim().ToUpper(),
                idMarca = equipament.MarcaId,
                idModelo = equipament.ModeloId,
                idTipo = equipament.TipoId,
                ativa = equipament.Ativa
            });
        }

        public async Task<UpdateEquipamentDTO> UpdateAsync(int id, UpdateEquipamentDTO equipament)
        {
            await sqlData.SaveDataAsync("[dbo].[LABOPS_ATUALIZA_MAQUINA]", new 
            { 
                equipament
            });
            return equipament;
        }

        public bool DisableById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
