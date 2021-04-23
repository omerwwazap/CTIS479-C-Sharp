using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeventDurdali_HW2.Models
{
    public class EFHelicopterRepository : IHelicopterRepository
    {
        private DroneDBContext _context;
        public EFHelicopterRepository(DroneDBContext context)
        {
            _context = context;
        }
        //public IQueryable<Drone> Drones => _context.Drones;

        public IQueryable<Helicopter> Helicopters => _context.Helicopters;
    }
}
