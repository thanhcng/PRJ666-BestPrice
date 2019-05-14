using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebApplication.Helper;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        WeatherAPI _api = new WeatherAPI();

        public async Task<IActionResult> Index()
        {
            City city = null;
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("data/2.5/forecast?id=524901&appid=b1b15e88fa797225412429c1c50c122a1");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                JObject joResponse = JObject.Parse(result);
                JObject cityJObject = (JObject) joResponse["city"];
                city = JsonConvert.DeserializeObject<City>(cityJObject.ToString(Formatting.None));
            }

            return View(city);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
