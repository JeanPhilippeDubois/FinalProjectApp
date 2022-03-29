using STS_ESP.Models;
using STS_ESP.Pages;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace STS_ESP.ViewModels
{

    /// <summary>
    /// ViewModel de la page MenuWindow.xaml
    /// </summary>
    class MenuViewModel : INotifyPropertyChanged
    {

        public MenuViewModel()
        {
            button_Billet_Click = new CommandeRelais(Execute_Button_Billet_Click, CanExecute_Button_Billet_Click);
            button_Compte_Click = new CommandeRelais(Execute_Button_Compte_Click, CanExecute_Button_Compte_Click);
            button_Employer_Click = new CommandeRelais(Execute_Button_Employer_Click, CanExecute_Button_Employer_Click);
            button_Rapport_Click = new CommandeRelais(Execute_Button_Rapport_Click, CanExecute_Button_Rapport_Click);
            button_Usager_Click = new CommandeRelais(Execute_Button_Usager_Click, CanExecute_Button_Usager_Click);
        }

        public MenuViewModel(Employe employe)
        {
            CurrentPage = new UsersList();
            CurrentPage.DataContext = new UsersListViewModel();
            _currentUser = employe;
            if (_currentUser.Role != "Administrateur")
            {
                Visibility = Visibility.Hidden;
            }
            button_Billet_Click = new CommandeRelais(Execute_Button_Billet_Click, CanExecute_Button_Billet_Click);
            button_Compte_Click = new CommandeRelais(Execute_Button_Compte_Click, CanExecute_Button_Compte_Click);
            button_Employer_Click = new CommandeRelais(Execute_Button_Employer_Click, CanExecute_Button_Employer_Click);
            button_Rapport_Click = new CommandeRelais(Execute_Button_Rapport_Click, CanExecute_Button_Rapport_Click);
            button_Usager_Click = new CommandeRelais(Execute_Button_Usager_Click, CanExecute_Button_Usager_Click);
        }
        #region attributs
        private Employe _currentUser;
        public Employe CurrentUser
        {
            get { return _currentUser; }
            set
            {
                if (_currentUser == value)
                    return;

                _currentUser = value;
                OnPropertyChanged("CurrentUser");
            }
        }

        private Visibility visibility;
        public Visibility Visibility
        {
            get { return visibility; }
            set
            {
                visibility = value;
                OnPropertyChanged("Visibility");
            }
        }


        private Page _currentPage;
        public Page CurrentPage
        {
            get { return _currentPage; }
            set
            {
                if (_currentPage == value)
                    return;

                _currentPage = value;
                OnPropertyChanged("CurrentPage");
            }
        }
        #endregion
        #region boutons
        private ICommand button_Compte_Click;
        public ICommand Button_Compte_Click
        {
            get { return button_Compte_Click; }
            set { button_Compte_Click = value; }
        }
        public void Execute_Button_Compte_Click(object parameter)
        {
            CurrentPage = new ModifierCompte();
            CurrentPage.DataContext = new ModifierCompteViewModel(_currentUser);
        }
        public bool CanExecute_Button_Compte_Click(object parameter)
        {
            return true;
        }

        private ICommand button_Rapport_Click;
        public ICommand Button_Rapport_Click
        {
            get { return button_Rapport_Click; }
            set { button_Rapport_Click = value; }
        }
        public void Execute_Button_Rapport_Click(object parameter)
        {
            CurrentPage = new Reports();
            CurrentPage.DataContext = new ReportsViewModel();
            ;
        }
        public bool CanExecute_Button_Rapport_Click(object parameter)
        {
            return true;
        }

        private ICommand button_Employer_Click;
        public ICommand Button_Employer_Click
        {
            get { return button_Employer_Click; }
            set { button_Employer_Click = value; }
        }
        public void Execute_Button_Employer_Click(object parameter)
        {
            CurrentPage = new EmployeList();
            CurrentPage.DataContext = new EmployeListViewModel();
        }
        public bool CanExecute_Button_Employer_Click(object parameter)
        {
            return true;
        }

        private ICommand button_Billet_Click;
        public ICommand Button_Billet_Click
        {
            get { return button_Billet_Click; }
            set { button_Billet_Click = value; }
        }
        public void Execute_Button_Billet_Click(object parameter)
        {

            CurrentPage = new SellTickets();
            CurrentPage.DataContext = new SellTicketsViewModel();

        }
        public bool CanExecute_Button_Billet_Click(object parameter)
        {
            return true;
        }


        private ICommand button_Usager_Click;
        public ICommand Button_Usager_Click
        {
            get { return button_Usager_Click; }
            set { button_Usager_Click = value; }
        }
        public void Execute_Button_Usager_Click(object parameter)
        {

            CurrentPage = new UsersList();
            CurrentPage.DataContext = new UsersListViewModel();

        }
        public bool CanExecute_Button_Usager_Click(object parameter)
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
