namespace STS_ESP.Models
{
/// <summary>
/// Modele de la classe Employe.
/// </summary>

    public class Employe
    {
        public int Id { get; set; }

        public string Role { get; set; }

        public string EmailAddress { get; set; }

        public string NomComplet { get; set; }

        public string Username { get; set; }

        public string NoTelephone { get; set; }

        public string StatutCompte { get; set; }

        public string Motdepasse { get; set; }

        public Employe()
        {

        }
        public Employe(string r, string e, string nc, string u, string nt, string sc, string mdp)
        {
            Role = r;
            EmailAddress = e;
            Username = u;
            NomComplet = nc;
            NoTelephone = nt;
            StatutCompte = sc;
            Motdepasse = mdp;
        }

    }
}
