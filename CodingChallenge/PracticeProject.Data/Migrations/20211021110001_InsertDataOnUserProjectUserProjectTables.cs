using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticeProject.Data.Migrations
{
    public partial class SeedProjectsAndUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO Users (FirstName,LastName) Values ('Juan Fred 1','Porras')");
            migrationBuilder
                .Sql("INSERT INTO Users (Name,LastName) Values ('Juan Fred 2','Porras2')");
            migrationBuilder
                .Sql("INSERT INTO Users (Name,LastName) Values ('Juan Fred 3','Porras3')");
          
                
            migrationBuilder
                .Sql("INSERT INTO Projects (StartDate, EndDate,Credits) Values (convert(datetime,'21-10-20 10:34:09 PM',5), convert(datetime,'22-10-20 10:34:09 PM',5), 10 )");
            migrationBuilder
                 .Sql("INSERT INTO Projects (StartDate, EndDate,Credits) Values (convert(datetime,'21-11-20 10:34:09 PM',5), convert(datetime,'22-11-20 10:34:09 PM',5), 3 )");
            migrationBuilder
                 .Sql("INSERT INTO Projects (StartDate, EndDate,Credits) Values (convert(datetime,'22-01-20 10:34:09 PM',5), convert(datetime,'23-11-20 10:34:09 PM',5), 11 )");
            migrationBuilder
                 .Sql("INSERT INTO Projects (StartDate, EndDate,Credits) Values (convert(datetime,'22-04-20 10:34:09 PM',5), convert(datetime,'23-08-10 10:34:09 PM',5), 7 )");

            migrationBuilder
                .Sql("INSERT INTO UserProject (UserId, ProjectId,isActive) Values (1,1,1)");
            migrationBuilder
                .Sql("INSERT INTO UserProject (UserId, ProjectId,isActive) Values (1,2,0)");
            migrationBuilder
                .Sql("INSERT INTO UserProject (UserId, ProjectId,isActive) Values (2,3,0)");
            migrationBuilder
                .Sql("INSERT INTO UserProject (UserId, ProjectId,isActive) Values (3,4,0)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM Projects");

            migrationBuilder
                .Sql("DELETE FROM Users");
        }
    }
}
