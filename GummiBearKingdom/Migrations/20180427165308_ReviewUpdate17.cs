using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GummiBearKingdom.Migrations
{
    public partial class ReviewUpdate17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gummis_Reviews_ReviewAuthorId",
                table: "Gummis");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Reviews",
                newName: "ReviewId");

            migrationBuilder.DropIndex(
                name: "IX_Gummis_ReviewAuthorId",
                table: "Gummis");

            migrationBuilder.DropColumn(
                name: "ReviewAuthorId",
                table: "Gummis");

            migrationBuilder.AddColumn<int>(
                name: "GummiId",
                table: "Reviews",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Reviews",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GummiId",
                table: "Reviews",
                column: "GummiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Gummis_GummiId",
                table: "Reviews",
                column: "GummiId",
                principalTable: "Gummis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Gummis_GummiId",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "Reviews",
                newName: "AuthorId");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_GummiId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "GummiId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Reviews");

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
    }
}
