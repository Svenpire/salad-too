﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data;

namespace WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211020152501_SetRefsAsVirtual")]
    partial class SetRefsAsVirtual
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Data.Contact", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("WebAPI.Data.ContactList", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ContactId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId");

                    b.HasIndex("ContactId");

                    b.ToTable("ContactLists");
                });

            modelBuilder.Entity("WebAPI.Data.Ingredient", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ingredient")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IngredientType")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Ingredient");

                    b.HasIndex("IngredientType")
                        .IsUnique();

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("WebAPI.Data.IngredientType", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("selectType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("IngredientTypes");
                });

            modelBuilder.Entity("WebAPI.Data.Item", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ItemGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("ItemGroup");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("WebAPI.Data.ItemGroup", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ItemGroup")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("ItemGroup");

                    b.ToTable("ItemGroups");
                });

            modelBuilder.Entity("WebAPI.Models.DrinkType", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("DrinkTypes");
                });

            modelBuilder.Entity("WebAPI.Models.User", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("password")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("passwordKey")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebAPI.Data.ContactList", b =>
                {
                    b.HasOne("WebAPI.Data.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebAPI.Data.Ingredient", b =>
                {
                    b.HasOne("WebAPI.Data.Item", "items")
                        .WithMany("ingredients")
                        .HasForeignKey("Ingredient");

                    b.HasOne("WebAPI.Data.IngredientType", "ingredientType")
                        .WithOne("Ingredient")
                        .HasForeignKey("WebAPI.Data.Ingredient", "IngredientType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ingredientType");

                    b.Navigation("items");
                });

            modelBuilder.Entity("WebAPI.Data.Item", b =>
                {
                    b.HasOne("WebAPI.Data.ItemGroup", "itemGroup")
                        .WithMany()
                        .HasForeignKey("ItemGroup")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("itemGroup");
                });

            modelBuilder.Entity("WebAPI.Data.ItemGroup", b =>
                {
                    b.HasOne("WebAPI.Data.Ingredient", null)
                        .WithMany("itemGroups")
                        .HasForeignKey("ItemGroup");
                });

            modelBuilder.Entity("WebAPI.Data.Ingredient", b =>
                {
                    b.Navigation("itemGroups");
                });

            modelBuilder.Entity("WebAPI.Data.IngredientType", b =>
                {
                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("WebAPI.Data.Item", b =>
                {
                    b.Navigation("ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
