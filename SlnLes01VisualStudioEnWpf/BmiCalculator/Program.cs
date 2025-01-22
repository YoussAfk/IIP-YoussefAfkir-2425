namespace BmiCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"BMI CALCULATOR
================");
            Console.Write ("Lengte (in cm): ");
            string lengte = Console.ReadLine();
            double cm = Convert.ToDouble(lengte);
            double m = cm / 100;

            Console.Write("Gewicht (in kg): ");
            string gewicht = Console.ReadLine();
            double kg = Convert.ToDouble (gewicht);
            
            double bmi = kg / (m * m);
            Console.WriteLine($"Je BMI bedraagt: {bmi:F2}");

            if (bmi <= 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Je hebt ondergewicht");
            }
            else if (bmi <= 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Je gewicht is normaal");
            }
            else if (bmi <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Je hebt overgewicht");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Je hebt obesitas");
            }
            Console.ResetColor();
            Console.ReadKey(true);
        }
         }
            }