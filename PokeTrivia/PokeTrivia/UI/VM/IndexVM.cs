using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using PokeTrivia.UI.VM.Utils;
using PokeTrivia.UI.Views;
using Microsoft.AspNetCore.SignalR.Client;

namespace PokeTrivia.UI.VM
{
    public class IndexVM : clsVMBase
    {
        #region atributes
        string name;
        clsPlayer player1;
        clsPlayer player2;
        DelegateCommand btnStart;

        private readonly HubConnection conn;

        #endregion

        #region constructors
        public IndexVM()
        {
            name = string.Empty;
            btnStart = new DelegateCommand(startCommandExecute);

            //Establecemos la conexión con el servidor.
            conn = new HubConnectionBuilder().WithUrl("http://localhost:5250/game").Build();

        }
        #endregion

        #region properties
        public string Name
        {
            get { return name; }
            set { name = value;
                NotifyPropertyChanged("Name");
                btnStart.RaiseCanExecuteChanged();
            }
        }

        public clsPlayer Player1
        {
            get { return player1; }
        }

        public DelegateCommand BtnStart
        {
            get { return btnStart; }

        }

        #endregion

        #region commands
        /*
        private bool startCommandCanExecute()
        {
            bool canStart = false;
            if (!string.IsNullOrEmpty(name))
            {
                canStart = true;
            }
            return canStart;
        }*/

        private async void startCommandExecute()
        {
            //we construct two players
            player1 = new clsPlayer(name);

            player2= new clsPlayer();   


            GamePlayVM vm = new GamePlayVM(player1, player2);

            //conexión con el servidor
            conn.StartAsync();

            //notificamos al servidor del nombre
            await conn.InvokeCoreAsync("ConectaCliente", new object[] {player2 });

            //this will take us to the next view
            await Shell.Current.Navigation.PushAsync(new GamePlay(vm));

            

            
        }
        #endregion
    }

}
