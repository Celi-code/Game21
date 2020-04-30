using System;

namespace Game21
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Variablenerstellung
            int spielerzug; int hoelzer = 21;

            //Bildschirmausgabe bei Start des Programms
            Console.WriteLine($"Spiel 21 \n");
            Console.WriteLine("Nimm ziwschen 1 und 4 Hoelzer. Wer das letzte Holz nimmt hat verloren.");
            Console.WriteLine("Du faengst an.");
            Console.Write("Streichhoelzer auf dem Tisch: | | | | | | | | | | | | | | | | | | | | | ");

            do
            {
                //Fragt solange danach Hölzer zu ziehen bis der Spieler zwischen 1 und 4 Hölzern gezogen hat
                do
                {
                    Console.WriteLine("\n");
                    Console.Write("Wie viele Hoelzer nimmst du? ");
                    spielerzug = int.Parse(Console.ReadLine());

                } while (spielerzug < 1 || spielerzug > 4);

                Console.Write("Streichhoelzer auf dem Tisch: ");

                //Die neue Steichholzzahl wird berechnet und als Striche ausgegeben
                hoelzer -= spielerzug;
                for (int i = 1; i <= hoelzer ; i++)
                {
                    Console.Write("| ");
                }

                Console.WriteLine();

                int computerzug = 5 - spielerzug;
                Console.WriteLine($"Ich nehme {computerzug} Hoelzer.");
                Console.Write("Hoelzer auf dem Tisch: ");

                hoelzer -= computerzug;

                for (int i = 1; i <= hoelzer; i++)
                {
                    Console.Write("| ");
                }

                Console.WriteLine();
                Console.WriteLine();

            } while (hoelzer > 1); //Spieler und Computer müssen Hoelzer nehmen, solange mehr als 1 Holz übrig bleibt.

            Console.WriteLine("Tut mir leid. Du hast leider verloren.");
        }
    }
}
