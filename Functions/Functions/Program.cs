using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program Program = new Program(); //variable program
            Program.Run();
        }

        //hier komt de functie
        internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
        }
        
        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        
    }

}
