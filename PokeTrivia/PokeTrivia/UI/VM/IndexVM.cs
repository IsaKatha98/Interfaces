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
        clsPlayer player;
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

        public clsPlayer Player
        {
            get { return player; }
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
            
            player = new clsPlayer(name);

            WaitingVM vm = new WaitingVM(player);

            //conexión con el servidor
            await conn.StartAsync();

            //notificamos al servidor del nombre
            await conn.InvokeCoreAsync("MandaCliente", new[] {player.Name});

            //this will take us to the next view
            await Shell.Current.Navigation.PushAsync(new Waiting(vm));

            

            
        }
        #endregion
    }

}
