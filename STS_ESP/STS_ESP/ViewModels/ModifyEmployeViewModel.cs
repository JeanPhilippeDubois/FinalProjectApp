using STS_ESP.Helpers;
using STS_ESP.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Security;
using System.Windows.Input;

namespace STS_ESP.ViewModels
{
    /// <summary>
    /// ViewModel de la page ModifyEmploye.xaml
    /// </summary>
    public class ModifyEmployeViewModel : INotifyPropertyChanged
    {

        public DBHelper dBHelper = new DBHelper();

        public ModifyEmployeViewModel()
        {

        }


        public ModifyEmployeViewModel(Employe e)
        {
            button_ModifierEmploye_Click = new CommandeRelais(Execute_Button_ModifierEmploye_Click, CanExecute_Button_ModifierUsager_Click);
            MainEmploye = dBHelper.GetAnEmploye(e.Id);
            nomComplet = MainEmploye.NomComplet;
            username = MainEmploye.Username;
            noTelephone = MainEmploye.NoTelephone;
            courriel = MainEmploye.EmailAddress;
            role = MainEmploye.Role;
            statut = MainEmploye.StatutCompte;
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

        private Employe mainEmploye;
        public Employe MainEmploye
        {
            get { return mainEmploye; }
            set
            {
                mainEmploye = value;
                OnPropertyChanged("MainEmploye");
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

        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }

        private SecureString securedAccPass;
        public SecureString SecuredAccPass
        {
            get { return securedAccPass; }
            set
            {
                securedAccPass = value;
                OnPropertyChanged("SecuredAccPass");
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

        private string statut;
        public string Statut
        {
            get { return statut; }
            set
            {
                statut = value;
                OnPropertyChanged("Statut");
            }
        }

        private string role;
        public string Role
        {
            get { return role; }
            set
            {
                role = value;
                OnPropertyChanged("Role");
            }
        }


        private string statutChoice;
        public string StatutChoice
        {
            get { return statutChoice; }
            set
            {
                statutChoice = value;
                OnPropertyChanged("StatutChoice");
            }
        }

        private string roleChoice;
        public string RoleChoice
        {
            get { return roleChoice; }
            set
            {
                roleChoice = value;
                OnPropertyChanged("RoleChoice");
            }
        }
        #endregion
        #region ICommand Bouttons
        private ICommand button_ModifierEmploye_Click;
        public ICommand Button_ModifierEmploye_Click
        {
            get { return button_ModifierEmploye_Click; }
            set { button_ModifierEmploye_Click = value; }
        }
        public void Execute_Button_ModifierEmploye_Click(object parameter)
        {
            ObservableCollection<Employe> a = dBHelper.GetEmployeList();
            bool trouve = false;
            if (MainEmploye.EmailAddress != Courriel)
            {
                foreach (Employe i in a)
                {
                    if (i.EmailAddress == Courriel)
                    {
                        trouve = true;
                    }
                }
            }
            if (MainEmploye.Username != Username)
            {
                foreach (Employe i in a)
                {
                    if (i.Username == Username)
                    {
                        trouve = true;
                    }
                }
            }


            if (trouve == false)
            {
                if (Courriel == "" || Role == "" || Statut == "" || NomComplet == "" || NoTelephone == "" || Username == "")
                {
                    State = "Remplissez tous les champs";
                }
                else
                {

                    if (DBHelper.IsValidEmail(Courriel) != true || DBHelper.isValidPhoneNumber(NoTelephone) == "X")
                    {
                        State = "Courriel/Téléphone Invalide";
                    }
                    else
                    {

                        if (SecuredAccPass != null && CryptographyHelper.HashPassword(CryptographyHelper.SecureStringToString(SecuredAccPass)) != MainEmploye.Motdepasse)
                        {

                            if (SecuredAccPass.Length < 7)
                            {
                                State = "Mot de passe pas assez long";
                            }
                            else
                            {
                                MainEmploye.Motdepasse = CryptographyHelper.HashPassword(CryptographyHelper.SecureStringToString(SecuredAccPass));
                            }
                        }


                        try
                        {
                            MainEmploye.NomComplet = NomComplet;
                            MainEmploye.NoTelephone = DBHelper.isValidPhoneNumber(NoTelephone);
                            MainEmploye.NomComplet = NomComplet;
                            MainEmploye.Role = Role.ToString();
                            MainEmploye.StatutCompte = Statut;
                            MainEmploye.Username = Username;


                            if (dBHelper.EditEmploye(MainEmploye) != false)
                            {
                                State = "Utilisateur modifié";
                            }
                            else
                            {
                                State = "Erreur SQL";
                            }
                        }
                        catch
                        {
                            State = "Erreur SQL";
                        }



                    }
                }
            }
            else
            {
                State = "Utilisateur déja existant";
            }

        }
        public bool CanExecute_Button_ModifierUsager_Click(object parameter)
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
