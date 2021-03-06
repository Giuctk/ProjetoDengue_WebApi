﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(MeuDbContext))]
    [Migration("20201108211449_Aumentar_Campo_Cep")]
    partial class Aumentar_Campo_Cep
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Business.Model.Atendimento", b =>
                {
                    b.Property<int>("IdAtendimento")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataAtendimento");

                    b.Property<DateTime?>("DataAtualizacao");

                    b.Property<DateTime>("DataInclusao");

                    b.Property<int?>("IdAgenteAdministrativo");

                    b.Property<int?>("IdAgenteCampo");

                    b.Property<int?>("IdGravidade");

                    b.Property<int>("IdLocalizacao");

                    b.Property<int?>("IdStatus");

                    b.Property<string>("ObservacaoAgente")
                        .HasColumnType("varchar(3000)");

                    b.Property<string>("ObservacaoRequisitante")
                        .HasColumnType("varchar(3000)");

                    b.HasKey("IdAtendimento");

                    b.HasIndex("IdAgenteAdministrativo");

                    b.HasIndex("IdAgenteCampo");

                    b.HasIndex("IdGravidade");

                    b.HasIndex("IdLocalizacao");

                    b.HasIndex("IdStatus");

                    b.ToTable("Atendimento");
                });

            modelBuilder.Entity("Business.Model.Gravidade", b =>
                {
                    b.Property<int>("IdGravidade")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("Prioridade");

                    b.HasKey("IdGravidade");

                    b.ToTable("Gravidade");
                });

            modelBuilder.Entity("Business.Model.Localizacao", b =>
                {
                    b.Property<int>("IdLocalizacao")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CEP")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cidade")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Rua")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("SiglaEstado")
                        .HasColumnType("varchar(2)");

                    b.HasKey("IdLocalizacao");

                    b.ToTable("Localizacao");
                });

            modelBuilder.Entity("Business.Model.Status", b =>
                {
                    b.Property<int>("IdStatus")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(30)");

                    b.HasKey("IdStatus");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("Business.Model.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Senha")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(10)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Business.Model.Atendimento", b =>
                {
                    b.HasOne("Business.Model.Usuario", "AgenteAdministrativo")
                        .WithMany("AtendimentosAdm")
                        .HasForeignKey("IdAgenteAdministrativo");

                    b.HasOne("Business.Model.Usuario", "AgenteCampo")
                        .WithMany("AtendimentosCampo")
                        .HasForeignKey("IdAgenteCampo");

                    b.HasOne("Business.Model.Gravidade", "Gravidade")
                        .WithMany("Atendimentos")
                        .HasForeignKey("IdGravidade");

                    b.HasOne("Business.Model.Localizacao", "Localizacao")
                        .WithMany("Atendimentos")
                        .HasForeignKey("IdLocalizacao")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Business.Model.Status", "Status")
                        .WithMany("Atendimentos")
                        .HasForeignKey("IdStatus");
                });
#pragma warning restore 612, 618
        }
    }
}
