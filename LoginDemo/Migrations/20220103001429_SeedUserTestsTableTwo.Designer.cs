// <auto-generated />
using LoginDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoginDemo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220103001429_SeedUserTestsTableTwo")]
    partial class SeedUserTestsTableTwo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("LoginDemo.Models.UserTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("UserTests");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            Email = "a11.yahoo.com",
                            Name = "a11",
                            Password = "b"
                        },
                        new
                        {
                            Id = 12,
                            Email = "a212.yahoo.com",
                            Name = "a2",
                            Password = "b2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
