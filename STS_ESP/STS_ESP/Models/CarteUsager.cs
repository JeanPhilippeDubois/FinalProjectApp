namespace STS_ESP.Models
{

    /// <summary>
    /// Modele pour les cartes d'usager
    /// </summary>
    public class CarteUsager
    {

        public CarteUsager(string No, double ba, Abonnement a)
        {
            NoCarte = No;
            Balance = ba;
            Abo = a;
        }
        public CarteUsager()
        {

        }

        public int Id { get; set; }

        public string NoCarte { get; set; }

        public double Balance { get; set; }

        public Abonnement Abo { get; set; }
    }
}
