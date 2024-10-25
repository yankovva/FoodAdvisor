using FoodAdvisor.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodAdvisor.Data
{
    public class FoodAdvisorDbContext : IdentityDbContext
    {
        public FoodAdvisorDbContext()
        {
            
        }
        public FoodAdvisorDbContext(DbContextOptions<FoodAdvisorDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<City> Citys { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}