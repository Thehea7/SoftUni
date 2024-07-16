using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogDemo.Migrations
{
    public partial class BlogNmaeIndexAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "ix_Blogs_Name_Unique",
                schema: "blg",
                table: "Blogs",
                column: "BlogName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_Blogs_Name_Unique",
                schema: "blg",
                table: "Blogs");
        }
    }
}
