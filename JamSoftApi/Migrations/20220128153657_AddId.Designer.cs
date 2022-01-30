﻿// <auto-generated />
using JamSoftApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JamSoftApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220128153657_AddId")]
    partial class AddId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("JamSoftApi.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Qtd_Estoque")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Valor_Unitario")
                        .HasColumnType("INTEGER");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
