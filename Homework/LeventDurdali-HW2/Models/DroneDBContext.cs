using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeventDurdali_HW2.Models
{
    public class DroneDBContext : DbContext
    {
        public DroneDBContext(DbContextOptions<DroneDBContext> options) : base(options) { }
        public DbSet<Drone> Drones { get; set; }
    }
}
