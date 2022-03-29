using STS_ESP.Helpers;
using STS_ESP.Models;
using System;
using System.Linq;
using UnitTest_STSESP.Database;
using Xunit;

namespace UnitTest_STSESP
{

    /// <summary>
    /// Projet de test du 
    /// </summary>
    public class UnitTest1 : IClassFixture<STSFixture>
    {
        public STSFixture Fixture { get; }

        public UnitTest1(STSFixture fixture) => Fixture = fixture;

        public MOCKDBHelper helper = new();


        [Fact]
        public void Test_AboToValeur()
        {
            Assert.Equal("10.99", helper.AboToValeur("Journalier").ToString());
        }

        [Fact]
        public void Test_AboToValeur_Zero()
        {
            Assert.Equal("0", helper.AboToValeur("Aucun").ToString());
        }

        [Fact]
        public void Test_AboToTime()
        {
            Assert.Equal(DateTime.Now.AddDays(1).Hour, helper.AboToLength("Journalier").Hour);
        }

        [Fact]
        public void Test_AboToTime_Zero()
        {
            Assert.Equal(DateTime.Now.Hour, helper.AboToLength("Aucun").Hour);
        }
        [Fact]
        public void Test_CheckEmail()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    string a = "dasdas";
                    string b = "asdasdas@outlook.com";
                    Assert.True(DBHelper.IsValidEmail(b));
                    Assert.False(DBHelper.IsValidEmail(a));

                }

            }
        }

        [Fact]
        public void Test_CheckEmail_NULL()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    string a = "dasdas";
                    Assert.False(DBHelper.IsValidEmail(a));

                }

            }
        }

        [Fact]
        public void Test_HashTest()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    string a = CryptographyHelper.HashPassword("dasdas");
                    string b = "dasdas";

                    Assert.True(CryptographyHelper.ValidateHashedPassword(b, a));
                }

            }
        }

        [Fact]
        public void Test_HashTest_Different()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    string a = CryptographyHelper.HashPassword("dasdas");
                    string b = "dasdasgfddfgdfg";

                    Assert.False(CryptographyHelper.ValidateHashedPassword(b, a));
                }

            }
        }


        [Fact]
        public void Test_IsValidPhone()
        {
            string a = "432-342-2343";
            Assert.NotEqual("X", DBHelper.isValidPhoneNumber(a));

        }

        [Fact]
        public void Test_IsValidPhone_Invalid()
        {
            string a = "432342354354354dfgdfgdfgdgfdfg2343";
            Assert.Equal("X", DBHelper.isValidPhoneNumber("A"));

        }

        [Fact]
        public void Test_Ajout_Employe()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    Employe newE = new Employe("test6", "test6", "test6", "test6", "test6", "test6", CryptographyHelper.HashPassword("test6"));
                    context.Add(newE);
                    context.SaveChanges();
                    Assert.Equal(6, context.Employes.ToList().Count);

                }

            }
        }

        [Fact]
        public void Test_Supp_Employe()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    context.Remove(context.Employes.ToList()[4]);
                    context.SaveChanges();
                    Assert.Equal(4, context.Employes.ToList().Count);

                }

            }
        }

        [Fact]
        public void Test_Supp_Usager()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    context.Remove(context.Usagers.ToList()[4]);
                    context.SaveChanges();
                    Assert.Equal(4, context.Usagers.ToList().Count);
                }

            }
        }


        [Fact]
        public void Test_Supp_Transaction()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    context.Remove(context.Transactions.ToList()[4]);
                    context.SaveChanges();
                    Assert.Equal(4, context.Transactions.ToList().Count);
                }

            }
        }

        [Fact]
        public void Test_Ajout_Usager()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    Usager newU = new Usager("test@test1.com", "test", "test", "test", new CarteUsager("test", 5.99, new Abonnement("test", 5.99, DateTime.MinValue, DateTime.MaxValue)));
                    context.Add(newU);
                    context.SaveChanges();
                    Assert.Equal(6, context.Usagers.ToList().Count);

                }

            }
        }


        [Fact]
        public void Test_Ajout_Transaction()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    Transaction newT = new Transaction(5, 5, DateTime.Now, 6.99, "test5");
                    context.Add(newT);
                    context.SaveChanges();
                    Assert.Equal(6, context.Transactions.ToList().Count);
                }

            }
        }


        [Fact]
        public void Test_Modif_Employe()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    Employe newE = new Employe("test6", "test6", "test6", "test6", "test6", "test6", CryptographyHelper.HashPassword("test6"));
                    context.Add(newE);
                    context.SaveChanges();
                    newE.Username = "TESTED";
                    newE.NomComplet = "TESTED:";
                    context.Employes.Update(newE);
                    context.SaveChanges();
                    Assert.Equal(6, context.Employes.ToList().Count);

                    Employe test = context.Employes.ToList()[5];
                    Assert.Contains("TESTED", test.Username);
                    Assert.Contains("TESTED", test.NomComplet);

                }

            }
        }

        [Fact]
        public void Test_Modif_Usager()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    Usager newU = new Usager("test@test1.com", "test", "test", "test", new CarteUsager("test", 5.99, new Abonnement("test", 5.99, DateTime.MinValue, DateTime.MaxValue)));
                    context.Add(newU);
                    context.SaveChanges();
                    newU.NoTelephone = "TESTED";
                    newU.NomComplet = "TESTED:";
                    context.Usagers.Update(newU);
                    context.SaveChanges();
                    Assert.Equal(6, context.Usagers.ToList().Count);
                    Usager test = context.Usagers.ToList()[5];
                    Assert.Contains("TESTED", test.NoTelephone);
                    Assert.Contains("TESTED", test.NomComplet);

                }

            }
        }

        [Fact]
        public void Test_Modif_Transaction()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    Transaction newT = new Transaction(5, 5, DateTime.Now, 6.99, "test5");
                    context.Add(newT);
                    context.SaveChanges();
                    newT.IdEmploye = 99;
                    newT.IdUsager = 99;
                    context.Transactions.Update(newT);
                    context.SaveChanges();
                    Assert.Equal(6, context.Transactions.ToList().Count);
                    Transaction test = context.Transactions.ToList()[5];
                    Assert.Contains("99", test.IdUsager.ToString());
                    Assert.Contains("99", test.IdEmploye.ToString());

                }

            }
        }


        [Fact]
        public void Test_Count_Employe()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    Assert.Equal(5, context.Employes.ToList().Count);
                }

            }
        }

        [Fact]
        public void Test_Count_Transactions()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    Assert.Equal(5, context.Transactions.ToList().Count);
                }

            }
        }


        [Fact]
        public void Test_Count_Usager()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    Assert.Equal(5, context.Usagers.ToList().Count);
                }

            }
        }

        [Fact]
        public void Test_Count_CarteUsager()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    Assert.Equal(5, context.CarteUsagers.Count());
                }

            }
        }


        [Fact]
        public void Test_Count_Abonnement()
        {
            using (var transaction = Fixture.Connection.BeginTransaction())
            {

                using (var context = Fixture.CreateContext(transaction))
                {
                    Assert.Equal(5, context.Abonnements.Count());
                }

            }
        }

    }
}
