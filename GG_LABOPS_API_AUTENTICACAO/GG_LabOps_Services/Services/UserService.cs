using GG_labOps_Domain.DTOs;
using GG_labOps_Domain.Entities;
using GG_labOps_Domain.Exceptions;
using GG_labOps_Domain.Interfaces;
using GG_LabOps_Services.Security;
using AutoMapper;
#pragma warning disable IDE0290 // Use primary constructor

namespace GG_LabOps_Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IJWTService _jwtService;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper, IJWTService jwtService)
        {
            _repository = userRepository;
            _mapper = mapper;
            _jwtService = jwtService;
        }

        public async Task<User> GetUser(string chaveUsuario)
        {
            return await QueryUser(chaveUsuario);
        }

        public async Task<User> GetUser(User user)
        {
            return await QueryUser(user);
        }

        public async Task<User> AddUserAsync(RegisterUserDTO userDTO)
        {
            var user = ConvertToUser(userDTO);
            await QueryUser(user);
            GeneratesHashPasswordUser.ConverteSenhaEmHash(user);
            return await _repository.InsertUserAsync(user);
        }

        public Task<User> UpdateUser(int id, User user)
        {
            return _repository.UpdateUser(id, user);
        }

        public async Task<UserLoggedDTO> ValidUserAndGeneratesToken(User user)
        {
            await QueryUser(user);
            VerifyHash(user);
            SetToken(user);
            var userLogged = _mapper.Map<UserLoggedDTO>(user);
            return userLogged;
        }

        private async Task<User> QueryUser(string userKey)
        {
            var userConsulted = await _repository.SearchUserAsync(userKey);
            if (userConsulted != null)
            {
                return userConsulted;
            }
            throw new DataBaseExceptions();
        }

        private async Task<User> QueryUser(User user)
        {
            var userConsulted = await _repository.SearchUserAsync(user);
            if (userConsulted != null)
            {
                return userConsulted;
            }
            throw new Exception();
        }

        private static bool VerifyHash(User user)
        {
            var verify = GeneratesHashPasswordUser.ValidUpdateHashAsync(user, user.Senha);
            if (verify == false)
            {
                throw new Exception();
            }
            return true;
        }

        private User SetToken(User user)
        {
            var userDTO = ConvertToLoggedDto(user);
            userDTO.Token = _jwtService.GenerateToken(user);
            return user;
        }

        private static UserLoggedDTO ConvertToLoggedDto(User user)
        {
            var dto = new UserLoggedDTO
            {
                Login = user.ChaveUsuario,
            };
            return dto;
        }

        private static User ConvertToUser(RegisterUserDTO userDTO)
        {
            var user = new User
            {
                Nome = userDTO.Nome,
                ChaveUsuario = userDTO.ChaveUsuario,
                Email = userDTO.Email,
                Senha = userDTO.Senha,
                ConfirmaSenha = userDTO.ConfirmaSenha,
                DataCadastro = userDTO.DataCadastro
            };
            return user;
        }
    }
}