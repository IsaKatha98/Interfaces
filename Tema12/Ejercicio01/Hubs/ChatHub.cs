using Microsoft.AspNetCore.SignalR;
using Models;
using System.Runtime.InteropServices.Marshalling;

namespace Ejercicio01.Hubs
{
    public class ChatHub: Hub
    {
        //inicializamos un objeto.
        clsMensajeUsuario oMensajeUsuario = new clsMensajeUsuario();
        public async Task SendMessage ( clsMensajeUsuario oMensajeUsuario )
        {
            await Clients.All.SendAsync("ReceiveMessage", oMensajeUsuario);
        }
    }
}
