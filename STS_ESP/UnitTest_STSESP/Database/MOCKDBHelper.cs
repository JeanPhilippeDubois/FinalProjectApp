using Microsoft.EntityFrameworkCore;
using STS_ESP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using UnitTest_STSESP.Database;

namespace STS_ESP.Helpers
{
    public class MOCKDBHelper
    {
        public MOCKSTSDBContext context = new MOCKSTSDBContext();

        public MOCKDBHelper()
        {

        }
        public MOCKDBHelper(MOCKSTSDBContext context1)
        {
            context = context1;
        }

        public bool AddEmploye(Employe employe)
        {
            try
            {
                context.Add(employe);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddTransaction(Transaction trans)
        {
            try
            {
                context.Transactions.Add(trans);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool EditEmploye(Employe employe)
        {
            try
            {
                context.Employes.UpdateRange(employe);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveEmploye(Employe employe)
        {
            try
            {
                context.Employes.Remove(employe);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ObservableCollection<Employe> GetEmployeList()
        {
            ObservableCollection<Employe> newList = new ObservableCollection<Employe>();
            context.Employes.ToList().ForEach(x => newList.Add(x));
            return newList;
        }
        public Employe GetAnEmploye(int id)
        {
            return context.Employes.Find(id);
        }

        public bool AddUsager(Usager usager)
        {
            try
            {
                context.Add(usager);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool EditUsager(Usager usager)
        {
            try
            {
                context.Usagers.Update(usager);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveUsager(Usager usager)
        {
            try
            {
                context.Usagers.Remove(usager);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ObservableCollection<Usager> GetUsagerList()
        {
            ObservableCollection<Usager> list = new ObservableCollection<Usager>();
            context.Usagers.Include(u => u.Carte).Include(u => u.Carte.Abo).ToList().ForEach(x => list.Add(x));
            return list;
        }
        public Usager GetAnUsager(int id)
        {
            return context.Usagers.Find(id);
        }

        public bool AddCarteUsager(CarteUsager usager)
        {
            try
            {
                context.Add(usager);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool EditCarteUsager(CarteUsager usager)
        {
            try
            {
                context.CarteUsagers.Update(usager);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Employe GetAnEmployeLogin(string username)
        {
            Employe emp = null;
            try
            {
                emp = context.Employes
                .Where(b => b.Username == username)
                .FirstOrDefault();
            }
            catch
            {

            }

            return emp;
        }

        public bool RemoveCarteUsager(CarteUsager usager)
        {
            try
            {
                context.CarteUsagers.Remove(usager);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ObservableCollection<Transaction> GetTransactionList()
        {
            ObservableCollection<Transaction> newList = new ObservableCollection<Transaction>();
            context.Transactions.ToList().ForEach(x => newList.Add(x));
            return newList;
        }

        public List<CarteUsager> GetCarteUsagerList()
        {
            return context.CarteUsagers.ToList();
        }
        public CarteUsager GetAnCarteUsager(int id)
        {
            return context.CarteUsagers.Find(id);
        }
        public bool AddAbonnement(Abonnement abo)
        {
            try
            {
                context.Add(abo);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool EditAbonnement(Abonnement abo)
        {
            try
            {
                context.Abonnements.Update(abo);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveAbonnement(Abonnement abo)
        {
            try
            {
                context.Abonnements.Remove(abo);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Abonnement> GetAbonnementList()
        {
            return context.Abonnements.ToList();
        }
        public Abonnement GetAnAbonnement(int id)
        {
            return context.Abonnements.Find(id);
        }

        public double AboToValeur(string type)
        {
            double valeur = 0.00;
            switch (type)
            {
                case "Aucun":
                    valeur = 0;
                    break;
                case "Journalier":
                    valeur = 10.99;
                    break;
                case "Hebdomadaire":
                    valeur = 20.99;
                    break;
                case "Bihebdomadaire":
                    valeur = 40.99;
                    break;
                case "Mensuel":
                    valeur = 55.99;
                    break;
                case "Trimestriel":
                    valeur = 65.99;
                    break;
                case "Annuel":
                    valeur = 350.99;
                    break;
                default:
                    break;
            }
            return valeur;
        }

        public DateTime AboToLength(string type)
        {
            DateTime valeur = DateTime.Now;
            switch (type)
            {
                case "Aucun":
                    valeur = DateTime.Now;
                    break;
                case "Journalier":
                    valeur = DateTime.Now.AddDays(1);
                    break;
                case "Hebdomadaire":
                    valeur = DateTime.Now.AddDays(7);
                    break;
                case "Bihebdomadaire":
                    valeur = DateTime.Now.AddDays(14);
                    break;
                case "Mensuel":
                    valeur = DateTime.Now.AddDays(31);
                    break;
                case "Trimestriel":
                    valeur = DateTime.Now.AddDays(93);
                    break;
                case "Annuel":
                    valeur = DateTime.Now.AddDays(365);
                    break;
                default:
                    break;
            }
            return valeur;

        }

        public string GenerateRandomString(int Length) //Configurable output string length
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var list = Enumerable.Repeat(0, Length).Select(x => chars[random.Next(chars.Length)]);
            return string.Join("", list);
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
