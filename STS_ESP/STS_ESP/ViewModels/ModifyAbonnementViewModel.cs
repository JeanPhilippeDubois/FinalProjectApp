using STS_ESP.Helpers;
using STS_ESP.Models;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace STS_ESP.ViewModels
{
    /// <summary>
    /// ViewModel de la page ModifyAbonnement.xaml
    /// </summary>
    class ModifyAbonnementViewModel : INotifyPropertyChanged
    {

        public DBHelper dBHelper = new DBHelper();
        public ModifyAbonnementViewModel(Usager us)
        {
            usActuel = us;
            aboActuel = us.Carte.Abo.Type;
            button_Ajouter_Click = new CommandeRelais(Execute_Button_Ajouter_Click, CanExecute_Button_Ajouter_Click);
            button_Supprimer_Click = new CommandeRelais(Execute_Button_Supprimer_Click, CanExecute_Button_Supprimer_Click);
        }

        public ModifyAbonnementViewModel()
        {

        }
        #region attributs
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

        private Usager usActuel;
        public Usager UsActuel
        {
            get { return usActuel; }
            set
            {
                usActuel = value;
                OnPropertyChanged("UsActuel");
            }
        }



        private string aboActuel;
        public string AboActuel
        {
            get { return aboActuel; }
            set
            {
                aboActuel = value;
                OnPropertyChanged("AboActuel");
            }
        }

        private string aboNew;
        public string AboNew
        {
            get { return aboNew; }
            set
            {
                aboNew = value;
                OnPropertyChanged("AboNew");
            }
        }
        #endregion
        #region ICommand Bouttons
        private ICommand button_Supprimer_Click;
        public ICommand Button_Supprimer_Click
        {
            get { return button_Supprimer_Click; }
            set { button_Supprimer_Click = value; }
        }
        public void Execute_Button_Supprimer_Click(object parameter)
        {
            try
            {
                usActuel.Carte.Abo.Type = "Aucun";
                usActuel.Carte.Abo.DateFin = DateTime.Now;
                usActuel.Carte.Abo.Prix = 0.00;
                AboActuel = "Aucun";
                dBHelper.EditUsager(UsActuel);
                State = "Changements effectué";
            }
            catch
            {
                State = "Erreur";
            }
        }
        public bool CanExecute_Button_Supprimer_Click(object parameter)
        {
            if (AboActuel != "Aucun")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private ICommand button_Ajouter_Click;
        public ICommand Button_Ajouter_Click
        {
            get { return button_Ajouter_Click; }
            set { button_Ajouter_Click = value; }
        }
        public void Execute_Button_Ajouter_Click(object parameter)
        {
            try
            {
                string newAbo = AboNew.Remove(0, 38);
                usActuel.Carte.Abo.Type = newAbo;
                usActuel.Carte.Abo.Prix = dBHelper.AboToValeur(newAbo);
                usActuel.Carte.Abo.DateDebut = DateTime.Now;
                usActuel.Carte.Abo.DateFin = dBHelper.AboToLength(newAbo);
                Transaction newTrans = new Transaction(usActuel.Id, 0, DateTime.Now, dBHelper.AboToValeur(newAbo), "0");
                dBHelper.AddTransaction(newTrans);
                dBHelper.EditUsager(usActuel);
                dBHelper.context.SaveChanges();
                State = "Changements effectué";
            }
            catch
            {
                State = "Erreur";
            }

        }
        public bool CanExecute_Button_Ajouter_Click(object parameter)
        {
            if (AboNew != null)
            {
                return true;
            }
            else
            {
                return false;
            }
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
