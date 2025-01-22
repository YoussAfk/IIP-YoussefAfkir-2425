using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices.JavaScript;

namespace Eindcijfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hoofding
            Console.WriteLine(@"Berekening eindcijfer 
=====================
");
            //Inlezen waarden
            Console.Write("Geef het cijfer dagelijks werk (op 20): ");
            double dagCijfers = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geef het cijfer op het project (op 20): ");
            double projectCijfers = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geef het cijfer op het examen (op 20): ");
            double examenCijfers = Convert.ToDouble(Console.ReadLine());

            //Berekeningen
            //eindtotaal
            double eindTot = (((dagCijfers * 5) * 0.3) + ((projectCijfers * 5) * 0.2) + (examenCijfers * 5) * 0.5);
            // percent examen
            double percentExamen = examenCijfers * 5;
            double resultaat;
            
            string proficiat;
            
            /*
            Console.WriteLine(eindTot);
            Console.WriteLine(percentExamen);
            */
            //output

            

            if (examenCijfers > 7)                
            {
                resultaat = eindTot;

            }
            else
            {
                resultaat = Math.Min(eindTot, percentExamen);
            }
            Console.WriteLine($"Je eindcijfer is {resultaat}");





            if (resultaat > 82.5)
            {
                proficiat = "grootste onderscheiding";
            }
            else if (resultaat > 75)
            {
                proficiat = "grote onderscheiding";
            }
            else if (resultaat > 67.5)
            {
                proficiat = "onderscheiding";
            }
            else if (resultaat > 49)
            {
                proficiat = "voldoende";
            }
            else
            {
                  proficiat = "onvoldoende";
            }
            Console.WriteLine($"-> {proficiat}");
            Console.ReadKey(true);
            }
    }
}
