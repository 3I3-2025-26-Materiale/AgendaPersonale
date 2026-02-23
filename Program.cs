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
                        // Visualizzazione delle attività inserite, una per riga
                        // non in ordine cronologico, ma per come sono presenti nell'array
                        visualizza(attivita);
                        break;
                    case "2":
                        /* INSERIMENTO DI UNA NUOVA ATTIVITA' in coda all'array
                         * Usare il formato richiesto ma richiedere ogni dato separatamente
                         * ATTENZIONE: non cancellare le attività già inserite */
                        Console.Write("Inserire il titolo dell'attività: ");
                        string titolo = Console.ReadLine();
                        Console.Write("Inserire la descrizione dell'attività: ");
                        string descrizione = Console.ReadLine();
                        Console.Write("Inserire l'anno dell'attività: ");
                        int anno = int.Parse(Console.ReadLine());
                        Console.Write("Inserire il mese dell'attività: ");
                        int mese = int.Parse(Console.ReadLine()); // DA FARE: non andare avanti fino a che il mese non è corretto
                        Console.Write("Inserire il giorno dell'attività: ");
                        int giorno = int.Parse(Console.ReadLine()); // DA FARE: non andare avanti fino a che il giorno non è corretto
                        Console.Write("Inserire l'ora dell'attività: ");
                        int ora = int.Parse(Console.ReadLine());
                        Console.Write("Inserire i minuti dell'attività: ");
                        int minuti = int.Parse(Console.ReadLine());

                        // DA FARE: il mese deve essere preceduto da 0 se è ad una sola cifra
                        // (es.: febbraio deve essere stampato come "02", non "2")
                        // altrimenti l'ordinamento per ordine alfabetico non funziona
                        string stringaData = anno + "." + mese + "." + giorno + "-" + ora + ":" + minuti;
                        string nuovaAttivita = stringaData + " | " + titolo + " | " + descrizione;
                        
                        bool inserimentoRiuscito = inserisci(attivita, nuovaAttivita);
                        if (inserimentoRiuscito)
                        {
                            Console.WriteLine("Attività inserita con successo");
                        }
                        else
                        {
                            Console.WriteLine("Attività non inserita (si è già raggiunto il massimo numero di attività memorizzabili).");
                        }
                        break;
                    case "3":
                        Console.WriteLine("DEBUG: Ordinemanto delle attività.");
                        // Ordinamento delle attività per data (che vuol dire, per come è stata memorizzata la data, in ordine alfabetico)
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
            Console.WriteLine("3 - Ordina attività per data");
            Console.WriteLine("4 - Elimina attività");
            Console.WriteLine("0 - ESCI");
        }

        static void visualizza(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        // Inserisce un valore nell'array e restituisce TRUE se l'inserimento è andato a buon fine.
        // Se viene restituito FALSE, o elem è null oppure l'array è già pieno.
        static bool inserisci(string[] array, string elem)
        {
            if (elem != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == null)
                    {
                        // inserisco l'elemento
                        array[i] = elem;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
