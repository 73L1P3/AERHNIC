﻿// <auto-generated />
using System;
using CRUD_NETCore5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AERHNIC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211010031932_update table user in roles")]
    partial class updatetableuserinroles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AERHNIC.Models.Roles", b =>
                {
                    b.Property<Guid>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NombreRole")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("IdRole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AERHNIC.Models.Users_in_Roles", b =>
                {
                    b.Property<Guid>("Id_User_Role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RolesIdRole")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UsuariosUsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id_User_Role");

                    b.HasIndex("RolesIdRole");

                    b.HasIndex("UsuariosUsuarioId");

                    b.ToTable("Users_in_Roles");
                });

            modelBuilder.Entity("AERHNIC.Models.Usuarios", b =>
                {
                    b.Property<Guid>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cargo_Usuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cedula_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comentario_Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contacto_Pago_Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo_Usuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Empresa_Usuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Estado_Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Nacimiento_Usuario")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre_Usuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Registro_Usuario")
                        .HasColumnType("datetime2");

                    b.Property<int>("Telefono_Celular_Usuario")
                        .HasColumnType("int");

                    b.Property<int>("Telefono_Empresa_Usuario")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("AERHNIC.Models.Users_in_Roles", b =>
                {
                    b.HasOne("AERHNIC.Models.Roles", "Roles")
                        .WithMany("Users_in_Roles")
                        .HasForeignKey("RolesIdRole");

                    b.HasOne("AERHNIC.Models.Usuarios", "Usuarios")
                        .WithMany("Users_in_Roles")
                        .HasForeignKey("UsuariosUsuarioId");

                    b.Navigation("Roles");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("AERHNIC.Models.Roles", b =>
                {
                    b.Navigation("Users_in_Roles");
                });

            modelBuilder.Entity("AERHNIC.Models.Usuarios", b =>
                {
                    b.Navigation("Users_in_Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
