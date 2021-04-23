using LeventDurdali_HW2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeventDurdali_HW2.ViewModels
{
    public class ListViewModel
    {
        public IEnumerable<Drone> Drones { get; set; }
        public IEnumerable<Helicopter> Helicopters { get; set; }

        public PageingInfo PagingInfo { get; set; }
    }
}
