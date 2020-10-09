using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProfileApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedTs = table.Column<DateTime>(nullable: false),
                    UpdatedTs = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Phonenumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Favorite = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 697, "1379 Zulauf Well", new DateTime(1973, 7, 1, 4, 23, 31, 36, DateTimeKind.Utc).AddTicks(2400), "Walkerborough", "Wales", new DateTime(2016, 12, 19, 19, 43, 25, 36, DateTimeKind.Utc).AddTicks(7040), "hilton_reichel@troy.net", false, "Ashly O'Hara", "1-8106-122-6925", "https://randomuser.me/api/portraits/men/40.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 25, 36, DateTimeKind.Utc).AddTicks(7500) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 690, "21010 Barton Mountains", new DateTime(1972, 8, 11, 14, 58, 56, 21, DateTimeKind.Utc).AddTicks(9820), "Russelfurt", "Wales", new DateTime(2016, 12, 19, 19, 43, 25, 22, DateTimeKind.Utc).AddTicks(4920), "isaac_gottlieb@erica.biz", false, "Liza Hintz", "(991)568-8515", "https://randomuser.me/api/portraits/men/33.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 25, 22, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 684, "1007 Hirthe Camp", new DateTime(1999, 5, 23, 4, 34, 4, 10, DateTimeKind.Utc).AddTicks(8250), "Lake Carmela", "Wales", new DateTime(2016, 12, 19, 19, 43, 25, 11, DateTimeKind.Utc).AddTicks(2770), "lina@dan.us", false, "Maribel Blanda", "319.416.70810", "https://randomuser.me/api/portraits/women/27.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 11, DateTimeKind.Utc).AddTicks(3120) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 686, "2734 Victor Mall", new DateTime(1985, 7, 9, 14, 33, 3, 14, DateTimeKind.Utc).AddTicks(2190), "Gottliebmouth", "Wales", new DateTime(2016, 12, 19, 19, 43, 25, 14, DateTimeKind.Utc).AddTicks(6830), "camryn_stroman@jermain.us", false, "Mekhi Heaney", "1-2104-1108-5410 x410106", "https://randomuser.me/api/portraits/women/29.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 14, DateTimeKind.Utc).AddTicks(7190) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 689, "1069 Abelardo Viaduct", new DateTime(1994, 10, 17, 8, 55, 23, 19, DateTimeKind.Utc).AddTicks(6640), "Leannonhaven", "Wales", new DateTime(2016, 12, 19, 19, 43, 25, 20, DateTimeKind.Utc).AddTicks(1640), "danyka_o.hara@naomi.tv", false, "Michele Morissette", "188.970.2616 x8877", "https://randomuser.me/api/portraits/women/32.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 20, DateTimeKind.Utc).AddTicks(1970) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 661, "280210 Veronica Loaf", new DateTime(1978, 11, 9, 20, 44, 32, 965, DateTimeKind.Utc).AddTicks(7520), "McDermottville", "Northern Ireland", new DateTime(2016, 12, 19, 19, 43, 24, 966, DateTimeKind.Utc).AddTicks(3260), "gabrielle@madelyn.biz", false, "Miss America Mills", "662-150-6104", "https://randomuser.me/api/portraits/men/4.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 24, 966, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 704, "831 Douglas Corner", new DateTime(1984, 2, 6, 3, 1, 17, 48, DateTimeKind.Utc).AddTicks(7140), "Dovieville", "Northern Ireland", new DateTime(2016, 12, 19, 19, 43, 25, 49, DateTimeKind.Utc).AddTicks(1370), "jannie@marisol.org", false, "Miss Jayce Aufderhar", "114.003.8146", "https://randomuser.me/api/portraits/women/47.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 49, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 696, "191 Bins Avenue", new DateTime(1978, 3, 1, 7, 18, 6, 33, DateTimeKind.Utc).AddTicks(3830), "Lindbury", "England", new DateTime(2016, 12, 19, 19, 43, 25, 34, DateTimeKind.Utc).AddTicks(2850), "shad.king@lauriane.us", false, "Mr. Dillan Kihn", "305.949.0595 x3580", "https://randomuser.me/api/portraits/women/39.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 34, DateTimeKind.Utc).AddTicks(3760) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 671, "567 Jerald Unions", new DateTime(1968, 7, 24, 3, 54, 40, 986, DateTimeKind.Utc).AddTicks(3730), "Oberbrunnerport", "Scotland", new DateTime(2016, 12, 19, 19, 43, 24, 987, DateTimeKind.Utc).AddTicks(4260), "ethelyn.borer@rogelio.ca", false, "Mrs. Grady Walker", "(669)949-10338 x027", "https://randomuser.me/api/portraits/women/14.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 24, 987, DateTimeKind.Utc).AddTicks(4720) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 688, "483107 Darby Unions", new DateTime(1977, 7, 26, 19, 49, 11, 17, DateTimeKind.Utc).AddTicks(7040), "Lake Rosario", "England", new DateTime(2016, 12, 19, 19, 43, 25, 18, DateTimeKind.Utc).AddTicks(3100), "clifford_kunde@milan.info", false, "Nannie Schinner", "(651)1108-2550 x870", "https://randomuser.me/api/portraits/men/31.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 25, 18, DateTimeKind.Utc).AddTicks(3520) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 667, "455 Auer Lock", new DateTime(1980, 11, 6, 9, 16, 40, 976, DateTimeKind.Utc).AddTicks(9850), "Beermouth", "Northern Ireland", new DateTime(2016, 12, 19, 19, 43, 24, 977, DateTimeKind.Utc).AddTicks(4060), "tillman@allene.name", false, "Nestor Reichel", "1-442-1610-73108", "https://randomuser.me/api/portraits/men/10.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 24, 977, DateTimeKind.Utc).AddTicks(4430) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 693, "473 Heaney Lights", new DateTime(1994, 12, 16, 8, 48, 45, 28, DateTimeKind.Utc).AddTicks(1100), "Douglasburgh", "England", new DateTime(2016, 12, 19, 19, 43, 25, 28, DateTimeKind.Utc).AddTicks(5480), "kadin@mina.biz", false, "Robb Jacobson", "1-873-185-66103 x27455", "https://randomuser.me/api/portraits/women/36.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 28, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 681, "048 Jovan Squares", new DateTime(2000, 5, 3, 18, 19, 22, 5, DateTimeKind.Utc).AddTicks(3780), "New Amarafort", "England", new DateTime(2016, 12, 19, 19, 43, 25, 5, DateTimeKind.Utc).AddTicks(8600), "alia@sydni.com", false, "Roosevelt Daniel", "1-388-571-9046", "https://randomuser.me/api/portraits/women/24.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 5, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 673, "51040 Parisian Causeway", new DateTime(1981, 7, 28, 14, 9, 53, 991, DateTimeKind.Utc).AddTicks(80), "South Eliane", "England", new DateTime(2016, 12, 19, 19, 43, 24, 991, DateTimeKind.Utc).AddTicks(4830), "triston@guiseppe.net", false, "Rose Hessel IV", "1-207-153-8194", "https://randomuser.me/api/portraits/men/16.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 24, 991, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 668, "88582 Gleichner Stravenue", new DateTime(1967, 2, 19, 9, 57, 21, 978, DateTimeKind.Utc).AddTicks(7030), "New Heberhaven", "Wales", new DateTime(2016, 12, 19, 19, 43, 24, 979, DateTimeKind.Utc).AddTicks(1820), "pinkie_heaney@elva.biz", false, "Shanny Robel", "981-643-21062 x2510", "https://randomuser.me/api/portraits/women/11.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 24, 979, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 672, "614 Xzavier Fork", new DateTime(1996, 11, 3, 21, 20, 9, 988, DateTimeKind.Utc).AddTicks(9770), "Port Annaliseburgh", "Northern Ireland", new DateTime(2016, 12, 19, 19, 43, 24, 989, DateTimeKind.Utc).AddTicks(5390), "jordan@malinda.us", false, "Sigurd Muller", "1-081-699-31088 x762", "https://randomuser.me/api/portraits/men/15.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 24, 989, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 699, "064 Murazik Forks", new DateTime(1992, 11, 20, 18, 19, 42, 39, DateTimeKind.Utc).AddTicks(6180), "Welchton", "Scotland", new DateTime(2016, 12, 19, 19, 43, 25, 40, DateTimeKind.Utc).AddTicks(440), "khalil@yesenia.biz", false, "Sophia Ernser PhD", "137.854.4195", "https://randomuser.me/api/portraits/men/42.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 25, 40, DateTimeKind.Utc).AddTicks(800) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 682, "418 Ruth Meadow", new DateTime(1986, 7, 31, 11, 44, 48, 7, DateTimeKind.Utc).AddTicks(1220), "Gorczanyhaven", "England", new DateTime(2016, 12, 19, 19, 43, 25, 7, DateTimeKind.Utc).AddTicks(6090), "philip_greenfelder@ezekiel.co.uk", false, "Terence Koepp", "621-1103-18910 x6913", "https://randomuser.me/api/portraits/men/25.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 25, 7, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 677, "1073 Kareem Road", new DateTime(1977, 8, 16, 15, 17, 11, 998, DateTimeKind.Utc).AddTicks(3500), "South Anguston", "Wales", new DateTime(2016, 12, 19, 19, 43, 24, 998, DateTimeKind.Utc).AddTicks(8240), "calista.dach@gayle.co.uk", false, "Tony Harris", "1-913-670-7023", "https://randomuser.me/api/portraits/men/20.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 24, 998, DateTimeKind.Utc).AddTicks(8540) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 703, "167 Abigayle Green", new DateTime(1982, 8, 11, 21, 0, 9, 46, DateTimeKind.Utc).AddTicks(7830), "East Cliffordmouth", "Scotland", new DateTime(2016, 12, 19, 19, 43, 25, 47, DateTimeKind.Utc).AddTicks(2640), "julianne@brielle.org", false, "Unique Volkman", "(005)286-9624 x5816", "https://randomuser.me/api/portraits/men/46.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 25, 47, DateTimeKind.Utc).AddTicks(2980) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 666, "7610 Nelda Drives", new DateTime(1999, 5, 23, 2, 42, 51, 975, DateTimeKind.Utc).AddTicks(3280), "Zemlakburgh", "Northern Ireland", new DateTime(2016, 12, 19, 19, 43, 24, 975, DateTimeKind.Utc).AddTicks(7700), "dorian_kreiger@leopold.ca", false, "Vidal Spencer", "1-537-584-103110 x484", "https://randomuser.me/api/portraits/women/9.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 24, 975, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 692, "101536 Nannie Crest", new DateTime(2001, 12, 14, 6, 9, 28, 26, DateTimeKind.Utc).AddTicks(1120), "North Kathleen", "Northern Ireland", new DateTime(2016, 12, 19, 19, 43, 25, 26, DateTimeKind.Utc).AddTicks(6780), "friedrich@warren.us", false, "Vinnie Schmidt", "1-914-368-8906 x9138", "https://randomuser.me/api/portraits/women/35.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 26, DateTimeKind.Utc).AddTicks(7180) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 678, "049 Javon Squares", new DateTime(2001, 11, 26, 15, 47, 26, 999, DateTimeKind.Utc).AddTicks(9980), "New Coleman", "Northern Ireland", new DateTime(2016, 12, 19, 19, 43, 25, 0, DateTimeKind.Utc).AddTicks(5290), "ewell@joseph.me", false, "Levi Keebler", "300-597-1976", "https://randomuser.me/api/portraits/men/21.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 25, 0, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 657, "603 Gusikowski Lodge", new DateTime(1990, 2, 21, 21, 44, 53, 956, DateTimeKind.Utc).AddTicks(3670), "East Liammouth", "Scotland", new DateTime(2016, 12, 19, 19, 43, 24, 956, DateTimeKind.Utc).AddTicks(9490), "bernie@elwin.tv", false, "Lenora Waters", "516-492-10574 x410624", "https://randomuser.me/api/portraits/men/0.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 24, 956, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 669, "925 Dena Manors", new DateTime(1971, 5, 24, 10, 52, 43, 980, DateTimeKind.Utc).AddTicks(6400), "South Jimmieburgh", "Wales", new DateTime(2016, 12, 19, 19, 43, 24, 981, DateTimeKind.Utc).AddTicks(1830), "kirstin.gleichner@samir.org", false, "Leda Dach", "186.558.8870", "https://randomuser.me/api/portraits/women/12.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 24, 981, DateTimeKind.Utc).AddTicks(2230) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 694, "760 Sammy Dale", new DateTime(1974, 2, 26, 16, 3, 0, 29, DateTimeKind.Utc).AddTicks(6950), "Guªannbury", "Northern Ireland", new DateTime(2016, 12, 19, 19, 43, 25, 30, DateTimeKind.Utc).AddTicks(1090), "florencio.fisher@wendell.tv", false, "Laverne Gleichner", "(081)291-9173 x3567", "https://randomuser.me/api/portraits/women/37.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 30, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 695, "89579 Koepp Roads", new DateTime(1981, 2, 11, 8, 35, 53, 31, DateTimeKind.Utc).AddTicks(2230), "D'Amoreland", "England", new DateTime(2016, 12, 19, 19, 43, 25, 31, DateTimeKind.Utc).AddTicks(6400), "jade@raphael.info", false, "Bell Schaefer", "1-1009-265-3975 x0010", "https://randomuser.me/api/portraits/men/38.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 25, 31, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 705, "2910 Mortimer Hollow", new DateTime(1978, 7, 12, 21, 44, 44, 50, DateTimeKind.Utc).AddTicks(3180), "Lake Tara", "Scotland", new DateTime(2016, 12, 19, 19, 43, 25, 50, DateTimeKind.Utc).AddTicks(7720), "karina@margret.net", false, "Benedict VonRueden", "157-986-37107 x687", "https://randomuser.me/api/portraits/women/48.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 50, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 680, "2814 Howe Ways", new DateTime(2000, 7, 3, 1, 57, 13, 3, DateTimeKind.Utc).AddTicks(6340), "East Katlynnhaven", "Northern Ireland", new DateTime(2016, 12, 19, 19, 43, 25, 4, DateTimeKind.Utc).AddTicks(1240), "reina_stehr@elsa.name", false, "Christine Jacobs", "646.634.3900", "https://randomuser.me/api/portraits/women/23.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 4, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 691, "129 Maverick Bridge", new DateTime(1974, 9, 25, 22, 5, 54, 23, DateTimeKind.Utc).AddTicks(7360), "North Junius", "England", new DateTime(2016, 12, 19, 19, 43, 25, 24, DateTimeKind.Utc).AddTicks(2270), "mckenzie@blaise.me", false, "Clyde Nikolaus II", "(51010)967-7197", "https://randomuser.me/api/portraits/women/34.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 24, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 664, "82186 Macejkovic Corner", new DateTime(1979, 7, 13, 10, 24, 37, 971, DateTimeKind.Utc).AddTicks(9400), "North Donatoberg", "Wales", new DateTime(2016, 12, 19, 19, 43, 24, 972, DateTimeKind.Utc).AddTicks(4170), "jerry.cole@ben.net", false, "Dangelo Boehm", "1-413-997-09310", "https://randomuser.me/api/portraits/women/7.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 24, 972, DateTimeKind.Utc).AddTicks(4550) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 698, "6319 Mariana Vista", new DateTime(1985, 2, 1, 6, 30, 41, 37, DateTimeKind.Utc).AddTicks(9850), "Lake Breana", "England", new DateTime(2016, 12, 19, 19, 43, 25, 38, DateTimeKind.Utc).AddTicks(4620), "deanna_schmitt@zoey.tv", false, "Delfina Anderson", "(239)926-26103", "https://randomuser.me/api/portraits/men/41.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 25, 38, DateTimeKind.Utc).AddTicks(4990) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 702, "943 Johnny Summit", new DateTime(1989, 6, 9, 6, 37, 49, 44, DateTimeKind.Utc).AddTicks(5680), "Runolfsdottirside", "Northern Ireland", new DateTime(2016, 12, 19, 19, 43, 25, 45, DateTimeKind.Utc).AddTicks(230), "annabelle@sofia.ca", false, "Dock Gislason", "1-408-128-1614 x238", "https://randomuser.me/api/portraits/women/45.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 45, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 658, "258 Hank Brooks", new DateTime(1985, 11, 1, 6, 59, 6, 960, DateTimeKind.Utc).AddTicks(920), "West Lilliana", "England", new DateTime(2016, 12, 19, 19, 43, 24, 960, DateTimeKind.Utc).AddTicks(5990), "jaron.shields@angie.biz", false, "Domingo White", "(498)2105-4380", "https://randomuser.me/api/portraits/men/1.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 24, 960, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 700, "38105 Weimann Cliffs", new DateTime(1992, 8, 5, 22, 48, 15, 41, DateTimeKind.Utc).AddTicks(2680), "New Josiannetown", "Northern Ireland", new DateTime(2016, 12, 19, 19, 43, 25, 41, DateTimeKind.Utc).AddTicks(7200), "lavinia_walsh@emanuel.us", false, "Drake Murray", "(936)532-4061", "https://randomuser.me/api/portraits/women/43.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 41, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 679, "721 Daugherty Corner", new DateTime(1990, 10, 2, 22, 36, 1, 1, DateTimeKind.Utc).AddTicks(8720), "Russelmouth", "Wales", new DateTime(2016, 12, 19, 19, 43, 25, 2, DateTimeKind.Utc).AddTicks(3550), "kennedy@lorna.org", false, "Emilio Christiansen", "1-671-879-101003", "https://randomuser.me/api/portraits/women/22.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 25, 2, DateTimeKind.Utc).AddTicks(3980) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 662, "8222 Rutherford Overpass", new DateTime(1983, 10, 24, 15, 14, 17, 968, DateTimeKind.Utc).AddTicks(1430), "East Aurelia", "Scotland", new DateTime(2016, 12, 19, 19, 43, 24, 968, DateTimeKind.Utc).AddTicks(6680), "granville_howe@ressie.co.uk", false, "Virgie Walsh", "(0410)1000-10571 x941010", "https://randomuser.me/api/portraits/women/5.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 24, 968, DateTimeKind.Utc).AddTicks(7100) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 685, "19729 Jamarcus Views", new DateTime(1995, 7, 18, 15, 19, 44, 12, DateTimeKind.Utc).AddTicks(5030), "Aufderharberg", "Scotland", new DateTime(2016, 12, 19, 19, 43, 25, 12, DateTimeKind.Utc).AddTicks(9780), "nels.johns@verlie.com", false, "Emmie Sporer", "(1001)159-76210", "https://randomuser.me/api/portraits/men/28.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 25, 13, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 674, "352 Christiansen Plain", new DateTime(1987, 6, 23, 19, 46, 12, 992, DateTimeKind.Utc).AddTicks(6920), "Heidenreichshire", "Northern Ireland", new DateTime(2016, 12, 19, 19, 43, 24, 993, DateTimeKind.Utc).AddTicks(900), "carmine@milton.biz", false, "Era Satterfield PhD", "1-10510-1104-3789", "https://randomuser.me/api/portraits/men/17.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 24, 993, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 663, "825 Sylvester Junction", new DateTime(1977, 12, 10, 9, 33, 0, 970, DateTimeKind.Utc).AddTicks(1030), "New Aricside", "Northern Ireland", new DateTime(2016, 12, 19, 19, 43, 24, 970, DateTimeKind.Utc).AddTicks(6350), "brandt@jalon.me", false, "Everett Erdman", "439.618.8041", "https://randomuser.me/api/portraits/men/6.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 24, 970, DateTimeKind.Utc).AddTicks(6750) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 683, "494 Ward Light", new DateTime(1992, 7, 19, 0, 16, 7, 9, DateTimeKind.Utc).AddTicks(350), "Einoshire", "Scotland", new DateTime(2016, 12, 19, 19, 43, 25, 9, DateTimeKind.Utc).AddTicks(5280), "marcia_kessler@suzanne.net", false, "Ewell Hegmann", "1-361-455-2962", "https://randomuser.me/api/portraits/men/26.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 25, 9, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 701, "071034 Humberto Pike", new DateTime(1971, 5, 17, 9, 21, 15, 42, DateTimeKind.Utc).AddTicks(9030), "Curtbury", "England", new DateTime(2016, 12, 19, 19, 43, 25, 43, DateTimeKind.Utc).AddTicks(3510), "josephine@carlos.tv", false, "Finn Shanahan", "1-354-3104-21029 x59324", "https://randomuser.me/api/portraits/men/44.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 25, 43, DateTimeKind.Utc).AddTicks(3810) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 660, "8102104 Kian Union", new DateTime(1981, 6, 14, 0, 34, 30, 963, DateTimeKind.Utc).AddTicks(8150), "East Mattie", "Scotland", new DateTime(2016, 12, 19, 19, 43, 24, 964, DateTimeKind.Utc).AddTicks(3520), "tyree.mayer@malika.ca", false, "German Blanda II", "1081-863-5347 x02106", "https://randomuser.me/api/portraits/men/3.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 24, 964, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 687, "506 Parker Stream", new DateTime(1977, 4, 19, 23, 56, 9, 15, DateTimeKind.Utc).AddTicks(8780), "Kihnhaven", "Northern Ireland", new DateTime(2016, 12, 19, 19, 43, 25, 16, DateTimeKind.Utc).AddTicks(3370), "vaughn@eleonore.biz", false, "Hazle Beer", "934-491-8855", "https://randomuser.me/api/portraits/men/30.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 25, 16, DateTimeKind.Utc).AddTicks(3740) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 659, "056 VonRueden Throughway", new DateTime(1998, 8, 27, 18, 35, 12, 962, DateTimeKind.Utc).AddTicks(140), "Kutchtown", "Wales", new DateTime(2016, 12, 19, 19, 43, 24, 962, DateTimeKind.Utc).AddTicks(4560), "oleta.hessel@mayra.biz", false, "Jazmin Bode", "1-330-349-8362", "https://randomuser.me/api/portraits/men/2.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 24, 962, DateTimeKind.Utc).AddTicks(4890) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 675, "4497 Vickie Spurs", new DateTime(1979, 11, 1, 8, 4, 36, 994, DateTimeKind.Utc).AddTicks(3530), "Lake Jaidenton", "England", new DateTime(2016, 12, 19, 19, 43, 24, 994, DateTimeKind.Utc).AddTicks(7900), "beulah@neha.ca", false, "Joan Daniel", "049-1080-2551", "https://randomuser.me/api/portraits/men/18.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 24, 994, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 670, "490 Willms Cliffs", new DateTime(1988, 6, 28, 18, 39, 21, 982, DateTimeKind.Utc).AddTicks(7910), "Minervaside", "Scotland", new DateTime(2016, 12, 19, 19, 43, 24, 983, DateTimeKind.Utc).AddTicks(6490), "missouri@arthur.org", false, "Kamron Jacobi I", "412.343.2782 x759", "https://randomuser.me/api/portraits/men/13.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 24, 983, DateTimeKind.Utc).AddTicks(7130) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 665, "046910 Grant Lane", new DateTime(1974, 10, 12, 12, 26, 23, 973, DateTimeKind.Utc).AddTicks(6180), "North Johnmouth", "Scotland", new DateTime(2016, 12, 19, 19, 43, 24, 974, DateTimeKind.Utc).AddTicks(990), "deshawn_nolan@rey.biz", false, "Kenna Bradtke", "1-399-797-3337 x39402", "https://randomuser.me/api/portraits/men/8.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 24, 974, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 706, "596 Hansen Motorway", new DateTime(1977, 7, 15, 5, 3, 12, 52, DateTimeKind.Utc).AddTicks(6870), "McCluremouth", "England", new DateTime(2016, 12, 19, 19, 43, 25, 53, DateTimeKind.Utc).AddTicks(1440), "merle@emilio.biz", false, "Enos Osinski", "1-251-1022-104110 x47110", "https://randomuser.me/api/portraits/men/49.jpg", "M", new DateTime(2016, 12, 19, 19, 43, 25, 53, DateTimeKind.Utc).AddTicks(1820) });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "Birthdate", "City", "Country", "CreatedTs", "Email", "Favorite", "Name", "Phonenumber", "Photo", "Sex", "UpdatedTs" },
                values: new object[] { 676, "8605 Mertz Crest", new DateTime(1985, 6, 15, 5, 9, 3, 996, DateTimeKind.Utc).AddTicks(6050), "Lake Terranceton", "Wales", new DateTime(2016, 12, 19, 19, 43, 24, 997, DateTimeKind.Utc).AddTicks(960), "rogers_dietrich@monroe.org", false, "Zakary Kertzmann", "1-687-600-1737", "https://randomuser.me/api/portraits/women/19.jpg", "F", new DateTime(2016, 12, 19, 19, 43, 24, 997, DateTimeKind.Utc).AddTicks(1340) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
