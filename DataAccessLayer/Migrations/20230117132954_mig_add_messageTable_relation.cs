using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_messageTable_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Message2",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderID = table.Column<int>(type: "int", nullable: false),
                    ReceiverID = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message2", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_Message2_Writers_ReceiverID",
                        column: x => x.ReceiverID,
                        principalTable: "Writers",
                        principalColumn: "WriterID");
                    table.ForeignKey(
                        name: "FK_Message2_Writers_SenderID",
                        column: x => x.SenderID,
                        principalTable: "Writers",
                        principalColumn: "WriterID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Message2_ReceiverID",
                table: "Message2",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Message2_SenderID",
                table: "Message2",
                column: "SenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message2");
        }
    }
}
