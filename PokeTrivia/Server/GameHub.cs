using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Entities;

namespace Server
{
    public class GameHub: Hub

    {
        
        public async Task MandaCliente(string player)
        {
            Console.WriteLine(player);
            //esto se supone que recibe el nombre del otro jugador.
            await Clients.Others.SendAsync("RecibeCliente", player);
        }

     


    }
}
