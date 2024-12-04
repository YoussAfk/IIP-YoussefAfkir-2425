using System.Text;

namespace les_1_opgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string header =
            (@"************************
|  WELKOM BIJ MAHJONG  |
************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(header);

            Console.WriteLine();

            // resetcolor
            Console.ResetColor();
            Console.Write("Druk op een");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" willekeurige toets ");
            Console.ResetColor();
            Console.WriteLine("om de steen te tonen...");
            Console.ReadKey(true);

            // utf-8 
            //color
            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ◉◉◉ ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ◉◉◉ ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ◉◉◉ ");
            Console.ResetColor();

            //afsluiten 
            Console.Write("druk op een toets om af te sluiten...");



        }
    }
}