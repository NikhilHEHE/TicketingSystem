using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketingSystem.Migrations
{
    /// <inheritdoc />
    public partial class SimpleAirlineSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Tickets",
                newName: "DepartureDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "BookingDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FlightNumber",
                table: "Tickets",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PassengerName",
                table: "Tickets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Tickets",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SeatClass",
                table: "Tickets",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 3, 3, 15, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 17, 6, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 3, 6, 43, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "JE0001", "New York (JFK)", "Passenger 1", 1062.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 5, 20, 8, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 15, 6, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 6, 31, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "AM0002", "Los Angeles (LAX)", "Passenger 2", 1887m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 10, 25, 23, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 1, 12, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 25, 12, 2, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "UN0003", "New York (JFK)", "Passenger 3", 980m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 4, 23, 15, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 6, 13, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 23, 13, 49, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "JE0004", "Atlanta (ATL)", "Passenger 4", 896m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 19, 21, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 4, 18, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 19, 18, 37, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "JE0005", "Chicago (ORD)", "Passenger 5", 524m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 8, 9, 19, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 2, 12, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 9, 12, 3, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "AM0006", "Atlanta (ATL)", "Passenger 6", 1118m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 27, 1, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 9, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 26, 17, 4, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "AM0007", "New York (JFK)", "Passenger 7", 322.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 10, 30, 2, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dubai (DXB)", "UN0008", "Atlanta (ATL)", "Passenger 8", 1050m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 8, 14, 4, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 28, 1, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 14, 1, 22, 0, 0, DateTimeKind.Unspecified), "Dubai (DXB)", "AL0009", "Denver (DEN)", "Passenger 9", 1152m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 8, 4, 7, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 14, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 3, 17, 1, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "SO0010", "Chicago (ORD)", "Passenger 10", 5776m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 5, 2, 21, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 28, 18, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 2, 18, 8, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "JE0011", "New York (JFK)", "Passenger 11", 720m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 9, 18, 21, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 16, 6, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 18, 6, 33, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "SO0012", "Denver (DEN)", "Passenger 12", 2615m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 4, 7, 10, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 1, 0, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 7, 0, 12, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "UN0013", "Denver (DEN)", "Passenger 13", 748m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 4, 29, 20, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 10, 18, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 29, 18, 49, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "AL0014", "New York (JFK)", "Passenger 14", 381m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 4, 12, 23, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 25, 13, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 12, 13, 38, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "AL0015", "Los Angeles (LAX)", "Passenger 15", 1800m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 12, 28, 8, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 9, 18, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 27, 18, 8, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "AM0016", "New York (JFK)", "Passenger 16", 1768m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 8, 7, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 11, 9, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 7, 9, 52, 0, 0, DateTimeKind.Unspecified), "Toronto (YYZ)", "SO0017", "Atlanta (ATL)", "Passenger 17", 652m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 2, 16, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 4, 2, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 16, 2, 0, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "UN0018", "Atlanta (ATL)", "Passenger 18", 5688m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 11, 30, 3, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 28, 23, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 29, 23, 53, 0, 0, DateTimeKind.Unspecified), "Dubai (DXB)", "UN0019", "Atlanta (ATL)", "Passenger 19", 634m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 4, 13, 21, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 19, 8, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 13, 8, 31, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "SO0020", "Denver (DEN)", "Passenger 20", 1302.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 11, 1, 22, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 10, 15, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 1, 15, 4, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "SO0021", "Los Angeles (LAX)", "Passenger 21", 1246m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 11, 23, 9, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 15, 23, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 22, 23, 9, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "JE0022", "Denver (DEN)", "Passenger 22", 711m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 5, 7, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 21, 12, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 7, 12, 43, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "SO0023", "Dallas/Fort Worth (DFW)", "Passenger 23", 3552m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 5, 5, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 21, 5, 18, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "SO0024", "Los Angeles (LAX)", "Passenger 24", 578m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 10, 6, 21, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 17, 15, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 6, 15, 59, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "AL0025", "Chicago (ORD)", "Passenger 25", 1969.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 5, 23, 6, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 3, 22, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 22, 22, 4, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "AM0026", "Denver (DEN)", "Passenger 26", 3360m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 4, 20, 3, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 10, 13, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 19, 13, 1, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "AL0027", "Denver (DEN)", "Passenger 27", 734m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 10, 2, 11, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 22, 0, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 2, 0, 20, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "SO0028", "Denver (DEN)", "Passenger 28", 1020m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 8, 9, 21, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 3, 15, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 9, 15, 36, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "SO0029", "Chicago (ORD)", "Passenger 29", 1064m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 5, 9, 6, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 28, 0, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 9, 0, 34, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "DE0030", "Denver (DEN)", "Passenger 30", 1608m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 8, 28, 15, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 6, 4, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 28, 4, 38, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "SO0031", "New York (JFK)", "Passenger 31", 1318m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 10, 17, 0, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 7, 13, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 16, 13, 32, 0, 0, DateTimeKind.Unspecified), "Dubai (DXB)", "SO0032", "Chicago (ORD)", "Passenger 32", 734m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 7, 18, 1, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 2, 19, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 17, 19, 41, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "AL0033", "Dallas/Fort Worth (DFW)", "Passenger 33", 1449m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 16, 13, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 23, 9, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 16, 9, 25, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "UN0034", "Denver (DEN)", "Passenger 34", 3724m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 6, 26, 20, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 9, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 26, 17, 24, 0, 0, DateTimeKind.Unspecified), "Dubai (DXB)", "DE0035", "Denver (DEN)", "Passenger 35", 666m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 3, 19, 8, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 27, 22, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 18, 22, 52, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "UN0036", "Denver (DEN)", "Passenger 36", 2577.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 11, 28, 0, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 4, 15, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 27, 15, 55, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "SO0037", "Los Angeles (LAX)", "Passenger 37", 400m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 8, 27, 14, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 9, 0, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 27, 0, 14, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "DE0038", "Chicago (ORD)", "Passenger 38", 1275m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 4, 16, 15, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 10, 13, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 16, 13, 3, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "UN0039", "Atlanta (ATL)", "Passenger 39", 4184m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 11, 25, 22, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 5, 16, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 25, 16, 53, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "SO0040", "Dallas/Fort Worth (DFW)", "Passenger 40", 1812.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 8, 30, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 18, 2, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 30, 2, 47, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "JE0041", "Denver (DEN)", "Passenger 41", 5208m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 6, 13, 2, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 21, 21, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 12, 21, 11, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "JE0042", "Denver (DEN)", "Passenger 42", 5064m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 11, 6, 15, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 9, 8, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 6, 8, 51, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "SO0043", "Denver (DEN)", "Passenger 43", 334m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 12, 19, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 31, 13, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 12, 13, 39, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "DE0044", "Denver (DEN)", "Passenger 44", 1472m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 5, 21, 0, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 22, 13, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 13, 58, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "JE0045", "New York (JFK)", "Passenger 45", 837m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 4, 15, 11, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 26, 21, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 14, 21, 55, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "UN0046", "Atlanta (ATL)", "Passenger 46", 1453m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 22, 8, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 29, 19, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 21, 19, 27, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "AM0047", "Chicago (ORD)", "Passenger 47", 4872m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 8, 13, 19, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 27, 11, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 13, 11, 45, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "AM0048", "Denver (DEN)", "Passenger 48", 2700m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 6, 30, 20, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 20, 12, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 30, 12, 21, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "UN0049", "New York (JFK)", "Passenger 49", 1090m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 12, 17, 13, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 14, 8, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 17, 8, 17, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "SO0050", "Dallas/Fort Worth (DFW)", "Passenger 50", 2928m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 9, 30, 4, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 11, 14, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 29, 14, 28, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "DE0051", "New York (JFK)", "Passenger 51", 1138.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 12, 13, 14, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 11, 2, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 13, 2, 17, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "DE0052", "Chicago (ORD)", "Passenger 52", 1727.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 4, 6, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 20, 11, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 6, 11, 31, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "UN0053", "Denver (DEN)", "Passenger 53", 2647.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 3, 4, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 10, 5, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 4, 5, 12, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "AM0054", "Chicago (ORD)", "Passenger 54", 674m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 16, 14, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 11, 26, 3, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 16, 3, 34, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "DE0055", "Chicago (ORD)", "Passenger 55", 5304m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 28, 8, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 12, 2, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 28, 2, 59, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "DE0056", "Atlanta (ATL)", "Passenger 56", 1440m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 8, 25, 18, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 13, 15, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 25, 15, 25, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "DE0057", "New York (JFK)", "Passenger 57", 861m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 7, 4, 6, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 27, 0, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 4, 0, 56, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "AL0058", "Atlanta (ATL)", "Passenger 58", 1444.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 3, 26, 18, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 23, 14, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 26, 14, 34, 0, 0, DateTimeKind.Unspecified), "Dubai (DXB)", "AL0059", "Denver (DEN)", "Passenger 59", 1044m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 10, 25, 11, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 29, 21, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 24, 21, 11, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "AM0060", "Denver (DEN)", "Passenger 60", 476m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 12, 23, 18, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 20, 11, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 23, 11, 12, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "JE0061", "Chicago (ORD)", "Passenger 61", 669m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 5, 14, 13, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 11, 5, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 14, 5, 41, 0, 0, DateTimeKind.Unspecified), "Toronto (YYZ)", "AM0062", "Dallas/Fort Worth (DFW)", "Passenger 62", 1400m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 6, 29, 4, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 22, 23, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 28, 23, 57, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "DE0063", "Los Angeles (LAX)", "Passenger 63", 1615.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 5, 20, 15, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 5, 9, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 9, 41, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "AL0064", "New York (JFK)", "Passenger 64", 1271m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 11, 14, 22, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 10, 12, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 14, 12, 12, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "UN0065", "New York (JFK)", "Passenger 65", 1149m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 5, 15, 22, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 14, 11, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 15, 11, 27, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "AM0066", "Dallas/Fort Worth (DFW)", "Passenger 66", 1050m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 3, 14, 11, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 16, 2, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 14, 2, 37, 0, 0, DateTimeKind.Unspecified), "Toronto (YYZ)", "SO0067", "Denver (DEN)", "Passenger 67", 2552.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 8, 20, 23, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 24, 21, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 20, 21, 26, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "SO0068", "Chicago (ORD)", "Passenger 68", 968m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 6, 6, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 13, 2, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 6, 2, 6, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "JE0069", "Chicago (ORD)", "Passenger 69", 1242m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 3, 30, 13, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 13, 10, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 30, 10, 25, 0, 0, DateTimeKind.Unspecified), "Toronto (YYZ)", "AL0070", "Denver (DEN)", "Passenger 70", 5004m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 21, 8, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 22, 19, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 20, 19, 7, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "AL0071", "Dallas/Fort Worth (DFW)", "Passenger 71", 3612m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 4, 1, 14, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 26, 3, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 1, 3, 24, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "DE0072", "Chicago (ORD)", "Passenger 72", 1507.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 12, 31, 2, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 19, 13, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 30, 13, 42, 0, 0, DateTimeKind.Unspecified), "Toronto (YYZ)", "DE0073", "Dallas/Fort Worth (DFW)", "Passenger 73", 3507.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 13, 14, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 8, 2, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 13, 2, 25, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "UN0074", "Chicago (ORD)", "Passenger 74", 980m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 11, 16, 3, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 8, 12, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 15, 12, 52, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "AL0075", "Los Angeles (LAX)", "Passenger 75", 1407m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 9, 30, 9, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 31, 4, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 30, 4, 55, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "DE0076", "Dallas/Fort Worth (DFW)", "Passenger 76", 3040m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 13, 21, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 3, 16, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 13, 16, 12, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "DE0077", "Los Angeles (LAX)", "Passenger 77", 1605m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 2, 12, 23, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 15, 16, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 12, 16, 21, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "JE0078", "Atlanta (ATL)", "Passenger 78", 3260m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 2, 20, 1, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 19, 16, 35, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "SO0079", "Dallas/Fort Worth (DFW)", "Passenger 79", 1260m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 7, 2, 7, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 19, 16, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 1, 16, 26, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "DE0080", "Los Angeles (LAX)", "Passenger 80", 1397.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 5, 21, 11, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 18, 9, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 21, 9, 9, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "AM0081", "Atlanta (ATL)", "Passenger 81", 1456.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 11, 4, 10, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 14, 8, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 4, 8, 4, 0, 0, DateTimeKind.Unspecified), "Dubai (DXB)", "AL0082", "Atlanta (ATL)", "Passenger 82", 748.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 12, 30, 15, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 3, 12, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 30, 12, 41, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "DE0083", "Dallas/Fort Worth (DFW)", "Passenger 83", 1868m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 2, 28, 14, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 14, 1, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 28, 1, 27, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "AM0084", "Chicago (ORD)", "Passenger 84", 1915m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 12, 24, 2, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 14, 15, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 23, 15, 48, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "SO0085", "Atlanta (ATL)", "Passenger 85", 1089m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 2, 10, 22, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 21, 14, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 10, 14, 25, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "SO0086", "Chicago (ORD)", "Passenger 86", 2968m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 10, 17, 23, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 31, 11, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 17, 11, 21, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "JE0087", "New York (JFK)", "Passenger 87", 393m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 10, 29, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 8, 13, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 29, 13, 47, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "AL0088", "Los Angeles (LAX)", "Passenger 88", 1981.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 11, 6, 1, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 3, 20, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 5, 20, 35, 0, 0, DateTimeKind.Unspecified), "Dubai (DXB)", "JE0089", "New York (JFK)", "Passenger 89", 905m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 28, 23, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 30, 11, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 28, 11, 40, 0, 0, DateTimeKind.Unspecified), "Dubai (DXB)", "SO0090", "New York (JFK)", "Passenger 90", 1312.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 3, 27, 14, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 22, 8, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 27, 8, 47, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "AM0091", "New York (JFK)", "Passenger 91", 1312m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 2, 14, 4, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 19, 15, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 13, 15, 39, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "JE0092", "Los Angeles (LAX)", "Passenger 92", 590m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 2, 19, 23, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 28, 21, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 19, 21, 49, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "AL0093", "New York (JFK)", "Passenger 93", 1787.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 21, 0, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 22, 15, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 20, 15, 31, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "AL0094", "New York (JFK)", "Passenger 94", 1927.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 10, 1, 14, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 5, 8, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "DE0095", "Los Angeles (LAX)", "Passenger 95", 3220m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 7, 26, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 5, 3, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 26, 3, 52, 0, 0, DateTimeKind.Unspecified), "Dubai (DXB)", "JE0096", "Denver (DEN)", "Passenger 96", 1794m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 9, 3, 22, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 7, 18, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 3, 18, 22, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "SO0097", "Dallas/Fort Worth (DFW)", "Passenger 97", 562.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 11, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "DE0098", "New York (JFK)", "Passenger 98", 5172m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 7, 22, 10, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 29, 0, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 22, 0, 33, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "UN0099", "Chicago (ORD)", "Passenger 99", 5048m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 12, 17, 14, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 20, 7, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 17, 7, 23, 0, 0, DateTimeKind.Unspecified), "Toronto (YYZ)", "JE0100", "Atlanta (ATL)", "Passenger 100", 913.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 4, 25, 2, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 27, 15, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 24, 15, 55, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "AL0101", "Los Angeles (LAX)", "Passenger 101", 759m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 11, 15, 15, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 6, 0, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 15, 0, 12, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "DE0102", "Dallas/Fort Worth (DFW)", "Passenger 102", 436m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 9, 4, 20, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 31, 12, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 4, 12, 25, 0, 0, DateTimeKind.Unspecified), "Dubai (DXB)", "AM0103", "Dallas/Fort Worth (DFW)", "Passenger 103", 1309m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 10, 11, 15, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 18, 6, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 11, 6, 10, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "AM0104", "Atlanta (ATL)", "Passenger 104", 4208m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 10, 3, 14, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 9, 2, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 3, 2, 31, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "DE0105", "Denver (DEN)", "Passenger 105", 4012m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 9, 30, 8, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 14, 4, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 30, 4, 49, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "DE0106", "Chicago (ORD)", "Passenger 106", 1592.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 9, 21, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 15, 12, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 21, 12, 47, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "AM0107", "Chicago (ORD)", "Passenger 107", 1960m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 8, 6, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 3, 7, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 6, 7, 38, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "AL0108", "Atlanta (ATL)", "Passenger 108", 1009.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 7, 4, 23, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 30, 18, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 4, 18, 25, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "AL0109", "Dallas/Fort Worth (DFW)", "Passenger 109", 1468m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 9, 2, 20, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 18, 14, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 2, 14, 6, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "UN0110", "Denver (DEN)", "Passenger 110", 1568m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 26, 0, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 30, 10, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 25, 10, 11, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "AM0111", "Los Angeles (LAX)", "Passenger 111", 1056m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 10, 22, 3, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 25, 13, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 21, 13, 37, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "SO0112", "Los Angeles (LAX)", "Passenger 112", 2552m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 3, 18, 4, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 17, 21, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 17, 21, 27, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "DE0113", "Atlanta (ATL)", "Passenger 113", 2475m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 4, 10, 5, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 3, 16, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 9, 16, 10, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "AM0114", "Chicago (ORD)", "Passenger 114", 1321m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 16, 10, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 9, 2, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 16, 2, 8, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "SO0115", "Chicago (ORD)", "Passenger 115", 690m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 2, 21, 8, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 9, 18, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 20, 18, 14, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "AL0116", "Los Angeles (LAX)", "Passenger 116", 1224m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 3, 24, 15, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 16, 4, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 24, 4, 56, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "AL0117", "Dallas/Fort Worth (DFW)", "Passenger 117", 837m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 5, 20, 21, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 13, 14, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 20, 14, 21, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "UN0118", "Dallas/Fort Worth (DFW)", "Passenger 118", 1459.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 4, 3, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 3, 23, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 3, 23, 22, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "JE0119", "New York (JFK)", "Passenger 119", 2226m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 2, 11, 22, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 23, 19, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 11, 19, 10, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "UN0120", "Los Angeles (LAX)", "Passenger 120", 2030m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 9, 24, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 23, 4, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 24, 4, 13, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "DE0121", "Chicago (ORD)", "Passenger 121", 5000m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 6, 13, 12, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 27, 23, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 12, 23, 25, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "UN0122", "Denver (DEN)", "Passenger 122", 670m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 9, 15, 8, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 11, 2, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 15, 2, 42, 0, 0, DateTimeKind.Unspecified), "Toronto (YYZ)", "AL0123", "Dallas/Fort Worth (DFW)", "Passenger 123", 1516m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 12, 15, 14, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 28, 7, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 15, 7, 2, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "UN0124", "Los Angeles (LAX)", "Passenger 124", 4756m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 2, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "JE0125", "Atlanta (ATL)", "Passenger 125", 754.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2027, 1, 1, 0, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 23, 9, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 31, 9, 43, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "UN0126", "Chicago (ORD)", "Passenger 126", 485m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 2, 5, 12, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 27, 3, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 5, 3, 57, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "UN0127", "Denver (DEN)", "Passenger 127", 1146m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 7, 9, 9, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 30, 4, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 9, 4, 23, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "AL0128", "Denver (DEN)", "Passenger 128", 1939.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 3, 11, 13, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 5, 2, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 11, 2, 9, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "DE0129", "Chicago (ORD)", "Passenger 129", 4740m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 4, 24, 23, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 25, 20, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 24, 20, 4, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "SO0130", "New York (JFK)", "Passenger 130", 668m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 3, 20, 22, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 31, 9, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 20, 9, 16, 0, 0, DateTimeKind.Unspecified), "Toronto (YYZ)", "SO0131", "Chicago (ORD)", "Passenger 131", 1103m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 7, 21, 13, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 20, 3, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 21, 3, 48, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "AL0132", "Chicago (ORD)", "Passenger 132", 252m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 7, 25, 12, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 13, 21, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 24, 21, 46, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "DE0133", "Los Angeles (LAX)", "Passenger 133", 1423m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 7, 18, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 1, 14, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 18, 14, 41, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "DE0134", "Los Angeles (LAX)", "Passenger 134", 4852m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 8, 1, 6, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 22, 3, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 1, 3, 54, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "JE0135", "Los Angeles (LAX)", "Passenger 135", 3780m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 12, 19, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 29, 8, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 19, 8, 43, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "DE0136", "Chicago (ORD)", "Passenger 136", 1330.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 9, 9, 22, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 14, 17, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 9, 17, 33, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "SO0137", "Chicago (ORD)", "Passenger 137", 888m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 3, 16, 5, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 17, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 15, 16, 15, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "UN0138", "Dallas/Fort Worth (DFW)", "Passenger 138", 947m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 8, 24, 0, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 10, 15, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 23, 15, 9, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "AL0139", "Atlanta (ATL)", "Passenger 139", 5508m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 3, 8, 2, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 15, 11, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 7, 11, 26, 0, 0, DateTimeKind.Unspecified), "Dubai (DXB)", "AL0140", "Los Angeles (LAX)", "Passenger 140", 805.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 9, 8, 18, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 22, 5, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 8, 5, 40, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "SO0141", "Atlanta (ATL)", "Passenger 141", 990m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 5, 14, 2, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 10, 23, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 13, 23, 58, 0, 0, DateTimeKind.Unspecified), "Frankfurt (FRA)", "DE0142", "Denver (DEN)", "Passenger 142", 686m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 30, 13, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 17, 6, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 30, 6, 19, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "SO0143", "New York (JFK)", "Passenger 143", 430.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 11, 12, 20, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 19, 8, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 12, 8, 2, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "AM0144", "Los Angeles (LAX)", "Passenger 144", 817.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 2, 19, 6, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 5, 23, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 18, 23, 16, 0, 0, DateTimeKind.Unspecified), "Dubai (DXB)", "AL0145", "Los Angeles (LAX)", "Passenger 145", 762.5m, "Business" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 4, 13, 18, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 19, 13, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 13, 13, 15, 0, 0, DateTimeKind.Unspecified), "Sydney (SYD)", "UN0146", "Chicago (ORD)", "Passenger 146", 896m, "Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 17, 22, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 15, 18, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 17, 18, 20, 0, 0, DateTimeKind.Unspecified), "Mexico City (MEX)", "AL0147", "Los Angeles (LAX)", "Passenger 147", 745.5m, "Premium Economy" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 1, 28, 18, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 21, 6, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 28, 6, 36, 0, 0, DateTimeKind.Unspecified), "London (LHR)", "AL0148", "Los Angeles (LAX)", "Passenger 148", 1796m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 3, 30, 3, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 10, 21, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 29, 21, 40, 0, 0, DateTimeKind.Unspecified), "Tokyo (NRT)", "DE0149", "Denver (DEN)", "Passenger 149", 3088m, "First" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ArrivalDate", "BookingDate", "DepartureDate", "Destination", "FlightNumber", "Origin", "PassengerName", "Price", "SeatClass" },
                values: new object[] { new DateTime(2026, 6, 25, 6, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 3, 15, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 24, 15, 31, 0, 0, DateTimeKind.Unspecified), "Paris (CDG)", "DE0150", "Dallas/Fort Worth (DFW)", "Passenger 150", 2372.5m, "Business" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalDate",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "BookingDate",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "FlightNumber",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Origin",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PassengerName",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "SeatClass",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "DepartureDate",
                table: "Tickets",
                newName: "CreatedDate");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tickets",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Tickets",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU1818 - Business Class - Main Cabin - Apr 06, 2026 05:30 PM", "SU1818: Chicago (ORD) → Dubai (DXB)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 3, 0, 48, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE5813 - Premium Economy - Main Cabin - Jul 08, 2026 12:48 AM", "JE5813: Las Vegas (LAS) → Frankfurt (FRA)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 11, 3, 54, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM6955 - Business Class - Basic Economy - Sep 17, 2026 03:54 AM", "AM6955: Miami (MIA) → São Paulo (GRU)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 13, 19, 44, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE3906 - First Class - Basic Economy - Jul 15, 2026 07:44 PM", "DE3906: Dallas/Fort Worth (DFW) → Bangkok (BKK)", new DateTime(2026, 7, 15, 19, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 1, 15, 8, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI540 - Economy - Business Flexible - Apr 16, 2026 03:08 PM", "SI540: Charlotte (CLT) → Dubai (DXB)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 2, 8, 16, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE779 - Business Class - Main Cabin - Jan 05, 2026 08:16 AM", "DE779: San Francisco (SFO) → Shanghai (PVG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 13, 0, 49, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR227 - Premium Economy - Refundable - Jul 02, 2026 12:49 AM", "FR227: New York (JFK) → São Paulo (GRU)", new DateTime(2026, 7, 3, 0, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 22, 1, 22, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE1504 - Premium Economy - Flexible - Aug 14, 2026 01:22 AM", "DE1504: Detroit (DTW) → Santiago (SCL)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 5, 0, 52, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA9580 - First Class - Business Saver - Sep 26, 2026 12:52 AM", "HA9580: San Francisco (SFO) → Frankfurt (FRA)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 26, 3, 12, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN5956 - Premium Economy - Business Flexible - Feb 24, 2026 03:12 AM", "UN5956: Los Angeles (LAX) → Barcelona (BCN)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 12, 27, 15, 1, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI3519 - Premium Economy - Refundable - Dec 28, 2026 03:01 PM", "SI3519: Charlotte (CLT) → Beijing (PEK)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 25, 2, 59, 0, 0, DateTimeKind.Unspecified), "Southwest Airlines Flight SO1301 - Economy - Business Saver - Jun 04, 2026 02:59 AM", "SO1301: Dallas/Fort Worth (DFW) → Paris (CDG)", new DateTime(2026, 6, 13, 2, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 11, 5, 5, 55, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI8467 - Economy - Business Flexible - Nov 24, 2026 05:55 AM", "SI8467: Minneapolis (MSP) → London (LHR)", new DateTime(2026, 12, 10, 5, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 20, 22, 59, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU7837 - Economy - Basic Economy - Mar 26, 2026 10:59 PM", "SU7837: Atlanta (ATL) → Frankfurt (FRA)", new DateTime(2026, 4, 21, 22, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 10, 9, 52, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE4504 - Business Class - Basic Economy - Aug 07, 2026 09:52 AM", "JE4504: Las Vegas (LAS) → Prague (PRG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 28, 0, 10, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR9408 - First Class - Basic Economy - Feb 09, 2026 12:10 AM", "FR9408: Las Vegas (LAS) → Santiago (SCL)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 25, 4, 20, 0, 0, DateTimeKind.Unspecified), "Allegiant Air Flight AL5467 - First Class - First Class Flexible - Nov 22, 2026 04:20 AM", "AL5467: San Francisco (SFO) → Dubai (DXB)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 14, 5, 53, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA6677 - Premium Economy - Refundable - Oct 21, 2026 05:53 AM", "CA6677: Miami (MIA) → Cancun (CUN)", new DateTime(2026, 10, 29, 5, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 23, 18, 57, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA9435 - Premium Economy - Business Flexible - Nov 18, 2026 06:57 PM", "CA9435: Charlotte (CLT) → Tokyo (NRT)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 16, 16, 6, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI8078 - Economy - Business Saver - Jul 02, 2026 04:06 PM", "VI8078: Chicago (ORD) → Bangkok (BKK)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 9, 22, 3, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO651 - First Class - Business Saver - Mar 14, 2026 10:03 PM", "BO651: Atlanta (ATL) → Vienna (VIE)", new DateTime(2026, 3, 23, 22, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 21, 18, 39, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE9992 - Premium Economy - Flexible - Jun 15, 2026 06:39 PM", "JE9992: Dallas/Fort Worth (DFW) → Lima (LIM)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 12, 22, 4, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE4763 - Business Class - Business Saver - May 22, 2026 10:04 PM", "JE4763: Chicago (ORD) → Santiago (SCL)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 11, 0, 53, 0, 0, DateTimeKind.Unspecified), "Essential Air Flight ES4167 - Economy - Flexible - Jul 31, 2026 12:53 AM", "ES4167: Detroit (DTW) → Lima (LIM)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 24, 15, 2, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI6883 - First Class - Basic Economy - May 05, 2026 03:02 PM", "VI6883: Dallas/Fort Worth (DFW) → Santiago (SCL)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 19, 15, 5, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL1445 - Business Class - Business Saver - Apr 28, 2026 03:05 PM", "AL1445: Atlanta (ATL) → Bangkok (BKK)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 4, 38, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI1174 - Business Class - Flexible - Feb 26, 2026 04:38 AM", "VI1174: Denver (DEN) → London (LHR)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 24, 14, 25, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU4342 - Business Class - First Class Flexible - May 11, 2026 02:25 PM", "SU4342: Atlanta (ATL) → Singapore (SIN)", new DateTime(2026, 6, 3, 14, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 22, 5, 18, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA5449 - Business Class - First Class Flexible - Sep 12, 2026 05:18 AM", "HA5449: Charlotte (CLT) → Rome (FCO)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 28, 20, 2, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL4191 - Premium Economy - First Class Flexible - Jul 03, 2026 08:02 PM", "AL4191: Phoenix (PHX) → Rio de Janeiro (GIG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 30, 11, 42, 0, 0, DateTimeKind.Unspecified), "Allegiant Air Flight AL4198 - First Class - Refundable - Apr 23, 2026 11:42 AM", "AL4198: San Francisco (SFO) → London (LHR)", new DateTime(2026, 4, 28, 11, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 11, 27, 21, 38, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR6433 - Business Class - Main Cabin - Dec 12, 2026 09:38 PM", "FR6433: Detroit (DTW) → Santiago (SCL)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 11, 28, 13, 9, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL3833 - First Class - Business Saver - Dec 02, 2026 01:09 PM", "AL3833: Los Angeles (LAX) → Dubai (DXB)", new DateTime(2026, 12, 13, 13, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 20, 19, 23, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE6022 - Economy - First Class Flexible - Oct 29, 2026 07:23 PM", "DE6022: Charlotte (CLT) → London (LHR)", new DateTime(2026, 11, 21, 19, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 23, 18, 31, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA7226 - Business Class - Basic Economy - Jul 13, 2026 06:31 PM", "HA7226: New York (JFK) → London (LHR)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 8, 22, 48, 0, 0, DateTimeKind.Unspecified), "Essential Air Flight ES6660 - First Class - Business Flexible - Nov 05, 2026 10:48 PM", "ES6660: Denver (DEN) → Rome (FCO)", new DateTime(2026, 11, 28, 22, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 14, 10, 54, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA2037 - First Class - Business Flexible - Oct 25, 2026 10:54 AM", "CA2037: Chicago (ORD) → Shanghai (PVG)", new DateTime(2026, 11, 18, 10, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 3, 20, 23, 0, 0, DateTimeKind.Unspecified), "Allegiant Air Flight AL1127 - Economy - Business Flexible - May 07, 2026 08:23 PM", "AL1127: Detroit (DTW) → Bogotá (BOG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 24, 7, 7, 0, 0, DateTimeKind.Unspecified), "Essential Air Flight ES2072 - Economy - Refundable - Aug 28, 2026 07:07 AM", "ES2072: Las Vegas (LAS) → Montevideo (MVD)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 1, 6, 59, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN4866 - Business Class - First Class Flexible - Sep 17, 2026 06:59 AM", "UN4866: Seattle (SEA) → Madrid (MAD)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 11, 23, 7, 14, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE4140 - First Class - First Class Flexible - Dec 19, 2026 07:14 AM", "DE4140: Dallas/Fort Worth (DFW) → Lima (LIM)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 11, 3, 6, 52, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE1498 - First Class - Business Flexible - Nov 21, 2026 06:52 AM", "DE1498: Minneapolis (MSP) → Barcelona (BCN)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 29, 3, 6, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR1182 - Business Class - Main Cabin - May 14, 2026 03:06 AM", "FR1182: Boston (BOS) → Barcelona (BCN)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL9603 - Economy - Business Saver - Oct 10, 2026 08:48 AM", "AL9603: Seattle (SEA) → Shanghai (PVG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 11, 8, 9, 44, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE6072 - Economy - Basic Economy - Dec 05, 2026 09:44 AM", "JE6072: San Francisco (SFO) → Prague (PRG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 26, 22, 5, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP3016 - Premium Economy - Main Cabin - Sep 06, 2026 10:05 PM", "SP3016: Minneapolis (MSP) → Dubai (DXB)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 29, 11, 31, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA3334 - Economy - Business Saver - Apr 06, 2026 11:31 AM", "HA3334: Seattle (SEA) → Montevideo (MVD)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 21, 5, 43, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN3713 - Economy - Main Cabin - Mar 23, 2026 05:43 AM", "UN3713: Seattle (SEA) → Paris (CDG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR8624 - Economy - Main Cabin - Jul 28, 2026 04:51 PM", "FR8624: New York (JFK) → Lima (LIM)", new DateTime(2026, 8, 13, 16, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 27, 6, 4, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA1594 - First Class - Flexible - Feb 15, 2026 06:04 AM", "CA1594: Los Angeles (LAX) → Dubai (DXB)", new DateTime(2026, 2, 19, 6, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 11, 18, 13, 21, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU4923 - Business Class - Business Flexible - Nov 20, 2026 01:21 PM", "SU4923: San Francisco (SFO) → Tokyo (NRT)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 22, 11, 48, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI2391 - Economy - First Class Flexible - Nov 08, 2026 11:48 AM", "VI2391: Dallas/Fort Worth (DFW) → Bangkok (BKK)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 2, 2, 48, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN8853 - Economy - First Class Flexible - Aug 09, 2026 02:48 AM", "UN8853: New York (JFK) → Paris (CDG)", new DateTime(2026, 9, 4, 2, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 12, 21, 11, 12, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP4214 - Economy - Main Cabin - Dec 23, 2026 11:12 AM", "SP4214: Miami (MIA) → Zurich (ZRH)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 16, 16, 26, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN9240 - Economy - Flexible - Mar 24, 2026 04:26 PM", "UN9240: Miami (MIA) → Shanghai (PVG)", new DateTime(2026, 3, 25, 16, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE8447 - First Class - First Class Flexible - Apr 06, 2026 04:37 PM", "DE8447: Seattle (SEA) → Zurich (ZRH)", new DateTime(2026, 4, 8, 16, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 17, 9, 9, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP8173 - Premium Economy - Business Flexible - Oct 03, 2026 09:09 AM", "SP8173: San Francisco (SFO) → Shanghai (PVG)", new DateTime(2026, 10, 29, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 15, 23, 10, 0, 0, DateTimeKind.Unspecified), "Southwest Airlines Flight SO3760 - Business Class - Main Cabin - Sep 29, 2026 11:10 PM", "SO3760: Phoenix (PHX) → Beijing (PEK)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 12, 17, 11, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO1229 - Business Class - First Class Flexible - Sep 28, 2026 05:11 PM", "BO1229: Charlotte (CLT) → London (LHR)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 15, 52, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU4420 - Premium Economy - Business Saver - Mar 03, 2026 03:52 PM", "SU4420: Philadelphia (PHL) → Vienna (VIE)", new DateTime(2026, 3, 20, 15, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 9, 2, 54, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI8037 - Economy - Flexible - Feb 06, 2026 02:54 AM", "SI8037: San Francisco (SFO) → Vienna (VIE)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 16, 1, 48, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI7585 - Economy - Refundable - Jun 05, 2026 01:48 AM", "VI7585: Charlotte (CLT) → São Paulo (GRU)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 13, 12, 29, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI464 - First Class - Basic Economy - Oct 17, 2026 12:29 PM", "VI464: Boston (BOS) → Paris (CDG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 3, 2, 0, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO7172 - Premium Economy - Business Saver - Apr 24, 2026 02:00 AM", "BO7172: Atlanta (ATL) → Dubai (DXB)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 5, 10, 21, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI2253 - First Class - First Class Flexible - Mar 06, 2026 10:21 AM", "VI2253: Las Vegas (LAS) → Shanghai (PVG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 12, 8, 7, 21, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM3188 - Economy - Business Saver - Dec 24, 2026 07:21 AM", "AM3188: San Francisco (SFO) → Rio de Janeiro (GIG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 2, 18, 42, 0, 0, DateTimeKind.Unspecified), "Essential Air Flight ES7479 - Economy - Basic Economy - Oct 09, 2026 06:42 PM", "ES7479: Philadelphia (PHL) → Prague (PRG)", new DateTime(2026, 11, 5, 18, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 9, 0, 40, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI2216 - Premium Economy - First Class Flexible - May 14, 2026 12:40 AM", "SI2216: Las Vegas (LAS) → Dubai (DXB)", new DateTime(2026, 6, 3, 0, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 24, 8, 25, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO8510 - Business Class - Basic Economy - Sep 13, 2026 08:25 AM", "BO8510: Charlotte (CLT) → Singapore (SIN)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 7, 12, 5, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO8311 - Economy - Business Saver - Aug 05, 2026 12:05 PM", "BO8311: Atlanta (ATL) → Buenos Aires (EZE)", new DateTime(2026, 8, 10, 12, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 31, 4, 18, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA6076 - Premium Economy - First Class Flexible - Apr 12, 2026 04:18 AM", "HA6076: Seattle (SEA) → Hong Kong (HKG)", new DateTime(2026, 4, 24, 4, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 28, 12, 23, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP3170 - Business Class - Basic Economy - Nov 08, 2026 12:23 PM", "SP3170: Chicago (ORD) → Paris (CDG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 26, 4, 50, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM9958 - Premium Economy - Basic Economy - Sep 16, 2026 04:50 AM", "AM9958: New York (JFK) → Mexico City (MEX)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 29, 15, 9, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM710 - Premium Economy - Flexible - Feb 23, 2026 03:09 PM", "AM710: Atlanta (ATL) → Barcelona (BCN)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 27, 23, 39, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP8024 - Business Class - First Class Flexible - Jan 16, 2026 11:39 PM", "SP8024: Boston (BOS) → Vienna (VIE)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 16, 14, 25, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN4555 - First Class - First Class Flexible - Feb 10, 2026 02:25 PM", "UN4555: Phoenix (PHX) → Rome (FCO)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 4, 8, 43, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU1570 - Economy - Business Flexible - Jul 01, 2026 08:43 AM", "SU1570: Los Angeles (LAX) → Lima (LIM)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 15, 3, 51, 0, 0, DateTimeKind.Unspecified), "Southwest Airlines Flight SO3509 - First Class - Refundable - Oct 17, 2026 03:51 AM", "SO3509: Phoenix (PHX) → Zurich (ZRH)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 6, 13, 33, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP6478 - First Class - Business Saver - Mar 23, 2026 01:33 PM", "SP6478: Los Angeles (LAX) → Buenos Aires (EZE)", new DateTime(2026, 4, 4, 13, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 17, 6, 4, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM5155 - First Class - Main Cabin - Jun 24, 2026 06:04 AM", "AM5155: Seattle (SEA) → Hong Kong (HKG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 3, 6, 35, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL819 - Economy - Refundable - Oct 23, 2026 06:35 AM", "AL819: Boston (BOS) → Frankfurt (FRA)", new DateTime(2026, 11, 11, 6, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 9, 14, 8, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI8926 - First Class - Basic Economy - Mar 10, 2026 02:08 PM", "SI8926: Dallas/Fort Worth (DFW) → Santiago (SCL)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 26, 1, 39, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP5298 - Economy - First Class Flexible - May 21, 2026 01:39 AM", "SP5298: Denver (DEN) → Lima (LIM)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 18, 8, 25, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR3444 - Economy - First Class Flexible - Oct 01, 2026 08:25 AM", "FR3444: New York (JFK) → Frankfurt (FRA)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 10, 21, 55, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI7685 - Premium Economy - Refundable - Feb 26, 2026 09:55 PM", "SI7685: Detroit (DTW) → Zurich (ZRH)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 22, 4, 1, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI4604 - Business Class - Business Flexible - May 20, 2026 04:01 AM", "SI4604: Detroit (DTW) → Beijing (PEK)", new DateTime(2026, 5, 24, 4, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 6, 18, 28, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA4985 - Economy - Main Cabin - Nov 04, 2026 06:28 PM", "CA4985: Detroit (DTW) → Singapore (SIN)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 28, 18, 36, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA7394 - Business Class - Business Flexible - Nov 25, 2026 06:36 PM", "HA7394: New York (JFK) → Prague (PRG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 12, 9, 5, 19, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE207 - Premium Economy - First Class Flexible - Dec 28, 2026 05:19 AM", "JE207: San Francisco (SFO) → Madrid (MAD)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 9, 1, 0, 0, 0, DateTimeKind.Unspecified), "Essential Air Flight ES8749 - First Class - Basic Economy - Sep 06, 2026 01:00 AM", "ES8749: Charlotte (CLT) → Barcelona (BCN)", new DateTime(2026, 9, 12, 1, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN4233 - First Class - Flexible - Feb 14, 2026 04:30 PM", "UN4233: Charlotte (CLT) → Mexico City (MEX)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 14, 6, 10, 0, 0, DateTimeKind.Unspecified), "Allegiant Air Flight AL5522 - First Class - First Class Flexible - Oct 11, 2026 06:10 AM", "AL5522: Atlanta (ATL) → Singapore (SIN)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 3, 12, 44, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM6220 - First Class - Business Flexible - Feb 06, 2026 12:44 PM", "AM6220: Detroit (DTW) → Sydney (SYD)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 8, 4, 20, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR7957 - Business Class - Main Cabin - Nov 01, 2026 04:20 AM", "FR7957: Atlanta (ATL) → Hong Kong (HKG)", new DateTime(2026, 11, 15, 4, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 5, 14, 51, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA6650 - First Class - Main Cabin - Mar 23, 2026 02:51 PM", "CA6650: Miami (MIA) → Vienna (VIE)", new DateTime(2026, 3, 31, 14, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 12, 5, 16, 50, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL9291 - Premium Economy - Business Saver - Dec 28, 2026 04:50 PM", "AL9291: Charlotte (CLT) → Vienna (VIE)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 12, 19, 5, 51, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP6730 - Business Class - Flexible - Dec 23, 2026 05:51 AM", "SP6730: Atlanta (ATL) → Dubai (DXB)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 5, 23, 3, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE4264 - Premium Economy - Flexible - Jul 07, 2026 11:03 PM", "JE4264: Chicago (ORD) → Mexico City (MEX)", new DateTime(2026, 8, 3, 23, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 23, 13, 37, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP8720 - First Class - Business Flexible - Oct 21, 2026 01:37 PM", "SP8720: Las Vegas (LAS) → Frankfurt (FRA)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 11, 12, 10, 24, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM6122 - Business Class - Main Cabin - Nov 18, 2026 10:24 AM", "AM6122: Las Vegas (LAS) → Tokyo (NRT)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 16, 20, 51, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL939 - Premium Economy - Business Saver - Mar 03, 2026 08:51 PM", "AL939: Denver (DEN) → Dubai (DXB)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 8, 1, 6, 0, 0, DateTimeKind.Unspecified), "Southwest Airlines Flight SO9820 - Economy - Main Cabin - Jun 14, 2026 01:06 AM", "SO9820: Miami (MIA) → Paris (CDG)", new DateTime(2026, 7, 13, 1, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 3, 23, 46, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN3255 - First Class - Business Flexible - Mar 09, 2026 11:46 PM", "UN3255: Boston (BOS) → Mexico City (MEX)", new DateTime(2026, 3, 15, 23, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 30, 0, 15, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI3876 - Economy - Flexible - Oct 11, 2026 12:15 AM", "VI3876: Miami (MIA) → Zurich (ZRH)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP9684 - Business Class - Basic Economy - May 10, 2026 11:00 AM", "SP9684: Phoenix (PHX) → Tokyo (NRT)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 11, 2, 48, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI1813 - Premium Economy - Basic Economy - Sep 05, 2026 02:48 AM", "VI1813: Las Vegas (LAS) → Rome (FCO)", new DateTime(2026, 9, 19, 2, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 5, 5, 43, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN8097 - First Class - Business Flexible - Mar 17, 2026 05:43 AM", "UN8097: San Francisco (SFO) → Santiago (SCL)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 10, 19, 3, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA2651 - Premium Economy - First Class Flexible - Jun 02, 2026 07:03 PM", "CA2651: Dallas/Fort Worth (DFW) → Shanghai (PVG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 9, 3, 34, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO4399 - Economy - Business Flexible - May 01, 2026 03:34 AM", "BO4399: Philadelphia (PHL) → Shanghai (PVG)", new DateTime(2026, 5, 28, 3, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 16, 17, 38, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI3776 - Premium Economy - Business Flexible - Oct 20, 2026 05:38 PM", "VI3776: Dallas/Fort Worth (DFW) → Paris (CDG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 10, 8, 4, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA2213 - Economy - Main Cabin - May 22, 2026 08:04 AM", "HA2213: New York (JFK) → Madrid (MAD)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 11, 9, 13, 13, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO1057 - Business Class - Refundable - Nov 25, 2026 01:13 PM", "BO1057: Philadelphia (PHL) → Mexico City (MEX)", new DateTime(2026, 12, 23, 13, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 28, 12, 11, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO4033 - First Class - Basic Economy - Apr 02, 2026 12:11 PM", "BO4033: Chicago (ORD) → Santiago (SCL)", new DateTime(2026, 4, 27, 12, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 16, 3, 41, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM7602 - First Class - Main Cabin - Feb 02, 2026 03:41 AM", "AM7602: Denver (DEN) → Tokyo (NRT)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 10, 3, 21, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE9711 - Premium Economy - Business Flexible - Jan 25, 2026 03:21 AM", "DE9711: Atlanta (ATL) → Dubai (DXB)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 24, 16, 48, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU9865 - Premium Economy - Main Cabin - Oct 29, 2026 04:48 PM", "SU9865: Los Angeles (LAX) → Toronto (YYZ)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM2713 - First Class - Business Saver - Jan 15, 2026 12:00 AM", "AM2713: Las Vegas (LAS) → Sydney (SYD)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 20, 2, 15, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA9013 - First Class - First Class Flexible - Sep 05, 2026 02:15 AM", "HA9013: Detroit (DTW) → Rio de Janeiro (GIG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 18, 7, 59, 0, 0, DateTimeKind.Unspecified), "Allegiant Air Flight AL9479 - First Class - Business Flexible - Oct 22, 2026 07:59 AM", "AL9479: Charlotte (CLT) → London (LHR)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 4, 2, 21, 0, 0, DateTimeKind.Unspecified), "Essential Air Flight ES9650 - Economy - Basic Economy - Jun 25, 2026 02:21 AM", "ES9650: Chicago (ORD) → Bangkok (BKK)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 11, 11, 0, 41, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR7322 - Business Class - Flexible - Nov 20, 2026 12:41 AM", "FR7322: Las Vegas (LAS) → Amsterdam (AMS)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 14, 4, 40, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA2723 - First Class - Business Flexible - Mar 31, 2026 04:40 AM", "HA2723: Philadelphia (PHL) → Zurich (ZRH)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 17, 15, 9, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP5528 - Premium Economy - Business Flexible - Aug 23, 2026 03:09 PM", "SP5528: Philadelphia (PHL) → Hong Kong (HKG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 3, 10, 58, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA2668 - Premium Economy - Main Cabin - Jun 20, 2026 10:58 AM", "CA2668: Atlanta (ATL) → Zurich (ZRH)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 7, 20, 9, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU2915 - Business Class - Main Cabin - Sep 03, 2026 08:09 PM", "SU2915: Phoenix (PHX) → Singapore (SIN)", new DateTime(2026, 9, 30, 20, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 7, 1, 34, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM183 - First Class - Basic Economy - May 17, 2026 01:34 AM", "AM183: Denver (DEN) → Montevideo (MVD)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 30, 5, 16, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM5625 - Premium Economy - Basic Economy - Sep 25, 2026 05:16 AM", "AM5625: Dallas/Fort Worth (DFW) → Frankfurt (FRA)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 12, 12, 7, 23, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL6250 - Economy - Flexible - Dec 20, 2026 07:23 AM", "AL6250: New York (JFK) → Beijing (PEK)", new DateTime(2027, 1, 18, 7, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 26, 5, 16, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP5648 - Premium Economy - Flexible - Aug 11, 2026 05:16 AM", "SP5648: Los Angeles (LAX) → Toronto (YYZ)", new DateTime(2026, 8, 19, 5, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 21, 18, 20, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP2044 - First Class - Flexible - Jan 17, 2026 06:20 PM", "SP2044: Detroit (DTW) → Frankfurt (FRA)", new DateTime(2026, 1, 17, 18, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 3, 17, 11, 0, 0, DateTimeKind.Unspecified), "Southwest Airlines Flight SO1216 - Economy - Main Cabin - Aug 12, 2026 05:11 PM", "SO1216: New York (JFK) → Montevideo (MVD)", new DateTime(2026, 9, 9, 17, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 27, 7, 5, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA7618 - Business Class - Flexible - Jun 10, 2026 07:05 AM", "CA7618: Atlanta (ATL) → Bogotá (BOG)", new DateTime(2026, 6, 30, 7, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 6, 1, 9, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU731 - Business Class - Flexible - Aug 16, 2026 01:09 AM", "SU731: Las Vegas (LAS) → Montevideo (MVD)", new DateTime(2026, 8, 24, 1, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 27, 10, 24, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU9896 - First Class - Refundable - Feb 02, 2026 10:24 AM", "SU9896: Chicago (ORD) → London (LHR)", new DateTime(2026, 3, 1, 10, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 11, 23, 4, 0, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN3215 - First Class - First Class Flexible - Dec 06, 2026 04:00 AM", "UN3215: Los Angeles (LAX) → London (LHR)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 11, 16, 18, 13, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI5752 - First Class - Refundable - Dec 03, 2026 06:13 PM", "SI5752: Charlotte (CLT) → Sydney (SYD)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 16, 18, 16, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE4932 - Premium Economy - Business Saver - Sep 02, 2026 06:16 PM", "DE4932: Atlanta (ATL) → Barcelona (BCN)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 3, 5, 3, 7, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI2708 - Business Class - Flexible - Mar 26, 2026 03:07 AM", "SI2708: San Francisco (SFO) → Mexico City (MEX)", new DateTime(2026, 3, 30, 3, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 24, 5, 48, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE3662 - Economy - First Class Flexible - Jun 27, 2026 05:48 AM", "JE3662: Denver (DEN) → Amsterdam (AMS)", new DateTime(2026, 7, 14, 5, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI7829 - Premium Economy - Refundable - Mar 21, 2026 12:00 AM", "SI7829: Denver (DEN) → Prague (PRG)", new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 6, 10, 16, 32, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU8960 - Business Class - Basic Economy - Jun 15, 2026 04:32 PM", "SU8960: Minneapolis (MSP) → Bangkok (BKK)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 6, 19, 13, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE5934 - First Class - Business Flexible - Apr 11, 2026 07:13 PM", "DE5934: Atlanta (ATL) → Barcelona (BCN)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 30, 23, 8, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA9413 - First Class - Business Saver - Jan 17, 2026 11:08 PM", "CA9413: Philadelphia (PHL) → Hong Kong (HKG)", new DateTime(2026, 1, 31, 23, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 11, 22, 12, 2, 0, 0, DateTimeKind.Unspecified), "Allegiant Air Flight AL1951 - Business Class - Business Flexible - Nov 27, 2026 12:02 PM", "AL1951: New York (JFK) → Lima (LIM)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 9, 9, 22, 56, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA2478 - Premium Economy - Main Cabin - Sep 24, 2026 10:56 PM", "HA2478: Los Angeles (LAX) → Paris (CDG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 8, 9, 13, 45, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE5496 - Premium Economy - Business Flexible - Aug 28, 2026 01:45 PM", "DE5496: Phoenix (PHX) → Lima (LIM)", new DateTime(2026, 9, 13, 13, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 4, 2, 1, 48, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA9533 - Business Class - Basic Economy - Apr 27, 2026 01:48 AM", "CA9533: Boston (BOS) → Bogotá (BOG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 24, 23, 9, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN2560 - Business Class - Business Flexible - May 28, 2026 11:09 PM", "UN2560: Charlotte (CLT) → Prague (PRG)", null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 10, 24, 11, 25, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE7655 - Premium Economy - Basic Economy - Nov 07, 2026 11:25 AM", "DE7655: Dallas/Fort Worth (DFW) → Rio de Janeiro (GIG)", new DateTime(2026, 12, 6, 11, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 7, 23, 3, 5, 0, 0, DateTimeKind.Unspecified), "Southwest Airlines Flight SO5406 - Economy - Business Flexible - Aug 15, 2026 03:05 AM", "SO5406: Las Vegas (LAS) → Amsterdam (AMS)", null });
        }
    }
}
