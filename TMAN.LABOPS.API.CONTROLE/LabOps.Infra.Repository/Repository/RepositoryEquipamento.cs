using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Application.DTO.Response;
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

        public async Task<IEnumerable<Equipamento>> BuscarTodosPorPagina(int pageNumber, int pageSize)
        {
            try
            {
                var query = _context.Equipamentos.AsNoTracking()
                    .Include(x => x.Fabricante)
                    .Include(x => x.TipoEquipamento)
                    .Include(x => x.Situacao)
                    .Include(x => x.Laboratorio)
                    .OrderBy(x => x.Id);

                var equipaments = await query.Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                var totalCount = await query.CountAsync();

                return equipaments;
            }
            catch
            {
                //return new ResponsePaged<IEnumerable<Equipamento>>(false, "Não foi possivel consultar os equipamentos");
                throw;
            }
        }

        public async Task<Equipamento> BuscarComRetornoId(long id)
        {
            var data = await _context.Equipamentos
                .Include(x => x.Fabricante)
                .Include(x => x.TipoEquipamento)
                .Include(x => x.Situacao)
                .FirstOrDefaultAsync(x => x.Id == id);
            return data;
        }

        public override async Task Registrar(Equipamento obj)
        {
            await base.Registrar(obj);
        }

        public override async Task Atualizar(Equipamento obj)
        {
            await base.Atualizar(obj);
        }

        public override async Task Deletar(Equipamento obj)
        {
            await base.Deletar(obj);
        }
    }
}