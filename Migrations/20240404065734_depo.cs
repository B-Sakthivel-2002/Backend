using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace task.Migrations
{
    /// <inheritdoc />
    public partial class depo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessPartner",
                columns: table => new
                {
                    linerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    linerCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessPartner", x => x.linerId);
                });

            migrationBuilder.CreateTable(
                name: "DepotDetail",
                columns: table => new
                {
                    depotId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    depotCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepotDetail", x => x.depotId);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentDetails",
                columns: table => new
                {
                    equipmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    equipmentNo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    equipmentSize = table.Column<int>(type: "int", nullable: false),
                    equipmentLinerId = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    depotId = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    conTrackingNo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    gateInDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReferenceNo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentDetails", x => x.equipmentId);
                });

            migrationBuilder.CreateTable(
                name: "transportDetail",
                columns: table => new
                {
                    transportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transportCompany = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    licenseNo = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    driverName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    driverMobileNo = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    driverEmail = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transportDetail", x => x.transportId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessPartner");

            migrationBuilder.DropTable(
                name: "DepotDetail");

            migrationBuilder.DropTable(
                name: "EquipmentDetails");

            migrationBuilder.DropTable(
                name: "transportDetail");
        }
    }
}
