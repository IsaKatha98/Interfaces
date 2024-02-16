using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using PokeTrivia.UI.VM.Utils;
using PokeTrivia.UI.Views;

namespace PokeTrivia.UI.VM
{
    public class IndexVM : clsVMBase
    {
        #region atributes
        string name;
        clsPlayer player;
        DelegateCommand btnStart;
        #endregion

        #region constructors
        public IndexVM()
        {
            name = string.Empty;
            btnStart = new DelegateCommand(startCommandExecute);

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
            //we construct a player
            player = new clsPlayer(name);

            //this will take us to the next view
            await Shell.Current.Navigation.PushAsync(new GamePlay(player));
        }
        #endregion
    }

}
