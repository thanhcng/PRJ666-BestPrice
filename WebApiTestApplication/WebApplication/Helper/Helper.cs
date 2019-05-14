using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace WebApplication.Helper
{
    public class WeatherAPI
    {
        public HttpClient Initial()
        {
            var Client = new HttpClient();
            Client.BaseAddress = new Uri("https://samples.openweathermap.org");
            return Client;
        }
    }
}
