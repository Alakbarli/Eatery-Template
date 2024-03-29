﻿// <auto-generated />
using System;
using Eatery.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Eatery.Migrations
{
    [DbContext(typeof(EatDb))]
    [Migration("20190714081858_sasasa")]
    partial class sasasa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Eatery.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Eatery.Models.EatingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("EatingTypes");
                });

            modelBuilder.Entity("Eatery.Models.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.HasKey("Id");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("Eatery.Models.HistoryPics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HistoryId");

                    b.Property<string>("Image");

                    b.HasKey("Id");

                    b.HasIndex("HistoryId");

                    b.ToTable("HistoryPics");
                });

            modelBuilder.Entity("Eatery.Models.OurMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("OurMenus");
                });

            modelBuilder.Entity("Eatery.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("SliderImage")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("Eatery.Models.SpecialDishes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("SpecialDishes");
                });

            modelBuilder.Entity("Eatery.Models.StaticSlider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("StaticSliders");
                });

            modelBuilder.Entity("Eatery.Models.Testimonial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PersonPosition")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Testimonials");
                });

            modelBuilder.Entity("Eatery.Models.HistoryPics", b =>
                {
                    b.HasOne("Eatery.Models.History", "History")
                        .WithMany("HistoryPics")
                        .HasForeignKey("HistoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
