using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args) // MAIN funktion (Dennis)
        {
            bool exit = false; // Bool variabel til at exit spillet hvis true (Dennis)

            while (!exit) // while løkke til menu (Dennis)
            {
                Console.Clear(); // menu skrives ud på skærmen med grafisk interface (Dennis)
                Console.WriteLine("=== Game Menu ===");
                Console.WriteLine("1. spil 'gæt et tal'");
                Console.WriteLine("2. spil 'sten saks papir'");
                Console.WriteLine("3. Exit");
                Console.Write("Vælg mulighed 1 2 3");
                Console.Write("\n");
                string choice = Console.ReadLine(); // modtager input fra user (Dennis)

                switch (choice) // switch til at lave valg mulighed (Dennis)
                {
                    case "1": // case options til switch med breaks her er det til spil1 med break til at komme ud af løkken (Dennis)
                        Spil1();
                        break;
                    case "2": // spil 2 mulighed samt break (Dennis)
                        Spil2();
                        break;
                    case "3":
                        Console.WriteLine("Lukker spillet ned... "); // fin lille besked om at spiller bliver afsluttet (Dennis)
                        exit = true; // ændre bool så den lukker spillet ned ved at gå ud af løkken også går den til linje 273 (Dennis)
                        break;
                    default: // en eller anden form for fejlhåndtering (Dennis)
                        Console.WriteLine("fejl.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void Spil1()
        {
            Console.Clear();
            Console.WriteLine("Velkommen til spil 1!");
            Console.WriteLine("gæt et tal");
            Console.Write("\n");

            //DINAS OPGAVE, GÆT ET TAL:

            //DISPLAY: ”Velkommen til Gæt et tal”

            Console.WriteLine("Hej velkommen til Gæt et tal");

            //DISPLAY: ”Reglerne til spillet”
            Console.WriteLine("Du kan gætte et tal mellem 1 og 100.");
            Console.WriteLine("Du indtaster tallet og trykker Enter");
            Console.WriteLine("Du har max 3 antal gæt");
            Console.WriteLine("Held og lykke. Tryk Enter for at komme videre");

            //INITIALIZE: Værdien sættes til 0, så det ikke kan blive et negativt tal
            int brugerTal = 0;
            //PROMPT: Spillerens 1. gæt indtastes
            string indTastning = Console.ReadLine();
            //INITIALIZE: Konverterer indTastningen til int32 og erklærer den som "brugerTal" på samme tid
            brugerTal = Convert.ToInt32(indTastning);

            //INITIALIZE: Værdi-- (decrease) fra max antal gæt
            //INITIALIZE: Stop spillet, når 3 gæt er brugt

            //INITIALIZE: Computeren genererer et tilfældigt nummer (funktion er fundet på google)
            Random rnd = new Random();

            //INITIALIZE: Tallet skal være mellem 1 - 100
            int pcTal = rnd.Next(1, 101);


            //INITIALIZE: I alle tilfælde, får spilleren +1 gæt mere, (kun indenfor max antal gæt)

            //Hvis man vinder:
            //DISPLAY: Vundet spillet: "Du gættede rigtigt”
            Console.WriteLine("du har gættet rigtigt");

            //INITIALIZE: Hvis tallet gættes, kan spilleren 1. Spille igen eller 2. Hovedmenu

            //PROMPT: Spilleren kan vælge enten: 1. Spil igen, 2. Hovedmenu eller 3. Luk spillet

            //Hvis man taber:
            //DISPLAY: “Du har tabt spillet”
            Console.WriteLine("Spillet er tabt....");
            //Skriver valgmuligheder
            Console.WriteLine("Vælg 1,2 eller 3 (1. Spil igen. 2. Hovedmenu. 3. Luk spillet");

            //INITIALIZE: Tabt spillet: Spiller kan vælge 1. Spille igen, 2. Hovedmenu, 3. Luk spillet:
            //PROMPT: Vælg 1,2 eller 3 (1. Spil igen. 2. Hovedmenu. 3. Luk spillet)


            //INITIALIZE: Computer kalkulerer forskellen mellem Tilfældigt tal og Spilleren gæt


            //INITIALIZE
            //Erklærer, i betingelsen While, at så længe brugerTal ikke er pcTal, så;
            while (brugerTal != pcTal)
            {
                //INITIALIZE: Betingelse: Hvis nummeret er Under spillerens gæt
                //hvis brugerTal er højere end pcTal:
                if (brugerTal > pcTal)
                {
                    //DISPLAY: “Tallet du skal gætte, er lavere, prøv igen”
                    Console.WriteLine("tallet du skal gætte er lavere");
                }
                //INITIALIZE: Betingelse: Hvis nummeret er Over spillerens gæt,
                //hvis brugerTal er lavere end pcTal:
                else if (brugerTal < pcTal)
                {
                    //DISPLAY: Display “Tallet du skal gætte, er højere, prøv igen”
                    Console.WriteLine("tallet du skal gætte er højere");
                }
            }
        }

        static void Spil2() // Spil2 funktion (Dennis)
        {
            Random random = new Random(); // genere random tal (Dennis)

            int spillerScore = 0; // beholder til points 'spiller' (Dennis)
            int aiScore = 0; // beholder til points 'ai' (Dennis)

            Console.Clear(); // Velkomstskærm med grafisk userinterface afventer any key (Dennis)
            Console.WriteLine("Velkommen til spil 2!");
            Console.WriteLine("sten saks papir");
            Console.Write("\n");
            Console.WriteLine("Press any key to start");
            Console.ReadKey();
            Console.Clear();

            bool exitspil2 = false; // bool variabel til exit af spil hvis true (Dennis)

            while (exitspil2 == false) // løkke til spil2  (Dennis)
            {
                Console.WriteLine("Spiller points er: " + spillerScore + " og computeren har " + aiScore); // start skærm med scoreboard (Dennis)
                Console.Write("\n");
                Console.WriteLine("Skriv '1' for sten, '2' for papir og '3' for saks og 'q' for at stoppe"); // funktions knapper til spiller (Dennis)
                string spillerindput = Console.ReadLine();

                int aiIndputs = random.Next(1, 4); // random number generator til ai på 1-3 for sten saks papir spil, noget med dens array der gør at det skal være fra 1 til 4 (Dennis)

                if (spillerindput == "q") // 'q' knap til bruger for at afslutte spillet og komme ud af løkken (Dennis)
                {
                    exitspil2 = true; // bool variabel ændres (Dennis)
                    break; // samt break til at komme ud af løkken  (Dennis)
                }

                Console.Clear(); // clear screen for spil action går i gang (Dennis)

                if (aiIndputs == 1) // hvis random number 1  (Dennis)
                {
                    Console.WriteLine("Computer har valgt: STEN");
                    switch (spillerindput) // switch til at 'behandle' de indputs bruger og ai kommer med (Dennis)
                    {
                        case "1": // sten v sten   // her er det hvis bruger har valgt at trykke '1' (Dennis) 
                            Console.WriteLine("Spiller har valgt:  STEN");
                            Console.Write("\n");
                            Console.WriteLine("STEN mod STEN");
                            Console.Write("\n");
                            Console.WriteLine("Draw !");
                            Console.Write("\n");
                            break; // breakker ud af løkken (Dennis)
                        case "2": // sten v saks   // her er det hvis bruger har valgt at trykke '2' (Dennis) 
                            Console.WriteLine("Spiller har valgt:  SAKS");
                            Console.Write("\n");
                            Console.WriteLine("STEN slår SAKS");
                            Console.Write("\n");
                            Console.WriteLine("NO! NO! NO! Ai vinder denne runde");
                            Console.Write("\n");
                            aiScore++; // +1 til points for ai's points beholder hvis denne 'case' (Dennis)
                            break; // breakker ud af løkken (Dennis)
                        case "3": // sten v papir   // her er det hvis bruger har valgt at trykke '3' (Dennis) 
                            Console.WriteLine("Spiller har valgt:  PAPIR");
                            Console.Write("\n");
                            Console.WriteLine("PAPIR slår STEN");
                            Console.Write("\n");
                            Console.WriteLine("spiller vinder denne rund - !!! YES! YOU ARE WINNING !!! ");
                            Console.Write("\n");
                            spillerScore++; // +1 til points for spillers's points beholder hvis denne 'case ' (Dennis)
                            break;
                        default:  // alt andet er så kommer denne besked (Dennis)
                            Console.WriteLine("bruger input fejl");
                            Console.Write("\n");
                            break; // breakker ud af løkken (Dennis)
                    }

                }
                else if (aiIndputs == 2) // hvis random number 2   (Dennis)
                {
                    Console.WriteLine("Computer har valgt: PAPIR");
                    switch (spillerindput) // switch til at 'behandle' de indputs bruger og ai kommer med (Dennis)
                    {
                        case "1": // papir v sten   // her er det hvis bruger har valgt at trykke '1' (Dennis) 
                            Console.WriteLine("Spiller har valgt:  STEN");
                            Console.Write("\n");
                            Console.WriteLine("PAPIR slår STEN");
                            Console.Write("\n");
                            Console.WriteLine("NO! NO! NO! Ai vinder denne runde");
                            Console.Write("\n");
                            aiScore++;   // +1 til points for ai's points beholder hvis denne 'case' (Dennis)
                            break; // breakker ud af løkken (Dennis)
                        case "2": // papir v saks    // her er det hvis bruger har valgt at trykke '2' (Dennis) 
                            Console.WriteLine("Spiller har valgt:  SAKS");
                            Console.Write("\n");
                            Console.WriteLine("SAKS slår PAPIR");
                            Console.Write("\n");
                            Console.WriteLine("spiller vinder denne rund - !!! YES! YOU ARE WINNING !!! ");
                            Console.Write("\n");
                            spillerScore++;  // +1 til points for spillers's points beholder hvis denne 'case ' (Dennis)
                            break; // breakker ud af løkken (Dennis)
                        case "3": // papir v papir   // her er det hvis bruger har valgt at trykke '3' (Dennis) 
                            Console.WriteLine("Spiller har valgt:  PAPIR");
                            Console.Write("\n");
                            Console.WriteLine("PAPIR mod PAPIR");
                            Console.Write("\n");
                            Console.WriteLine("! ! ! Draw ! ! !");
                            Console.Write("\n");
                            break; // breakker ud af løkken (Dennis)
                        default:  // alt andet er så kommer denne besked (Dennis) 
                            Console.WriteLine("bruger input fejl");
                            Console.Write("\n");
                            break; // breakker ud af løkken (Dennis)
                    }
                }
                else (aiIndputs == 3) // hvis random number 3  (Dennis)
                {
                    Console.WriteLine("Computer har valgt: SAKS");
                    switch (spillerindput) // switch til at 'behandle' de indputs bruger og ai kommer med (Dennis)
                    {
                        case "1": // saks v sten    // her er det hvis bruger har valgt at trykke '1' (Dennis) 
                            Console.WriteLine("Spiller har valgt:  STEN"); 
                            Console.Write("\n");
                            Console.WriteLine("STEN slår SAKS");
                            Console.Write("\n");
                            Console.WriteLine("spiller vinder denne rund - !!! YES! YOU ARE WINNING !!!");
                            Console.Write("\n");
                            spillerScore++;  // +1 til points for spillers's points beholder hvis denne 'case ' (Dennis)
                            break; // breakker ud af løkken (Dennis)
                        case "2": // saks v saks    // her er det hvis bruger har valgt at trykke '2' (Dennis) 
                            Console.WriteLine("Spiller har valgt:  SAKS");
                            Console.Write("\n");
                            Console.WriteLine("SAKS mod SAKS");
                            Console.Write("\n");
                            Console.WriteLine("! ! ! Draw ! ! !");
                            Console.Write("\n");
                            break; // breakker ud af løkken (Dennis)
                        case "3": // saks v papir   // her er det hvis bruger har valgt at trykke '3' (Dennis) 
                            Console.WriteLine("Spiller har valgt:  PAPIR");
                            Console.Write("\n");
                            Console.WriteLine("SAKS slår PAPIR");
                            Console.Write("\n");
                            Console.WriteLine("NO! NO! NO! Ai vinder denne runde");
                            Console.Write("\n");
                            aiScore++;  // +1 til points for ai's points beholder hvis denne 'case' (Dennis)
                            break; // breakker ud af løkken (Dennis)
                        default: // alt andet er så kommer denne besked (Dennis) 
                            Console.WriteLine("bruger input fejl");
                            Console.Write("\n");
                            break;
                    }
                }
            }
            if (exitspil2 == true) // spil2 afsluttes og der laves en bedsked på skærmen alt efter om man har flere points end programmet med if funktionen  (Dennis)
            {
                Console.Clear();
                Console.WriteLine("Du har valgt og stoppe spillet");
                Console.Write("\n");
                Console.WriteLine("Spiller points er: " + spillerScore + " og computeren har " + aiScore);
                if (spillerScore > aiScore) // Hvis man har points der er over ai's så denne besked  (Dennis) 
                {
                    Console.Write("\n");
                    Console.WriteLine("Tillykke!");
                    Console.WriteLine("YES! YOU ARE A WINNER!!! DU HAR VUNDET MOD AI!");
                }
                if (spillerScore < aiScore)  // Hvis man har points der er under ai's points så får denne besked  (Dennis) 
                {
                    Console.Write("\n");
                    Console.WriteLine("Du har tabt");
                }
                Console.Write("\n");
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();  // også lille pause til at se pointsne inden man går tilbage til menu  (Dennis) 
            }
        }
    }
}
