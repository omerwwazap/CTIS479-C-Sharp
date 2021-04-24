using Microsoft.EntityFrameworkCore;

// Setting Connection for both Drone and Helicopter Tables
namespace LeventDurdali_HW2.Models
{
    public class DroneDBContext : DbContext
    {
        public DroneDBContext(DbContextOptions<DroneDBContext> options) : base(options)
        {
        }

        public DbSet<Drone> Drones { get; set; }

        public DbSet<Helicopter> Helicopters { get; set; }
    }
}