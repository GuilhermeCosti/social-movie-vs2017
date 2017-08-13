using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SocialMovie.Models;

namespace SocialMovie.Migrations
{
    [DbContext(typeof(SocialMovieContext))]
    [Migration("20170813214407_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("SocialMovie.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Extension");

                    b.Property<string>("File");

                    b.Property<string>("MediaURL");

                    b.Property<string>("Name");

                    b.Property<string>("ThumbnailPath");

                    b.Property<byte>("Type");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("SocialMovie.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvatarImagePath");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<byte[]>("Password");

                    b.Property<byte[]>("Salt");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
        }
    }
}
