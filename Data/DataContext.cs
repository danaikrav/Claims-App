using Claims_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Claims_App.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<Owners> Owners { get; set; }
        public DbSet<Claims> Claims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // to link the ids
            modelBuilder.Entity<Claims>()
                .HasKey(c => new { c.Id, c.Vehicle_Id }); 
            modelBuilder.Entity<Vehicles>()
                .HasKey(c => new { c.Owner_Id, c.Id });
        }
    }
}
