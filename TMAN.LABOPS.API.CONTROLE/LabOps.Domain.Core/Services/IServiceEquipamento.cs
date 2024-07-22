﻿using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Domain.Entities;

namespace LabOps.Domain.Core.Services
{
    public interface IServiceEquipamento : IServiceBase<Equipamento>
    {
        Task<Equipamento> BuscarComRetornoId(int id);
        new Task<BuscarEquipamentos> BuscarPorId(int id);
        new Task<IEnumerable<BuscarEquipamentos>> BuscarTodos();
        Task<ICollection<Equipamento>> BuscarTodosPorPagina(int pageNumber, int pageSize);
    }

    
}