using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BestPrice.Models;

namespace BestPrice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult ReportIssue()
        {
            return View();
        }

        public IActionResult HelpCentre()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
