using STS_ESP.Helpers;
using STS_ESP.Models;
using STS_ESP.Windows;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace STS_ESP.ViewModels
{
    /// <summary>
    /// ViewModel de la page EmployeList.xaml
    /// </summary>
    class EmployeListViewModel : INotifyPropertyChanged
    {
        public DBHelper dbHelper = new DBHelper();
        public EmployeListViewModel()
        {
            ListEmploye = dbHelper.GetEmployeList();
            button_AjouterEmploye_Click = new CommandeRelais(Execute_Button_AjouterEmploye_Click, CanExecute_Button_AjouterEmploye_Click);
            button_ModifierEmploye_Click = new CommandeRelais(Execute_Button_ModifierEmploye_Click, CanExecute_Button_ModifierEmploye_Click);
            button_RechercheEmploye_Click = new CommandeRelais(Execute_Button_RechercheEmploye_Click, CanExecute_Button_RechercheEmploye_Click);
            button_SupprimerEmploye_Click = new CommandeRelais(Execute_Button_SupprimerEmploye_Click, CanExecute_Button_SupprimerEmploye_Click);
            button_Actualiser_Click = new CommandeRelais(Execute_Button_Actualiser_Click, CanExecute_Button_Actualiser_Click);
        }
        #region attributs

        private ObservableCollection<Employe> listEmploye;
        public ObservableCollection<Employe> ListEmploye
        {
            get { return listEmploye; }
            set
            {
                listEmploye = value;
                OnPropertyChanged("ListEmploye");
            }
        }

        private Employe selectEmploye;
        public Employe SelectEmploye
        {
            get { return selectEmploye; }
            set
            {
                selectEmploye = value;
                OnPropertyChanged("SelectEmploye");
            }
        }

        private string champRecherche;
        public string ChampRecherche
        {
            get { return champRecherche; }
            set
            {
                champRecherche = value;
                OnPropertyChanged("ChampRecherche");
            }
        }
        #endregion
        #region boutons

        private ICommand button_AjouterEmploye_Click;
        public ICommand Button_AjouterEmploye_Click
        {
            get { return button_AjouterEmploye_Click; }
            set { button_AjouterEmploye_Click = value; }
        }
        public void Execute_Button_AjouterEmploye_Click(object parameter)
        {
            AddEmploye newWindow = new AddEmploye();
            newWindow.DataContext = new AddEmployeViewModel();
            newWindow.ShowDialog();
            ListEmploye = null;
            ListEmploye = dbHelper.GetEmployeList();
            ICollectionView view = CollectionViewSource.GetDefaultView(ListEmploye);
            view.Refresh();
        }
        public bool CanExecute_Button_AjouterEmploye_Click(object parameter)
        {
            return true;
        }

        private ICommand button_ModifierEmploye_Click;
        public ICommand Button_ModifierEmploye_Click
        {
            get { return button_ModifierEmploye_Click; }
            set { button_ModifierEmploye_Click = value; }
        }
        public void Execute_Button_ModifierEmploye_Click(object parameter)
        {
            ModifyEmploye newWindow = new ModifyEmploye();
            newWindow.DataContext = new ModifyEmployeViewModel(SelectEmploye);
            newWindow.ShowDialog();
            ListEmploye = null;
            ListEmploye = dbHelper.GetEmployeList();
            ICollectionView view = CollectionViewSource.GetDefaultView(ListEmploye);
            view.Refresh();


        }
        public bool CanExecute_Button_ModifierEmploye_Click(object parameter)
        {
            if (SelectEmploye != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private ICommand button_Actualiser_Click;
        public ICommand Button_Actualiser_Click
        {
            get { return button_Actualiser_Click; }
            set { button_Actualiser_Click = value; }
        }
        public bool RechercheOn = true;
        public void Execute_Button_Actualiser_Click(object parameter)
        {
            ListEmploye = null;
            ListEmploye = dbHelper.GetEmployeList();
            RechercheOn = true;
            ICollectionView view = CollectionViewSource.GetDefaultView(ListEmploye);
            view.Refresh();

        }
        public bool CanExecute_Button_Actualiser_Click(object parameter)
        {
            return true;
        }

        private ICommand button_SupprimerEmploye_Click;
        public ICommand Button_SupprimerEmploye_Click
        {
            get { return button_SupprimerEmploye_Click; }
            set { button_SupprimerEmploye_Click = value; }
        }
        public void Execute_Button_SupprimerEmploye_Click(object parameter)
        {
            if (SelectEmploye != null)
            {


                MessageBoxButton buttons = MessageBoxButton.YesNo;
                const string message = "Voulez-vous vraiment supprimer cet employé ?";
                string title = "Confirmation suppression";
                var result = MessageBox.Show(message, title, buttons);

                if (result == MessageBoxResult.Yes)
                {
                    dbHelper.RemoveEmploye(SelectEmploye);
                    ListEmploye.Remove(SelectEmploye);
                }
            }

        }
        public bool CanExecute_Button_SupprimerEmploye_Click(object parameter)
        {
            if (SelectEmploye != null)
            { return true; }
            else
            {
                return false;
            }
        }


        private ICommand button_RechercheEmploye_Click;
        public ICommand Button_RechercheEmploye_Click
        {
            get { return button_RechercheEmploye_Click; }
            set { button_RechercheEmploye_Click = value; }
        }
        public void Execute_Button_RechercheEmploye_Click(object parameter)
        {
            RechercheOn = false;
            ObservableCollection<Employe> newList = new ObservableCollection<Employe>();
            if (ChampRecherche == null || ChampRecherche == "")
            {

            }
            else
            {
                foreach (Employe e in ListEmploye)
                {
                    if (e.EmailAddress.Contains(ChampRecherche) || e.Username.Contains(ChampRecherche) || e.NomComplet.Contains(ChampRecherche) || e.Role.Contains(ChampRecherche) || e.StatutCompte.Contains(ChampRecherche))
                    {
                        newList.Add(e);
                    }
                }
                ListEmploye = newList;
                RechercheOn = false;
            }
        }
        public bool CanExecute_Button_RechercheEmploye_Click(object parameter)
        {
            return RechercheOn;
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
