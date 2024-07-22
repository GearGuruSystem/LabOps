﻿using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Domain.Entities;

namespace LabOps.Domain.Core.Interfaces
{
    public interface IRepositoryEquipamento : IRepositoryBase<Equipamento>
    {
        new Task<IEnumerable<BuscarEquipamentos>> BuscarTodos();
        new Task<BuscarEquipamentos> BuscarPorId(int id);
        Task<Equipamento> BuscarComRetornoId(long id);
        Task<ICollection<Equipamento>> BuscarTodosPorPagina(int pageNumber, int pageSize);
    }
}