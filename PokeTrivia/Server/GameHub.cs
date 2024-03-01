using Microsoft.AspNetCore.SignalR;

namespace Server
{
    public class GameHub: Hub
    {
       public async Task PlayerConnected(clsPlayer player)
        {
            await Groups
                .AddToGroupAsync(Context.ConnectionId, player.GroupName);
            await Clients
                .All
                .SendAsync("PlayerConnected", player);
        }

        public async Task SessionStarted(SessionStarted session)
        {
            await Clients
                .Group(session.GroupName)
                .SendAsync("SessionStarted", session);
        }

        //a partir de aquí empezamos a improvisar
        public async Task UpdateAnswer(Answer answer)
        {
            await Clients
                .OthersInGroup(answer.GroupName)
                .SendAsync("UpdateAnswer", answer);
        }


    }
}
