using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeventDurdali_HW2.Components
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedItem = 1;
            List<string> footerStringMSG = new List<string>() { "The Project was made by Levent Durdalı - 21702600" };
            return View(footerStringMSG);
        }
    }
}
