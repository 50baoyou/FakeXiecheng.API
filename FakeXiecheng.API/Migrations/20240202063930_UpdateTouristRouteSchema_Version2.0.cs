using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FakeXiecheng.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTouristRouteSchema_Version20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastUpdatedTime",
                table: "TouristRoutes",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValueSql: "SYSDATETIMEOFFSET()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "TouristRoutes",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateTime",
                table: "TouristRoutes",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValueSql: "SYSDATETIMEOFFSET()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastUpdatedTime",
                table: "TouristRoutePictures",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValueSql: "SYSDATETIMEOFFSET()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "TouristRoutePictures",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateTime",
                table: "TouristRoutePictures",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValueSql: "SYSDATETIMEOFFSET()");

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9368), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9373), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9439), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9440), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9461), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9462), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9481), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9482), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9501), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9502), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9523), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9524), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9542), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9543), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9562), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9562), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9583), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9583), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9604), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9604), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9625), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9625), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9644), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9645), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9664), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9665), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9720), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9720), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9742), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9743), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9763), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9781), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9782), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9803), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9803), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9822), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9823), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9841), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9842), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9861), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9861), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9881), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9882), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9901), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9901), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9920), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9920), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9939), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(9940), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(25), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(25), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(50), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(51), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(70), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(71), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(89), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(90), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(108), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(109), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(127), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(127), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(176), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(177), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(199), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(199), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(244), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(245), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(267), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(267), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(286), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(287), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(305), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(306), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(324), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(325), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(344), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(344), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(363), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(363), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(404), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(405), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(423), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(424), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(442), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(443), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(462), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(462), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(481), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(481), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(500), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(501), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(520), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(521), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(541), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(542), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(591), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(592), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(614), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(615), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(634), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(635), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(653), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(654), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(673), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(673), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(694), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(694), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(713), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(714), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(732), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(733), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(752), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(752), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(771), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(771), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(790), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(791), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(810), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(811), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(830), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(831), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(850), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(850), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(869), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(869), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(888), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(889), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(910), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(910), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(958), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(959), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(982), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 894, DateTimeKind.Unspecified).AddTicks(982), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("2430bf64-fd56-460c-8b75-da0a1d1cd74c"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(1496), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(1497), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47110"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(2594), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(2595), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47111"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(3011), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(3012), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47112"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(3457), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(3458), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47113"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(3961), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(3962), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47114"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(4409), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(4410), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47115"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(4844), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(4845), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47116"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(6299), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(6301), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47117"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(6759), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(6761), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47118"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(7159), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(7160), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47119"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(7694), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(7695), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47169"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(2012), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(2014), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("3ecbcd92-a9e0-45f7-9b29-e03272cb0862"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 892, DateTimeKind.Unspecified).AddTicks(9848), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 892, DateTimeKind.Unspecified).AddTicks(9849), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("88cf89b9-e4b5-4b42-a5bf-622bd3039601"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(561), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 893, DateTimeKind.Unspecified).AddTicks(562), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("a1fd0bee-0afc-4586-96c8-f46b7c99d2a0"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 892, DateTimeKind.Unspecified).AddTicks(9404), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 892, DateTimeKind.Unspecified).AddTicks(9408), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("fb6d4f10-79ed-4aff-a915-4ce29dc9c7e1"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 892, DateTimeKind.Unspecified).AddTicks(8089), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 2, 14, 39, 29, 892, DateTimeKind.Unspecified).AddTicks(8100), new TimeSpan(0, 8, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastUpdatedTime",
                table: "TouristRoutes",
                type: "datetimeoffset",
                nullable: false,
                defaultValueSql: "SYSDATETIMEOFFSET()",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "TouristRoutes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateTime",
                table: "TouristRoutes",
                type: "datetimeoffset",
                nullable: false,
                defaultValueSql: "SYSDATETIMEOFFSET()",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastUpdatedTime",
                table: "TouristRoutePictures",
                type: "datetimeoffset",
                nullable: false,
                defaultValueSql: "SYSDATETIMEOFFSET()",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "TouristRoutePictures",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateTime",
                table: "TouristRoutePictures",
                type: "datetimeoffset",
                nullable: false,
                defaultValueSql: "SYSDATETIMEOFFSET()",
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("2430bf64-fd56-460c-8b75-da0a1d1cd74c"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47110"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47111"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47112"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47113"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47114"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47115"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47116"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47117"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47118"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47119"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47169"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("3ecbcd92-a9e0-45f7-9b29-e03272cb0862"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("88cf89b9-e4b5-4b42-a5bf-622bd3039601"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("a1fd0bee-0afc-4586-96c8-f46b7c99d2a0"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("fb6d4f10-79ed-4aff-a915-4ce29dc9c7e1"),
                columns: new[] { "CreateTime", "LastUpdatedTime" },
                values: new object[] { new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
