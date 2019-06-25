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
            //Create do controller
            //Pega o CounterHub
            HubContext = hubcontext;
            //Cria um novo handler para o evento de timer e remove o antigo se houver
            System.Timers.ElapsedEventHandler aHandler = (sender, e) => { this.HubContext.Clients.All.SendAsync("ReceiveMessage", aNumber.ToString()); aNumber++; };
            Program.aTimer.Elapsed -= Program.aLastHandler;
            Program.aTimer.Elapsed += aHandler;
            Program.aLastHandler = aHandler;
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
