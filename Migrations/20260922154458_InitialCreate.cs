using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Director = table.Column<string>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    PosterUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Genre", "PosterUrl", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Історія родини мафіозі Корлеоне та боротьби за владу в кримінальному світі Нью-Йорка.", "Френсіс Форд Коппола", "Драма, кримінал", "https://upload.wikimedia.org/wikipedia/en/1/1c/Godfather_ver1.jpg", "Хрещений батько", 1972 },
                    { 2, "Банкір, засуджений за вбивство, яке не скоював, шукає надію та свободу у в'язниці Шоушенк.", "Френк Дарабонт", "Драма", "https://upload.wikimedia.org/wikipedia/en/8/81/ShawshankRedemptionMoviePoster.jpg", "Втеча з Шоушенку", 1994 },
                    { 3, "Бетмен протистоїть Джокеру, який занурює Готем у хаос та анархію.", "Крістофер Нолан", "Бойовик, драма", "https://upload.wikimedia.org/wikipedia/en/1/1c/The_Dark_Knight_%282008_film%29.jpg", "Темний лицар", 2008 },
                    { 4, "Команда дослідників подорожує крізь червоточину у пошуках нового дому для людства.", "Крістофер Нолан", "Фантастика, драма", "https://upload.wikimedia.org/wikipedia/en/b/bc/Interstellar_film_poster.jpg", "Інтерстеллар", 2014 },
                    { 5, "Історія життя простодушного чоловіка, який став свідком і учасником ключових подій американської історії.", "Роберт Земекіс", "Драма, комедія", "https://upload.wikimedia.org/wikipedia/en/6/67/Forrest_Gump_poster.jpg", "Форрест Гамп", 1994 },
                    { 6, "Переплетені історії двох найманих вбивць, боксера та дружини гангстера в Лос-Анджелесі.", "Квентін Тарантіно", "Кримінал, драма", "https://upload.wikimedia.org/wikipedia/en/3/3b/Pulp_Fiction_%281994%29_poster.jpg", "Кримінальне чтиво", 1994 },
                    { 7, "Злодій, який краде секрети зі снів, отримує завдання навпаки — впровадити ідею в чужу підсвідомість.", "Крістофер Нолан", "Фантастика, трилер", "https://avatars.mds.yandex.net/get-kinopoisk-image/1629390/8ab9a119-dd74-44f0-baec-0629797483d7/600x900", "Початок", 2010 },
                    { 8, "Програміст дізнається, що реальність навколо нього — симуляція, і приєднується до повстання проти машин.", "Лана та Ліллі Вачовскі", "Фантастика, бойовик", "https://thumb.wikimedia.org/wikipedia/ru/thumb/9/9d/Matrix-DVD.jpg/250px-Matrix-DVD.jpg?utm_source=ru.wikipedia.org&utm_campaign=parser&utm_content=thumbnail", "Матриця", 1999 },
                    { 9, "Офісний працівник, страждаючи від безсоння, засновує підпільний бійцівський клуб зі своїм новим знайомим.", "Девід Фінчер", "Драма", "https://upload.wikimedia.org/wikipedia/en/f/fc/Fight_Club_poster.jpg", "Бійцівський клуб", 1999 },
                    { 10, "Гобіт Фродо вирушає у небезпечну подорож, щоб знищити могутній перстень і врятувати Середзем'я.", "Пітер Джексон", "Фентезі, пригоди", "https://thumb.wikimedia.org/wikipedia/uk/thumb/8/8c/%D0%91%D1%80%D0%B0%D1%82%D1%81%D1%82%D0%B2%D0%BE_%D0%9F%D0%B5%D1%80%D1%81%D0%BD%D1%8F.jpg/250px-%D0%91%D1%80%D0%B0%D1%82%D1%81%D1%82%D0%B2%D0%BE_%D0%9F%D0%B5%D1%80%D1%81%D0%BD%D1%8F.jpg?utm_source=uk.wikipedia.org&utm_campaign=parser&utm_content=thumbnail", "Володар перснів: Братство персня", 2001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
