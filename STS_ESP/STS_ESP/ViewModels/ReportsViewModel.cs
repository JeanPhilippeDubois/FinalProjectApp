using STS_ESP.Helpers;
using STS_ESP.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace STS_ESP.ViewModels
{

    /// <summary>
    /// ViewModel de la page Reports.xaml
    /// </summary>
    class ReportsViewModel : INotifyPropertyChanged
    {

        public DBHelper dBHelper = new DBHelper();

        public ReportsViewModel()
        {
            listeUsager = dBHelper.GetUsagerList();
            listeEmploye = dBHelper.GetEmployeList();
            listeTransaction = dBHelper.GetTransactionList();
            nbTransaction7jours = Get7DayTransactions(listeTransaction);
            nbTransactionTotal7jours = Get7DayTotalTransactions(listeTransaction);
            nbTransactionTotal31jours = Get31DayTotalTransactions(listeTransaction);
            nbTransaction31jours = Get31DayTransactions(listeTransaction);
            nbAbonnement = GetAbonnement(listeUsager);
            nbEmploye = GetNbEmploye(listeEmploye);
            nbUsager = GetUsager(listeUsager);
            totalCarte = GetTotalActif(listeUsager);

        }
        #region Attributs
        public string Get7DayTransactions(ObservableCollection<Transaction> t)
        {
            int nbTransaction = 0;

            foreach (Transaction a in t)
            {
                if (a.DateCreation >= DateTime.Now.AddDays(-7))
                {
                    nbTransaction++;
                }
            }

            return nbTransaction + " transactions";
        }

        public string Get7DayTotalTransactions(ObservableCollection<Transaction> t)
        {
            double nbTransactionTotal = 0;

            foreach (Transaction a in t)
            {
                if (a.DateCreation >= DateTime.Now.AddDays(-7))
                {
                    nbTransactionTotal = nbTransactionTotal + a.Total;
                }
            }

            return string.Format("{0:0.##}", nbTransactionTotal) + " $CAD en transactions";
        }

        public string Get31DayTransactions(ObservableCollection<Transaction> t)
        {
            int nbTransaction = 0;

            foreach (Transaction a in t)
            {
                if (a.DateCreation >= DateTime.Now.AddDays(-31))
                {
                    nbTransaction++;
                }
            }

            return nbTransaction + " transactions";
        }

        public string Get31DayTotalTransactions(ObservableCollection<Transaction> t)
        {
            double nbTransactionTotal = 0;

            foreach (Transaction a in t)
            {
                if (a.DateCreation >= DateTime.Now.AddDays(-31))
                {
                    nbTransactionTotal = nbTransactionTotal + a.Total;
                }
            }

            return string.Format("{0:0.##}", nbTransactionTotal) + " $CAD en transactions";
        }



        public string GetNbEmploye(ObservableCollection<Employe> e)
        {
            int cpt = 0;
            foreach (Employe a in e)
            {
                if (a.StatutCompte == "Actif")
                {
                    cpt++;
                }
            }

            return cpt + " employé(e)s";
        }
        public string GetUsager(ObservableCollection<Usager> u)
        {
            return u.Count.ToString() + " usagers";
        }

        public string GetAbonnement(ObservableCollection<Usager> u)
        {
            int cpt = 0;
            foreach (Usager usg in u)
            {
                if (usg.Carte.Abo.Type != "Aucun")
                {
                    cpt++;
                }
            }
            return cpt + " abonnements";
        }
        public string GetTotalActif(ObservableCollection<Usager> u)
        {
            double cpt = 0;
            foreach (Usager usg in u)
            {
                if (usg.Carte.Balance != 0)
                {
                    cpt = cpt + usg.Carte.Balance;
                }
            }
            return string.Format("{0:0.##}", cpt) + " $CAD";
        }


        ObservableCollection<Usager> listeUsager = new ObservableCollection<Usager>();

        ObservableCollection<Employe> listeEmploye = new ObservableCollection<Employe>();

        ObservableCollection<Transaction> listeTransaction = new ObservableCollection<Transaction>();

        private string nbTransaction7jours;
        public string NbTransaction7jours
        {
            get { return nbTransaction7jours; }
            set
            {
                nbTransaction7jours = value;
                OnPropertyChanged("NbTransaction7jours");
            }
        }

        private string nbTransactionTotal7jours;
        public string NbTransactionTotal7jours
        {
            get { return nbTransactionTotal7jours; }
            set
            {
                nbTransactionTotal7jours = value;
                OnPropertyChanged("NbTransactionTotal7jours");
            }
        }

        private string nbTransaction31jours;
        public string NbTransaction31jours
        {
            get { return nbTransaction31jours; }
            set
            {
                nbTransaction31jours = value;
                OnPropertyChanged("NbTransaction31jours");
            }
        }

        private string nbTransactionTotal31jours;
        public string NbTransactionTotal31jours
        {
            get { return nbTransactionTotal31jours; }
            set
            {
                nbTransactionTotal31jours = value;
                OnPropertyChanged("NbTransactionTotal31jours");
            }
        }

        private string nbEmploye;
        public string NbEmploye
        {
            get { return nbEmploye; }
            set
            {
                nbEmploye = value;
                OnPropertyChanged("NbEmploye");
            }
        }

        private string nbUsager;
        public string NbUsager
        {
            get { return nbUsager; }
            set
            {
                nbUsager = value;
                OnPropertyChanged("NbUsager");
            }
        }

        private string nbAbonnement;
        public string NbAbonnement
        {
            get { return nbAbonnement; }
            set
            {
                nbAbonnement = value;
                OnPropertyChanged("NbAbonnement");
            }
        }

        private string totalCarte;
        public string TotalCarte
        {
            get { return totalCarte; }
            set
            {
                totalCarte = value;
                OnPropertyChanged("TotalCarte");
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
