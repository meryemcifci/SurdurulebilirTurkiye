using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EntityLayer;
using EntityLayer.Concrete; // EntityLayer'daki modelleri ekliyoruz

namespace SürdürülebilirTürkiye.DataAccessLayer
{
    public class Context : IdentityDbContext<User,Role,string>
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        // EntityLayer'daki modelleri ekleyelim
        public DbSet<About> Abouts { get; set; }
        public DbSet<CarbonFootprintCategory> CarbonFootprintCategories { get; set; }
        public DbSet<CarEmission> CarEmissions { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ElectricityCalculation> ElectricityCalculations { get; set; }
        public DbSet<EnvironmentalImpact> EnvironmentalImpacts { get; set; }
        public DbSet<HomepageBanner> HomepageBanners { get; set; }
        public DbSet<NaturalGasCalculation> NaturalGasCalculations { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsArticle> NewsArticles { get; set; }
        public DbSet<Plastic> Plastics { get; set; }
        public DbSet<PlasticAlternative> PlasticAlternatives { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RecyclingContainer> RecyclingContainers { get; set; }
        public DbSet<SocialMediaLink> SocialMediaLinks { get; set; }
        public DbSet<SupportProgram> SupportPrograms { get; set; }
        public DbSet<SustainabilityGoal> SustainabilityGoals { get; set; }
        public DbSet<WaterManagementStrategy> WaterManagementStrategies { get; set; }
        public DbSet<WaterSource> WaterSources { get; set; }

    }
}
