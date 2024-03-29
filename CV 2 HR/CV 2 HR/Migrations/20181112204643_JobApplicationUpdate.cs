﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CV2HR.Migrations
{
    public partial class JobApplicationUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_JobOffers_JobOfferId",
                table: "JobApplications");

            migrationBuilder.DropIndex(
                name: "IX_JobApplications_JobOfferId",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "JobOfferId",
                table: "JobApplications");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "JobApplications",
                newName: "FirstName");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_OfferId",
                table: "JobApplications",
                column: "OfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_JobOffers_OfferId",
                table: "JobApplications",
                column: "OfferId",
                principalTable: "JobOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_JobOffers_OfferId",
                table: "JobApplications");

            migrationBuilder.DropIndex(
                name: "IX_JobApplications_OfferId",
                table: "JobApplications");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "JobApplications",
                newName: "firstName");

            migrationBuilder.AddColumn<int>(
                name: "JobOfferId",
                table: "JobApplications",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_JobOfferId",
                table: "JobApplications",
                column: "JobOfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_JobOffers_JobOfferId",
                table: "JobApplications",
                column: "JobOfferId",
                principalTable: "JobOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
