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
        
    }

}
