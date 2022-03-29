using System;

namespace STS_ESP.Models
{
    /// <summary>
    /// Modele pour les abonnements.
    /// </summary>
    public class Abonnement
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public double Prix { get; set; }

        public DateTime DateDebut { get; set; }

        public DateTime DateFin { get; set; }

        public Abonnement()
        {

        }
        public Abonnement(string t, double p, DateTime dd, DateTime df)
        {
            Type = t;
            Prix = p;
            DateDebut = dd;
            DateFin = df;
        }

    }
}
