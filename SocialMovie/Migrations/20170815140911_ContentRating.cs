using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialMovie.Migrations
{
    public partial class ContentRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Star1",
                table: "Movies",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySQL:AutoIncrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Star2",
                table: "Movies",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySQL:AutoIncrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Star3",
                table: "Movies",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySQL:AutoIncrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Star4",
                table: "Movies",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySQL:AutoIncrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Star5",
                table: "Movies",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySQL:AutoIncrement", true);

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Extension = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    ThumbNailPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Body = table.Column<string>(nullable: true),
                    Deslikes = table.Column<int>(nullable: false, defaultValue: 0)
                        .Annotation("MySQL:AutoIncrement", true),
                    IdContent = table.Column<int>(nullable: false),
                    Likes = table.Column<int>(nullable: false, defaultValue: 0)
                        .Annotation("MySQL:AutoIncrement", true),
                    ReviewerId = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_ReviewerId",
                        column: x => x.ReviewerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Star1 = table.Column<int>(nullable: false),
                    Star2 = table.Column<int>(nullable: false),
                    Star3 = table.Column<int>(nullable: false),
                    Star4 = table.Column<int>(nullable: false),
                    Star5 = table.Column<int>(nullable: false),
                    ThumbnailPath = table.Column<string>(nullable: true),
                    Type = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Number = table.Column<int>(nullable: false),
                    SerieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seasons_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    File = table.Column<string>(nullable: true),
                    MediaId = table.Column<int>(nullable: true),
                    MediaURL = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: true),
                    Star1 = table.Column<int>(nullable: false),
                    Star2 = table.Column<int>(nullable: false),
                    Star3 = table.Column<int>(nullable: false),
                    Star4 = table.Column<int>(nullable: false),
                    Star5 = table.Column<int>(nullable: false),
                    ThumbnailPath = table.Column<string>(nullable: true),
                    Type = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodes_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Episodes_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_MediaId",
                table: "Episodes",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_SeasonId",
                table: "Episodes",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewerId",
                table: "Reviews",
                column: "ReviewerId");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_SerieId",
                table: "Seasons",
                column: "SerieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropColumn(
                name: "Star1",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Star2",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Star3",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Star4",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Star5",
                table: "Movies");
        }
    }
}
