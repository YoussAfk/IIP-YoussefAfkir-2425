
namespace Puntenboek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"PUNTENBOEK
==========");
            Console.Write(@"Aantal studenten : ");
            int aantalstudenten =int.Parse(Console.ReadLine());



            Console.Write(@"
student 1:");
            Console.ReadLine();
            Console.Write("Score portfolio(Op 20):");
            Console.ReadLine();
            Console.Write("project (op 20):");
            Console.ReadLine();
            Console.WriteLine(); 

            Console.Write(@"
student 2:");
            Console.ReadLine();
            Console.Write("Score portfolio(Op 20):");
            Console.ReadLine();
            Console.Write("project (op 20):");
            Console.ReadLine();
            Console.WriteLine();

            Console.Write(@"
student 3:");
            Console.ReadLine();
            Console.Write("Score portfolio(Op 20):");
            Console.ReadLine();
            Console.Write("project (op 20):");
            Console.ReadLine();
            Console.WriteLine();

            Console.Write(@"
student 4:");
            Console.ReadLine();
            Console.Write("Score portfolio(Op 20):");
            Console.ReadLine();
            Console.Write("project (op 20):");
            Console.ReadLine();
            Console.WriteLine();


            Console.WriteLine(@"SCORE
======");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mattias     13,2/20");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("ilyas     8/20");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("nadya  12,6/20");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Emmanuel     7,8/20");

            Console.ForegroundColor = ConsoleColor.White;        
            Console.WriteLine("Geslaagd: Matthias, Nadya");

          ConsoleKey(true);
}

        private static void ConsoleKey(bool v)
        {
        }
    }
}
