using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StackOverflow.Migrations
{
    public partial class AddUsersAnswersTablePART2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users_Answers",
                columns: table => new
                {
                    UAKey = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    AnswerId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_Answers", x => x.UAKey);
                    table.ForeignKey(
                        name: "FK_Users_Answers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddColumn<int>(
                name: "Users_AnswersUAKey",
                table: "Answers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_Users_AnswersUAKey",
                table: "Answers",
                column: "Users_AnswersUAKey");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Answers_UserId",
                table: "Users_Answers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Users_Answers_Users_AnswersUAKey",
                table: "Answers",
                column: "Users_AnswersUAKey",
                principalTable: "Users_Answers",
                principalColumn: "UAKey",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Users_Answers_Users_AnswersUAKey",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_Users_AnswersUAKey",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "Users_AnswersUAKey",
                table: "Answers");

            migrationBuilder.DropTable(
                name: "Users_Answers");
        }
    }
}
