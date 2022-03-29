namespace STS_ESP.Models
{
    /// <summary>
    /// Modele de la classe Usager.
    /// </summary>
    public class Usager
    {
        public int Id { get; set; }

        public string EmailAddress { get; set; }

        public string NomComplet { get; set; }

        public string NoTelephone { get; set; }

        public string StatutCompte { get; set; }

        public CarteUsager Carte { get; set; }

        public Usager()
        {

        }
        public Usager(string e, string nc, string nt, string sc, CarteUsager c)
        {
            EmailAddress = e;
            NomComplet = nc;
            NoTelephone = nt;
            StatutCompte = sc;
            Carte = c;
        }

    }
}
