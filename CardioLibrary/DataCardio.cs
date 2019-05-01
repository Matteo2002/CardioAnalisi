using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        //Script 1
        public static double battiti_minimi(int età)
        {
            int frequenza = 220 - età;
            double battiti_minimi = frequenza * 0.7;
            return battiti_minimi;
        }

        public static double battiti_massimi(int età)
        {
            int frequenza = 220 - età;
            double battiti_massimi = frequenza * 0.9;
            return battiti_massimi;
        }

        //Script 2
        public static string FrequenzaCardiacaRiposo(double battiti)
        {
            string risultato = "";

            if (battiti <= 60)
            {
                risultato = "bradicardia";
            }

            if (battiti >= 60 && battiti <= 100)
            {
                risultato = "normale";
            }

            if (battiti > 100)
            {
                risultato = "tachicardia";
            }

            return risultato;
        }

        //Script 3
        public static double Caloriebruciate(string sesso, double frequenza_cardiaca, double peso, int anni, double durata_sessione_allenamento)
        {
            double calorie_bruciate = 0;

            if (sesso == "M")
            {
                calorie_bruciate = ((anni * 0.2017) + (peso * 0.199) + (frequenza_cardiaca * 0.6309) - 55.0969) * durata_sessione_allenamento / 4.184;
                calorie_bruciate = Math.Round(calorie_bruciate, 2);
            }

            if (sesso == "F")
            {
                calorie_bruciate = ((anni * 0.074) - (peso * 0.126) + (frequenza_cardiaca * 0.4472) - 20.4022) * durata_sessione_allenamento / 4.184;
                calorie_bruciate = Math.Round(calorie_bruciate, 2);
            }

            return calorie_bruciate;
        }

        //Script 4
        public static double SpesaEnergetica(string attività, double km_percorsi, double peso_corporeo)
        {
            double r = 0;

            if (attività == "Corsa")
            {
                r = (0.9 * km_percorsi) * peso_corporeo;
            }

            if (attività == "Camminata")
            {
                r = (0.50 * km_percorsi) * peso_corporeo;
            }

            return r;
        }

        //Script 5 
        public static double battitigiornalieri(double bat_risposo, double bat_massimi, double bat_recupero)
        {
            double Bat_giornalieri = 0;

            Bat_giornalieri = (bat_risposo + bat_massimi + bat_recupero) / 3;
            Bat_giornalieri = Math.Round(Bat_giornalieri, 1);

            return Bat_giornalieri;

        }
    }
}
