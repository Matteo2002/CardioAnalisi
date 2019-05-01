using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        //Script 1
        [DataTestMethod]
        [DataRow(15, 250, 175, 225)] //Calcoliamo battiti minimi a massimi facendo: battiti minimi * 0.7 e battiti massimi per 0.9
        [DataRow(20, 200, 140, 180)]
        [DataRow(25, 195, 136.5, 175.5)]
        [DataRow(30, 190, 133, 171)]
        [DataRow(35, 185, 129.5, 166.5)]
        public void TestMethod1(int età, int frequenza, double battiti_minimi_aspettati, double battiti_massimi_aspettati)
        {
            double battiti_minimi_calcolati = CardioLibrary.DataCardio.battiti_minimi(età);
            Assert.AreEqual(battiti_minimi_calcolati, battiti_minimi_aspettati);

            double battiti_massimi_calcolati = CardioLibrary.DataCardio.battiti_massimi(età);
            Assert.AreEqual(battiti_massimi_calcolati, battiti_massimi_aspettati);
        }

        //Script 2
        [DataTestMethod]
        [DataRow(45, "bradicardia")]
        [DataRow(70, "normale")]
        [DataRow(90, "normale")]
        [DataRow(40, "bradicardia")]
        [DataRow(55, "bradicardia")]
        [DataRow(110, "tachicardia")]
        [DataRow(120, "tachicardia")]

        public void TestValoriFrequenzaCardiacaRiposo(double battiti, string frequenza_cardiaca_riposo_aspettata)
        {
            string frequenza_cardiaca_riposo = CardioLibrary.DataCardio.FrequenzaCardiacaRiposo(battiti);
            Assert.AreEqual(frequenza_cardiaca_riposo, frequenza_cardiaca_riposo_aspettata);
        }

        //Script 3
        [DataTestMethod]
        [DataRow("M", 90, 75, 40, 60, 125.4)] //Sesso, frequenza cardiaca media, peso, anni, durata sessione allenamento, calorie bruciate
        [DataRow("F", 75, 55, 35, 40, 50.2)]

        public void TestCalorieBruciate(string sesso, double frequenza_cardiaca, double peso, int anni, double durata_sessione_allenamento, string calorie_bruciate_aspettate)
        {
            double calorie_bruciate = CardioLibrary.DataCardio.Caloriebruciate(sesso, frequenza_cardiaca, peso, anni, durata_sessione_allenamento);
            Assert.AreEqual(calorie_bruciate_aspettate, calorie_bruciate);
        }

        //Script 4
        [DataTestMethod]
        [DataRow("Corsa", 5, 50, 600)] //Attività, Km percorsi, peso corporeo, spesa energetica
        [DataRow("Camminata", 10, 60, 450)]

        public void TestSpesaEnergetica(string attività, double km_percorsi, double peso_corporeo, double SpesaEnergetica, double spesa_energetica_aspettata)
        {
            double Spesa_Energetica = CardioLibary.DataCardio.SpesaEnergetica(attività, km_percorsi, peso_corporeo);
            Assert.AreEqual(spesa_energetica_aspettata, SpesaEnergetica);
        }

        //Script 5
        [DataTestMethod]
        [DataRow(75, 120, 110, 100)] //Battiti riposo, battiti massimi, battiti recupero, media giornaoliera
        [DataRow(65, 110, 100, 90)]

        public void TestBatGiornalieri (double bat_riposo, double bat_massimi, double bat_recupero, double bat_giornalieri_aspettati)
        {
            double bat_giornalieri = CardioLibrary.DataCardio.battitigiornalieri(bat_riposo, bat_massimi, bat_recupero);
            Assert.AreEqual(bat_giornalieri_aspettati, bat_giornalieri);
        }
    }
}
 