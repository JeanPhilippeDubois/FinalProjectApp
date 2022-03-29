using STS_ESP.Helpers;
using STS_ESP.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace STS_ESP.ViewModels
{
    /// <summary>
    /// ViewModel de la page AddUsager.xaml
    /// </summary>
    class AddUsagerViewModel : INotifyPropertyChanged
    {
        DBHelper dB = new DBHelper();
        public AddUsagerViewModel()
        {
            State = "";
            button_AddUsager_Click = new CommandeRelais(Execute_Button_AddUsager_Click, CanExecute_Button_AddUsager_Click);
        }

        #region attributs
        private string nomComplet;
        public string NomComplet
        {
            get { return nomComplet; }
            set
            {
                nomComplet = value;
                OnPropertyChanged("NomComplet");
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

        private string courriel;
        public string Courriel
        {
            get { return courriel; }
            set
            {
                courriel = value;
                OnPropertyChanged("Courriel");
            }
        }

        private string noTelephone;
        public string NoTelephone
        {
            get { return noTelephone; }
            set
            {
                noTelephone = value;
                OnPropertyChanged("NoTelephone");
            }
        }

        private string typeAbonnement;
        public string TypeAbonnement
        {
            get { return typeAbonnement; }
            set
            {
                typeAbonnement = value;
                OnPropertyChanged("TypeAbonnement");
            }
        }
        #endregion
        #region boutons
        /// <summary>
        /// Commandes pour l'éxécution du boutton de l'ouverture du menu
        /// </summary>
        private ICommand button_AddUsager_Click;
        public ICommand Button_AddUsager_Click
        {
            get { return button_AddUsager_Click; }
            set { button_AddUsager_Click = value; }
        }
        public void Execute_Button_AddUsager_Click(object parameter)
        {
            State = "";
            ObservableCollection<Usager> a = dB.GetUsagerList();
            bool trouve = false;
            foreach (Usager i in a)
            {
                if (i.EmailAddress.Contains(Courriel))
                {
                    trouve = true;
                }
            }

            if (trouve != false)
            {
                State = "Utilisateur déja existant";
            }
            else
            {
                if (Courriel == "" || NomComplet == "" || NoTelephone == "")
                {
                    State = "Remplissez les champs";
                }
                else
                {
                    if (DBHelper.IsValidEmail(Courriel) != true || DBHelper.isValidPhoneNumber(NoTelephone) == "X")
                    {
                        State = "Courriel/Téléphone invalide";
                    }
                    else
                    {
                        if (State != "Courriel Invalide" || State != "Remplissez les champs" || State != "Utilisateur déja existant")
                        {
                            try
                            {
                                TypeAbonnement = TypeAbonnement.Remove(0, 38);
                                Abonnement newAbo = new Abonnement(TypeAbonnement, dB.AboToValeur(TypeAbonnement), DateTime.Now, dB.AboToLength(TypeAbonnement));
                                CarteUsager newCarte = new CarteUsager(dB.GenerateRandomString(24), 0, newAbo);
                                Usager newUsager = new Usager(Courriel, NomComplet, DBHelper.isValidPhoneNumber(NoTelephone), "Actif", newCarte);
                                bool result = dB.AddUsager(newUsager);

                                if (result != true)
                                {
                                    State = "Erreur lors de l'ajour de l'usager";
                                }
                                else
                                {
                                    State = "Usager ajouté !";
                                    Courriel = "";
                                    NomComplet = "";
                                    NoTelephone = "";
                                    TypeAbonnement = "";

                                }
                            }
                            catch
                            {
                                State = "Erreur lors de l'ajour de l'usager";
                            }
                        }
                    }
                }
            }










        }
        public bool CanExecute_Button_AddUsager_Click(object parameter)
        {
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion


    }
}
