using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HantahaAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class countryUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "India", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IN.svg", "Hindistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Brazil", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/BR.svg", "Brezilya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Iran", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IR.svg", "İran" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Iraq", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IQ.svg", "Irak" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Ireland", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IE.svg", "İrlanda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Isle of Man", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IM.svg", "Man Adası" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Iceland", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IS.svg", "İzlanda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Italy", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IT.svg", "Italya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Jersey", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/JE.svg", "Jersey" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Jamaica", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/JM.svg", "Jamaika" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Jordan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/JO.svg", "Ürdün" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Japan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/JP.svg", "Japonya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Kenya", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KE.svg", "Kenya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Kyrgyzstan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KG.svg", "Kırgızistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Cambodia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KH.svg", "Kamboçya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Kiribati", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KI.svg", "Kiribati" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Comoros", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KM.svg", "Komorlar" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Saint Kitts and Nevis", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KN.svg", "Saint Kitts ve Nevis" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "North Korea", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KP.svg", "Kuzey Kore" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "South Korea", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KR.svg", "Güney Kore" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Kuwait", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KW.svg", "Kuveyt" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Kazakhstan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KZ.svg", "Kazakistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Laos", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LA.svg", "Laos" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Lebanon", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LB.svg", "Lübnan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Saint Lucia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LC.svg", "Saint Lucia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Liechtenstein", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LI.svg", "Liechtenstein" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Sri Lanka", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LK.svg", "Sri Lanka" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Liberia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LR.svg", "Liberya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Lesotho", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LS.svg", "Lesotho" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Lithuania", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LT.svg", "Litvanya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Luxembourg", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LU.svg", "Lüksemburg" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Latvia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LV.svg", "Letonya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Libya", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LY.svg", "Libya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Morocco", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MA.svg", "Fas" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Monaco", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MC.svg", "Monako" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Moldova", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MD.svg", "Moldova" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Montenegro", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ME.svg", "Karadağ" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Madagascar", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MG.svg", "Madagaskar" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Marshall Islands", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MH.svg", "Marshall Adaları" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "North Macedonia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MK.svg", "Makedonya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Mali", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ML.svg", "Mali" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Myanmar (Burma)", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MM.svg", "Myanmar (Burma)" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Mongolia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MN.svg", "Moğolistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Macao", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MO.svg", "Macao" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Northern Mariana Islands", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MP.svg", "Kuzey Mariana Adaları" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Martinique", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MQ.svg", "Martinique" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Mauritania", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MR.svg", "Moritanya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Montserrat", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MS.svg", "Montserrat" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Malta", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MT.svg", "Malta" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Mauritius", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MU.svg", "Mauritius" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Maldives", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MV.svg", "Maldivler" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Malawi", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MW.svg", "Malavi" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Mexico", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MX.svg", "Meksika" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Malaysia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MY.svg", "Malezya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Mozambique", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MZ.svg", "Mozambik" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Namibia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NA.svg", "Namibya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "New Caledonia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NC.svg", "Yeni Kaledonya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Niger", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NE.svg", "Nijer" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Norfolk Island", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NF.svg", "Norfolk Adası" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Nigeria", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NG.svg", "Nijerya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Nicaragua", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NI.svg", "Nikaragua" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Netherlands", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NL.svg", "Hollanda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Norway", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NO.svg", "Norveç" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Nepal", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NP.svg", "Nepal" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Nauru", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NR.svg", "Nauru" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Niue", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NU.svg", "Niue" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "New Zealand", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NZ.svg", "Yeni Zelanda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Oman", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/OM.svg", "Umman" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Panama", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PA.svg", "Panama" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Peru", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PE.svg", "Peru" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "French Polynesia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PF.svg", "Fransız Polinezyası" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Papua New Guinea", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PG.svg", "Papua Yeni Gine" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Philippines", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PH.svg", "Filipinler" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Pakistan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PK.svg", "Pakistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Poland", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PL.svg", "Polonya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Saint Pierre and Miquelon", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PM.svg", "Saint Pierre ve Miquelon" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Pitcairn Islands", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PN.svg", "Pitcairn Adaları" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Puerto Rico", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PR.svg", "Porto Riko" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Palestinian Territories", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PS.svg", "Filistin Bölgesi" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Portugal", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PT.svg", "Portekiz" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Palau", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PW.svg", "Palau" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Paraguay", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PY.svg", "Paraguay" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Qatar", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/QA.svg", "Katar" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Réunion", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/RE.svg", "Reunion" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Romania", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/RO.svg", "Romanya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Serbia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/RS.svg", "Sırbistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Russia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/RU.svg", "Rusya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Rwanda", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/RW.svg", "Ruanda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Saudi Arabia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SA.svg", "Suudi Arabistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Solomon Islands", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SB.svg", "Solomon Adaları" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Seychelles", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SC.svg", "Seyşeller" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Sudan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SD.svg", "Sudan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Sweden", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SE.svg", "İsveç" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Singapore", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SG.svg", "Singapur" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Saint Helena", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SH.svg", "Saint Helena" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Slovenia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SI.svg", "Slovenya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Svalbard and Jan Mayen", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SJ.svg", "Svalbard ve Jan Mayen" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Slovakia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SK.svg", "Slovakya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Sierra Leone", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SL.svg", "Sierra Leone" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "San Marino", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SM.svg", "San Marino" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Senegal", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SN.svg", "Senegal" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Somalia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SO.svg", "Somali" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Suriname", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SR.svg", "Surinam" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "South Sudan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SS.svg", "Güney Sudan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "São Tomé and Príncipe", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ST.svg", "São Tomé ve Príncipe" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "El Salvador", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SV.svg", "El Salvador" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Sint Maarten", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SX.svg", "Sint Maarten" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Syria", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SY.svg", "Suriye" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Eswatini", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SZ.svg", "Esvatini" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Tristan da Cunha", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TA.svg", "Tristan da Cunha" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Turkmenistan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TM.svg", "Türkmenistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Tunisia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TN.svg", "Tunus" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Tonga", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TO.svg", "Tonga" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Timor-Leste", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TL.svg", "Doğu Timor" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Trinidad and Tobago", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TT.svg", "Trinidad ve Tobago" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Turkey", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TR.svg", "Türkiye" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Tuvalu", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TV.svg", "Tuvalu" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Taiwan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TW.svg", "Tayvan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Tanzania", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TZ.svg", "Tanzanya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Ukraine", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/UA.svg", "Ukrayna" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Uganda", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/UG.svg", "Uganda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "United Kingdom", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/GB.svg", "Birleşik Krallık" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "United States", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/US.svg", "Amerika Birleşik Devletleri" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Uruguay", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/UY.svg", "Uruguay" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Uzbekistan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/UZ.svg", "Özbekistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Vatican City", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/VA.svg", "Vatikan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Saint Vincent and the Grenadines", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/VC.svg", "Saint Vincent ve Grenadinler" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Venezuela", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/VE.svg", "Venezuela" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "British Virgin Islands", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/VG.svg", "Britanya Virjin Adaları" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "U.S. Virgin Islands", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/VI.svg", "Amerika Virjin Adaları" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Vietnam", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/VN.svg", "Vietnam" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Vanuatu", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/VU.svg", "Vanuatu" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Wallis and Futuna", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/WF.svg", "Wallis ve Futuna" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Samoa", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/WS.svg", "Samoa" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Yemen", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/YE.svg", "Yemen" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Mayotte", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/YT.svg", "Mayotte" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "South Africa", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ZA.svg", "Güney Afrika" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Zambia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ZM.svg", "Zambia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Zimbabwe", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ZW.svg", "Zimbabve" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "England", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ENGLAND.svg", "İngiltere" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Scotland", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SCOTLAND.svg", "İskoçya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Wales", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/WALES.svg", "Galler" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Afghanistan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/AF.svg", "Afganistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "India", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IN.svg", "Hindistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Brazil", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/BR.svg", "Brezilya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Iran", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IR.svg", "İran" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Iraq", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IQ.svg", "Irak" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Ireland", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IE.svg", "İrlanda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Isle of Man", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IM.svg", "Man Adası" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Iceland", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IS.svg", "İzlanda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Italy", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/IT.svg", "Italya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Jersey", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/JE.svg", "Jersey" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Jamaica", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/JM.svg", "Jamaika" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Jordan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/JO.svg", "Ürdün" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Japan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/JP.svg", "Japonya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Kenya", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KE.svg", "Kenya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Kyrgyzstan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KG.svg", "Kırgızistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Cambodia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KH.svg", "Kamboçya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Kiribati", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KI.svg", "Kiribati" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Comoros", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KM.svg", "Komorlar" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Saint Kitts and Nevis", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KN.svg", "Saint Kitts ve Nevis" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "North Korea", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KP.svg", "Kuzey Kore" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "South Korea", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KR.svg", "Güney Kore" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Kuwait", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KW.svg", "Kuveyt" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Kazakhstan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/KZ.svg", "Kazakistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Laos", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LA.svg", "Laos" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Lebanon", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LB.svg", "Lübnan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Saint Lucia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LC.svg", "Saint Lucia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Liechtenstein", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LI.svg", "Liechtenstein" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Sri Lanka", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LK.svg", "Sri Lanka" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Liberia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LR.svg", "Liberya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Lesotho", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LS.svg", "Lesotho" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Lithuania", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LT.svg", "Litvanya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Luxembourg", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LU.svg", "Lüksemburg" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Latvia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LV.svg", "Letonya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Libya", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/LY.svg", "Libya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Morocco", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MA.svg", "Fas" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Monaco", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MC.svg", "Monako" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Moldova", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MD.svg", "Moldova" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Montenegro", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ME.svg", "Karadağ" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Madagascar", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MG.svg", "Madagaskar" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Marshall Islands", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MH.svg", "Marshall Adaları" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "North Macedonia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MK.svg", "Makedonya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Mali", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ML.svg", "Mali" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Myanmar (Burma)", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MM.svg", "Myanmar (Burma)" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Mongolia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MN.svg", "Moğolistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Macao", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MO.svg", "Macao" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Northern Mariana Islands", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MP.svg", "Kuzey Mariana Adaları" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Martinique", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MQ.svg", "Martinique" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Mauritania", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MR.svg", "Moritanya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Montserrat", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MS.svg", "Montserrat" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Malta", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MT.svg", "Malta" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Mauritius", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MU.svg", "Mauritius" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Maldives", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MV.svg", "Maldivler" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Malawi", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MW.svg", "Malavi" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Mexico", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MX.svg", "Meksika" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Malaysia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MY.svg", "Malezya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Mozambique", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/MZ.svg", "Mozambik" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Namibia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NA.svg", "Namibya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "New Caledonia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NC.svg", "Yeni Kaledonya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Niger", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NE.svg", "Nijer" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Norfolk Island", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NF.svg", "Norfolk Adası" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Nigeria", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NG.svg", "Nijerya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Nicaragua", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NI.svg", "Nikaragua" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Netherlands", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NL.svg", "Hollanda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Norway", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NO.svg", "Norveç" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Nepal", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NP.svg", "Nepal" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Nauru", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NR.svg", "Nauru" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Niue", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NU.svg", "Niue" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "New Zealand", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/NZ.svg", "Yeni Zelanda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Oman", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/OM.svg", "Umman" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Panama", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PA.svg", "Panama" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Peru", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PE.svg", "Peru" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "French Polynesia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PF.svg", "Fransız Polinezyası" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Papua New Guinea", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PG.svg", "Papua Yeni Gine" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Philippines", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PH.svg", "Filipinler" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Pakistan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PK.svg", "Pakistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Poland", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PL.svg", "Polonya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Saint Pierre and Miquelon", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PM.svg", "Saint Pierre ve Miquelon" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Pitcairn Islands", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PN.svg", "Pitcairn Adaları" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Puerto Rico", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PR.svg", "Porto Riko" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Palestinian Territories", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PS.svg", "Filistin Bölgesi" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Portugal", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PT.svg", "Portekiz" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Palau", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PW.svg", "Palau" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Paraguay", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/PY.svg", "Paraguay" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Qatar", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/QA.svg", "Katar" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Réunion", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/RE.svg", "Reunion" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Romania", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/RO.svg", "Romanya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Serbia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/RS.svg", "Sırbistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Russia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/RU.svg", "Rusya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Rwanda", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/RW.svg", "Ruanda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Saudi Arabia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SA.svg", "Suudi Arabistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Solomon Islands", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SB.svg", "Solomon Adaları" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Seychelles", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SC.svg", "Seyşeller" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Sudan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SD.svg", "Sudan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Sweden", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SE.svg", "İsveç" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Singapore", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SG.svg", "Singapur" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Saint Helena", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SH.svg", "Saint Helena" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Slovenia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SI.svg", "Slovenya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Svalbard and Jan Mayen", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SJ.svg", "Svalbard ve Jan Mayen" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Slovakia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SK.svg", "Slovakya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Sierra Leone", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SL.svg", "Sierra Leone" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "San Marino", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SM.svg", "San Marino" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Senegal", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SN.svg", "Senegal" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Somalia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SO.svg", "Somali" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Suriname", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SR.svg", "Surinam" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "South Sudan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SS.svg", "Güney Sudan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "São Tomé and Príncipe", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ST.svg", "São Tomé ve Príncipe" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "El Salvador", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SV.svg", "El Salvador" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Sint Maarten", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SX.svg", "Sint Maarten" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Syria", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SY.svg", "Suriye" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Eswatini", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SZ.svg", "Esvatini" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Tristan da Cunha", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TA.svg", "Tristan da Cunha" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Turkmenistan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TM.svg", "Türkmenistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Tunisia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TN.svg", "Tunus" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Tonga", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TO.svg", "Tonga" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Timor-Leste", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TL.svg", "Doğu Timor" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Trinidad and Tobago", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TT.svg", "Trinidad ve Tobago" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Turkey", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TR.svg", "Türkiye" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Tuvalu", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TV.svg", "Tuvalu" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Taiwan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TW.svg", "Tayvan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Tanzania", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/TZ.svg", "Tanzanya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Ukraine", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/UA.svg", "Ukrayna" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Uganda", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/UG.svg", "Uganda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "United Kingdom", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/GB.svg", "Birleşik Krallık" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "United States", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/US.svg", "Amerika Birleşik Devletleri" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Uruguay", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/UY.svg", "Uruguay" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Uzbekistan", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/UZ.svg", "Özbekistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Vatican City", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/VA.svg", "Vatikan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Saint Vincent and the Grenadines", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/VC.svg", "Saint Vincent ve Grenadinler" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Venezuela", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/VE.svg", "Venezuela" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "British Virgin Islands", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/VG.svg", "Britanya Virjin Adaları" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "U.S. Virgin Islands", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/VI.svg", "Amerika Virjin Adaları" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Vietnam", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/VN.svg", "Vietnam" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Vanuatu", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/VU.svg", "Vanuatu" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Wallis and Futuna", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/WF.svg", "Wallis ve Futuna" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Samoa", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/WS.svg", "Samoa" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Yemen", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/YE.svg", "Yemen" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Mayotte", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/YT.svg", "Mayotte" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "South Africa", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ZA.svg", "Güney Afrika" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Zambia", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ZM.svg", "Zambia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Zimbabwe", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ZW.svg", "Zimbabve" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "England", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/ENGLAND.svg", "İngiltere" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EnglishName", "ImageURL", "Name" },
                values: new object[] { "Scotland", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/SCOTLAND.svg", "İskoçya" });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "EnglishName", "ImageURL", "Name" },
                values: new object[] { 209, "Wales", "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/images/WALES.svg", "Galler" });
        }
    }
}
