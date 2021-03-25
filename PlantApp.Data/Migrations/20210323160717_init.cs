using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantApp.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommonName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlantTypes",
                columns: table => new
                {
                    PlantTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantTypes", x => x.PlantTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PlantPlantTypes",
                columns: table => new
                {
                    PlantId = table.Column<int>(type: "int", nullable: false),
                    PlantTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantPlantTypes", x => new { x.PlantId, x.PlantTypeId });
                    table.ForeignKey(
                        name: "FK_PlantPlantTypes_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlantPlantTypes_PlantTypes_PlantTypeId",
                        column: x => x.PlantTypeId,
                        principalTable: "PlantTypes",
                        principalColumn: "PlantTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PlantTypes",
                columns: new[] { "PlantTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Alpine" },
                    { 17, "Succulent" },
                    { 16, "Shrub" },
                    { 15, "Pond" },
                    { 14, "Perennial" },
                    { 13, "Marginal" },
                    { 12, "Fruit" },
                    { 11, "House" },
                    { 18, "Tree" },
                    { 10, "Herb" },
                    { 8, "Conservatory" },
                    { 7, "Climber" },
                    { 6, "Cactus" },
                    { 5, "Bulb" },
                    { 4, "Bog" },
                    { 3, "Biennial" },
                    { 2, "Annual" },
                    { 9, "Fruit" },
                    { 19, "Vegetable" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlantPlantTypes_PlantTypeId",
                table: "PlantPlantTypes",
                column: "PlantTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlantPlantTypes");

            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "PlantTypes");
        }
    }
}
