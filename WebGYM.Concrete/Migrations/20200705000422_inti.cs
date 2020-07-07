using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebGYM.Concrete.Migrations
{
    public partial class inti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberRegistration",
                columns: table => new
                {
                    MemberId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MemberNo = table.Column<string>(nullable: true),
                    MemberFName = table.Column<string>(nullable: false),
                    MemberLName = table.Column<string>(nullable: false),
                    MemberMName = table.Column<string>(nullable: false),
                    Dob = table.Column<DateTime>(nullable: false),
                    Age = table.Column<string>(nullable: false),
                    Contactno = table.Column<string>(nullable: false),
                    EmailId = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    PlanID = table.Column<int>(nullable: true),
                    SchemeID = table.Column<int>(nullable: true),
                    Createdby = table.Column<long>(nullable: true),
                    ModifiedBy = table.Column<long>(nullable: true),
                    JoiningDate = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    MainMemberId = table.Column<long>(nullable: true),
                    MemImagePath = table.Column<string>(nullable: true),
                    MemImagename = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberRegistration", x => x.MemberId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    PaymentID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlanID = table.Column<int>(nullable: false),
                    WorkouttypeID = table.Column<int>(nullable: true),
                    Paymenttype = table.Column<string>(nullable: true),
                    PaymentFromdt = table.Column<DateTime>(nullable: false),
                    PaymentTodt = table.Column<DateTime>(nullable: false),
                    PaymentAmount = table.Column<decimal>(nullable: true),
                    NextRenwalDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    Createdby = table.Column<int>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    RecStatus = table.Column<string>(nullable: true),
                    MemberID = table.Column<long>(nullable: true),
                    MemberNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.PaymentID);
                });

            migrationBuilder.CreateTable(
                name: "PeriodTB",
                columns: table => new
                {
                    PeriodID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodTB", x => x.PeriodID);
                });

            migrationBuilder.CreateTable(
                name: "PlanMaster",
                columns: table => new
                {
                    PlanID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlanName = table.Column<string>(nullable: true),
                    PlanAmount = table.Column<decimal>(nullable: true),
                    ServicetaxAmount = table.Column<decimal>(nullable: true),
                    ServiceTax = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    CreateUserID = table.Column<int>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    ModifyUserID = table.Column<int>(nullable: true),
                    RecStatus = table.Column<bool>(nullable: false),
                    SchemeID = table.Column<int>(nullable: true),
                    PeriodID = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<decimal>(nullable: true),
                    ServicetaxNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanMaster", x => x.PlanID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleName = table.Column<string>(maxLength: 100, nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "SchemeMaster",
                columns: table => new
                {
                    SchemeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SchemeName = table.Column<string>(nullable: true),
                    Createdby = table.Column<int>(nullable: false),
                    Createddate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchemeMaster", x => x.SchemeID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: true),
                    Contactno = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Createdby = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UsersInRoles",
                columns: table => new
                {
                    UserRolesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersInRoles", x => x.UserRolesId);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "RoleName", "Status" },
                values: new object[] { 1, "admin", true });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Contactno", "CreatedDate", "Createdby", "EmailId", "FullName", "Password", "Status", "UserName" },
                values: new object[] { 1, "212121212", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "some-admin-email@nonce.fake", "kerollos", "+nK/Ob7nYYUeC4+1qGRojg==", true, "admin" });

            migrationBuilder.InsertData(
                table: "UsersInRoles",
                columns: new[] { "UserRolesId", "RoleId", "UserId" },
                values: new object[] { 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberRegistration");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "PeriodTB");

            migrationBuilder.DropTable(
                name: "PlanMaster");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "SchemeMaster");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UsersInRoles");
        }
    }
}
