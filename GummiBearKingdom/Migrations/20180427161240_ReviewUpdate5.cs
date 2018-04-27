using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GummiBearKingdom.Migrations
{
    public partial class ReviewUpdate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    Author = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.AuthorId);
                });

            migrationBuilder.AddColumn<int>(
                name: "ReviewAuthorId",
                table: "Gummis",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gummis_ReviewAuthorId",
                table: "Gummis",
                column: "ReviewAuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gummis_Reviews_ReviewAuthorId",
                table: "Gummis",
                column: "ReviewAuthorId",
                principalTable: "Reviews",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gummis_Reviews_ReviewAuthorId",
                table: "Gummis");

            migrationBuilder.DropIndex(
                name: "IX_Gummis_ReviewAuthorId",
                table: "Gummis");

            migrationBuilder.DropColumn(
                name: "ReviewAuthorId",
                table: "Gummis");

            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
