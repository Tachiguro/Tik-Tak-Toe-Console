using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_Tak_Toe_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Startmenue
            //Variablen
            string NL = Environment.NewLine;
            string Auswahl;

            //Erste Ausgabe
            Console.WriteLine(NL);
            Console.WriteLine("#################################################");
            Console.WriteLine("---------------Tik-Tak-Toe-Console---------------");
            Console.WriteLine("#################################################" + NL);
            Console.WriteLine("Optionen:");
            Console.WriteLine("Tippe \"start\" um ein Neues Spiel zu beginnen");
            Console.WriteLine("Tippe \"ende\" um das Programm zu beenden" + NL);
            Console.Write("Geben Sie ihre Auswahl ein:");

            //Auswertung der Auswahl
            Auswahl = Console.ReadLine();
            if (Auswahl == "ende" || Auswahl == "Ende")
            {
                Ende();
            }
            else if (Auswahl == "start" || Auswahl == "Start")
                Einfuehrung();

        }
        //Programende Methode
        static void Ende()
        {
            Console.Clear();
            Console.WriteLine("Bis zum Nächsten mal. /n");
            Console.WriteLine("Weiter mit belibiger Taste");
            Console.ReadKey();
            Environment.Exit(1);
        }
        //Einführung ins Spiel
        static void Einfuehrung()
        {
            string NL = Environment.NewLine;
            //Array für die Spielsteine
            string[,] SpielSteine = new string[3, 3]
            //"A" , "B" , "C"
            {{" " , " " , " "}, //1
             {" " , " " , " "}, //2
             {" " , " " , " "}};//3

            Console.Clear();
            //Eniführung
            Console.WriteLine("Spieler 1 hat den Spielsten \"X\"");
            Console.WriteLine("Spieler 2 hat den Spielsten \"O\"");
            Console.WriteLine("Spieler 1 fängt an.\n");
            Console.WriteLine("Koordinaten vom Spielfeld eingeben um einen Spielstein zu setzen.");
            Console.WriteLine("Beispiel: \"B3\"\n");
            SpielSteine[1, 2] = "X";
            //Spielfeld Ausgabe
            Console.WriteLine("  " + " | " + "1" + " | " + "2" + " | " + "3");
            Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
            Console.WriteLine(" A" + " | " + SpielSteine[0, 0] + " | " + SpielSteine[0, 1] + " | " + SpielSteine[0, 2]);
            Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
            Console.WriteLine(" B" + " | " + SpielSteine[1, 0] + " | " + SpielSteine[1, 1] + " | " + SpielSteine[1, 2]);
            Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
            Console.WriteLine(" C" + " | " + SpielSteine[2, 0] + " | " + SpielSteine[2, 1] + " | " + SpielSteine[2, 2] + NL);

            Console.WriteLine("Hat ein Spieler drei Steine horizontal, vertikal oder diagonal,\ngewinnt er." + NL);

            //Beispiel für ein gewonnenes Spiel
            SpielSteine[1, 0] = "X";
            SpielSteine[0, 1] = "O";
            SpielSteine[1, 2] = "X";
            SpielSteine[2, 1] = "O";
            SpielSteine[1, 1] = "X";

            //Spielfeld Ausgabe
            Console.WriteLine("  " + " | " + "1" + " | " + "2" + " | " + "3");
            Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
            Console.WriteLine(" A" + " | " + SpielSteine[0, 0] + " | " + SpielSteine[0, 1] + " | " + SpielSteine[0, 2]);
            Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
            Console.WriteLine(" B" + " | " + SpielSteine[1, 0] + " | " + SpielSteine[1, 1] + " | " + SpielSteine[1, 2]);
            Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
            Console.WriteLine(" C" + " | " + SpielSteine[2, 0] + " | " + SpielSteine[2, 1] + " | " + SpielSteine[2, 2] + NL);
            Console.WriteLine("Spieler 1 hat gewonnen!\n");
            Console.WriteLine("Um Spiel zu Starten belibige Taste drücken.");
            NeuesSpiel();
            Console.ReadKey();
        }
        static void NeuesSpiel()
        {
            Console.WriteLine("#################################################");

        }
    }
}
