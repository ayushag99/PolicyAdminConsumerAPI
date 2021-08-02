using Microsoft.EntityFrameworkCore.Migrations;

namespace PolicyAdmin.ConsumerMS.API.Migrations
{
    public partial class Populate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "PropertiesMaster",
               columns: new[] { "PropertyType", "MinimumCostOfAsset", "MaximumCostOfAsset", "MinimumArea", "MaximumArea", "PropertyAgeMin", "PropertyAgeMax", "EstimatedLife" },
               values: new object[,]
               {
                { 0, 10000000, 999999999, 1000, 99999999, 2, 100, 50}
           });
            migrationBuilder.InsertData(
               table: "BusinessesMaster",
               columns: new[] { "BusinessType", "MinimumAnnualTurnOver", "MinimumCapitalInvested", "MinimumBusinessAgeInYears", "MinimumTotalEmployees" },
               values: new object[,]
               {
               { 0, 1200000, 2000000, 2, 10},
{ 1, 2400000, 3000000, 2, 20},
{ 2, 4000000, 5000000, 2, 30},
{ 3, 5000000, 8000000, 2, 40},
{4, 7000000, 10000000, 2, 80 },
{5, 1000000, 1000000, 2, 20 },
{6, 1000000, 1000000, 2, 20 }
           });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
