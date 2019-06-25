using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SignalRCounter
{
    public class Program
    {
        public readonly static System.Timers.Timer aTimer = new System.Timers.Timer();
        public static System.Timers.ElapsedEventHandler aLastHandler;

        public static void Main(string[] args)
        {
            aTimer.Interval = 1000;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            aTimer.Elapsed += aLastHandler;

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
