﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Weslley;

#nullable disable

namespace Weslley.Migrations
{
    [DbContext(typeof(AppdbContext))]
    [Migration("20240429215708_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Weslley.Folha", b =>
                {
                    b.Property<string>("folhaId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ano")
                        .HasColumnType("INTEGER");

                    b.Property<string>("funcionarioId")
                        .HasColumnType("TEXT");

                    b.Property<int>("mes")
                        .HasColumnType("INTEGER");

                    b.Property<double>("quantidade")
                        .HasColumnType("REAL");

                    b.Property<double>("valor")
                        .HasColumnType("REAL");

                    b.HasKey("folhaId");

                    b.HasIndex("funcionarioId");

                    b.ToTable("folhas");
                });

            modelBuilder.Entity("Weslley.Funcionario", b =>
                {
                    b.Property<string>("funcionarioId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("funcionarioId");

                    b.ToTable("funcionarios");
                });

            modelBuilder.Entity("Weslley.Folha", b =>
                {
                    b.HasOne("Weslley.Funcionario", "funcionario")
                        .WithMany()
                        .HasForeignKey("funcionarioId");

                    b.Navigation("funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}
