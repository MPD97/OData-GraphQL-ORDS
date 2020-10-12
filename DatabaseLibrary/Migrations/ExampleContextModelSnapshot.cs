﻿// <auto-generated />
using System;
using DatabaseLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabaseLibrary.Migrations
{
    [DbContext(typeof(ExampleContext))]
    partial class ExampleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DatabaseLibrary.Entities.Country", b =>
                {
                    b.Property<short>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = (short)1,
                            CountryName = "Poland"
                        },
                        new
                        {
                            CountryId = (short)2,
                            CountryName = "Germany"
                        },
                        new
                        {
                            CountryId = (short)3,
                            CountryName = "Russia"
                        },
                        new
                        {
                            CountryId = (short)4,
                            CountryName = "France"
                        },
                        new
                        {
                            CountryId = (short)5,
                            CountryName = "Denmark"
                        });
                });

            modelBuilder.Entity("DatabaseLibrary.Entities.Person", b =>
                {
                    b.Property<long>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("BirthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<short>("NationalityId")
                        .HasColumnType("smallint");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("PersonId");

                    b.HasIndex("NationalityId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            PersonId = 1L,
                            BirthDate = new DateTimeOffset(new DateTime(1952, 10, 13, 22, 37, 42, 230, DateTimeKind.Unspecified).AddTicks(6296), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Antoni",
                            Gender = 0,
                            LastName = "Muller",
                            NationalityId = (short)2
                        },
                        new
                        {
                            PersonId = 2L,
                            BirthDate = new DateTimeOffset(new DateTime(2002, 1, 6, 22, 37, 42, 233, DateTimeKind.Unspecified).AddTicks(1433), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Helga",
                            Gender = 1,
                            LastName = "Von Treskow",
                            NationalityId = (short)2,
                            SecondName = "Petra"
                        },
                        new
                        {
                            PersonId = 3L,
                            BirthDate = new DateTimeOffset(new DateTime(1964, 10, 14, 22, 37, 42, 233, DateTimeKind.Unspecified).AddTicks(1508), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Antoni",
                            Gender = 0,
                            LastName = "Szewczyk",
                            NationalityId = (short)1,
                            SecondName = "Władysław"
                        },
                        new
                        {
                            PersonId = 4L,
                            BirthDate = new DateTimeOffset(new DateTime(1984, 10, 14, 22, 37, 42, 233, DateTimeKind.Unspecified).AddTicks(1519), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Katarzyna",
                            Gender = 1,
                            LastName = "Kowal",
                            NationalityId = (short)1
                        },
                        new
                        {
                            PersonId = 5L,
                            BirthDate = new DateTimeOffset(new DateTime(1999, 6, 8, 22, 37, 42, 233, DateTimeKind.Unspecified).AddTicks(1526), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Николай",
                            Gender = 0,
                            LastName = "Лебедев",
                            NationalityId = (short)3,
                            SecondName = "Иван"
                        },
                        new
                        {
                            PersonId = 6L,
                            BirthDate = new DateTimeOffset(new DateTime(1987, 9, 27, 22, 37, 42, 233, DateTimeKind.Unspecified).AddTicks(1534), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Галина",
                            Gender = 1,
                            LastName = "Соколов",
                            NationalityId = (short)3,
                            SecondName = "Нина"
                        });
                });

            modelBuilder.Entity("DatabaseLibrary.Entities.Person", b =>
                {
                    b.HasOne("DatabaseLibrary.Entities.Country", "Nationality")
                        .WithMany("Citizenship")
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
