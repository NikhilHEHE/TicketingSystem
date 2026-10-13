using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TicketingSystem.Migrations
{
    /// <inheritdoc />
    public partial class AirlineSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 3, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU1818 - Business Class - Main Cabin - Apr 06, 2026 05:30 PM", "SU1818: Chicago (ORD) → Dubai (DXB)", null },
                    { 2, new DateTime(2026, 7, 3, 0, 48, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE5813 - Premium Economy - Main Cabin - Jul 08, 2026 12:48 AM", "JE5813: Las Vegas (LAS) → Frankfurt (FRA)", null },
                    { 3, new DateTime(2026, 9, 11, 3, 54, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM6955 - Business Class - Basic Economy - Sep 17, 2026 03:54 AM", "AM6955: Miami (MIA) → São Paulo (GRU)", null },
                    { 4, new DateTime(2026, 7, 13, 19, 44, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE3906 - First Class - Basic Economy - Jul 15, 2026 07:44 PM", "DE3906: Dallas/Fort Worth (DFW) → Bangkok (BKK)", new DateTime(2026, 7, 15, 19, 44, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2026, 4, 1, 15, 8, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI540 - Economy - Business Flexible - Apr 16, 2026 03:08 PM", "SI540: Charlotte (CLT) → Dubai (DXB)", null },
                    { 6, new DateTime(2026, 1, 2, 8, 16, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE779 - Business Class - Main Cabin - Jan 05, 2026 08:16 AM", "DE779: San Francisco (SFO) → Shanghai (PVG)", null },
                    { 7, new DateTime(2026, 6, 13, 0, 49, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR227 - Premium Economy - Refundable - Jul 02, 2026 12:49 AM", "FR227: New York (JFK) → São Paulo (GRU)", new DateTime(2026, 7, 3, 0, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2026, 7, 22, 1, 22, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE1504 - Premium Economy - Flexible - Aug 14, 2026 01:22 AM", "DE1504: Detroit (DTW) → Santiago (SCL)", null },
                    { 9, new DateTime(2026, 9, 5, 0, 52, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA9580 - First Class - Business Saver - Sep 26, 2026 12:52 AM", "HA9580: San Francisco (SFO) → Frankfurt (FRA)", null },
                    { 10, new DateTime(2026, 1, 26, 3, 12, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN5956 - Premium Economy - Business Flexible - Feb 24, 2026 03:12 AM", "UN5956: Los Angeles (LAX) → Barcelona (BCN)", null },
                    { 11, new DateTime(2026, 12, 27, 15, 1, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI3519 - Premium Economy - Refundable - Dec 28, 2026 03:01 PM", "SI3519: Charlotte (CLT) → Beijing (PEK)", null },
                    { 12, new DateTime(2026, 5, 25, 2, 59, 0, 0, DateTimeKind.Unspecified), "Southwest Airlines Flight SO1301 - Economy - Business Saver - Jun 04, 2026 02:59 AM", "SO1301: Dallas/Fort Worth (DFW) → Paris (CDG)", new DateTime(2026, 6, 13, 2, 59, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2026, 11, 5, 5, 55, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI8467 - Economy - Business Flexible - Nov 24, 2026 05:55 AM", "SI8467: Minneapolis (MSP) → London (LHR)", new DateTime(2026, 12, 10, 5, 55, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2026, 3, 20, 22, 59, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU7837 - Economy - Basic Economy - Mar 26, 2026 10:59 PM", "SU7837: Atlanta (ATL) → Frankfurt (FRA)", new DateTime(2026, 4, 21, 22, 59, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2026, 7, 10, 9, 52, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE4504 - Business Class - Basic Economy - Aug 07, 2026 09:52 AM", "JE4504: Las Vegas (LAS) → Prague (PRG)", null },
                    { 16, new DateTime(2026, 1, 28, 0, 10, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR9408 - First Class - Basic Economy - Feb 09, 2026 12:10 AM", "FR9408: Las Vegas (LAS) → Santiago (SCL)", null },
                    { 17, new DateTime(2026, 10, 25, 4, 20, 0, 0, DateTimeKind.Unspecified), "Allegiant Air Flight AL5467 - First Class - First Class Flexible - Nov 22, 2026 04:20 AM", "AL5467: San Francisco (SFO) → Dubai (DXB)", null },
                    { 18, new DateTime(2026, 10, 14, 5, 53, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA6677 - Premium Economy - Refundable - Oct 21, 2026 05:53 AM", "CA6677: Miami (MIA) → Cancun (CUN)", new DateTime(2026, 10, 29, 5, 53, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2026, 10, 23, 18, 57, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA9435 - Premium Economy - Business Flexible - Nov 18, 2026 06:57 PM", "CA9435: Charlotte (CLT) → Tokyo (NRT)", null },
                    { 20, new DateTime(2026, 6, 16, 16, 6, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI8078 - Economy - Business Saver - Jul 02, 2026 04:06 PM", "VI8078: Chicago (ORD) → Bangkok (BKK)", null },
                    { 21, new DateTime(2026, 3, 9, 22, 3, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO651 - First Class - Business Saver - Mar 14, 2026 10:03 PM", "BO651: Atlanta (ATL) → Vienna (VIE)", new DateTime(2026, 3, 23, 22, 3, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2026, 5, 21, 18, 39, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE9992 - Premium Economy - Flexible - Jun 15, 2026 06:39 PM", "JE9992: Dallas/Fort Worth (DFW) → Lima (LIM)", null },
                    { 23, new DateTime(2026, 5, 12, 22, 4, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE4763 - Business Class - Business Saver - May 22, 2026 10:04 PM", "JE4763: Chicago (ORD) → Santiago (SCL)", null },
                    { 24, new DateTime(2026, 7, 11, 0, 53, 0, 0, DateTimeKind.Unspecified), "Essential Air Flight ES4167 - Economy - Flexible - Jul 31, 2026 12:53 AM", "ES4167: Detroit (DTW) → Lima (LIM)", null },
                    { 25, new DateTime(2026, 4, 24, 15, 2, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI6883 - First Class - Basic Economy - May 05, 2026 03:02 PM", "VI6883: Dallas/Fort Worth (DFW) → Santiago (SCL)", null },
                    { 26, new DateTime(2026, 4, 19, 15, 5, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL1445 - Business Class - Business Saver - Apr 28, 2026 03:05 PM", "AL1445: Atlanta (ATL) → Bangkok (BKK)", null },
                    { 27, new DateTime(2026, 2, 20, 4, 38, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI1174 - Business Class - Flexible - Feb 26, 2026 04:38 AM", "VI1174: Denver (DEN) → London (LHR)", null },
                    { 28, new DateTime(2026, 4, 24, 14, 25, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU4342 - Business Class - First Class Flexible - May 11, 2026 02:25 PM", "SU4342: Atlanta (ATL) → Singapore (SIN)", new DateTime(2026, 6, 3, 14, 25, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2026, 8, 22, 5, 18, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA5449 - Business Class - First Class Flexible - Sep 12, 2026 05:18 AM", "HA5449: Charlotte (CLT) → Rome (FCO)", null },
                    { 30, new DateTime(2026, 6, 28, 20, 2, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL4191 - Premium Economy - First Class Flexible - Jul 03, 2026 08:02 PM", "AL4191: Phoenix (PHX) → Rio de Janeiro (GIG)", null },
                    { 31, new DateTime(2026, 3, 30, 11, 42, 0, 0, DateTimeKind.Unspecified), "Allegiant Air Flight AL4198 - First Class - Refundable - Apr 23, 2026 11:42 AM", "AL4198: San Francisco (SFO) → London (LHR)", new DateTime(2026, 4, 28, 11, 42, 0, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2026, 11, 27, 21, 38, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR6433 - Business Class - Main Cabin - Dec 12, 2026 09:38 PM", "FR6433: Detroit (DTW) → Santiago (SCL)", null },
                    { 33, new DateTime(2026, 11, 28, 13, 9, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL3833 - First Class - Business Saver - Dec 02, 2026 01:09 PM", "AL3833: Los Angeles (LAX) → Dubai (DXB)", new DateTime(2026, 12, 13, 13, 9, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2026, 10, 20, 19, 23, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE6022 - Economy - First Class Flexible - Oct 29, 2026 07:23 PM", "DE6022: Charlotte (CLT) → London (LHR)", new DateTime(2026, 11, 21, 19, 23, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2026, 6, 23, 18, 31, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA7226 - Business Class - Basic Economy - Jul 13, 2026 06:31 PM", "HA7226: New York (JFK) → London (LHR)", null },
                    { 36, new DateTime(2026, 10, 8, 22, 48, 0, 0, DateTimeKind.Unspecified), "Essential Air Flight ES6660 - First Class - Business Flexible - Nov 05, 2026 10:48 PM", "ES6660: Denver (DEN) → Rome (FCO)", new DateTime(2026, 11, 28, 22, 48, 0, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2026, 10, 14, 10, 54, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA2037 - First Class - Business Flexible - Oct 25, 2026 10:54 AM", "CA2037: Chicago (ORD) → Shanghai (PVG)", new DateTime(2026, 11, 18, 10, 54, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2026, 5, 3, 20, 23, 0, 0, DateTimeKind.Unspecified), "Allegiant Air Flight AL1127 - Economy - Business Flexible - May 07, 2026 08:23 PM", "AL1127: Detroit (DTW) → Bogotá (BOG)", null },
                    { 39, new DateTime(2026, 8, 24, 7, 7, 0, 0, DateTimeKind.Unspecified), "Essential Air Flight ES2072 - Economy - Refundable - Aug 28, 2026 07:07 AM", "ES2072: Las Vegas (LAS) → Montevideo (MVD)", null },
                    { 40, new DateTime(2026, 9, 1, 6, 59, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN4866 - Business Class - First Class Flexible - Sep 17, 2026 06:59 AM", "UN4866: Seattle (SEA) → Madrid (MAD)", null },
                    { 41, new DateTime(2026, 11, 23, 7, 14, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE4140 - First Class - First Class Flexible - Dec 19, 2026 07:14 AM", "DE4140: Dallas/Fort Worth (DFW) → Lima (LIM)", null },
                    { 42, new DateTime(2026, 11, 3, 6, 52, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE1498 - First Class - Business Flexible - Nov 21, 2026 06:52 AM", "DE1498: Minneapolis (MSP) → Barcelona (BCN)", null },
                    { 43, new DateTime(2026, 4, 29, 3, 6, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR1182 - Business Class - Main Cabin - May 14, 2026 03:06 AM", "FR1182: Boston (BOS) → Barcelona (BCN)", null },
                    { 44, new DateTime(2026, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL9603 - Economy - Business Saver - Oct 10, 2026 08:48 AM", "AL9603: Seattle (SEA) → Shanghai (PVG)", null },
                    { 45, new DateTime(2026, 11, 8, 9, 44, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE6072 - Economy - Basic Economy - Dec 05, 2026 09:44 AM", "JE6072: San Francisco (SFO) → Prague (PRG)", null },
                    { 46, new DateTime(2026, 8, 26, 22, 5, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP3016 - Premium Economy - Main Cabin - Sep 06, 2026 10:05 PM", "SP3016: Minneapolis (MSP) → Dubai (DXB)", null },
                    { 47, new DateTime(2026, 3, 29, 11, 31, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA3334 - Economy - Business Saver - Apr 06, 2026 11:31 AM", "HA3334: Seattle (SEA) → Montevideo (MVD)", null },
                    { 48, new DateTime(2026, 3, 21, 5, 43, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN3713 - Economy - Main Cabin - Mar 23, 2026 05:43 AM", "UN3713: Seattle (SEA) → Paris (CDG)", null },
                    { 49, new DateTime(2026, 7, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR8624 - Economy - Main Cabin - Jul 28, 2026 04:51 PM", "FR8624: New York (JFK) → Lima (LIM)", new DateTime(2026, 8, 13, 16, 51, 0, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(2026, 1, 27, 6, 4, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA1594 - First Class - Flexible - Feb 15, 2026 06:04 AM", "CA1594: Los Angeles (LAX) → Dubai (DXB)", new DateTime(2026, 2, 19, 6, 4, 0, 0, DateTimeKind.Unspecified) },
                    { 51, new DateTime(2026, 11, 18, 13, 21, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU4923 - Business Class - Business Flexible - Nov 20, 2026 01:21 PM", "SU4923: San Francisco (SFO) → Tokyo (NRT)", null },
                    { 52, new DateTime(2026, 10, 22, 11, 48, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI2391 - Economy - First Class Flexible - Nov 08, 2026 11:48 AM", "VI2391: Dallas/Fort Worth (DFW) → Bangkok (BKK)", null },
                    { 53, new DateTime(2026, 8, 2, 2, 48, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN8853 - Economy - First Class Flexible - Aug 09, 2026 02:48 AM", "UN8853: New York (JFK) → Paris (CDG)", new DateTime(2026, 9, 4, 2, 48, 0, 0, DateTimeKind.Unspecified) },
                    { 54, new DateTime(2026, 12, 21, 11, 12, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP4214 - Economy - Main Cabin - Dec 23, 2026 11:12 AM", "SP4214: Miami (MIA) → Zurich (ZRH)", null },
                    { 55, new DateTime(2026, 3, 16, 16, 26, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN9240 - Economy - Flexible - Mar 24, 2026 04:26 PM", "UN9240: Miami (MIA) → Shanghai (PVG)", new DateTime(2026, 3, 25, 16, 26, 0, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(2026, 4, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE8447 - First Class - First Class Flexible - Apr 06, 2026 04:37 PM", "DE8447: Seattle (SEA) → Zurich (ZRH)", new DateTime(2026, 4, 8, 16, 37, 0, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(2026, 9, 17, 9, 9, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP8173 - Premium Economy - Business Flexible - Oct 03, 2026 09:09 AM", "SP8173: San Francisco (SFO) → Shanghai (PVG)", new DateTime(2026, 10, 29, 9, 9, 0, 0, DateTimeKind.Unspecified) },
                    { 58, new DateTime(2026, 9, 15, 23, 10, 0, 0, DateTimeKind.Unspecified), "Southwest Airlines Flight SO3760 - Business Class - Main Cabin - Sep 29, 2026 11:10 PM", "SO3760: Phoenix (PHX) → Beijing (PEK)", null },
                    { 59, new DateTime(2026, 9, 12, 17, 11, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO1229 - Business Class - First Class Flexible - Sep 28, 2026 05:11 PM", "BO1229: Charlotte (CLT) → London (LHR)", null },
                    { 60, new DateTime(2026, 2, 3, 15, 52, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU4420 - Premium Economy - Business Saver - Mar 03, 2026 03:52 PM", "SU4420: Philadelphia (PHL) → Vienna (VIE)", new DateTime(2026, 3, 20, 15, 52, 0, 0, DateTimeKind.Unspecified) },
                    { 61, new DateTime(2026, 1, 9, 2, 54, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI8037 - Economy - Flexible - Feb 06, 2026 02:54 AM", "SI8037: San Francisco (SFO) → Vienna (VIE)", null },
                    { 62, new DateTime(2026, 5, 16, 1, 48, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI7585 - Economy - Refundable - Jun 05, 2026 01:48 AM", "VI7585: Charlotte (CLT) → São Paulo (GRU)", null },
                    { 63, new DateTime(2026, 10, 13, 12, 29, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI464 - First Class - Basic Economy - Oct 17, 2026 12:29 PM", "VI464: Boston (BOS) → Paris (CDG)", null },
                    { 64, new DateTime(2026, 4, 3, 2, 0, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO7172 - Premium Economy - Business Saver - Apr 24, 2026 02:00 AM", "BO7172: Atlanta (ATL) → Dubai (DXB)", null },
                    { 65, new DateTime(2026, 3, 5, 10, 21, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI2253 - First Class - First Class Flexible - Mar 06, 2026 10:21 AM", "VI2253: Las Vegas (LAS) → Shanghai (PVG)", null },
                    { 66, new DateTime(2026, 12, 8, 7, 21, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM3188 - Economy - Business Saver - Dec 24, 2026 07:21 AM", "AM3188: San Francisco (SFO) → Rio de Janeiro (GIG)", null },
                    { 67, new DateTime(2026, 10, 2, 18, 42, 0, 0, DateTimeKind.Unspecified), "Essential Air Flight ES7479 - Economy - Basic Economy - Oct 09, 2026 06:42 PM", "ES7479: Philadelphia (PHL) → Prague (PRG)", new DateTime(2026, 11, 5, 18, 42, 0, 0, DateTimeKind.Unspecified) },
                    { 68, new DateTime(2026, 5, 9, 0, 40, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI2216 - Premium Economy - First Class Flexible - May 14, 2026 12:40 AM", "SI2216: Las Vegas (LAS) → Dubai (DXB)", new DateTime(2026, 6, 3, 0, 40, 0, 0, DateTimeKind.Unspecified) },
                    { 69, new DateTime(2026, 8, 24, 8, 25, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO8510 - Business Class - Basic Economy - Sep 13, 2026 08:25 AM", "BO8510: Charlotte (CLT) → Singapore (SIN)", null },
                    { 70, new DateTime(2026, 7, 7, 12, 5, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO8311 - Economy - Business Saver - Aug 05, 2026 12:05 PM", "BO8311: Atlanta (ATL) → Buenos Aires (EZE)", new DateTime(2026, 8, 10, 12, 5, 0, 0, DateTimeKind.Unspecified) },
                    { 71, new DateTime(2026, 3, 31, 4, 18, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA6076 - Premium Economy - First Class Flexible - Apr 12, 2026 04:18 AM", "HA6076: Seattle (SEA) → Hong Kong (HKG)", new DateTime(2026, 4, 24, 4, 18, 0, 0, DateTimeKind.Unspecified) },
                    { 72, new DateTime(2026, 10, 28, 12, 23, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP3170 - Business Class - Basic Economy - Nov 08, 2026 12:23 PM", "SP3170: Chicago (ORD) → Paris (CDG)", null },
                    { 73, new DateTime(2026, 8, 26, 4, 50, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM9958 - Premium Economy - Basic Economy - Sep 16, 2026 04:50 AM", "AM9958: New York (JFK) → Mexico City (MEX)", null },
                    { 74, new DateTime(2026, 1, 29, 15, 9, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM710 - Premium Economy - Flexible - Feb 23, 2026 03:09 PM", "AM710: Atlanta (ATL) → Barcelona (BCN)", null },
                    { 75, new DateTime(2025, 12, 27, 23, 39, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP8024 - Business Class - First Class Flexible - Jan 16, 2026 11:39 PM", "SP8024: Boston (BOS) → Vienna (VIE)", null },
                    { 76, new DateTime(2026, 1, 16, 14, 25, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN4555 - First Class - First Class Flexible - Feb 10, 2026 02:25 PM", "UN4555: Phoenix (PHX) → Rome (FCO)", null },
                    { 77, new DateTime(2026, 6, 4, 8, 43, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU1570 - Economy - Business Flexible - Jul 01, 2026 08:43 AM", "SU1570: Los Angeles (LAX) → Lima (LIM)", null },
                    { 78, new DateTime(2026, 10, 15, 3, 51, 0, 0, DateTimeKind.Unspecified), "Southwest Airlines Flight SO3509 - First Class - Refundable - Oct 17, 2026 03:51 AM", "SO3509: Phoenix (PHX) → Zurich (ZRH)", null },
                    { 79, new DateTime(2026, 3, 6, 13, 33, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP6478 - First Class - Business Saver - Mar 23, 2026 01:33 PM", "SP6478: Los Angeles (LAX) → Buenos Aires (EZE)", new DateTime(2026, 4, 4, 13, 33, 0, 0, DateTimeKind.Unspecified) },
                    { 80, new DateTime(2026, 6, 17, 6, 4, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM5155 - First Class - Main Cabin - Jun 24, 2026 06:04 AM", "AM5155: Seattle (SEA) → Hong Kong (HKG)", null },
                    { 81, new DateTime(2026, 10, 3, 6, 35, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL819 - Economy - Refundable - Oct 23, 2026 06:35 AM", "AL819: Boston (BOS) → Frankfurt (FRA)", new DateTime(2026, 11, 11, 6, 35, 0, 0, DateTimeKind.Unspecified) },
                    { 82, new DateTime(2026, 3, 9, 14, 8, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI8926 - First Class - Basic Economy - Mar 10, 2026 02:08 PM", "SI8926: Dallas/Fort Worth (DFW) → Santiago (SCL)", null },
                    { 83, new DateTime(2026, 4, 26, 1, 39, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP5298 - Economy - First Class Flexible - May 21, 2026 01:39 AM", "SP5298: Denver (DEN) → Lima (LIM)", null },
                    { 84, new DateTime(2026, 9, 18, 8, 25, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR3444 - Economy - First Class Flexible - Oct 01, 2026 08:25 AM", "FR3444: New York (JFK) → Frankfurt (FRA)", null },
                    { 85, new DateTime(2026, 2, 10, 21, 55, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI7685 - Premium Economy - Refundable - Feb 26, 2026 09:55 PM", "SI7685: Detroit (DTW) → Zurich (ZRH)", null },
                    { 86, new DateTime(2026, 4, 22, 4, 1, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI4604 - Business Class - Business Flexible - May 20, 2026 04:01 AM", "SI4604: Detroit (DTW) → Beijing (PEK)", new DateTime(2026, 5, 24, 4, 1, 0, 0, DateTimeKind.Unspecified) },
                    { 87, new DateTime(2026, 10, 6, 18, 28, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA4985 - Economy - Main Cabin - Nov 04, 2026 06:28 PM", "CA4985: Detroit (DTW) → Singapore (SIN)", null },
                    { 88, new DateTime(2026, 10, 28, 18, 36, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA7394 - Business Class - Business Flexible - Nov 25, 2026 06:36 PM", "HA7394: New York (JFK) → Prague (PRG)", null },
                    { 89, new DateTime(2026, 12, 9, 5, 19, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE207 - Premium Economy - First Class Flexible - Dec 28, 2026 05:19 AM", "JE207: San Francisco (SFO) → Madrid (MAD)", null },
                    { 90, new DateTime(2026, 8, 9, 1, 0, 0, 0, DateTimeKind.Unspecified), "Essential Air Flight ES8749 - First Class - Basic Economy - Sep 06, 2026 01:00 AM", "ES8749: Charlotte (CLT) → Barcelona (BCN)", new DateTime(2026, 9, 12, 1, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, new DateTime(2026, 1, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN4233 - First Class - Flexible - Feb 14, 2026 04:30 PM", "UN4233: Charlotte (CLT) → Mexico City (MEX)", null },
                    { 92, new DateTime(2026, 9, 14, 6, 10, 0, 0, DateTimeKind.Unspecified), "Allegiant Air Flight AL5522 - First Class - First Class Flexible - Oct 11, 2026 06:10 AM", "AL5522: Atlanta (ATL) → Singapore (SIN)", null },
                    { 93, new DateTime(2026, 2, 3, 12, 44, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM6220 - First Class - Business Flexible - Feb 06, 2026 12:44 PM", "AM6220: Detroit (DTW) → Sydney (SYD)", null },
                    { 94, new DateTime(2026, 10, 8, 4, 20, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR7957 - Business Class - Main Cabin - Nov 01, 2026 04:20 AM", "FR7957: Atlanta (ATL) → Hong Kong (HKG)", new DateTime(2026, 11, 15, 4, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 95, new DateTime(2026, 3, 5, 14, 51, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA6650 - First Class - Main Cabin - Mar 23, 2026 02:51 PM", "CA6650: Miami (MIA) → Vienna (VIE)", new DateTime(2026, 3, 31, 14, 51, 0, 0, DateTimeKind.Unspecified) },
                    { 96, new DateTime(2026, 12, 5, 16, 50, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL9291 - Premium Economy - Business Saver - Dec 28, 2026 04:50 PM", "AL9291: Charlotte (CLT) → Vienna (VIE)", null },
                    { 97, new DateTime(2026, 12, 19, 5, 51, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP6730 - Business Class - Flexible - Dec 23, 2026 05:51 AM", "SP6730: Atlanta (ATL) → Dubai (DXB)", null },
                    { 98, new DateTime(2026, 7, 5, 23, 3, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE4264 - Premium Economy - Flexible - Jul 07, 2026 11:03 PM", "JE4264: Chicago (ORD) → Mexico City (MEX)", new DateTime(2026, 8, 3, 23, 3, 0, 0, DateTimeKind.Unspecified) },
                    { 99, new DateTime(2026, 9, 23, 13, 37, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP8720 - First Class - Business Flexible - Oct 21, 2026 01:37 PM", "SP8720: Las Vegas (LAS) → Frankfurt (FRA)", null },
                    { 100, new DateTime(2026, 11, 12, 10, 24, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM6122 - Business Class - Main Cabin - Nov 18, 2026 10:24 AM", "AM6122: Las Vegas (LAS) → Tokyo (NRT)", null },
                    { 101, new DateTime(2026, 2, 16, 20, 51, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL939 - Premium Economy - Business Saver - Mar 03, 2026 08:51 PM", "AL939: Denver (DEN) → Dubai (DXB)", null },
                    { 102, new DateTime(2026, 6, 8, 1, 6, 0, 0, DateTimeKind.Unspecified), "Southwest Airlines Flight SO9820 - Economy - Main Cabin - Jun 14, 2026 01:06 AM", "SO9820: Miami (MIA) → Paris (CDG)", new DateTime(2026, 7, 13, 1, 6, 0, 0, DateTimeKind.Unspecified) },
                    { 103, new DateTime(2026, 3, 3, 23, 46, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN3255 - First Class - Business Flexible - Mar 09, 2026 11:46 PM", "UN3255: Boston (BOS) → Mexico City (MEX)", new DateTime(2026, 3, 15, 23, 46, 0, 0, DateTimeKind.Unspecified) },
                    { 104, new DateTime(2026, 9, 30, 0, 15, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI3876 - Economy - Flexible - Oct 11, 2026 12:15 AM", "VI3876: Miami (MIA) → Zurich (ZRH)", null },
                    { 105, new DateTime(2026, 5, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP9684 - Business Class - Basic Economy - May 10, 2026 11:00 AM", "SP9684: Phoenix (PHX) → Tokyo (NRT)", null },
                    { 106, new DateTime(2026, 8, 11, 2, 48, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI1813 - Premium Economy - Basic Economy - Sep 05, 2026 02:48 AM", "VI1813: Las Vegas (LAS) → Rome (FCO)", new DateTime(2026, 9, 19, 2, 48, 0, 0, DateTimeKind.Unspecified) },
                    { 107, new DateTime(2026, 3, 5, 5, 43, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN8097 - First Class - Business Flexible - Mar 17, 2026 05:43 AM", "UN8097: San Francisco (SFO) → Santiago (SCL)", null },
                    { 108, new DateTime(2026, 5, 10, 19, 3, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA2651 - Premium Economy - First Class Flexible - Jun 02, 2026 07:03 PM", "CA2651: Dallas/Fort Worth (DFW) → Shanghai (PVG)", null },
                    { 109, new DateTime(2026, 4, 9, 3, 34, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO4399 - Economy - Business Flexible - May 01, 2026 03:34 AM", "BO4399: Philadelphia (PHL) → Shanghai (PVG)", new DateTime(2026, 5, 28, 3, 34, 0, 0, DateTimeKind.Unspecified) },
                    { 110, new DateTime(2026, 10, 16, 17, 38, 0, 0, DateTimeKind.Unspecified), "ViaAir Flight VI3776 - Premium Economy - Business Flexible - Oct 20, 2026 05:38 PM", "VI3776: Dallas/Fort Worth (DFW) → Paris (CDG)", null },
                    { 111, new DateTime(2026, 5, 10, 8, 4, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA2213 - Economy - Main Cabin - May 22, 2026 08:04 AM", "HA2213: New York (JFK) → Madrid (MAD)", null },
                    { 112, new DateTime(2026, 11, 9, 13, 13, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO1057 - Business Class - Refundable - Nov 25, 2026 01:13 PM", "BO1057: Philadelphia (PHL) → Mexico City (MEX)", new DateTime(2026, 12, 23, 13, 13, 0, 0, DateTimeKind.Unspecified) },
                    { 113, new DateTime(2026, 3, 28, 12, 11, 0, 0, DateTimeKind.Unspecified), "Boutique Air Flight BO4033 - First Class - Basic Economy - Apr 02, 2026 12:11 PM", "BO4033: Chicago (ORD) → Santiago (SCL)", new DateTime(2026, 4, 27, 12, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 114, new DateTime(2026, 1, 16, 3, 41, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM7602 - First Class - Main Cabin - Feb 02, 2026 03:41 AM", "AM7602: Denver (DEN) → Tokyo (NRT)", null },
                    { 115, new DateTime(2026, 1, 10, 3, 21, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE9711 - Premium Economy - Business Flexible - Jan 25, 2026 03:21 AM", "DE9711: Atlanta (ATL) → Dubai (DXB)", null },
                    { 116, new DateTime(2026, 10, 24, 16, 48, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU9865 - Premium Economy - Main Cabin - Oct 29, 2026 04:48 PM", "SU9865: Los Angeles (LAX) → Toronto (YYZ)", null },
                    { 117, new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM2713 - First Class - Business Saver - Jan 15, 2026 12:00 AM", "AM2713: Las Vegas (LAS) → Sydney (SYD)", null },
                    { 118, new DateTime(2026, 8, 20, 2, 15, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA9013 - First Class - First Class Flexible - Sep 05, 2026 02:15 AM", "HA9013: Detroit (DTW) → Rio de Janeiro (GIG)", null },
                    { 119, new DateTime(2026, 10, 18, 7, 59, 0, 0, DateTimeKind.Unspecified), "Allegiant Air Flight AL9479 - First Class - Business Flexible - Oct 22, 2026 07:59 AM", "AL9479: Charlotte (CLT) → London (LHR)", null },
                    { 120, new DateTime(2026, 6, 4, 2, 21, 0, 0, DateTimeKind.Unspecified), "Essential Air Flight ES9650 - Economy - Basic Economy - Jun 25, 2026 02:21 AM", "ES9650: Chicago (ORD) → Bangkok (BKK)", null },
                    { 121, new DateTime(2026, 11, 11, 0, 41, 0, 0, DateTimeKind.Unspecified), "Frontier Airlines Flight FR7322 - Business Class - Flexible - Nov 20, 2026 12:41 AM", "FR7322: Las Vegas (LAS) → Amsterdam (AMS)", null },
                    { 122, new DateTime(2026, 3, 14, 4, 40, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA2723 - First Class - Business Flexible - Mar 31, 2026 04:40 AM", "HA2723: Philadelphia (PHL) → Zurich (ZRH)", null },
                    { 123, new DateTime(2026, 8, 17, 15, 9, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP5528 - Premium Economy - Business Flexible - Aug 23, 2026 03:09 PM", "SP5528: Philadelphia (PHL) → Hong Kong (HKG)", null },
                    { 124, new DateTime(2026, 6, 3, 10, 58, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA2668 - Premium Economy - Main Cabin - Jun 20, 2026 10:58 AM", "CA2668: Atlanta (ATL) → Zurich (ZRH)", null },
                    { 125, new DateTime(2026, 8, 7, 20, 9, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU2915 - Business Class - Main Cabin - Sep 03, 2026 08:09 PM", "SU2915: Phoenix (PHX) → Singapore (SIN)", new DateTime(2026, 9, 30, 20, 9, 0, 0, DateTimeKind.Unspecified) },
                    { 126, new DateTime(2026, 5, 7, 1, 34, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM183 - First Class - Basic Economy - May 17, 2026 01:34 AM", "AM183: Denver (DEN) → Montevideo (MVD)", null },
                    { 127, new DateTime(2026, 8, 30, 5, 16, 0, 0, DateTimeKind.Unspecified), "American Airlines Flight AM5625 - Premium Economy - Basic Economy - Sep 25, 2026 05:16 AM", "AM5625: Dallas/Fort Worth (DFW) → Frankfurt (FRA)", null },
                    { 128, new DateTime(2026, 12, 12, 7, 23, 0, 0, DateTimeKind.Unspecified), "Alaska Airlines Flight AL6250 - Economy - Flexible - Dec 20, 2026 07:23 AM", "AL6250: New York (JFK) → Beijing (PEK)", new DateTime(2027, 1, 18, 7, 23, 0, 0, DateTimeKind.Unspecified) },
                    { 129, new DateTime(2026, 7, 26, 5, 16, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP5648 - Premium Economy - Flexible - Aug 11, 2026 05:16 AM", "SP5648: Los Angeles (LAX) → Toronto (YYZ)", new DateTime(2026, 8, 19, 5, 16, 0, 0, DateTimeKind.Unspecified) },
                    { 130, new DateTime(2025, 12, 21, 18, 20, 0, 0, DateTimeKind.Unspecified), "Spirit Airlines Flight SP2044 - First Class - Flexible - Jan 17, 2026 06:20 PM", "SP2044: Detroit (DTW) → Frankfurt (FRA)", new DateTime(2026, 1, 17, 18, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 131, new DateTime(2026, 8, 3, 17, 11, 0, 0, DateTimeKind.Unspecified), "Southwest Airlines Flight SO1216 - Economy - Main Cabin - Aug 12, 2026 05:11 PM", "SO1216: New York (JFK) → Montevideo (MVD)", new DateTime(2026, 9, 9, 17, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 132, new DateTime(2026, 5, 27, 7, 5, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA7618 - Business Class - Flexible - Jun 10, 2026 07:05 AM", "CA7618: Atlanta (ATL) → Bogotá (BOG)", new DateTime(2026, 6, 30, 7, 5, 0, 0, DateTimeKind.Unspecified) },
                    { 133, new DateTime(2026, 8, 6, 1, 9, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU731 - Business Class - Flexible - Aug 16, 2026 01:09 AM", "SU731: Las Vegas (LAS) → Montevideo (MVD)", new DateTime(2026, 8, 24, 1, 9, 0, 0, DateTimeKind.Unspecified) },
                    { 134, new DateTime(2026, 1, 27, 10, 24, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU9896 - First Class - Refundable - Feb 02, 2026 10:24 AM", "SU9896: Chicago (ORD) → London (LHR)", new DateTime(2026, 3, 1, 10, 24, 0, 0, DateTimeKind.Unspecified) },
                    { 135, new DateTime(2026, 11, 23, 4, 0, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN3215 - First Class - First Class Flexible - Dec 06, 2026 04:00 AM", "UN3215: Los Angeles (LAX) → London (LHR)", null },
                    { 136, new DateTime(2026, 11, 16, 18, 13, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI5752 - First Class - Refundable - Dec 03, 2026 06:13 PM", "SI5752: Charlotte (CLT) → Sydney (SYD)", null },
                    { 137, new DateTime(2026, 8, 16, 18, 16, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE4932 - Premium Economy - Business Saver - Sep 02, 2026 06:16 PM", "DE4932: Atlanta (ATL) → Barcelona (BCN)", null },
                    { 138, new DateTime(2026, 3, 5, 3, 7, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI2708 - Business Class - Flexible - Mar 26, 2026 03:07 AM", "SI2708: San Francisco (SFO) → Mexico City (MEX)", new DateTime(2026, 3, 30, 3, 7, 0, 0, DateTimeKind.Unspecified) },
                    { 139, new DateTime(2026, 6, 24, 5, 48, 0, 0, DateTimeKind.Unspecified), "JetBlue Airways Flight JE3662 - Economy - First Class Flexible - Jun 27, 2026 05:48 AM", "JE3662: Denver (DEN) → Amsterdam (AMS)", new DateTime(2026, 7, 14, 5, 48, 0, 0, DateTimeKind.Unspecified) },
                    { 140, new DateTime(2026, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silver Airways Flight SI7829 - Premium Economy - Refundable - Mar 21, 2026 12:00 AM", "SI7829: Denver (DEN) → Prague (PRG)", new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 141, new DateTime(2026, 6, 10, 16, 32, 0, 0, DateTimeKind.Unspecified), "Sun Country Airlines Flight SU8960 - Business Class - Basic Economy - Jun 15, 2026 04:32 PM", "SU8960: Minneapolis (MSP) → Bangkok (BKK)", null },
                    { 142, new DateTime(2026, 4, 6, 19, 13, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE5934 - First Class - Business Flexible - Apr 11, 2026 07:13 PM", "DE5934: Atlanta (ATL) → Barcelona (BCN)", null },
                    { 143, new DateTime(2025, 12, 30, 23, 8, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA9413 - First Class - Business Saver - Jan 17, 2026 11:08 PM", "CA9413: Philadelphia (PHL) → Hong Kong (HKG)", new DateTime(2026, 1, 31, 23, 8, 0, 0, DateTimeKind.Unspecified) },
                    { 144, new DateTime(2026, 11, 22, 12, 2, 0, 0, DateTimeKind.Unspecified), "Allegiant Air Flight AL1951 - Business Class - Business Flexible - Nov 27, 2026 12:02 PM", "AL1951: New York (JFK) → Lima (LIM)", null },
                    { 145, new DateTime(2026, 9, 9, 22, 56, 0, 0, DateTimeKind.Unspecified), "Hawaiian Airlines Flight HA2478 - Premium Economy - Main Cabin - Sep 24, 2026 10:56 PM", "HA2478: Los Angeles (LAX) → Paris (CDG)", null },
                    { 146, new DateTime(2026, 8, 9, 13, 45, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE5496 - Premium Economy - Business Flexible - Aug 28, 2026 01:45 PM", "DE5496: Phoenix (PHX) → Lima (LIM)", new DateTime(2026, 9, 13, 13, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 147, new DateTime(2026, 4, 2, 1, 48, 0, 0, DateTimeKind.Unspecified), "Cape Air Flight CA9533 - Business Class - Basic Economy - Apr 27, 2026 01:48 AM", "CA9533: Boston (BOS) → Bogotá (BOG)", null },
                    { 148, new DateTime(2026, 5, 24, 23, 9, 0, 0, DateTimeKind.Unspecified), "United Airlines Flight UN2560 - Business Class - Business Flexible - May 28, 2026 11:09 PM", "UN2560: Charlotte (CLT) → Prague (PRG)", null },
                    { 149, new DateTime(2026, 10, 24, 11, 25, 0, 0, DateTimeKind.Unspecified), "Delta Air Lines Flight DE7655 - Premium Economy - Basic Economy - Nov 07, 2026 11:25 AM", "DE7655: Dallas/Fort Worth (DFW) → Rio de Janeiro (GIG)", new DateTime(2026, 12, 6, 11, 25, 0, 0, DateTimeKind.Unspecified) },
                    { 150, new DateTime(2026, 7, 23, 3, 5, 0, 0, DateTimeKind.Unspecified), "Southwest Airlines Flight SO5406 - Economy - Business Flexible - Aug 15, 2026 03:05 AM", "SO5406: Las Vegas (LAS) → Amsterdam (AMS)", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 150);
        }
    }
}
