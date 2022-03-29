using System;

namespace STS_ESP.Models
{

    /// <summary>
    /// Modele de la classe Transaction
    /// </summary>
    public class Transaction
    {
        public int Id { get; set; }

        public int IdUsager { get; set; }

        public int IdEmploye { get; set; }

        public DateTime DateCreation { get; set; }

        public double Total { get; set; }

        public string NoConfirmation { get; set; }

        public Transaction()
        {

        }

        public Transaction(int idu, int ide, DateTime dc, double Tt, string nc)
        {
            IdUsager = idu;
            IdEmploye = ide;
            DateCreation = dc;
            Total = Tt;
            NoConfirmation = nc;
        }
    }
}
