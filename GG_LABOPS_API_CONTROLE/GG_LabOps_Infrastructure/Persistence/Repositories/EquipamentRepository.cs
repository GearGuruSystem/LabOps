using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Exceptions;
using GG_LabOps_Domain.Interfaces;
using GG_LabOps_Infrastructure.DataAcess;
using Microsoft.IdentityModel.Tokens;

namespace GG_LabOps_Infrastructure.Persistence.Repositories
{
    public class EquipamentRepository : IEquipamentRepository
    {
        private readonly ISqlDataAcess _sqlData;

#pragma warning disable IDE0290 // Use primary constructor
        public EquipamentRepository(ISqlDataAcess sqlData)
        {
            _sqlData = sqlData;
        }

        public async Task<IEnumerable<ViewEquipamentDTO>> GetAllAsync()
        {
            var result = await _sqlData.LoadDataAsync<ViewEquipamentDTO, dynamic>("[dbo].[LABOPS_CONSULTA_TODAS_MAQUINAS]", new { });
            if (result.IsNullOrEmpty())
            {
                throw new BancoDeDadosExceptions("Não foi encontrando nenhum registro no banco.");
            }
            return result;
        }

        public async Task<ViewEquipamentDTO> GetByIdAsync(int id)
        {
            var result = await _sqlData.LoadDataAsync<ViewEquipamentDTO, dynamic>("[dbo].[LABOPS_CONSULTA_MAQUINA_POR_ID]", new
            {
                @idParam = id
            });
            if (result.IsNullOrEmpty())
            {
                throw new BancoDeDadosExceptions("Não foi encontrando nenhum registro no banco.");
            }
            return result.FirstOrDefault();
        }

        public async Task<CreateEquipamentDTO> CreateAsync(CreateEquipamentDTO equipament)
        {

            var result = await _sqlData.SaveDataAsync("[dbo].[LABOPS_CADASTRA_MAQUINATESTE]", new
            {
                @Inventario = equipament.Inventario.Trim().ToUpper(),
                @Hostname = equipament.Hostname.Trim().ToUpper(),
                @NumeroSerie = equipament.NumeroSerie.Trim().ToUpper(),
                @IdMarca = equipament.MarcaId,
                @IdModelo = equipament.ModeloId,
                @IdTipo = equipament.TipoId,
                equipament.Ativa
            });
            if (result.IsCompleted)
            {
                return equipament;
            }
            throw new BancoDeDadosExceptions();
        }

        public async Task<UpdateEquipamentDTO> UpdateAsync(int id, UpdateEquipamentDTO equipament)
        {
            var result = await _sqlData.SaveDataAsync("[dbo].[LABOPS_ATUALIZA_MAQUINA]", new
            {
                @Id = id,
                @Inventario = equipament.Inventario.Trim().ToUpper(),
                @Hostname = equipament.Hostname.Trim().ToUpper(),
                @NumeroSerie = equipament.NumeroSerie.Trim().ToUpper(),
                @IdMarca = equipament.MarcaId,
                @IdModelo = equipament.ModeloId,
                @IdTipo = equipament.TipoId,
                @Ativo = equipament.Ativa
            });
            if (result.IsCompleted)
            {
                return equipament;
            }
            throw new BancoDeDadosExceptions();
        }

        public async Task<bool> DisableById(int id)
        {
            var data = await GetByIdAsync(id);
            var result = await _sqlData.SaveDataAsync("", new
            {
                @Id = id,
                @Ativo = data.Ativa,
            });
            if (result.IsCompleted)
            {
                return true;
            }
            throw new BancoDeDadosExceptions();
        }
    }
}
