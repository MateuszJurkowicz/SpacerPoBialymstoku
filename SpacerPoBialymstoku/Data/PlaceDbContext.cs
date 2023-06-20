using Microsoft.EntityFrameworkCore;
using SpacerPoBialymstoku.Models;

namespace SpacerPoBialymstoku.Data
{
    public class PlaceDbContext : DbContext 
    {
        public PlaceDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Place> Place { get; set; }
    }
}
