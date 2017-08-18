using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SocialMovie.Models;

namespace SocialMovie.Migrations
{
    [DbContext(typeof(SocialMovieContext))]
    partial class SocialMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("SocialMovie.Models.Archive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Extension");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Archives");
                });

            modelBuilder.Entity("SocialMovie.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Discriminator")
                        .IsRequired();

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

                    b.Property<int?>("ThumbnailId");

                    b.Property<byte>("Type");

                    b.HasKey("Id");

                    b.HasIndex("ThumbnailId");

                    b.ToTable("Contents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Content");
                });

            modelBuilder.Entity("SocialMovie.Models.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ENumber");

                    b.Property<int>("SNumber");

                    b.Property<int?>("SerieId");

                    b.Property<int?>("VideoFileId");

                    b.HasKey("Id");

                    b.HasIndex("SerieId");

                    b.HasIndex("VideoFileId");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("SocialMovie.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArchiveId");

                    b.Property<string>("Body");

                    b.Property<int>("Deslikes")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("Likes")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<byte>("Rating");

                    b.Property<int>("ReviewerId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("SocialMovie.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AvatarId");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<byte[]>("Password");

                    b.Property<byte[]>("Salt");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SocialMovie.Models.Movie", b =>
                {
                    b.HasBaseType("SocialMovie.Models.Content");

                    b.Property<int?>("VideoFileId");

                    b.HasIndex("VideoFileId");

                    b.ToTable("Movie");

                    b.HasDiscriminator().HasValue("Movie");
                });

            modelBuilder.Entity("SocialMovie.Models.Serie", b =>
                {
                    b.HasBaseType("SocialMovie.Models.Content");


                    b.ToTable("Serie");

                    b.HasDiscriminator().HasValue("Serie");
                });

            modelBuilder.Entity("SocialMovie.Models.Content", b =>
                {
                    b.HasOne("SocialMovie.Models.Archive", "Thumbnail")
                        .WithMany()
                        .HasForeignKey("ThumbnailId");
                });

            modelBuilder.Entity("SocialMovie.Models.Episode", b =>
                {
                    b.HasOne("SocialMovie.Models.Serie")
                        .WithMany("Episodes")
                        .HasForeignKey("SerieId");

                    b.HasOne("SocialMovie.Models.Archive", "VideoFile")
                        .WithMany()
                        .HasForeignKey("VideoFileId");
                });

            modelBuilder.Entity("SocialMovie.Models.User", b =>
                {
                    b.HasOne("SocialMovie.Models.Archive", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId");
                });

            modelBuilder.Entity("SocialMovie.Models.Movie", b =>
                {
                    b.HasOne("SocialMovie.Models.Archive", "VideoFile")
                        .WithMany()
                        .HasForeignKey("VideoFileId");
                });
        }
    }
}
