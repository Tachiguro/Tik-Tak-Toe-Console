using System;
//Code by Tachi
//Useless upgrades by Kutsi

//todo: Farbe, Sound(piper,twitter), ASCII ART
namespace Tik_Tak_Toe_Console
{
    class Program
    {
        static void Main(string[] args)
        {   //Code by Tachi
            Console.Title = "Tik-Tak-Toe by Tachi `o_o´";
            Start:
            //Startmenue
            //Variablen
            string NL = Environment.NewLine;
            string Auswahl;
            //Erste Ausgabe
            Console.WriteLine(NL);
            Console.WriteLine("#################################################");
            Console.WriteLine("---------------Tik-Tak-Toe-Console---------------");
            Console.WriteLine("#################################################" + NL);
            Console.WriteLine("Codiert von Tachi");
            Console.WriteLine("Vielen Dank an:");
            Console.WriteLine("Jan Suchotzki von Lernmoment.de wegen der idee.");
            Console.WriteLine("Kutsi für die zu komplizierte, überflüßigen Code verbesserungen." + NL);
            Console.WriteLine("Optionen:");
            Console.WriteLine("Tippe \"start\" um ein Neues Spiel zu beginnen");
            Console.WriteLine("Tippe \"ende\" um das Programm zu beenden" + NL);
            Console.Write("Geben Sie ihre Auswahl ein:");
            Auswahl = Console.ReadLine();
            //Auswertung der Auswahl

            if (Auswahl == "ende" || Auswahl == "Ende")
            {
                Ende();
            }
            else if (Auswahl == "start" || Auswahl == "Start")
                Einfuehrung();

            else
            {
                Console.Clear();
                Console.WriteLine("Falsche eingabe. Bitte noch mal Probieren.");
                Console.WriteLine("Weiter mit belibiger Taste.");
                Console.ReadKey();
                Console.Clear();
                goto Start;
            }
        }
        //Programende Methode
        static void Ende()
        {
            Console.Clear();
            Console.WriteLine("Bis zum Nächsten mal. \n");
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
            Console.WriteLine("  " + " | " + "A" + " | " + "B" + " | " + "C");
            Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
            Console.WriteLine(" 1" + " | " + SpielSteine[0, 0] + " | " + SpielSteine[0, 1] + " | " + SpielSteine[0, 2]);
            Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
            Console.WriteLine(" 2" + " | " + SpielSteine[1, 0] + " | " + SpielSteine[1, 1] + " | " + SpielSteine[1, 2]);
            Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
            Console.WriteLine(" 3" + " | " + SpielSteine[2, 0] + " | " + SpielSteine[2, 1] + " | " + SpielSteine[2, 2] + NL);

            Console.WriteLine("Hat ein Spieler drei Steine horizontal, vertikal oder diagonal,\ngewinnt er." + NL);

            //Beispiel für ein gewonnenes Spiel
            SpielSteine[1, 0] = "X";
            SpielSteine[0, 1] = "O";
            SpielSteine[1, 2] = "X";
            SpielSteine[2, 1] = "O";
            SpielSteine[1, 1] = "X";

            //Spielfeld Ausgabe
            Console.WriteLine("  " + " | " + "A" + " | " + "B" + " | " + "C");
            Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
            Console.WriteLine(" 1" + " | " + SpielSteine[0, 0] + " | " + SpielSteine[0, 1] + " | " + SpielSteine[0, 2]);
            Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
            Console.WriteLine(" 2" + " | " + SpielSteine[1, 0] + " | " + SpielSteine[1, 1] + " | " + SpielSteine[1, 2]);
            Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
            Console.WriteLine(" 3" + " | " + SpielSteine[2, 0] + " | " + SpielSteine[2, 1] + " | " + SpielSteine[2, 2] + NL);
            Console.WriteLine("Spieler 1 hat gewonnen!\n");
            Console.WriteLine("Um Spiel zu Starten belibige Taste drücken.");
            Console.ReadKey();
            NeuesSpiel2();
        }
        static void NeuesSpiel()
        {
            //Code by Tachi
            int Spieler1Gewonnen = 0;
            int Spieler2Gewonnen = 0;
            NeuesSpielStarten:
            string NL = Environment.NewLine;
            Console.Clear();
            int Spieler = 1;
            int Zaehler = 0;
            bool Gewonnen = false;
            string Abfrage = null;

            //Array für die Spielsteine
            string[,] SpielSteine = new string[3, 3]
			//"A" , "B" , "C"
			{{" " , " " , " "}, //1
			 {" " , " " , " "}, //2
			 {" " , " " , " "}};//3
            do
            {
                Anfang:
                //Spielfeld ausgabe
                Console.WriteLine("  " + " | " + "A" + " | " + "B" + " | " + "C");
                Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
                Console.WriteLine(" 1" + " | " + SpielSteine[0, 0] + " | " + SpielSteine[0, 1] + " | " + SpielSteine[0, 2]);
                Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
                Console.WriteLine(" 2" + " | " + SpielSteine[1, 0] + " | " + SpielSteine[1, 1] + " | " + SpielSteine[1, 2]);
                Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
                Console.WriteLine(" 3" + " | " + SpielSteine[2, 0] + " | " + SpielSteine[2, 1] + " | " + SpielSteine[2, 2] + NL);

                Console.WriteLine("Spieler" + Spieler);
                Console.Write("Bitte Koordinaten eintippen:");
                //Spieler eingabe und AUswertung
                Abfrage = Console.ReadLine();
                if (Abfrage == "A1" || Abfrage == "a1")
                {
                    if (Spieler == 1 && SpielSteine[0, 0] == " ")
                    {
                        SpielSteine[0, 0] = "X";
                    }
                    else if (Spieler == 2 && SpielSteine[0, 0] == " ")
                    {
                        SpielSteine[0, 0] = "O";
                    }
                    else
                    {
                        Console.WriteLine("Spielfeld bereits belegt, bitte andere Koordinaten eingeben.");
                        Console.ReadKey();
                        Console.Clear();
                        goto Anfang;
                    }
                }
                else if (Abfrage == "B1" || Abfrage == "b1")
                {
                    if (Spieler == 1 && SpielSteine[0, 1] == " ")
                    {
                        SpielSteine[0, 1] = "X";
                    }
                    else if (Spieler == 2 && SpielSteine[0, 1] == " ")
                    {
                        SpielSteine[0, 1] = "O";
                    }
                    else
                    {
                        Console.WriteLine("Spielfeld bereits belegt, bitte andere Koordinaten eingeben.");
                        Console.ReadKey();
                        Console.Clear();
                        goto Anfang;
                    }
                }
                else if (Abfrage == "C1" || Abfrage == "c1")
                {
                    if (Spieler == 1 && SpielSteine[0, 2] == " ")
                    {
                        SpielSteine[0, 2] = "X";
                    }
                    else if (Spieler == 2 && SpielSteine[0, 2] == " ")
                    {
                        SpielSteine[0, 2] = "O";
                    }
                    else
                    {
                        Console.WriteLine("Spielfeld bereits belegt, bitte andere Koordinaten eingeben.");
                        Console.ReadKey();
                        Console.Clear();
                        goto Anfang;
                    }
                }
                else if (Abfrage == "A2" || Abfrage == "a2")
                {
                    if (Spieler == 1 && SpielSteine[1, 0] == " ")
                    {
                        SpielSteine[1, 0] = "X";
                    }
                    else if (Spieler == 2 && SpielSteine[1, 0] == " ")
                    {
                        SpielSteine[1, 0] = "O";
                    }
                    else
                    {
                        Console.WriteLine("Spielfeld bereits belegt, bitte andere Koordinaten eingeben.");
                        Console.ReadKey();
                        Console.Clear();
                        goto Anfang;
                    }
                }
                else if (Abfrage == "B2" || Abfrage == "b2")
                {
                    if (Spieler == 1 && SpielSteine[1, 1] == " ")
                    {
                        SpielSteine[1, 1] = "X";
                    }
                    else if (Spieler == 2 && SpielSteine[1, 1] == " ")
                    {
                        SpielSteine[1, 1] = "O";
                    }
                    else
                    {
                        Console.WriteLine("Spielfeld bereits belegt, bitte andere Koordinaten eingeben.");
                        Console.ReadKey();
                        Console.Clear();
                        goto Anfang;
                    }
                }
                else if (Abfrage == "C2" || Abfrage == "c2")
                {
                    if (Spieler == 1 && SpielSteine[1, 2] == " ")
                    {
                        SpielSteine[1, 2] = "X";
                    }
                    else if (Spieler == 2 && SpielSteine[1, 2] == " ")
                    {
                        SpielSteine[1, 2] = "O";
                    }
                    else
                    {
                        Console.WriteLine("Spielfeld bereits belegt, bitte andere Koordinaten eingeben.");
                        Console.ReadKey();
                        Console.Clear();
                        goto Anfang;
                    }
                }
                else if (Abfrage == "A3" || Abfrage == "a3")
                {
                    if (Spieler == 1 && SpielSteine[2, 0] == " ")
                    {
                        SpielSteine[2, 0] = "X";
                    }
                    else if (Spieler == 2 && SpielSteine[2, 0] == " ")
                    {
                        SpielSteine[2, 0] = "O";
                    }
                    else
                    {
                        Console.WriteLine("Spielfeld bereits belegt, bitte andere Koordinaten eingeben.");
                        Console.ReadKey();
                        Console.Clear();
                        goto Anfang;
                    }
                }
                else if (Abfrage == "B3" || Abfrage == "b3")
                {
                    if (Spieler == 1 && SpielSteine[2, 1] == " ")
                    {
                        SpielSteine[2, 1] = "X";
                    }
                    else if (Spieler == 2 && SpielSteine[2, 1] == " ")
                    {
                        SpielSteine[2, 1] = "O";
                    }
                    else
                    {
                        Console.WriteLine("Spielfeld bereits belegt, bitte andere Koordinaten eingeben.");
                        Console.ReadKey();
                        Console.Clear();
                        goto Anfang;
                    }
                }
                else if (Abfrage == "C3" || Abfrage == "c3")
                {
                    if (Spieler == 1 && SpielSteine[2, 2] == " ")
                    {
                        SpielSteine[2, 2] = "X";
                    }
                    else if (Spieler == 2 && SpielSteine[2, 2] == " ")
                    {
                        SpielSteine[2, 2] = "O";
                    }
                    else
                    {
                        Console.WriteLine("Spielfeld bereits belegt, bitte andere Koordinaten eingeben.");
                        Console.ReadKey();
                        Console.Clear();
                        goto Anfang;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Koordinaten, bitte noch mal eintippen...");
                    Console.ReadKey();
                    Console.Clear();
                    goto Anfang;
                }

                //Spieler 1 als gewinner ermitteln
                if (SpielSteine[0, 0] == "X" && SpielSteine[0, 1] == "X" && SpielSteine[0, 2] == "X" ||
                    SpielSteine[1, 0] == "X" && SpielSteine[1, 1] == "X" && SpielSteine[1, 2] == "X" ||
                    SpielSteine[2, 0] == "X" && SpielSteine[2, 1] == "X" && SpielSteine[2, 2] == "X" ||

                    SpielSteine[0, 0] == "X" && SpielSteine[1, 0] == "X" && SpielSteine[2, 0] == "X" ||
                    SpielSteine[0, 1] == "X" && SpielSteine[1, 1] == "X" && SpielSteine[2, 1] == "X" ||
                    SpielSteine[0, 2] == "X" && SpielSteine[1, 2] == "X" && SpielSteine[2, 2] == "X" ||

                    SpielSteine[0, 0] == "X" && SpielSteine[1, 1] == "X" && SpielSteine[2, 2] == "X" ||
                    SpielSteine[0, 2] == "X" && SpielSteine[1, 1] == "X" && SpielSteine[2, 0] == "X")
                {
                    Spieler1Gewonnen++;
                    Console.WriteLine("Spieler 1 hat Gewonnen!");
                    Console.WriteLine("Spieler 1 hat " + Spieler1Gewonnen + " gewonnen");
                    Console.WriteLine("Spieler 2 hat " + Spieler2Gewonnen + " gewonnen");

                    Console.WriteLine("Für ein neus Spiel belibige Taste drücken.");
                    Console.ReadKey();
                    Gewonnen = true;
                    goto NeuesSpielStarten;
                }
                //Spieler 2 als gewinner ermitteln
                else if (SpielSteine[0, 0] == "O" && SpielSteine[0, 1] == "O" && SpielSteine[0, 2] == "O" ||
                         SpielSteine[1, 0] == "O" && SpielSteine[1, 1] == "O" && SpielSteine[1, 2] == "O" ||
                         SpielSteine[2, 0] == "O" && SpielSteine[2, 1] == "O" && SpielSteine[2, 2] == "O" ||

                         SpielSteine[0, 0] == "O" && SpielSteine[1, 0] == "O" && SpielSteine[2, 0] == "O" ||
                         SpielSteine[0, 1] == "O" && SpielSteine[1, 1] == "O" && SpielSteine[2, 1] == "O" ||
                         SpielSteine[0, 2] == "O" && SpielSteine[1, 2] == "O" && SpielSteine[2, 2] == "O" ||

                         SpielSteine[0, 0] == "O" && SpielSteine[1, 1] == "O" && SpielSteine[2, 2] == "O" ||
                         SpielSteine[0, 2] == "O" && SpielSteine[1, 1] == "O" && SpielSteine[2, 0] == "O")
                {
                    Spieler2Gewonnen++;
                    Console.WriteLine("Spieler 2 hat Gewonnen!");
                    Console.WriteLine("Spieler 1 hat " + Spieler1Gewonnen + " gewonnen");
                    Console.WriteLine("Spieler 2 hat " + Spieler2Gewonnen + " gewonnen");
                    Console.WriteLine("Für ein neus Spiel belibige Taste drücken.");
                    Console.ReadKey();
                    Gewonnen = true;
                    goto NeuesSpielStarten;
                }
                //Spielerwechsel
                if (Spieler == 1)
                    Spieler = 2;
                else
                    Spieler = 1;
                Console.Clear();
                Zaehler++;
                if (Zaehler == 9)
                {
                    Console.WriteLine("Unentschieden");
                    Console.WriteLine("Für ein neus Spiel belibige Taste drücken.");
                    Console.ReadKey();

                    goto NeuesSpielStarten;
                }
            } while (Gewonnen == false);
            Console.ReadKey();
        }


        static void NeuesSpiel2()
        {   //Code by Kutsi(Profesional Developer)

            int Spieler1Gewonnen = 0;
            int Spieler2Gewonnen = 0;
            NeuesSpielStarten:
            string NL = Environment.NewLine;
            Console.Clear();
            int Spieler = 1;
            int Zaehler = 0;
            bool Gewonnen = false;
            string Abfrage = null;

            //Array für die Spielsteine
            string[,] SpielSteine = new string[3, 3]
			//"A" , "B" , "C"
			{{" " , " " , " "}, //1
			 {" " , " " , " "}, //2
			 {" " , " " , " "}};//3
            do
            {
                Anfang:
                //Spielfeld ausgabe
                Console.WriteLine("  " + " | " + "A" + " | " + "B" + " | " + "C");
                Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
                Console.WriteLine(" 1" + " | " + SpielSteine[0, 0] + " | " + SpielSteine[0, 1] + " | " + SpielSteine[0, 2]);
                Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
                Console.WriteLine(" 2" + " | " + SpielSteine[1, 0] + " | " + SpielSteine[1, 1] + " | " + SpielSteine[1, 2]);
                Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
                Console.WriteLine(" 3" + " | " + SpielSteine[2, 0] + " | " + SpielSteine[2, 1] + " | " + SpielSteine[2, 2] + NL);

                Console.WriteLine("Spieler" + Spieler);
                Console.Write("Bitte Koordinaten eintippen:");
                //Spieler eingabe und Auswertung
                Abfrage = Console.ReadLine();
                //Fehlerabfangen edit by Kutsi
                Abfrage = Abfrage.ToUpper().Trim().Replace(" " , "");
                if (Abfrage.Length == 2)
                { }
                char x = Abfrage[0];
                char y = Abfrage[1];
                if (x != 'A' &&  x != 'B' && x != 'C')
                {
                    x = Abfrage[1];
                    y = Abfrage[0];
                }
                if (y == '1' || y == '2' || y == '3')
                {
                    int idxX = 'A' - x;
                    int idxY = '0' - y - 1;
                    if (SpielSteine[idxX, idxY] == " ")
                    {
                        SpielSteine[idxX, idxY] = (Spieler == 1) ? "X" : "Y";
                    }
                    else
                    {
                        Console.WriteLine("Spielfeld bereits belegt, bitte andere Koordinaten eingeben.");
                        Console.ReadKey();
                        Console.Clear();
                        goto Anfang;
                    }
                }
                //Spieler 1 als gewinner ermitteln
                if (IsWinner(SpielSteine, "X"))
                {
                    Console.Clear();
                    Console.WriteLine("  " + " | " + "A" + " | " + "B" + " | " + "C");
                    Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
                    Console.WriteLine(" 1" + " | " + SpielSteine[0, 0] + " | " + SpielSteine[0, 1] + " | " + SpielSteine[0, 2]);
                    Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
                    Console.WriteLine(" 2" + " | " + SpielSteine[1, 0] + " | " + SpielSteine[1, 1] + " | " + SpielSteine[1, 2]);
                    Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
                    Console.WriteLine(" 3" + " | " + SpielSteine[2, 0] + " | " + SpielSteine[2, 1] + " | " + SpielSteine[2, 2] + NL);
                    Spieler1Gewonnen++;
                    Console.WriteLine("Spieler 1 hat Gewonnen!");
                    Console.WriteLine("Spieler 1 hat " + Spieler1Gewonnen + " gewonnen");
                    Console.WriteLine("Spieler 2 hat " + Spieler2Gewonnen + " gewonnen");
                    Console.WriteLine("Für ein neus Spiel belibige Taste drücken.");
                    Gewonnen = true;
                    Console.ReadKey();
                    goto NeuesSpielStarten;

                }
                //Spieler 2 als gewinner ermitteln
                else if (IsWinner(SpielSteine, "O"))
                {
                    Console.Clear();
                    Console.WriteLine("  " + " | " + "A" + " | " + "B" + " | " + "C");
                    Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
                    Console.WriteLine(" 1" + " | " + SpielSteine[0, 0] + " | " + SpielSteine[0, 1] + " | " + SpielSteine[0, 2]);
                    Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
                    Console.WriteLine(" 2" + " | " + SpielSteine[1, 0] + " | " + SpielSteine[1, 1] + " | " + SpielSteine[1, 2]);
                    Console.WriteLine("--" + "-+-" + "-" + "-+-" + "-" + "-+-" + "--");
                    Console.WriteLine(" 3" + " | " + SpielSteine[2, 0] + " | " + SpielSteine[2, 1] + " | " + SpielSteine[2, 2] + NL);
                    Spieler2Gewonnen++;
                    Console.WriteLine("Spieler 2 hat Gewonnen!");
                    Console.WriteLine("Spieler 1 hat " + Spieler1Gewonnen + " gewonnen");
                    Console.WriteLine("Spieler 2 hat " + Spieler2Gewonnen + " gewonnen");

                    Console.WriteLine("Für ein neus Spiel belibige Taste drücken.");
                    Console.ReadKey();
                    Gewonnen = true;
                    goto NeuesSpielStarten;
                }
                //Spielerwechsel
                if (Spieler == 1)
                    Spieler = 2;
                else
                    Spieler = 1;
                Console.Clear();
                Zaehler++;
                if (Zaehler == 9)
                {
                    Console.WriteLine("Unentschieden");
                    Console.WriteLine("Für ein neus Spiel belibige Taste drücken.");
                    Console.ReadKey();

                    goto NeuesSpielStarten;
                }
            } while (Gewonnen == false);
            Console.ReadKey();
        }
        // o o x
        // o o x
        // o x x
        static bool IsWinner(string[,] spielfeld, string spieler)
        {   //Code by Kutsi(Profesional Developer)
            for (int x = 0; x < 3; x++)
            {
                // vertical
                // horizontal
                bool vcheck = true;
                bool hcheck = true;
                for (int y = 0; y < 3; y++)
                {
                    if (spielfeld[x, y] != spieler)
                    {
                        vcheck = false;
                    }
                    if (spielfeld[y, x] != spieler)
                    {
                        hcheck = false;
                    }
                }
                if (vcheck || hcheck)
                {
                    return true;
                }
            }
            bool dcheck = true;
            for (int d = 0; d < 3; d++)
            {
                if (spielfeld[d, d] != spieler)
                {
                    dcheck = false;
                    break;
                }
            }
            if (dcheck)
            {
                return true;
            }
            for (int d = 0; d < 3; d++)
            {
                if (spielfeld[d, 2 - d] != spieler)
                {
                    dcheck = false;
                    break;
                }
            }
            if (dcheck)
            {
                return true;
            }
            return false;
        }
    }
}