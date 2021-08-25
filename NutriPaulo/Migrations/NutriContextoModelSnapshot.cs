﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NutriPaulo.Contexto;

namespace NutriPaulo.Migrations
{
    [DbContext(typeof(NutriContexto))]
    partial class NutriContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlimentosNutrientes", b =>
                {
                    b.Property<int>("AlimenntosAlimentosId")
                        .HasColumnType("int");

                    b.Property<int>("NutrientesId")
                        .HasColumnType("int");

                    b.HasKey("AlimenntosAlimentosId", "NutrientesId");

                    b.HasIndex("NutrientesId");

                    b.ToTable("AlimentosNutrientes");
                });

            modelBuilder.Entity("NutriPaulo.Models.Alimentos", b =>
                {
                    b.Property<int>("AlimentosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Almoço")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CafeDaManha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CafeDaNoite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lanche")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlimentosId");

                    b.ToTable("Alimentos");
                });

            modelBuilder.Entity("NutriPaulo.Models.CaracteristicasFisicas", b =>
                {
                    b.Property<int>("CaracteFisicasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Altura")
                        .HasColumnType("int");

                    b.Property<string>("Biotipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.Property<int>("PessoasId")
                        .HasColumnType("int");

                    b.HasKey("CaracteFisicasId");

                    b.HasIndex("PessoasId")
                        .IsUnique();

                    b.ToTable("CaracteristicasFisicas");
                });

            modelBuilder.Entity("NutriPaulo.Models.Enderecos", b =>
                {
                    b.Property<int>("EnderecosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CEP")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PessoasId")
                        .HasColumnType("int");

                    b.HasKey("EnderecosId");

                    b.HasIndex("PessoasId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("NutriPaulo.Models.Exercicios", b =>
                {
                    b.Property<int>("ExerciciosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ExerciciosId");

                    b.ToTable("Exercicios");
                });

            modelBuilder.Entity("NutriPaulo.Models.Nutrientes", b =>
                {
                    b.Property<int>("NutrientesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Acucar")
                        .HasColumnType("int");

                    b.Property<int>("Carboidratos")
                        .HasColumnType("int");

                    b.Property<int>("Gorduras")
                        .HasColumnType("int");

                    b.Property<int>("Proteinas")
                        .HasColumnType("int");

                    b.Property<int>("Sodio")
                        .HasColumnType("int");

                    b.HasKey("NutrientesId");

                    b.ToTable("Nutrientes");
                });

            modelBuilder.Entity("NutriPaulo.Models.NutrientesAlimentos", b =>
                {
                    b.Property<int>("AlimentosId")
                        .HasColumnType("int");

                    b.Property<int>("NutrientesId")
                        .HasColumnType("int");

                    b.HasKey("AlimentosId", "NutrientesId");

                    b.HasIndex("NutrientesId");

                    b.ToTable("NutrientesAlimentos");
                });

            modelBuilder.Entity("NutriPaulo.Models.Pessoas", b =>
                {
                    b.Property<int>("PessoasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RG")
                        .HasColumnType("int");

                    b.Property<string>("SobreNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PessoasId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("NutriPaulo.Models.Quantidade", b =>
                {
                    b.Property<int>("QuantidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("QuantidadeId");

                    b.ToTable("Quantidades");
                });

            modelBuilder.Entity("NutriPaulo.Models.RelatorioPrincipal", b =>
                {
                    b.Property<int>("RelatorioPrincipalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PessoasId")
                        .HasColumnType("int");

                    b.HasKey("RelatorioPrincipalId");

                    b.HasIndex("PessoasId");

                    b.ToTable("RelatorioPrincipal");
                });

            modelBuilder.Entity("AlimentosNutrientes", b =>
                {
                    b.HasOne("NutriPaulo.Models.Alimentos", null)
                        .WithMany()
                        .HasForeignKey("AlimenntosAlimentosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NutriPaulo.Models.Nutrientes", null)
                        .WithMany()
                        .HasForeignKey("NutrientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NutriPaulo.Models.CaracteristicasFisicas", b =>
                {
                    b.HasOne("NutriPaulo.Models.Pessoas", "PessoaId")
                        .WithOne("CaracteristicasFisicas")
                        .HasForeignKey("NutriPaulo.Models.CaracteristicasFisicas", "PessoasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PessoaId");
                });

            modelBuilder.Entity("NutriPaulo.Models.Enderecos", b =>
                {
                    b.HasOne("NutriPaulo.Models.Pessoas", "Pessoas")
                        .WithMany("Enderecos")
                        .HasForeignKey("PessoasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoas");
                });

            modelBuilder.Entity("NutriPaulo.Models.NutrientesAlimentos", b =>
                {
                    b.HasOne("NutriPaulo.Models.Alimentos", "Alimentos")
                        .WithMany()
                        .HasForeignKey("AlimentosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NutriPaulo.Models.Nutrientes", "Nutrientes")
                        .WithMany()
                        .HasForeignKey("NutrientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alimentos");

                    b.Navigation("Nutrientes");
                });

            modelBuilder.Entity("NutriPaulo.Models.RelatorioPrincipal", b =>
                {
                    b.HasOne("NutriPaulo.Models.Pessoas", "Pessoas")
                        .WithMany()
                        .HasForeignKey("PessoasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoas");
                });

            modelBuilder.Entity("NutriPaulo.Models.Pessoas", b =>
                {
                    b.Navigation("CaracteristicasFisicas");

                    b.Navigation("Enderecos");
                });
#pragma warning restore 612, 618
        }
    }
}
