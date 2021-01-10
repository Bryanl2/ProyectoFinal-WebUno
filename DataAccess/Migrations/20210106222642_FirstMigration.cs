using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cellphones",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cellphones", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cellphones",
                columns: new[] { "Id", "Brand", "Color", "Model", "Status" },
                values: new object[] { "HWE", "Huawei", "red", "Huawei 34P", "ACTIVO" });

            migrationBuilder.InsertData(
                table: "Cellphones",
                columns: new[] { "Id", "Brand", "Color", "Model", "Status" },
                values: new object[] { "HW3E", "Huawei", "blue", "Huawei 569CO", "ACTIVO" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cellphones");
        }
    }
}
