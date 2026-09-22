using Microsoft.EntityFrameworkCore;
using MVC_1.Models;

namespace MVC_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Хрещений батько", Director = "Френсіс Форд Коппола", Genre = "Драма, кримінал", Year = 1972, PosterUrl = "https://upload.wikimedia.org/wikipedia/en/1/1c/Godfather_ver1.jpg", Description = "Історія родини мафіозі Корлеоне та боротьби за владу в кримінальному світі Нью-Йорка." },
                new Movie { Id = 2, Title = "Втеча з Шоушенку", Director = "Френк Дарабонт", Genre = "Драма", Year = 1994, PosterUrl = "https://upload.wikimedia.org/wikipedia/en/8/81/ShawshankRedemptionMoviePoster.jpg", Description = "Банкір, засуджений за вбивство, яке не скоював, шукає надію та свободу у в'язниці Шоушенк." },
                new Movie { Id = 3, Title = "Темний лицар", Director = "Крістофер Нолан", Genre = "Бойовик, драма", Year = 2008, PosterUrl = "https://upload.wikimedia.org/wikipedia/en/1/1c/The_Dark_Knight_%282008_film%29.jpg", Description = "Бетмен протистоїть Джокеру, який занурює Готем у хаос та анархію." },
                new Movie { Id = 4, Title = "Інтерстеллар", Director = "Крістофер Нолан", Genre = "Фантастика, драма", Year = 2014, PosterUrl = "https://upload.wikimedia.org/wikipedia/en/b/bc/Interstellar_film_poster.jpg", Description = "Команда дослідників подорожує крізь червоточину у пошуках нового дому для людства." },
                new Movie { Id = 5, Title = "Форрест Гамп", Director = "Роберт Земекіс", Genre = "Драма, комедія", Year = 1994, PosterUrl = "https://upload.wikimedia.org/wikipedia/en/6/67/Forrest_Gump_poster.jpg", Description = "Історія життя простодушного чоловіка, який став свідком і учасником ключових подій американської історії." },
                new Movie { Id = 6, Title = "Кримінальне чтиво", Director = "Квентін Тарантіно", Genre = "Кримінал, драма", Year = 1994, PosterUrl = "https://upload.wikimedia.org/wikipedia/en/3/3b/Pulp_Fiction_%281994%29_poster.jpg", Description = "Переплетені історії двох найманих вбивць, боксера та дружини гангстера в Лос-Анджелесі." },
                new Movie { Id = 7, Title = "Початок", Director = "Крістофер Нолан", Genre = "Фантастика, трилер", Year = 2010, PosterUrl = "https://avatars.mds.yandex.net/get-kinopoisk-image/1629390/8ab9a119-dd74-44f0-baec-0629797483d7/600x900", Description = "Злодій, який краде секрети зі снів, отримує завдання навпаки — впровадити ідею в чужу підсвідомість." },
                new Movie { Id = 8, Title = "Матриця", Director = "Лана та Ліллі Вачовскі", Genre = "Фантастика, бойовик", Year = 1999, PosterUrl = "https://thumb.wikimedia.org/wikipedia/ru/thumb/9/9d/Matrix-DVD.jpg/250px-Matrix-DVD.jpg?utm_source=ru.wikipedia.org&utm_campaign=parser&utm_content=thumbnail", Description = "Програміст дізнається, що реальність навколо нього — симуляція, і приєднується до повстання проти машин." },
                new Movie { Id = 9, Title = "Бійцівський клуб", Director = "Девід Фінчер", Genre = "Драма", Year = 1999, PosterUrl = "https://upload.wikimedia.org/wikipedia/en/f/fc/Fight_Club_poster.jpg", Description = "Офісний працівник, страждаючи від безсоння, засновує підпільний бійцівський клуб зі своїм новим знайомим." },
                new Movie { Id = 10, Title = "Володар перснів: Братство персня", Director = "Пітер Джексон", Genre = "Фентезі, пригоди", Year = 2001, PosterUrl = "https://thumb.wikimedia.org/wikipedia/uk/thumb/8/8c/%D0%91%D1%80%D0%B0%D1%82%D1%81%D1%82%D0%B2%D0%BE_%D0%9F%D0%B5%D1%80%D1%81%D0%BD%D1%8F.jpg/250px-%D0%91%D1%80%D0%B0%D1%82%D1%81%D1%82%D0%B2%D0%BE_%D0%9F%D0%B5%D1%80%D1%81%D0%BD%D1%8F.jpg?utm_source=uk.wikipedia.org&utm_campaign=parser&utm_content=thumbnail", Description = "Гобіт Фродо вирушає у небезпечну подорож, щоб знищити могутній перстень і врятувати Середзем'я." }
            );
        }
    }
}
