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
            Console.Write("Scegliere la prossima operazione: ");
            string scelta = Console.ReadLine();
            switch (scelta)
            {
                case "1":
                    // TODO: visualizzare attività
                    Console.WriteLine("DEBUG - visualizzazione di tutte le attività.");
                    break;
                case "2":
                    Console.WriteLine("DEBUG: Inserimento di una nuova attività.");
                    break;
                case "3":
                    Console.WriteLine("DEBUG: Modifica di un'attività.");
                    break;
                case "4":
                    Console.WriteLine("DEBUG: Eliminazione di un'attività.");
                    break;
                case "0":
                    Console.WriteLine("DEBUG: BYE BYE!!!");
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
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
