using Microsoft.EntityFrameworkCore;
using STS_ESP.Models;

namespace UnitTest_STSESP.Database
{
    public class MOCKSTSDBContext : DbContext
    {
        public MOCKSTSDBContext(DbContextOptions<MOCKSTSDBContext> options) : base(options)
        {
        }

        public MOCKSTSDBContext()
        {

        }

        public DbSet<Employe> Employes { get; set; }

        public DbSet<CarteUsager> CarteUsagers { get; set; }

        public DbSet<Abonnement> Abonnements { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Usager> Usagers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Configuring the one to many relationship

            modelBuilder.Entity<Usager>()
            .HasKey(u => u.Id);

            modelBuilder.Entity<CarteUsager>()
            .HasKey(cu => cu.Id);

            modelBuilder.Entity<Transaction>()
            .HasKey(cu => cu.Id);

            modelBuilder.Entity<Abonnement>()
            .HasKey(cu => cu.Id);

            modelBuilder.Entity<Employe>()
                    .HasKey(a => a.Id);

        }
    }
}
