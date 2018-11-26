using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ExchangeRates.Client.Helpers;
using ExchangeRates.Client.Models;

namespace ExchangeRates.Client.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult  Index()
        {
            var PVM = new HomePageViewModel { SetValue = 1 };
            return View(PVM);
        }
    }
}