using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GookBooksApi.Migrations
{
    public partial class ApplyConstrains : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookAuthor_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Quote_Books_BookId",
                table: "Quote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quote",
                table: "Quote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthor",
                table: "BookAuthor");

            migrationBuilder.RenameTable(
                name: "Quote",
                newName: "Quotes");

            migrationBuilder.RenameTable(
                name: "BookAuthor",
                newName: "BookAuthors");

            migrationBuilder.RenameIndex(
                name: "IX_Quote_BookId",
                table: "Quotes",
                newName: "IX_Quotes_BookId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorId",
                table: "Books",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Quotes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "BookAuthors",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "BookAuthors",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quotes",
                table: "Quotes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookAuthors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "BookAuthors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Books_BookId",
                table: "Quotes",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookAuthors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Books_BookId",
                table: "Quotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quotes",
                table: "Quotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors");

            migrationBuilder.RenameTable(
                name: "Quotes",
                newName: "Quote");

            migrationBuilder.RenameTable(
                name: "BookAuthors",
                newName: "BookAuthor");

            migrationBuilder.RenameIndex(
                name: "IX_Quotes_BookId",
                table: "Quote",
                newName: "IX_Quote_BookId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorId",
                table: "Books",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Quote",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "BookAuthor",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "BookAuthor",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quote",
                table: "Quote",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthor",
                table: "BookAuthor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookAuthor_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "BookAuthor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quote_Books_BookId",
                table: "Quote",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
