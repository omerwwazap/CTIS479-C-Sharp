using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LeventDurdali_Homework2.Models

{
    public class DroneDBContext : DbContext
    {
        public DroneDBContext(DbContextOptions<DroneDBContext> options) : base(options)
        { }
        public DbSet<Drone> Drones { get; set; }
    }
}