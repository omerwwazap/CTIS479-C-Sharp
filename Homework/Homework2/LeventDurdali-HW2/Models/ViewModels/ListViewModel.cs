using System.Collections.Generic;

namespace LeventDurdali_HW2.Models.ViewModels
{
    public class ListViewModel
    {
        public IEnumerable<Drone> Drones { get; set; }
        public IEnumerable<Helicopter> Helicopters { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}