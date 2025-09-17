using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFL.Basisprogr.Gr4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Security.Cryptography;
            using System.Text;
            using System.Threading.Tasks;

namespace ConsoleApp13___afleverings_projekt
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //DINAS OPGAVE, GÆT ET TAL:

                //DISPLAY: ”Velkommen til Gæt et tal”
                Console.WriteLine("Hej velkommen " + navn);


                //DISPLAY: ”Reglerne til spillet”
                Console.WriteLine("Gæt et tal mellem 1 og 100.");
                Console.WriteLine("Du har max 3 antal gæt");


                //Sæt maksimum nummer af gæt til 3

                //INITIALIZE: Computeren genererer et tilfældigt nummer (funktion er fundet på google)
                Random rnd = new Random();

                //INITIALIZE: Tallet skal være mellem 1 - 100
                int pcTal = rnd.Next(1, 101);


                //PROMPT: Spillerens 1. gæt indtastes
                string indTastning = Console.ReadLine();

                //INITIALIZE: Konverterer indTastningen til int32 og erklærer den som "brugerTal"
                brugerTal = Convert.ToInt32(indTastning);


                //INITIALIZE: Værdi-- (decrease) fra max antal gæt






                //INITIALIZE: Stop spillet, når 3 gæt er brugt

                //DISPLAY: “Du har tabt spillet”

                //INITIALIZE: Spiller kan vælge 1. Spille igen, 2. Hovedmenu, 3. Luk spillet:

                //PROMPT: Vælg 1,2 eller 3 (1. Spil igen. 2. Hovedmenu. 3. Luk spillet)



                //INITIALIZE: Betingelse: Hvis nummeret er Over spillerens gæt,


                //DISPLAY: Display “Dit gæt er over tallet, prøv igen”


                //INITIALIZE: Betingelse: Hvis nummeret er Under spillerens gæt


                //DISPLAY: Display “Dit gæt er under tallet, prøv igen”


                //INITIALIZE: I begge tilfælde, får spilleren et gæt mere, (indenfor max antal gæt)                    


                //INITIALIZE: Hvis tallet gættes, kan spilleren 1. Spille igen eller 2. Hovedmenu


                //DISPLAY: Display, "Du gættede rigtigt”


                //PROMPT: Spilleren kan vælge enten: 1. Spil igen, 2. Hovedmenu eller 3. Luk spillet




                //INITIALIZE: Computer kalkulerer forskellen mellem Tilfældigt tal og Spilleren gæt

                //Erklærer, i betingelsen While, at så længe brugerTal ikke er pcTal, så;
                while (brugerTal != pcTal)
                {
                    //hvis brugerTal er højere end pcTal, så skal comp. skrive:
                    if (brugerTal > pcTal)
                    {
                        Console.WriteLine("tallet du skal gætte er lavere");
                    }
                    //og ellers, hvis brugerTal er lavere end pcTal, så skal comp. skrive:
                    else if (brugerTal < pcTal)
                    {
                        Console.WriteLine("tallet du skal gætte er højere");

                    }

                }
                Console.WriteLine("du har gættet rigtigt");

                
                int brugerTal = 0;
                //Viser tekst
                Console.WriteLine("GÆT ET TAL");
                //Beder brugeren indtaste sit navn
                Console.WriteLine("Venligst indtast dit navn:");

                //Dette er en tom linje
                Console.WriteLine(" ");

                //Viser brugerens indtastede tekst
                string navn = Console.ReadLine();

                





            }
        }
    }



}
    }
}
