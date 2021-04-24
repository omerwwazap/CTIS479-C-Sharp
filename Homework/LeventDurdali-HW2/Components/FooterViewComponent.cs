using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// This ViewComponent is used for adding a "Footer" the website
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