﻿using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infrastructure.Data.DataAcess;
using LabOps.Infrastructure.Data.DataContext;
using Microsoft.IdentityModel.Tokens;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infrastructure.Repository.Repository
{
    public class RepositoryEquipamento : RepositoryBase<Equipamento>, IRepositoryEquipamento
    {
        private readonly SqlFactory sqlFactory;

        public RepositoryEquipamento(SqlFactory sqlFactory, AppDbContext context)
            : base(context)
        {
            this.sqlFactory = sqlFactory;
        }

        public override async Task<IEnumerable<Equipamento>> BuscarTodos()
        {
            var resultSql = await sqlFactory.LoadDataAsync<Equipamento, dynamic>("", new { });
            if (resultSql.IsNullOrEmpty())
            {
                throw new Exception("Não foi encontrando nenhum registro no banco.");
            }
            return resultSql;
        }

        public override Task<ICollection<Equipamento>> BuscarTodosPorPagina(int pageNumber, int pageSize)
        {
            return base.BuscarTodosPorPagina(pageNumber, pageSize);
        }

        public override async Task<IEnumerable<Equipamento>> BuscarPorParametro(Equipamento obj)
        {
            var resultadoSql = await sqlFactory.LoadDataAsync<Equipamento, dynamic>("", new { });
            if (resultadoSql.IsNullOrEmpty())
            {
                throw new Exception("Não foi encontrando nenhum registro no banco.");
            }
            return resultadoSql;
        }

        public override async Task<Equipamento> BuscarPorId(int id)
        {
            var resultadoSql = await sqlFactory.LoadDataAsync<Equipamento, dynamic>("", new
            {
                @idParam = id
            });
            if (resultadoSql.Count != 0)
            {
                return resultadoSql.FirstOrDefault();
            }
            throw new Exception("Não foi encontrando nenhum registro no banco.");
        }

        public override async void Registrar(Equipamento obj)
        {
            var resultadoSql = await sqlFactory.SaveDataAsync("", new
            {

            });
            if (!resultadoSql.IsCompleted)
            {
                throw new Exception($"Falha ao inserir o {obj.Nome} no banco!");
            }
        }

        public override async void Atualizar(Equipamento obj)
        {
            var result = await sqlFactory.SaveDataAsync("", new
            {

            });
            if (!result.IsCompleted)
            {
                throw new Exception();
            }
        }

        public override async void Remove(Equipamento obj)
        {
            var result = await sqlFactory.SaveDataAsync("", new
            {

            });
            if (!result.IsCompleted)
            {
                throw new Exception();
            }
        }
    }
}
