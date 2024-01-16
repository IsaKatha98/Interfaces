using Microsoft.AspNetCore.SignalR;
using Models;

namespace Ejercicio01_ASP.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(clsMensajeUsuario mensajeU)
        {
            await Clients.All.SendAsync("ReceiveMessage", mensajeU);
        }
    }
}
