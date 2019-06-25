using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRCounter.Hubs;
using SignalRCounter.Models;

namespace SignalRCounter.Controllers
{
    public class HomeController : Controller
    {
        public int aNumber = 0;

        public HomeController(IHubContext<CounterHub> hubcontext)
        {
            BackgroundThread.SetHub(hubcontext);
        }

        private IHubContext<CounterHub> HubContext
        {
            get;
            set;
        }

        public IActionResult Index()
        {
            return View();
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
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            
        }
    }
}
