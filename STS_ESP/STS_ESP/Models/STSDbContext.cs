using Microsoft.EntityFrameworkCore;
using System;

namespace STS_ESP.Models
{

    /// <summary>
    /// Context pour l'initialisation de l'ORM dans l'application.
    /// </summary>
    public class STSDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=sql.decinfo-cchic.ca;port=33306;user=dev-1330419;password=Info2020;database=db_esp_1330419";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 21));
            optionsBuilder.UseMySql(connectionString,
                serverVersion);
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

