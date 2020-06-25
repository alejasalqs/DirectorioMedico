﻿// <auto-generated />
using System;
using DirectorioMedico.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DirectorioMedico.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DirectorioMedico.API.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsTodoElDia")
                        .HasColumnType("bit");

                    b.Property<string>("Evento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("DirectorioMedico.API.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgendaId")
                        .HasColumnType("int");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaUltimaActividad")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<int>("IdAgenda")
                        .HasColumnType("int");

                    b.Property<string>("Locacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Primer_apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Segundo_apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sitio_web")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SobreMi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono_oficina")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AgendaId");

                    b.ToTable("Doctores");
                });

            modelBuilder.Entity("DirectorioMedico.API.Models.Especialidades", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("DoctorID");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("DirectorioMedico.API.Models.Estudios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<string>("centro_estudios")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fecha_final")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_inicial")
                        .HasColumnType("datetime2");

                    b.Property<string>("grado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("DoctorID");

                    b.ToTable("Estudios");
                });

            modelBuilder.Entity("DirectorioMedico.API.Models.Experiencia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<string>("Labores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fecha_final")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_inicial")
                        .HasColumnType("datetime2");

                    b.Property<string>("lugar_trabajo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("puesto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("DoctorID");

                    b.ToTable("Experiencia");
                });

            modelBuilder.Entity("DirectorioMedico.API.Models.Idioma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<bool>("estado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DoctorID");

                    b.ToTable("Idioma");
                });

            modelBuilder.Entity("DirectorioMedico.API.Models.RedesSociales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorID");

                    b.ToTable("RedesSociales");
                });

            modelBuilder.Entity("DirectorioMedico.API.Models.Doctor", b =>
                {
                    b.HasOne("DirectorioMedico.API.Models.Agenda", "Agenda")
                        .WithMany()
                        .HasForeignKey("AgendaId");
                });

            modelBuilder.Entity("DirectorioMedico.API.Models.Especialidades", b =>
                {
                    b.HasOne("DirectorioMedico.API.Models.Doctor", "Doctor")
                        .WithMany("Especialidades")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DirectorioMedico.API.Models.Estudios", b =>
                {
                    b.HasOne("DirectorioMedico.API.Models.Doctor", "Doctor")
                        .WithMany("Estudios")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DirectorioMedico.API.Models.Experiencia", b =>
                {
                    b.HasOne("DirectorioMedico.API.Models.Doctor", "Doctor")
                        .WithMany("Experiencia")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DirectorioMedico.API.Models.Idioma", b =>
                {
                    b.HasOne("DirectorioMedico.API.Models.Doctor", "Doctor")
                        .WithMany("Idiomas")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DirectorioMedico.API.Models.RedesSociales", b =>
                {
                    b.HasOne("DirectorioMedico.API.Models.Doctor", "Doctor")
                        .WithMany("RedesSociales")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
