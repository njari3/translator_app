using Microsoft.EntityFrameworkCore.Migrations;

namespace Translator_app.Migrations
{
    public partial class PopulateLanguageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,] {
                    { "EN", "English" },
                    { "HU", "Hungarian" },
                    { "ES", "Spanish" },
                    { "ZH", "Chinese" },
                    { "PT", "Portuguese" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
