using Microsoft.AspNetCore.SignalR;
using Models;
using System.Runtime.InteropServices.Marshalling;

namespace Ejercicio01.Hubs
{
    public class ChatHub: Hub
    {
       
        public async Task SendMessage ( clsMensajeUsuario objMensajeUsuario )
        {
            await Clients.All.SendAsync("ReceiveMessage", objMensajeUsuario);
        }
    }
}
