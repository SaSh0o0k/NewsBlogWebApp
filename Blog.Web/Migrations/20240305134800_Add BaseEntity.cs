using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddBaseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "tblTags",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tblTags",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "tblPostTags",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "tblPostTags",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tblPostTags",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "tblPosts",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tblPosts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "tblCategories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "tblCategories",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "tblTags");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tblTags");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "tblPostTags");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "tblPostTags");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tblPostTags");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "tblPosts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tblPosts");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "tblCategories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "tblCategories");
        }
    }
}
