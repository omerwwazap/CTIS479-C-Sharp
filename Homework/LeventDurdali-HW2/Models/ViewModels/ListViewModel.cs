using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeventDurdali_HW2.Models.ViewModels
{
    public class ListViewModel
    {
        public IEnumerable<Drone> Drones { get; set; }
        public IEnumerable<Helicopter> Helicopters { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}
