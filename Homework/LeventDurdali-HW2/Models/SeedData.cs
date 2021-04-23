using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LeventDurdali_HW2.Models
{

    // SeedData: To populate the database and provide some sample data
    // Adds 5 entries for Drone and Helicopter models
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            DroneDBContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<DroneDBContext>();
            if (!context.Drones.Any())
            {
                context.Drones.AddRange(
                new Drone
                {
                    Name = "Anka-S",
                    Description = "Turkish Military C-UAV",
                    Category = "MALE",
                    Price = 275
                },
                new Drone
                {
                    Name = "RQ-4 Global Hawk",
                    Description = "U.S. Military UAV",
                    Category = "HALE",
                    Price = 48.95m
                },
                new Drone
                {
                    Name = "MQ-9 Reaper (Predator B)",
                    Description = "U.S. Military C-UAV",
                    Category = "MALE",
                    Price = 19.50m
                },
                new Drone
                {
                    Name = "Kronshtadt Orion",
                    Description = "Russian Millitary",
                    Category = "HALE",
                    Price = 34.95m
                },
                new Drone
                {
                    Name = "XQ-58A Valkyrie",
                    Description = "U.S. Military UAV",
                    Category = "HALE",
                    Price = 79500
                }
                );
                context.SaveChanges();
            }
            if (!context.Helicopters.Any())
            {
                context.Helicopters.AddRange(
                new Helicopter
                {
                    Name = "T-129 Attak",
                    Description = "Turkish Military",
                    Category = "Test",
                    Price = 275
                },
                new Helicopter
                {
                    Name = "RQ-4 Global Hawk",
                    Description = "U.S. MilitaryV",
                    Category = "HALE",
                    Price = 48.95m
                }
                );
                context.SaveChanges();
            }
        }
    }
}
