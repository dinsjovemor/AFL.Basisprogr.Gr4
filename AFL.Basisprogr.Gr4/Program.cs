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
                //INITIALIZE: Konverterer indTastningen til int32 og erklærer den som "brugerTal"
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

            int aiIndputs = random.Next(1, 4);

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
