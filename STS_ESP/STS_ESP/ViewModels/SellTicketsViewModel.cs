using STS_ESP.Helpers;
using STS_ESP.Models;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace STS_ESP.ViewModels
{
    /// <summary>
    /// VieWModel de la page SellTickets.xaml
    /// </summary>
    class SellTicketsViewModel : INotifyPropertyChanged
    {
        public DBHelper dBHelper = new DBHelper();

        public SellTicketsViewModel()
        {
            button_VenteBillet_Click = new CommandeRelais(Execute_Button_VenteBillet_Click, CanExecute_Button_VenteBillet_Click);
        }
        #region attributs
        private string choixBillet;
        public string ChoixBillet
        {
            get { return choixBillet; }
            set
            {
                choixBillet = value;
                OnPropertyChanged("ChoixBillet");
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
        #endregion
        #region ICommand Bouttons
        private ICommand button_VenteBillet_Click;
        public ICommand Button_VenteBillet_Click
        {
            get { return button_VenteBillet_Click; }
            set { button_VenteBillet_Click = value; }
        }
        public void Execute_Button_VenteBillet_Click(object parameter)
        {

            if (ChoixBillet != null)
            {
                ChoixBillet = ChoixBillet.Remove(0, 38);
                double valeur = 0;

                switch (ChoixBillet)
                {
                    case "Unité - 3.35 $":
                        valeur = 3.35;
                        break;
                    case "Livret de 5 billets - 16,75 $":
                        valeur = 16.75;
                        break;
                    case "Livret de 12 billets - 40,20 $":
                        valeur = 40.20;
                        break;
                    default:
                        valeur = 0;
                        break;
                }
                MessageBoxButton buttons = MessageBoxButton.YesNo;
                const string message = "Voulez-vous vendre ce billet ?";
                string title = "Confirmation de la vente d'un billet";
                var result = MessageBox.Show(message, title, buttons);

                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        Transaction transaction = new Transaction(0, 0, DateTime.Now, valeur, "0");
                        dBHelper.AddTransaction(transaction);
                        State = "Billet vendu !";

                        ChoixBillet = null;
                    }
                    catch
                    {
                        State = "Erreur";
                    }
                }
            }
            else
            {
                State = "Choissisez un billet";
            }
        }
        public bool CanExecute_Button_VenteBillet_Click(object parameter)
        {
            return true;
        }
        #endregion
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
