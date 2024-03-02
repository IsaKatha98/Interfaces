using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Entities;

namespace Server
{
    public class GameHub: Hub

    {
        
        public async Task ConectaCliente(clsPlayer player)
        {
            Console.WriteLine(player.Name);
            //esto se supone que recibe el nombre del otro jugador.
            await Clients.All.SendAsync("ConectaCliente", player);
        }

      public async Task NotificarRespuesta (int idRespuesta)
        {
            await Clients.All.SendAsync("NotificarRespuesta", idRespuesta);
        }

        public async Task NotificarGanador (clsPlayer player)
        {
            await Clients.All.SendAsync("NotificarGanador", player);
        }

        public async Task ReiniciarPartida()
        {
            await Clients.All.SendAsync("ReiniciarPartida");
        }


    }
}
