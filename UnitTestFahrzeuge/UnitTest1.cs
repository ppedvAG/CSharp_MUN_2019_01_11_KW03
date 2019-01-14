using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fahrzeugpark;

namespace UnitTestFahrzeuge
{
    //UNIT-TESTS sind kleinteilige Software-Tests, welche jeweils zum Testen einer einzige Funktion gedacht sind. Ausgef�hrt werden sie
    ///�ber den Test-Explorer
    [TestClass]
    public class PKWTest
    {
        [TestMethod]
        public void BeschleunigeAufMaxG()
        {
            PKW pkw1 = new PKW("BMW", 230, 23000, 5);

            pkw1.StarteMotor();

            pkw1.Beschleunige(300);

            //Dies ASSERT-Klasse enth�lt diverse Vergleichsmethoden, welche in Unit-Tests verwendet werden k�nnen. Pro Test-Methode
            ///muss es mindesten einen Assert-Aufruf geben
            Assert.AreEqual(pkw1.MaxGeschwindigkeit, pkw1.AktGeschwindigkeit);
        }

        [TestMethod]
        public void BeschleunigeAufMaxG_LKW()
        {
            LKW lkw1 = new LKW("BMW", 230, 23000, 5);

            lkw1.StarteMotor();

            lkw1.Beschleunige(300);

            Assert.AreEqual(lkw1.MaxGeschwindigkeit, lkw1.AktGeschwindigkeit);
        }
    }
}
