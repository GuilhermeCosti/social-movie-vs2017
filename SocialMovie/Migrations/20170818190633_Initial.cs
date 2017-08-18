using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialMovie.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Archives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Extension = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ArchiveId = table.Column<int>(nullable: false),
                    Body = table.Column<string>(nullable: true),
                    Deslikes = table.Column<int>(nullable: false, defaultValue: 0)
                        .Annotation("MySQL:AutoIncrement", true),
                    Likes = table.Column<int>(nullable: false, defaultValue: 0)
                        .Annotation("MySQL:AutoIncrement", true),
                    Rating = table.Column<byte>(nullable: false),
                    ReviewerId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Description = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Star1 = table.Column<int>(nullable: false, defaultValue: 0)
                        .Annotation("MySQL:AutoIncrement", true),
                    Star2 = table.Column<int>(nullable: false, defaultValue: 0)
                        .Annotation("MySQL:AutoIncrement", true),
                    Star3 = table.Column<int>(nullable: false, defaultValue: 0)
                        .Annotation("MySQL:AutoIncrement", true),
                    Star4 = table.Column<int>(nullable: false, defaultValue: 0)
                        .Annotation("MySQL:AutoIncrement", true),
                    Star5 = table.Column<int>(nullable: false, defaultValue: 0)
                        .Annotation("MySQL:AutoIncrement", true),
                    ThumbnailId = table.Column<int>(nullable: true),
                    Type = table.Column<byte>(nullable: false),
                    VideoFileId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Archives_ThumbnailId",
                        column: x => x.ThumbnailId,
                        principalTable: "Archives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contents_Archives_VideoFileId",
                        column: x => x.VideoFileId,
                        principalTable: "Archives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    AvatarId = table.Column<int>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<byte[]>(nullable: true),
                    Salt = table.Column<byte[]>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Archives_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Archives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ENumber = table.Column<int>(nullable: false),
                    SNumber = table.Column<int>(nullable: false),
                    SerieId = table.Column<int>(nullable: true),
                    VideoFileId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodes_Contents_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Episodes_Archives_VideoFileId",
                        column: x => x.VideoFileId,
                        principalTable: "Archives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_ThumbnailId",
                table: "Contents",
                column: "ThumbnailId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_VideoFileId",
                table: "Contents",
                column: "VideoFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_SerieId",
                table: "Episodes",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_VideoFileId",
                table: "Episodes",
                column: "VideoFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AvatarId",
                table: "Users",
                column: "AvatarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Archives");
        }
    }
}
