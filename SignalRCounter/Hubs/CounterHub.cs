using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRCounter.Hubs
{
    public class CounterHub : Hub
    {
        public async Task SendMessage(int number)
        {
            await Clients.All.SendAsync("ReceiveMessage", number.ToString());
        }
    }
}
