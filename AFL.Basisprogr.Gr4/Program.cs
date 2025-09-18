using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("=== Game Menu ===");
            Console.WriteLine("1. spil 'gæt et tal'");
            Console.WriteLine("2. spil 'sten saks papir'");
            Console.WriteLine("3. Exit");
            Console.Write("Vælg mulighed 1 2 3");
            Console.Write("\n");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Spil1();
                    break;
                case "2":
                    Spil2();
                    break;
                case "3":
                    Console.WriteLine("Lukker spillet ned... ");
                    exit = true;
                    break;
                default:
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

        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int userGuess = 0;

        while (userGuess != numberToGuess)
        {
            Console.Write("Gæt et tal mellem 1 og 100: ");
            string input = Console.ReadLine();

            userGuess = Convert.ToInt32(input);

            if (userGuess > numberToGuess)
            {
                Console.WriteLine("det er for højt");
            }
            else if (userGuess < numberToGuess)
            {
                Console.WriteLine("det er for lavt");
            }
            
        }
        Console.Write("\n");
        Console.WriteLine("Tillykke, du gættede det rigtige tal!");
        Console.Write("\n");
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    static void Spil2()
    {
        Random random = new Random();

        int spillerScore = 0;
        int aiScore = 0;

        Console.Clear();
        Console.WriteLine("Velkommen til spil 2!");
        Console.WriteLine("sten saks papir");
        Console.Write("\n");
        Console.WriteLine("Press any key to start");
        Console.ReadKey();
        Console.Clear();

        bool exitspil2 = false;

        while (exitspil2 == false)
        {
            Console.WriteLine("Spiller points er: " + spillerScore + " og computeren har " + aiScore);
            Console.Write("\n");
            Console.WriteLine("Skriv '1' for sten, '2' for papir og '3' for saks og 'q' for at stoppe");
            string spillerindput = Console.ReadLine();

            int aiIndputs = random.Next(1, 3);

            if (spillerindput == "q")
            {
                exitspil2 = true;
                break;
            }

            Console.Clear();

            if (aiIndputs == 0)
            {
                Console.WriteLine("Computer har valgt: STEN");
                switch (spillerindput)
                {
                    case "1": // sten v sten
                        Console.WriteLine("Spiller har valgt:  STEN");
                        Console.Write("\n");
                        Console.WriteLine("STEN mod STEN");
                        Console.Write("\n");
                        Console.WriteLine("Draw !");
                        Console.Write("\n");
                        break;
                    case "2": // sten v saks
                        Console.WriteLine("Spiller har valgt:  SAKS");
                        Console.Write("\n");
                        Console.WriteLine("STEN slår SAKS");
                        Console.Write("\n");
                        Console.WriteLine("NO! NO! NO! computeren vinder denne runde");
                        Console.Write("\n");
                        aiScore++;
                        break;
                    case "3": // sten v papir
                        Console.WriteLine("Spiller har valgt:  PAPIR");
                        Console.Write("\n");
                        Console.WriteLine("PAPIR slår STEN");
                        Console.Write("\n");
                        Console.WriteLine("spiller vinder denne rund - !!! YES! YOU ARE WINNING !!! ");
                        Console.Write("\n");
                        spillerScore++;
                        break;
                    default:
                        Console.WriteLine("bruger input fejl");
                        Console.Write("\n");
                        break;
                }

            }
            else if (aiIndputs == 1)
            {
                Console.WriteLine("Computer har valgt: PAPIR");
                switch (spillerindput)
                {
                    case "1": // papir v sten
                        Console.WriteLine("Spiller har valgt:  STEN");
                        Console.Write("\n");
                        Console.WriteLine("PAPIR slår STEN");
                        Console.Write("\n");
                        Console.WriteLine("NO! NO! NO! computeren vinder denne runde");
                        Console.Write("\n");
                        aiScore++;
                        break;
                    case "2": // papir v saks
                        Console.WriteLine("Spiller har valgt:  SAKS");
                        Console.Write("\n");
                        Console.WriteLine("SAKS slår PAPIR");
                        Console.Write("\n");
                        Console.WriteLine("spiller vinder denne rund - !!! YES! YOU ARE WINNING !!! ");
                        Console.Write("\n");
                        spillerScore++;
                        break;
                    case "3": // papir v papir
                        Console.WriteLine("Spiller har valgt:  PAPIR");
                        Console.Write("\n");
                        Console.WriteLine("PAPIR mod PAPIR");
                        Console.Write("\n");
                        Console.WriteLine("! ! ! Draw ! ! !");
                        Console.Write("\n");
                        break;
                    default:
                        Console.WriteLine("bruger input fejl");
                        Console.Write("\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Computer har valgt: SAKS");

                switch (spillerindput)
                {
                    case "1": // saks v sten
                        Console.WriteLine("Spiller har valgt:  STEN");
                        Console.Write("\n");
                        Console.WriteLine("STEN slår SAKS");
                        Console.Write("\n");
                        Console.WriteLine("spiller vinder denne rund - !!! YES! YOU ARE WINNING !!!");
                        Console.Write("\n");
                        spillerScore++;
                        break;
                    case "2": // saks v saks
                        Console.WriteLine("Spiller har valgt:  SAKS");
                        Console.Write("\n");
                        Console.WriteLine("SAKS mod SAKS");
                        Console.Write("\n");
                        Console.WriteLine("! ! ! Draw ! ! !");
                        Console.Write("\n");
                        break;
                    case "3": // saks v papir
                        Console.WriteLine("Spiller har valgt:  PAPIR");
                        Console.Write("\n");
                        Console.WriteLine("SAKS slår PAPIR");
                        Console.Write("\n");
                        Console.WriteLine("NO! NO! NO! Ai vinder denne runde");
                        Console.Write("\n");
                        aiScore++;
                        break;
                    default:
                        Console.WriteLine("bruger input fejl");
                        Console.Write("\n");
                        break;
                }
            }
        }
        if (exitspil2 == true)
        {
            Console.Clear(); 
            Console.WriteLine("Du har valgt og stoppe spillet");
            Console.Write("\n");
            Console.WriteLine("Spiller points er: " + spillerScore + " og computeren har " + aiScore);
            if (spillerScore > aiScore)
            {
                Console.Write("\n");
                Console.WriteLine("Tillykke!");
                Console.WriteLine("YES! YOU ARE A WINNER!!! DU HAR VUNDET MOD AI!");
            }
            if (spillerScore < aiScore)
            {
                Console.Write("\n"); 
                Console.WriteLine("Du har tabt");
            }
            Console.Write("\n");
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }
    }
}
