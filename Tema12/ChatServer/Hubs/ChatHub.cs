using Microsoft.AspNetCore.SignalR;
using System.Runtime.InteropServices.Marshalling;

namespace ChatServer.Hubs
{
    public class ChatHub: Hub
    {

        public async Task SendMessage(string message)
        {
            Console.WriteLine(message);
            await Clients.All.SendAsync("MessageReceived", message);
        }
    }
}
