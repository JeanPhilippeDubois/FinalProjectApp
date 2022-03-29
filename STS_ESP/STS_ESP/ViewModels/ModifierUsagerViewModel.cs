using STS_ESP.Helpers;
using STS_ESP.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace STS_ESP.ViewModels
{
    /// <summary>
    /// ViewModel de la page ModifyUsager.xaml
    /// </summary>
    public class ModifierUsagerViewModel : INotifyPropertyChanged
    {

        public DBHelper dBHelper = new DBHelper();
        public ModifierUsagerViewModel(Usager us)
        {
            MainUsager = dBHelper.GetAnUsager(us.Id);
            button_ModifierUsager_Click = new CommandeRelais(Execute_Button_ModifierUsager_Click, CanExecute_Button_ModifierUsager_Click);
            NomComplet = MainUsager.NomComplet;
            Courriel = MainUsager.EmailAddress;
            NoTelephone = MainUsager.NoTelephone;
        }
        public ModifierUsagerViewModel()
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
        #endregion
        #region ICommand Bouttons
        private ICommand button_ModifierUsager_Click;
        public ICommand Button_ModifierUsager_Click
        {
            get { return button_ModifierUsager_Click; }
            set { button_ModifierUsager_Click = value; }
        }
        public void Execute_Button_ModifierUsager_Click(object parameter)
        {
            State = "";
            ObservableCollection<Usager> a = dBHelper.GetUsagerList();
            bool trouve = false;
            foreach (Usager i in a)
            {
                if (i.EmailAddress.Contains(Courriel) && MainUsager.EmailAddress != Courriel)
                {
                    trouve = true;
                }
            }

            if (trouve == false)
            {
                if (Courriel == "" || NomComplet == "" || NoTelephone == "")
                {
                    State = "Remplissez les champs";
                }
                else
                {
                    if (DBHelper.IsValidEmail(Courriel) != true || DBHelper.isValidPhoneNumber(NoTelephone) == "X")
                    {
                        State = "Courriel/Téléphone Invalide";
                    }
                    else
                    {
                        if (State != "Utilisateur déja existant" || State != "Courriel Invalide" || State != "Utilisateur déja existant")
                        {
                            try
                            {
                                MainUsager.NoTelephone = DBHelper.isValidPhoneNumber(NoTelephone);
                                MainUsager.NomComplet = NomComplet;
                                MainUsager.EmailAddress = Courriel;
                                bool result = dBHelper.EditUsager(MainUsager);
                                dBHelper.context.SaveChanges();
                                if (result != true)
                                {
                                    State = "Erreur lors de l'ajour de l'usager";
                                }
                                else
                                {
                                    State = "Usager modifié !";
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
            else
            {
                State = "Courriel déja existant";
            }

        }
        public bool CanExecute_Button_ModifierUsager_Click(object parameter)
        {
            return true;
        }
        #endregion
        ///
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
