using STS_ESP.Helpers;
using STS_ESP.Models;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace STS_ESP.ViewModels
{
    /// <summary>
    /// ViewModel de la page ModifyBalance.xaml
    /// </summary>
    class ModifyBalanceViewModel : INotifyPropertyChanged
    {

        public DBHelper dBHelper = new DBHelper();
        public ModifyBalanceViewModel(Usager us)
        {
            button_Modifier_Click = new CommandeRelais(Execute_Button_Modifier_Click, CanExecute_Button_Modifier_Click);
            mainUsager = us;
            balanceActuel = String.Format("{0:0.00}", Math.Round(mainUsager.Carte.Balance, 2));

            balanceNew = "0.00";
        }
        public ModifyBalanceViewModel()
        {

        }
        #region attributs
        private Usager mainUsager;
        public Usager MainUsager
        {
            get { return mainUsager; }
            set
            {
                mainUsager = value;
                OnPropertyChanged("MainUsager");
            }
        }

        private string state;
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                OnPropertyChanged("State");
            }
        }
        private string balanceActuel;
        public string BalanceActuel
        {
            get { return balanceActuel; }
            set
            {
                balanceActuel = value;
                OnPropertyChanged("BalanceActuel");
            }
        }


        private string balanceNew;
        public string BalanceNew
        {
            get { return balanceNew; }
            set
            {
                balanceNew = value;
                OnPropertyChanged("BalanceActuel");
            }
        }

        #endregion
        #region ICommand Bouttons
        private ICommand button_Modifier_Click;
        public ICommand Button_Modifier_Click
        {
            get { return button_Modifier_Click; }
            set { button_Modifier_Click = value; }
        }
        public void Execute_Button_Modifier_Click(object parameter)
        {
            if (double.TryParse(balanceNew, out double result) == true)
            {
                double diff = result - MainUsager.Carte.Balance;
                Transaction transaction = new Transaction(MainUsager.Id, 0, DateTime.Now, diff, "0");
                MainUsager.Carte.Balance = result;
                if (dBHelper.EditUsager(MainUsager) == true && dBHelper.AddTransaction(transaction) == true)
                {
                    State = "Changements effectués";
                }
                else
                {
                    State = "Erreur MySQL";
                }

            }
            else
            {
                State = "Entrez un chiffre compatible (X.XX)";
            }

        }
        public bool CanExecute_Button_Modifier_Click(object parameter)
        {
            return true;
        }
        #endregion
        /// <summary>
        /// Interface used to handle property changed events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
