using STS_ESP.Helpers;
using STS_ESP.Models;
using System.ComponentModel;
using System.Security;
using System.Windows.Input;

namespace STS_ESP.ViewModels
{
    /// <summary>
    /// ViewModel de la page LogginWindow.xaml
    /// </summary>
    class LoggingWindowViewModel : INotifyPropertyChanged
    {
        public DBHelper dBHelper = new DBHelper();

        public LoggingWindowViewModel()
        {
            Button_Login_Click = new CommandeRelais(Execute_Button_Login_Click, CanExecute_Button_Login_Click);
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

        private string accountName;
        public string AccountName
        {
            get { return accountName; }
            set
            {
                accountName = value;
                OnPropertyChanged("AccountName");
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
        #endregion
        #region bouttons
        /// <summary>
        /// Commandes pour l'éxécution du boutton de l'ouverture du menu
        /// </summary>
        private ICommand button_Login_Click;
        public ICommand Button_Login_Click
        {
            get { return button_Login_Click; }
            set { button_Login_Click = value; }
        }
        public void Execute_Button_Login_Click(object parameter)
        {
            MenuWindow a = new MenuWindow();

            if (AccountName == "" || SecuredAccPass == null)
            {
                State = "Remplissez tous les champs ...";
            }
            else
            {
                Employe emp = dBHelper.GetAnEmployeLogin(AccountName);

                if (emp != null)
                {

                    if (CryptographyHelper.ValidateHashedPassword(CryptographyHelper.SecureStringToString(SecuredAccPass), emp.Motdepasse) == true)
                    {

                        a.DataContext = new MenuViewModel(emp);
                        a.ShowDialog();
                    }
                    else
                    {
                        State = "Courriel/Mot de passe invalide...";
                    }
                }
                else
                {
                    State = "Courriel/Mot de passe invalide...";
                }


            }


        }
        public bool CanExecute_Button_Login_Click(object parameter)
        {

            if (AccountName == "" || SecuredAccPass == null)
            {
                return false;
            }
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
