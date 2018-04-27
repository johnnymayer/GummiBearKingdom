using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GummiBearKingdom.Migrations
{
    public partial class ReviewUpdate18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Gummis_GummiId",
                table: "Reviews");

            migrationBuilder.AddColumn<int>(
                name: "GummiId",
                table: "Gummis",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGeneratedOnAdd", true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Gummis",
                nullable: true,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGeneratedOnAdd", true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Gummis_GummiId",
                table: "Reviews",
                column: "GummiId",
                principalTable: "Gummis",
                principalColumn: "GummiId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Gummis_GummiId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "GummiId",
                table: "Gummis");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Gummis",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true)
                .Annotation("MySql:ValueGeneratedOnAdd", true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Gummis_GummiId",
                table: "Reviews",
                column: "GummiId",
                principalTable: "Gummis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
