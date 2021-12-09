using Microsoft.EntityFrameworkCore;

namespace RocketApi.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Lead> leads { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Battery> batteries { get; set; }
        public DbSet<Building> buildings { get; set; }
        public DbSet<Column> columns { get; set; }
        public DbSet<Elevator> elevators { get; set; }
        public DbSet<Employee> employees { get; set;}
        // public DbSet<BuildingDataTransfer> buildingDTO { get; set;}
        // public DbSet<BuildingDataTransfer> buildingDetails { get; set;}
        public DbSet<Intervention> interventions { get; set; }
  
    }
}
