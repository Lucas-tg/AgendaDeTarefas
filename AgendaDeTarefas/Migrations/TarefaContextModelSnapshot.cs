﻿// <auto-generated />
using AgendaDeTarefas.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgendaDeTarefas.Migrations
{
    [DbContext(typeof(TarefaContext))]
    partial class TarefaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgendaDeTarefas.Models.TarefaModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("finalizada")
                        .HasColumnType("bit");

                    b.Property<string>("horaFim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horaInicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prioridade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Tarefa");
                });
#pragma warning restore 612, 618
        }
    }
}
