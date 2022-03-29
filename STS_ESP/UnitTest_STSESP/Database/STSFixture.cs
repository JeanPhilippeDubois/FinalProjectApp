using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using STS_ESP.Helpers;
using STS_ESP.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace UnitTest_STSESP.Database
{
    public class STSFixture : IDisposable
    {
        private static readonly object _lock = new object();

        private static bool _databaseInitialized;

        public STSFixture()
        {
            Connection = new MySqlConnection($"server=sql.decinfo-cchic.ca;port=33306;user=dev-1330419;password=Info2020;database=db_esp_test_1330419");
            Seed();
            Connection.Open();
        }

        public DbConnection Connection { get; }

        public MOCKSTSDBContext CreateContext(DbTransaction transaction = null)
        {
            var context = new MOCKSTSDBContext(new DbContextOptionsBuilder<MOCKSTSDBContext>().UseMySql(Connection, new MySqlServerVersion(new Version(8, 0, 21))).Options);

            if (transaction != null)
            {
                context.Database.UseTransaction(transaction);
            }

            return context;
        }

        private void Seed()
        {
            lock (_lock)
            {
                if (!_databaseInitialized)
                {
                    using (var context = CreateContext())
                    {
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();

                        var UsersList = new List<Usager>()
                         {
                             new Usager("test1@test1.com","test1", "test1", "test1", new CarteUsager("test1", 1.99, new Abonnement("test1", 1.99, DateTime.MinValue, DateTime.MaxValue))),
                             new Usager("test2@test1.com","test2", "test2", "test2", new CarteUsager("test2", 2.99, new Abonnement("test2", 2.99, DateTime.MinValue, DateTime.MaxValue))),
                             new Usager("test3@test1.com","test3", "test3", "test3", new CarteUsager("test3", 3.99, new Abonnement("test3", 3.99, DateTime.MinValue, DateTime.MaxValue))),
                             new Usager("test4@test1.com","test4", "test4", "test4", new CarteUsager("test4", 4.99, new Abonnement("test4", 4.99, DateTime.MinValue, DateTime.MaxValue))),
                             new Usager("test5@test1.com","test5", "test5", "test5", new CarteUsager("test5", 5.99, new Abonnement("test5", 5.99, DateTime.MinValue, DateTime.MaxValue)))
                        };

                        var EmployeList = new List<Employe>()
                         {
                            new Employe("test1","test2@outlook.com", "test1", "test1", "test1", "test1", CryptographyHelper.HashPassword("test1")),
                            new Employe("test2","test2@outlook.com", "test2", "test2", "test2", "test2", CryptographyHelper.HashPassword("test2")),
                            new Employe("test3","test2@outlook.com", "test3", "test3", "test3", "test3", CryptographyHelper.HashPassword("test3")),
                            new Employe("test4","test2@outlook.com", "test4", "test4", "test4", "test4", CryptographyHelper.HashPassword("test4")),
                            new Employe("test5","test2@outlook.com", "test5", "test5", "test5", "test5", CryptographyHelper.HashPassword("test5")),
                        };

                        var transactionList = new List<Transaction>()
                        {
                            new Transaction(1,1,DateTime.Now,2.99,"test1"),
                            new Transaction(2,2,DateTime.Now,3.99,"test2"),
                            new Transaction(3,3,DateTime.Now,4.99,"test3"),
                            new Transaction(4,4,DateTime.Now,5.99,"test4"),
                            new Transaction(5,5,DateTime.Now,6.99,"test5")
                        };


                        context.Usagers.AddRange(UsersList);
                        context.Employes.AddRange(EmployeList);
                        context.Transactions.AddRange(transactionList);
                        context.SaveChanges();
                    }

                    _databaseInitialized = true;
                }
            }
        }


        public void Dispose() => Connection.Dispose();
    }
}
