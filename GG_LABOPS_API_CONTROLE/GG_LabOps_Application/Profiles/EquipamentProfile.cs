using AutoMapper;
using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Application.Profiles
{
    public class EquipamentProfile : Profile
    {
        public EquipamentProfile() 
        {
            CreateMap<Equipament, ViewEquipamentDTO>().ReverseMap();
            CreateMap<Equipament, CreateEquipamentDTO>().ReverseMap();
            CreateMap<Equipament, UpdateEquipamentDTO>().ReverseMap();  
        }
    }
}
