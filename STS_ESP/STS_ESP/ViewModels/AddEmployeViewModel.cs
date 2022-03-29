using STS_ESP.Helpers;
using STS_ESP.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Security;
using System.Windows.Input;

namespace STS_ESP.ViewModels
{
    /// <summary>
    /// ViewModel de la page AddEmploye.xaml
    /// </summary>
    class AddEmployeViewModel : INotifyPropertyChanged
    {
        public AddEmployeViewModel()
        {
            button_AddEmploye_Click = new CommandeRelais(Execute_Button_AddEmploye_Click, CanExecute_Button_AddUsager_Click);
        }

        public DBHelper dBHelper = new DBHelper();

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
        #endregion

        #region boutons
        private ICommand button_AddEmploye_Click;
        public ICommand Button_AddEmploye_Click
        {
            get { return button_AddEmploye_Click; }
            set { button_AddEmploye_Click = value; }
        }



        public void Execute_Button_AddEmploye_Click(object parameter)
        {
            ObservableCollection<Employe> comp = dBHelper.GetEmployeList();
            bool trouve = false;


            foreach (Employe e in comp)
            {
                if (e.EmailAddress == Courriel || e.Username == Username)
                {
                    trouve = true;
                }
            }


            if (trouve == true)
            {
                State = "Employé déja existant";
            }
            else
            {
                if (NomComplet == "" || Courriel == "" || NoTelephone == "" || Username == "" || NomComplet == "" || SecuredAccPass.Length == 0)
                {
                    State = "Remmplissez tous les champs";
                }
                else
                {
                    if (DBHelper.IsValidEmail(Courriel) == false || SecuredAccPass.Length < 7 || DBHelper.isValidPhoneNumber(NoTelephone) == "X")
                    {
                        State = "Courriel/Téléphone/Mot de passe invalide";
                    }
                    else
                    {
                        try
                        {
                            Role = Role.Remove(0, 38);
                            Statut = Statut.Remove(0, 38);
                            string password = CryptographyHelper.HashPassword(CryptographyHelper.SecureStringToString(SecuredAccPass));
                            Employe newEmp = new Employe(Role, Courriel, NomComplet, Username, DBHelper.isValidPhoneNumber(NoTelephone), Statut, password);
                            dBHelper.AddEmploye(newEmp);
                            State = "Employé ajouté";
                            Role = "";
                            Courriel = "";
                            NomComplet = "";
                            Username = "";
                            NoTelephone = "";
                            Statut = "";
                            SecuredAccPass.Clear();
                        }
                        catch
                        {
                            State = "Erreur lors de l'ajout de l'employé";
                        }
                    }
                }
            }
        }



        public bool CanExecute_Button_AddUsager_Click(object parameter)
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
