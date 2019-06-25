using Microsoft.AspNetCore.SignalR;
using SignalRCounter.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SignalRCounter
{
    public class BackgroundThread
    {
        private static Boolean bStopThreadLoop = false;

        private static IHubContext<CounterHub> hubcontext;

        private static int aCounter;

        public static void MainLoop()
        {
            hubcontext = null;
            aCounter = 0;
            while(bStopThreadLoop != true)
            {
                //Console.WriteLine("Working thread...");
                if (hubcontext != null)
                {
                    hubcontext.Clients.All.SendAsync("ReceiveMessage", aCounter.ToString());
                    aCounter++;
                }
                Thread.Sleep(1000);
            }
        }

        public static void StopThread()
        {
            bStopThreadLoop = true;
        }

        public static void SetHub(IHubContext<CounterHub> hub)
        {
            hubcontext = hub;
        }
    }
}
