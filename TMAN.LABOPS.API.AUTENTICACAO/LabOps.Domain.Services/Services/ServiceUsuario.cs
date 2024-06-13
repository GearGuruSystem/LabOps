using Auth.LabOps.Domain.Core.Interfaces;
using Auth.LabOps.Domain.Core.Services;
using Auth.LabOps.Domain.Entities;
using Auth.LabOps.Domain.Services.Interfaces;
using Auth.LabOps.Domain.Services.Security;

#pragma warning disable IDE0290 // Use primary constructor

namespace Auth.LabOps.Domain.Services.Services
{
    public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario
    {
        public readonly IRepositoryUsuario repositoryUsuario;
        private readonly IServiceToken serviceJwt;

        public ServiceUsuario(IRepositoryUsuario repositoryUsuario, IServiceToken serviceJwt) : base(repositoryUsuario)
        {
            this.repositoryUsuario = repositoryUsuario;
            this.serviceJwt = serviceJwt;
        }

        public async Task<Usuario> Buscar(string chave)
        {
            return await ConsultaUsuario(chave);
        }

        public override void Registrar(Usuario usuario)
        {
            ServiceSecurity.ConverteSenhaEmHash(usuario);
            base.Registrar(usuario);
        }

        public override async Task<Usuario> Atualiza(Usuario usuario)
        {
            ServiceSecurity.ConverteSenhaEmHash(usuario);
            return await base.Atualiza(usuario);
        }

        public async Task<Usuario> ValidaUsuarioGeraToken(Usuario usuario)
        {
            var usuarioConsultado = await ConsultaUsuario(usuario);
            var verificacao = await VerificaHash(usuario, usuarioConsultado.Senha);
            if (verificacao)
            {
                AplicaToken(usuarioConsultado);
                return usuarioConsultado;
            }
            throw new Exception("Ocorreu um erro ao validar usuário");
        }

        private async Task<Usuario> ConsultaUsuario(Usuario usuario)
        {
            var uConsultado = await repositoryUsuario.Buscar(usuario.Login);
            if (uConsultado != null)
            {
                return uConsultado;
            }
            throw new Exception("Não foi encontrado nenhum usuario");
        }

        private async Task<Usuario> ConsultaUsuario(string chave)
        {
            var uConsultado = await repositoryUsuario.Buscar(chave);
            if (uConsultado != null)
            {
                return uConsultado;
            }
            Console.WriteLine("NÃO FOI ENCONTRADO NENHUM USUARIO");
            throw new Exception("Não foi encontrado nenhum usuario");
        }

        private async Task<bool> VerificaHash(Usuario usuario, string hash)
        {
            var verifica = await ServiceSecurity.ValidaAtualizaHashAsync(usuario, hash);
            return verifica != false;
        }

        private void AplicaToken(Usuario usuario)
        {
            usuario.Token = serviceJwt.GerarToken(usuario);
        }
    }
}