using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ConsoleGangsterName
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(@"**************************
    |  GANGSTA NAME BUILDER  |
    **************************

    ");

            //vraag aan de gebruiker om zijn naam te zetten //
                Console.Write("Give the first name of any Disney character: ");
                string naam = Console.ReadLine();
            //hier vraag je om zijn tool te tipen //

                Console.Write("Give any workbench tool: ");
                string tool = Console.ReadLine();
            //hier zijn achter naam//
                Console.Write("What is your last name: ");
                string achternaam = Console.ReadLine();
            // uitkomst en groen kleur //   
            Console.Write("your gangsta name is : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{naam} '{tool}' {achternaam}");
                //voor dat alles wit blijft en de uitkomste groen en geen text onder // 
                Console.ResetColor();
                Console.ReadKey(true);
            }
    }
}
