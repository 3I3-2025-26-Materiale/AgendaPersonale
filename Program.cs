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

            string[] attivita = new string[100];
            /* FORMATO DELLE ATTIVITA': Data | Titolo | Descrizione
             * Formato di una data: YYYY.MM.DD-HH:mm
             */

            bool continua = true;
            while (continua)
            {
                stampaMenu();
                Console.Write("Scegliere la prossima operazione: ");
                string scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        Console.WriteLine("DEBUG - visualizzazione di tutte le attività.");
                        // Visualizzazione delle attività inserite, una per riga
                        // non in ordine cronologico, ma per come sono presenti nell'array
                        break;
                    case "2":
                        Console.WriteLine("DEBUG: Inserimento di una nuova attività.");
                        /* INSERIMENTO DI UNA NUOVA ATTIVITA' in coda all'array
                         * Usare il formato richiesto ma richiedere ogni dato separatamente
                         * ATTENZIONE: non cancellare le attività già inserite
                         */
                        break;
                    case "3":
                        Console.WriteLine("DEBUG: Modifica di un'attività.");
                        // Modifica di un'attività, identificata tramite la sua posizione nell'array (l'utente la conosce perché la visualizzazione viene effettuata al punto 1)
                        break;
                    case "4":
                        Console.WriteLine("DEBUG: Eliminazione di un'attività.");
                        // Eliminazione di un'attività, identificata tramite la sua posizione nell'array (l'utente la conosce perché la visualizzazione viene effettuata al punto 1)
                        // ATTENZIONE: gestire correttamente la modifica degli indici o i "buchi" dopo l'eliminazione
                        break;
                    case "0":
                        Console.WriteLine("Bye bye!");
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }
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
