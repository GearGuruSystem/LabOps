using AutoMapper;
using GG_labOps_Domain.DTOs;
using GG_labOps_Domain.Entities;

namespace GG_LabOps_Services.Profiles
{
    public class UserProfiles : Profile
    {
        public UserProfiles()
        {
            CreateMap<User, UserLoggedDTO>().ReverseMap();
            CreateMap<User, RegisterUserDTO>().ReverseMap();
        }
    }
}