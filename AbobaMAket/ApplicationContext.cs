using AbobaMAket.Models;

using Microsoft.EntityFrameworkCore;

namespace AbobaMAket
{
    public class ApplicationContext : DbContext
    {
        private static ApplicationContext instance;
        public static ApplicationContext Instantce
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApplicationContext();

                }
                return instance;
            }

        }

        public DbSet<Service> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=hnt8.ru;database=Test;User ID=sa;Password=_RasulkotV2;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Service>().HasData(
                new Service() { Id = 1, Name = "Уроки по Дота2", Description = "description1", Image = "https://shorturl.at/tBHP6" },
                new Service() { Id = 2, Name = "Уроки Самбо", Description = "description2", Image = "http://www.krustabaznica.lv/wp-content/uploads/2019/09/smagsdarbs.png" },
                new Service() { Id = 3, Name = "Уроки Английского", Description = "description3", Image = "https://egevpare.ru/wp-content/uploads/2022/09/depositphotos_37850211_xl-2015-scaled-1.jpg" }

                );

        }

        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

    }
}
