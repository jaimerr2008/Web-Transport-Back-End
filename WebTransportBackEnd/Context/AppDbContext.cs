using Microsoft.EntityFrameworkCore;
using WebTransportBackEnd.Models;

namespace WebTransportBackEnd.Context
{
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User>Users {  get; set; }    
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<WebTransportBackEnd.Models.Route> Routes { get; set; }
            
    }
}
