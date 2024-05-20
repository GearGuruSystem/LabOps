using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOps.Domain.Services.Services
{
    public class ServiceLaboratorio : ServiceBase<Laboratorio>, IServiceLaboratorio
    {
        private readonly IRepositoryLaboratorio repository;
        public ServiceLaboratorio(IRepositoryLaboratorio repository)
            : base(repository)
        {
            this.repository = repository;
        }
    }
}
