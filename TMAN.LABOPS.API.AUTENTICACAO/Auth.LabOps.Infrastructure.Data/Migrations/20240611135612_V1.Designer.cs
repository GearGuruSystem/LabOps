﻿// <auto-generated />
using System;
using Auth.LabOps.Infrastructure.Data.DataContex;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auth.LabOps.Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240611135612_V1")]
    partial class V1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Auth.LabOps.Domain.Entities.Aplicacao", b =>
                {
                    b.Property<int>("IDAplicacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDAplicacao"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("IDAplicacao");

                    b.ToTable("Aplicacoes");
                });

            modelBuilder.Entity("Auth.LabOps.Domain.Entities.GrupoUsuario", b =>
                {
                    b.Property<int>("IDGrupoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDGrupoUsuario"));

                    b.Property<DateTime>("AtualizadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<DateTime>("InseridoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsuarioAtualizacao")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioInsercao")
                        .HasColumnType("int");

                    b.HasKey("IDGrupoUsuario");

                    b.ToTable("GrupoUsuarios");
                });

            modelBuilder.Entity("Auth.LabOps.Domain.Entities.GrupoUsuarioXAplicacoes", b =>
                {
                    b.Property<int>("IDAplicacao")
                        .HasColumnType("int");

                    b.Property<int>("IDGrupoUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Permissao")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("IDAplicacao", "IDGrupoUsuario");

                    b.HasIndex("IDGrupoUsuario");

                    b.ToTable("GrupoUsuarioXAplicacoes");
                });

            modelBuilder.Entity("Auth.LabOps.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("IDUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDUsuario"));

                    b.Property<DateTime>("AtualizadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InseridoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Auth.LabOps.Domain.Entities.UsuarioXGrupoUsuario", b =>
                {
                    b.Property<int>("IDUsuario")
                        .HasColumnType("int");

                    b.Property<int>("IDGrupoUsuario")
                        .HasColumnType("int");

                    b.HasKey("IDUsuario", "IDGrupoUsuario");

                    b.HasIndex("IDGrupoUsuario");

                    b.ToTable("UsuarioXGrupoUsuarios");
                });

            modelBuilder.Entity("Auth.LabOps.Domain.Entities.GrupoUsuarioXAplicacoes", b =>
                {
                    b.HasOne("Auth.LabOps.Domain.Entities.Aplicacao", "Aplicacao")
                        .WithMany("GrupoUsuarioXAplicacoes")
                        .HasForeignKey("IDAplicacao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Auth.LabOps.Domain.Entities.GrupoUsuario", "GrupoUsuario")
                        .WithMany("GrupoUsuarioXAplicacoes")
                        .HasForeignKey("IDGrupoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aplicacao");

                    b.Navigation("GrupoUsuario");
                });

            modelBuilder.Entity("Auth.LabOps.Domain.Entities.UsuarioXGrupoUsuario", b =>
                {
                    b.HasOne("Auth.LabOps.Domain.Entities.GrupoUsuario", "GrupoUsuario")
                        .WithMany("UsuarioXGrupoUsuarios")
                        .HasForeignKey("IDGrupoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Auth.LabOps.Domain.Entities.Usuario", "Usuario")
                        .WithMany("UsuarioXGrupoUsuarios")
                        .HasForeignKey("IDUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GrupoUsuario");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Auth.LabOps.Domain.Entities.Aplicacao", b =>
                {
                    b.Navigation("GrupoUsuarioXAplicacoes");
                });

            modelBuilder.Entity("Auth.LabOps.Domain.Entities.GrupoUsuario", b =>
                {
                    b.Navigation("GrupoUsuarioXAplicacoes");

                    b.Navigation("UsuarioXGrupoUsuarios");
                });

            modelBuilder.Entity("Auth.LabOps.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("UsuarioXGrupoUsuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
