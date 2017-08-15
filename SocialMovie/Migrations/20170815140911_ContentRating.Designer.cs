using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SocialMovie.Models;

namespace SocialMovie.Migrations
{
    [DbContext(typeof(SocialMovieContext))]
    [Migration("20170815140911_ContentRating")]
    partial class ContentRating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("SocialMovie.Models.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Extension");

                    b.Property<string>("File");

                    b.Property<int?>("MediaId");

                    b.Property<string>("MediaURL");

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.Property<int?>("SeasonId");

                    b.Property<int>("Star1");

                    b.Property<int>("Star2");

                    b.Property<int>("Star3");

                    b.Property<int>("Star4");

                    b.Property<int>("Star5");

                    b.Property<string>("ThumbnailPath");

                    b.Property<byte>("Type");

                    b.HasKey("Id");

                    b.HasIndex("MediaId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("SocialMovie.Models.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Extension");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.Property<string>("ThumbNailPath");

                    b.HasKey("Id");

                    b.ToTable("Media");
                });

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

                    b.Property<int>("Star1")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("Star2")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("Star3")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("Star4")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("Star5")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("ThumbnailPath");

                    b.Property<byte>("Type");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("SocialMovie.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<int>("Deslikes")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("IdContent");

                    b.Property<int>("Likes")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int?>("ReviewerId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("SocialMovie.Models.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Number");

                    b.Property<int?>("SerieId");

                    b.HasKey("Id");

                    b.HasIndex("SerieId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("SocialMovie.Models.Serie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Star1");

                    b.Property<int>("Star2");

                    b.Property<int>("Star3");

                    b.Property<int>("Star4");

                    b.Property<int>("Star5");

                    b.Property<string>("ThumbnailPath");

                    b.Property<byte>("Type");

                    b.HasKey("Id");

                    b.ToTable("Series");
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

            modelBuilder.Entity("SocialMovie.Models.Episode", b =>
                {
                    b.HasOne("SocialMovie.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaId");

                    b.HasOne("SocialMovie.Models.Season")
                        .WithMany("Episodes")
                        .HasForeignKey("SeasonId");
                });

            modelBuilder.Entity("SocialMovie.Models.Review", b =>
                {
                    b.HasOne("SocialMovie.Models.User", "Reviewer")
                        .WithMany()
                        .HasForeignKey("ReviewerId");
                });

            modelBuilder.Entity("SocialMovie.Models.Season", b =>
                {
                    b.HasOne("SocialMovie.Models.Serie")
                        .WithMany("Seasons")
                        .HasForeignKey("SerieId");
                });
        }
    }
}
