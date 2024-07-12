using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataAcess;
using LabOps.Infra.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data.SqlTypes;

#pragma warning disable IDE0290
#pragma warning disable IDE0301
#pragma warning disable IDE0305

namespace LabOps.Infra.Repository.Repository
{
    public class RepositoryEquipamento : RepositoryBase<Equipamento>, IRepositoryEquipamento
    {
        private readonly SqlFactory _sqlFactory;
        private readonly AppDbContext _context;
        private readonly ILogger<RepositoryEquipamento> _logger;

        public RepositoryEquipamento(SqlFactory sqlFactory, AppDbContext context, ILogger<RepositoryEquipamento> logger)
            : base(context)
        {
            this._sqlFactory = sqlFactory;
            this._context = context;
            this._logger = logger;
        }

        public new async Task<IEnumerable<BuscarEquipamentos>> BuscarTodos()
        {
            _logger.LogInformation("Iniciando processo de busca no banco de dados");
            try
            {
                var resultSql = await _sqlFactory.LoadDataAsync<BuscarEquipamentos>("[dbo].[BuscarEquipamentosInfosCompletas]");
                return resultSql.ToList();
            }
            catch (SqlNullValueException ex)
            {
                _logger.LogError("Retornado o seguinte erro da consulta {@erroConsul}", ex);
                return Enumerable.Empty<BuscarEquipamentos>();
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro inesperado durante a consulta. [{@erro}]", ex);
                return Enumerable.Empty<BuscarEquipamentos>();
            }
        }

        public new async Task<BuscarEquipamentos> BuscarPorId(int id)
        {
            try
            {
                var parameters = new { @IdParam = id };
                var resultadoSql = await _sqlFactory.LoadDataAsync<BuscarEquipamentos>("[dbo].[BuscarEquipamentosInfosCompletasPorId]", parameters);
                return resultadoSql.FirstOrDefault();
            }
            catch (SqlNullValueException ex)
            {
                _logger.LogError("Retornado o seguinte erro da consulta {@erroConsul}", ex);
                return Enumerable.Empty<BuscarEquipamentos>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro inesperado durante a consulta. [{@erro}]", ex);
                return Enumerable.Empty<BuscarEquipamentos>().FirstOrDefault();
            }
        }

        public override void Registrar(Equipamento obj)
        {
            base.Registrar(obj);
        }

        public override void Atualizar(Equipamento obj)
        {
            base.Atualizar(obj);
        }

        public override void Deletar(Equipamento obj)
        {
            base.Deletar(obj);
        }

        public async Task<ICollection<Equipamento>> BuscarTodosPorPagina(int pageNumber, int pageSize)
        {
            return await _context.Equipamentos.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        }
    }
}