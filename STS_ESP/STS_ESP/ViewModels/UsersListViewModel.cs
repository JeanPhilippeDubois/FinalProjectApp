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
    /// ViewModel de la page UsersList.xaml
    /// </summary>
    public class UsersListViewModel : INotifyPropertyChanged
    {
        public DBHelper dbHelper = new DBHelper();

        public UsersListViewModel()
        {

            ListeUsagers = dbHelper.GetUsagerList();
            button_AjouterUser_Click = new CommandeRelais(Execute_Button_AjouterUser_Click, CanExecute_Button_AjouterUser_Click);
            button_ModifierUser_Click = new CommandeRelais(Execute_Button_ModifierUser_Click, CanExecute_Button_ModifierUser_Click);
            button_SupprimerUser_Click = new CommandeRelais(Execute_Button_SupprimerUser_Click, CanExecute_Button_SupprimerUser_Click);
            button_RechercheUser_Click = new CommandeRelais(Execute_Button_RechercheUser_Click, CanExecute_Button_RechercheUser_Click);
            button_ModifierBalanceUser_Click = new CommandeRelais(Execute_Button_ModifierBalanceUser_Click, CanExecute_Button_ModifierBalanceUser_Click);
            button_ModifierAboUser_Click = new CommandeRelais(Execute_Button_ModifierAboUser_Click, CanExecute_Button_ModifierAboUser_Click);
            button_Actualiser_Click = new CommandeRelais(Execute_Button_Actualiser_Click, CanExecute_Button_Actualiser_Click);
        }

        #region attributs
        private ObservableCollection<Usager> listeUsagers;
        public ObservableCollection<Usager> ListeUsagers
        {
            get { return listeUsagers; }
            set
            {
                listeUsagers = value;
                OnPropertyChanged("ListeUsagers");
            }
        }


        private Usager selectUsagers;
        public Usager SelectUsagers
        {
            get { return selectUsagers; }
            set
            {
                selectUsagers = value;
                OnPropertyChanged("SelectUsagers");
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
        #region ICommand Bouttons
        private ICommand button_AjouterUser_Click;
        public ICommand Button_AjouterUser_Click
        {
            get { return button_AjouterUser_Click; }
            set { button_AjouterUser_Click = value; }
        }
        public void Execute_Button_AjouterUser_Click(object parameter)
        {
            AddUsager newWindow = new AddUsager();
            newWindow.ShowDialog();
            ListeUsagers = null;
            ListeUsagers = dbHelper.GetUsagerList();
            ICollectionView view = CollectionViewSource.GetDefaultView(ListeUsagers);
            view.Refresh();

        }
        public bool CanExecute_Button_AjouterUser_Click(object parameter)
        {
            return true;
        }

        private ICommand button_ModifierUser_Click;
        public ICommand Button_ModifierUser_Click
        {
            get { return button_ModifierUser_Click; }
            set { button_ModifierUser_Click = value; }
        }
        public void Execute_Button_ModifierUser_Click(object parameter)
        {
            ModifyUsager newWindow = new ModifyUsager();
            newWindow.DataContext = new ModifierUsagerViewModel(SelectUsagers);
            newWindow.ShowDialog();
            ListeUsagers = null;
            ListeUsagers = dbHelper.GetUsagerList();
            ICollectionView view = CollectionViewSource.GetDefaultView(ListeUsagers);
            view.Refresh();

        }
        public bool CanExecute_Button_ModifierUser_Click(object parameter)
        {
            if (SelectUsagers != null)
            { return true; }
            else
            {
                return false;
            }

        private ICommand button_SupprimerUser_Click;
        public ICommand Button_SupprimerUser_Click
        {
            get { return button_SupprimerUser_Click; }
            set { button_SupprimerUser_Click = value; }
        }
        public void Execute_Button_SupprimerUser_Click(object parameter)
        {
            if (SelectUsagers != null)
            {


                MessageBoxButton buttons = MessageBoxButton.YesNo;
                const string message = "Voulez-vous vraiment supprimer cet usager ?";
                string title = "Confirmation suppression";
                var result = MessageBox.Show(message, title, buttons);

                if (result == MessageBoxResult.Yes)
                {
                    dbHelper.RemoveUsager(SelectUsagers);
                    listeUsagers.Remove(SelectUsagers);
                }
            }


        }
        public bool CanExecute_Button_SupprimerUser_Click(object parameter)
        {
            if (SelectUsagers != null)
            { return true; }
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
        public void Execute_Button_Actualiser_Click(object parameter)
        {
            ListeUsagers = null;
            ListeUsagers = dbHelper.GetUsagerList();
            RechercheOn = true;
            ICollectionView view = CollectionViewSource.GetDefaultView(ListeUsagers);
            view.Refresh();

        }
        public bool CanExecute_Button_Actualiser_Click(object parameter)
        {
            return true;
        }

        private ICommand button_RechercheUser_Click;
        public ICommand Button_RechercheUser_Click
        {
            get { return button_RechercheUser_Click; }
            set { button_RechercheUser_Click = value; }
        }
        public void Execute_Button_RechercheUser_Click(object parameter)
        {

            ObservableCollection<Usager> newList = new ObservableCollection<Usager>();
            if (ChampRecherche == null || ChampRecherche == "")
            {

            }
            else
            {
                foreach (Usager i in ListeUsagers)
                {
                    if (i.NomComplet.Contains(ChampRecherche) || i.EmailAddress.Contains(ChampRecherche))
                    {
                        newList.Add(i);
                    }
                }
                ListeUsagers = newList;
                RechercheOn = false;
            }

        }
        public bool RechercheOn = true;
        public bool CanExecute_Button_RechercheUser_Click(object parameter)
        {
            return RechercheOn;
        }

        private ICommand button_ModifierAboUser_Click;
        public ICommand Button_ModifierAboUser_Click
        {
            get { return button_ModifierAboUser_Click; }
            set { button_ModifierAboUser_Click = value; }
        }
        public void Execute_Button_ModifierAboUser_Click(object parameter)
        {


            ModifyAbonnement newWindow = new ModifyAbonnement();
            newWindow.DataContext = new ModifyAbonnementViewModel(SelectUsagers);
            newWindow.ShowDialog();
            ListeUsagers = null;
            ListeUsagers = dbHelper.GetUsagerList();
            ICollectionView view = CollectionViewSource.GetDefaultView(ListeUsagers);
            view.Refresh();

        }
        public bool CanExecute_Button_ModifierAboUser_Click(object parameter)
        {
            if (SelectUsagers != null)
            { return true; }
            else
            {
                return false;
            }
        }

        private ICommand button_ModifierBalanceUser_Click;
        public ICommand Button_ModifierBalanceUser_Click
        {
            get { return button_ModifierBalanceUser_Click; }
            set { button_ModifierBalanceUser_Click = value; }
        }
        public void Execute_Button_ModifierBalanceUser_Click(object parameter)
        {
            ModifyBalance newWindow = new ModifyBalance();
            newWindow.DataContext = new ModifyBalanceViewModel(SelectUsagers);
            newWindow.ShowDialog();
            ListeUsagers = null;
            ListeUsagers = dbHelper.GetUsagerList();
            ICollectionView view = CollectionViewSource.GetDefaultView(ListeUsagers);
            view.Refresh();
        }
        public bool CanExecute_Button_ModifierBalanceUser_Click(object parameter)
        {
            if (SelectUsagers != null)
            { return true; }
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
