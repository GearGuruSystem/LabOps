using Dapper;
using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infrastructure.DataAcess;
using GG_LabOps_Infrastructure.Queries;
using System.Data;

namespace GG_LabOps_Infrastructure.Persistence.Repositories
{
    public class EquipamentRepository : IEquipamentRepository
    {
        private readonly ISqlDataAcess _sqlData;
        private readonly IDbConnection _connection;

#pragma warning disable IDE0290 // Use primary constructor
        public EquipamentRepository(ISqlDataAcess sqlData, ISqlFactory factory)
        {
            _sqlData = sqlData;
            _connection = factory.CreateConnection();
        }

        public async Task<IEnumerable<ViewEquipamentDTO>> GetAllAsync()
        {
            return await _sqlData.LoadDataAsync<ViewEquipamentDTO, dynamic>("[dbo].[LABOPS_CONSULTA_TODAS_MAQUINAS]", new { });
        }

        public async Task<ViewEquipamentDTO> GetByIdAsync(int id)
        {
            QueryModel query = EquipamentQueries.GetEquipamentById(id);
            var response = await _connection.QueryAsync<ViewEquipamentDTO>(query.Query, query.Parameters);
            return response.FirstOrDefault();
        }

        public async Task<CreateEquipamentDTO> CreateAsync(CreateEquipamentDTO equipament)
        {
            await _sqlData.SaveDataAsync("[dbo].[LABOPS_CADASTRA_MAQUINATESTE]", new
            {
                @Inventario = equipament.Inventario.Trim().ToUpper(),
                @Hostname = equipament.Hostname.Trim().ToUpper(),
                @NumeroSerie = equipament.NumeroSerie.Trim().ToUpper(),
                @IdMarca = equipament.MarcaId,
                @IdModelo = equipament.ModeloId,
                @IdTipo = equipament.TipoId,
                equipament.Ativa
            });
            return equipament;
        }

        public async Task<UpdateEquipamentDTO> UpdateAsync(int id, UpdateEquipamentDTO equipament)
        {
            await _sqlData.SaveDataAsync("[dbo].[LABOPS_ATUALIZA_MAQUINA]", new
            {
                @Id = id,
                @Inventario = equipament.Inventory.Trim().ToUpper(),
                @Hostname = equipament.Hostname.Trim().ToUpper(),
                @NumeroSerie = equipament.SerialNumber.Trim().ToUpper(),
                @MarcaId = equipament.BrandId,
                @TipoId = equipament.TypeId,
                @ModeloId = equipament.ModelId,
                @Ativo = equipament.IsActive
            });
            return equipament;
        }

        public async Task<bool> DisableById(int id)
        {
            var data = await GetByIdAsync(id);
            await _sqlData.SaveDataAsync("", new
            {
                @Id = id,
                @Ativo = data.IsActive,
            });
            return true;
        }
    }
}
