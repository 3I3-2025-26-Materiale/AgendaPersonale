using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GOOGLE CALENDAR NON PLUS ULTRA");

            stampaMenu();

        }

        static void stampaMenu()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("1 - Visualizza le attività");
            Console.WriteLine("2 - Inserisci attività");
            Console.WriteLine("3 - Modifica attività");
            Console.WriteLine("4 - Elimina attività");
            Console.WriteLine("0 - ESCI");
        }
    }
}
