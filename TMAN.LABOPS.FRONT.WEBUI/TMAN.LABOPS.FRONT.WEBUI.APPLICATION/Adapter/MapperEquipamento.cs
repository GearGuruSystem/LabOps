using AutoMapper;
using Tman.LabOps.WebUI.Application.DTOs.Equipamento;
using Tman.LabOps.WebUI.Application.Entities;

namespace Tman.LabOps.WebUI.Application.Adapter
{
    public class MapperEquipamento : Profile
    {
        public MapperEquipamento()
        {
            CreateMap<Equipamento, ViewEquipamento>().ReverseMap();
        }
    }
}
