using Microsoft.EntityFrameworkCore;
using Yelp.Entities.BusinessEntities;
using Yelp.Entities.ReviewEntities;
using Yelp.Entities.UserEntities;

namespace Yelp.DataAccess{
    public class DatabaseContext(DbContextOptions<DatabaseContext> _options) : DbContext(_options){
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<BusinessPhoto> BusinessPhotos { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<BusinessType> BusinessTypes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<BusinessService> BusinessServices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
    }
}