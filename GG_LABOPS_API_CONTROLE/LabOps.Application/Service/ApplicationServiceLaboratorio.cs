using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOps.Application.Service
{
    public class ApplicationServiceLaboratorio : IApplicationServiceLaboratorio
    {
        private readonly IServiceLaboratorio service;

        public ApplicationServiceLaboratorio(IServiceLaboratorio service)
        {
            this.service = service;
        }
    }
}