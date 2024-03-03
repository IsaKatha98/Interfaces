using Entities;
using Microsoft.AspNetCore.SignalR.Client;
using PokeTrivia.UI.VM.Utils;
using PokeTrivia.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrivia.UI.VM
{
    public class WaitingVM:clsVMBase
    {
        private string srcGifWaiting;
        private string waitingForPlayer;
        private clsPlayer player;
        private string otherPlayer;

        private readonly HubConnection conn;

        private DelegateCommand lookForRival;

        public WaitingVM()
        {

        }
        public WaitingVM(clsPlayer player)
        {
            //Establecemos la conexión con el servidor.
            conn = new HubConnectionBuilder().WithUrl("http://localhost:5250/game").Build();

            this.player = player;

            waitingForPlayer = "";
            srcGifWaiting = "loading.gif";


            lookForRival = new DelegateCommand(lookCommandExecute);

        }

        #region properties

        public string SrcGifWaiting {  get { return srcGifWaiting; } }

        public string WaitingForPlayer { get {  return waitingForPlayer; } }

        public clsPlayer Player { get { return player; } }

        public string OtherPlayer { get { return otherPlayer; } }

        public HubConnection Conn { get { return conn; } }

        public DelegateCommand LookForRival {  get { return lookForRival; } }
        #endregion

        #region commands
        public void lookCommandExecute()
        {
            lookingForOtherPlayer();
        }
        #endregion

        #region functions

        public async void lookingForOtherPlayer()
        {
            await conn.StartAsync();
           

            conn.On<string>("RecibeCliente", (p) =>
            {
               
               otherPlayer = p;
               NotifyPropertyChanged(nameof(otherPlayer));

                waitingForPlayer = p;
                NotifyPropertyChanged(nameof(waitingForPlayer));
            });

          




        }

            
        public async void startGame()
        {
            GamePlayVM vm = new GamePlayVM(player, player);

            //this will take us to the next view
            await Shell.Current.Navigation.PushAsync(new GamePlay(vm));
        }
        #endregion
    }
}
