using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SignalRCounter
{
    public class Program
    {
        public static Thread aThread;

        public static void Main(string[] args)
        {
            aThread = new Thread(BackgroundThread.MainLoop);
            aThread.Start();
            CreateWebHostBuilder(args).Build().Run();
            BackgroundThread.StopThread();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
