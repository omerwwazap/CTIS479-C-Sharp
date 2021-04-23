using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeventDurdali_HW2.ViewModels
{
    public class PageingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurentPage { get; set; }
        public int TotalPage => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
