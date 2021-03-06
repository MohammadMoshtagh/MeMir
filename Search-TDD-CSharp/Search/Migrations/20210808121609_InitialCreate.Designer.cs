// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Search.DatabaseAndStoring;

namespace Search.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210808121609_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Search.Models.Data", b =>
                {
                    b.Property<string>("Word")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Word");

                    b.ToTable("Datas");
                });
#pragma warning restore 612, 618
        }
    }
}
