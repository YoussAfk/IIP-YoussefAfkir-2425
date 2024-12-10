    namespace Abonnement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Bestgegevens
================");
            Console.Write("-naam klant:");
            string naam = Console.ReadLine();
           
            Console.Write("- aantal toegangsbeurten:");
            int aantal = Convert.ToInt32(Console.ReadLine());
      
 
            Console.Write("-prijs(b.v. 122, 5):");
            double prijs = Convert.ToDouble(Console.ReadLine());

            Console.Write("badkledij inbegrepen (typ true of false):");            
            bool badkledij = Convert.ToBoolean(Console.ReadLine());

            
            Console.WriteLine("-geslacht(druk 'm' of 'v'): ");
            char geslacht = Convert.ToChar(Console.ReadLine());
            Console.Read();





     
            Console.WriteLine(@$"samenvatting 
                ================

- houder:{naam};   
- geslacht:{aantal};
- prijs: {prijs};
- aantal beurten:{badkledij};
- incl. badkledij: {geslacht}
- kaartnummer: ");





        }
    }
}