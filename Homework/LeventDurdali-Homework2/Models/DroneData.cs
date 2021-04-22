using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeventDurdali_Homework2.Models
{
    /*
	 Drone Databse: Some sample data
	 */
    public class DroneData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            DroneDBContext context = app.ApplicationServices.CreateScope().
                                        ServiceProvider.GetRequiredService<DroneDBContext>();
            if (!context.Drones.Any())
            {
                context.Drones.AddRange(
                new Drone
                {
                    Name = "Anka-S",
                    Description = "Turkish Military C-UAV",
                    Category = "MALE",
                    Price = 8m
                },
                new Drone
                {
                    Name = "RQ-4 Global Hawk",
                    Description = "U.S. Military UAV",
                    Category = "HALE",
                    Price = 15m
                },
                new Drone
                {
                    Name = "MQ-9 Reaper",
                    Description = "U.S. Military C-UAV",
                    Category = "Male",
                    Price = 10m
                },
                new Drone
                {
                    Name = "Kronshtadt Orion (Orion)",
                    Description = "Russian  Military C-UAV",
                    Category = "HALE",
                    Price = 9m
                }

               );
                context.SaveChanges();
            }
        }

    }
}
