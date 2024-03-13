﻿// <auto-generated />
using System;
using Infraestrutura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestrutura.Migrations
{
    [DbContext(typeof(SindContext))]
    partial class SindContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.16");

            modelBuilder.Entity("Modelos.Associado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Associados");
                });

            modelBuilder.Entity("Modelos.Contato", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssociadoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("AssociadoId")
                        .IsUnique();

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("Modelos.Digitalizados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssociadoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Autorizacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CanhotoProtocolo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Filiacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReqINSS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReqLicensa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Residencia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssociadoId")
                        .IsUnique();

                    b.ToTable("Digitalizados");
                });

            modelBuilder.Entity("Modelos.Documentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssociadoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PIS")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RGId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AssociadoId")
                        .IsUnique();

                    b.HasIndex("RGId");

                    b.ToTable("Documentos");
                });

            modelBuilder.Entity("Modelos.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssociadoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Localidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssociadoId")
                        .IsUnique();

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Modelos.Escolaridade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssociadoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Autodeclaracao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Formacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssociadoId")
                        .IsUnique();

                    b.ToTable("Escolaridades");
                });

            modelBuilder.Entity("Modelos.Filiacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssociadoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CNPJEntidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Filiado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeEntidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoEntidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UFEntidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssociadoId")
                        .IsUnique();

                    b.ToTable("Filiacoes");
                });

            modelBuilder.Entity("Modelos.ProdutosPesca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Algas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssociadoId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Crustaceos")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Mariscos")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Outros")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Peixes")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ProdutosPesca");
                });

            modelBuilder.Entity("Modelos.Profissao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AB")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Aposentado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AreaPesca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("AssociadoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Empregado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FormaPesca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LocalPesca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeEmbarcacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProdutoPescaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RGP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssociadoId")
                        .IsUnique();

                    b.HasIndex("ProdutoPescaId");

                    b.ToTable("Profissoes");
                });

            modelBuilder.Entity("Modelos.RG", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssociadoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataEmisao")
                        .HasColumnType("TEXT");

                    b.Property<string>("EstadoEmissao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeMae")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomePai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrgaoEmissor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RG");
                });

            modelBuilder.Entity("Modelos.Contato", b =>
                {
                    b.HasOne("Modelos.Associado", null)
                        .WithOne("Contato")
                        .HasForeignKey("Modelos.Contato", "AssociadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Modelos.Digitalizados", b =>
                {
                    b.HasOne("Modelos.Associado", null)
                        .WithOne("Digitalizados")
                        .HasForeignKey("Modelos.Digitalizados", "AssociadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Modelos.Documentos", b =>
                {
                    b.HasOne("Modelos.Associado", null)
                        .WithOne("Documentos")
                        .HasForeignKey("Modelos.Documentos", "AssociadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelos.RG", "RG")
                        .WithMany()
                        .HasForeignKey("RGId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RG");
                });

            modelBuilder.Entity("Modelos.Endereco", b =>
                {
                    b.HasOne("Modelos.Associado", null)
                        .WithOne("Endereco")
                        .HasForeignKey("Modelos.Endereco", "AssociadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Modelos.Escolaridade", b =>
                {
                    b.HasOne("Modelos.Associado", null)
                        .WithOne("Escolaridade")
                        .HasForeignKey("Modelos.Escolaridade", "AssociadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Modelos.Filiacao", b =>
                {
                    b.HasOne("Modelos.Associado", null)
                        .WithOne("Filiacao")
                        .HasForeignKey("Modelos.Filiacao", "AssociadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Modelos.Profissao", b =>
                {
                    b.HasOne("Modelos.Associado", null)
                        .WithOne("Profissao")
                        .HasForeignKey("Modelos.Profissao", "AssociadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelos.ProdutosPesca", "ProdutoPesca")
                        .WithMany()
                        .HasForeignKey("ProdutoPescaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProdutoPesca");
                });

            modelBuilder.Entity("Modelos.Associado", b =>
                {
                    b.Navigation("Contato")
                        .IsRequired();

                    b.Navigation("Digitalizados")
                        .IsRequired();

                    b.Navigation("Documentos")
                        .IsRequired();

                    b.Navigation("Endereco")
                        .IsRequired();

                    b.Navigation("Escolaridade")
                        .IsRequired();

                    b.Navigation("Filiacao")
                        .IsRequired();

                    b.Navigation("Profissao")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
