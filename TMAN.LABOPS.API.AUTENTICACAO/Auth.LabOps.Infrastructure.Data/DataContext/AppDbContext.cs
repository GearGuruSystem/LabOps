using Auth.LabOps.Domain.Entities;
using Auth.LabOps.Infrastructure.Data.MapData;
using Microsoft.EntityFrameworkCore;

#pragma warning disable IDE0290 // Use primary constructor

namespace Auth.LabOps.Infrastructure.Data.DataContex
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Aplicacao> Aplicacoes { get; set; } = null!;
        public DbSet<GrupoUsuario> GrupoUsuarios { get; set; } = null!;
        public DbSet<GrupoUsuarioXAplicacoes> GrupoUsuarioXAplicacoes { get; set; } = null!;
        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<UsuarioXGrupoUsuario> UsuarioXGrupoUsuarios { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapAplicacao());
            modelBuilder.ApplyConfiguration(new MapGrupoUsuario());
            modelBuilder.ApplyConfiguration(new MapGrupoUsuarioXAplicacoes());
            modelBuilder.ApplyConfiguration(new MapUsuario());
            modelBuilder.ApplyConfiguration(new MapUsuarioXGrupoUsuario());
            base.OnModelCreating(modelBuilder);
        }
    }
}
