using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VaalBHCS.Web.Areas.BoatLockers.Controllers
{
    [Area("BoatLockers")]
    public class BoatLockerController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddNewBoatlocker()
        {
            return View();
        }
    }
}