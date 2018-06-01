using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace labb_4_mvc.Data.Migrations
{
    public partial class addedentitiestocontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HighScores_AspNetUsers_ApplicationUserId",
                table: "HighScores");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Answers_CorrectAnswerId",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HighScores",
                table: "HighScores");

            migrationBuilder.RenameTable(
                name: "HighScores",
                newName: "UserScores");

            migrationBuilder.RenameIndex(
                name: "IX_HighScores_ApplicationUserId",
                table: "UserScores",
                newName: "IX_UserScores_ApplicationUserId");

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "UserScores",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserScores",
                table: "UserScores",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AnonymousScores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Points = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnonymousScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnonymousScores_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnswerChoices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Answer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerChoices", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserScores_QuestionId",
                table: "UserScores",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AnonymousScores_QuestionId",
                table: "AnonymousScores",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_AnswerChoices_CorrectAnswerId",
                table: "Questions",
                column: "CorrectAnswerId",
                principalTable: "AnswerChoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserScores_AspNetUsers_ApplicationUserId",
                table: "UserScores",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserScores_Questions_QuestionId",
                table: "UserScores",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_AnswerChoices_CorrectAnswerId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScores_AspNetUsers_ApplicationUserId",
                table: "UserScores");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScores_Questions_QuestionId",
                table: "UserScores");

            migrationBuilder.DropTable(
                name: "AnonymousScores");

            migrationBuilder.DropTable(
                name: "AnswerChoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserScores",
                table: "UserScores");

            migrationBuilder.DropIndex(
                name: "IX_UserScores_QuestionId",
                table: "UserScores");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "UserScores");

            migrationBuilder.RenameTable(
                name: "UserScores",
                newName: "HighScores");

            migrationBuilder.RenameIndex(
                name: "IX_UserScores_ApplicationUserId",
                table: "HighScores",
                newName: "IX_HighScores_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HighScores",
                table: "HighScores",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Answer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_HighScores_AspNetUsers_ApplicationUserId",
                table: "HighScores",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Answers_CorrectAnswerId",
                table: "Questions",
                column: "CorrectAnswerId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
