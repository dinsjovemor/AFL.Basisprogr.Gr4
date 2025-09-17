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

                //INITIALIZE: Værdien skal være 0
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

                //INITIALIZE: I alle tilfælde, får spilleren et gæt mere, (indenfor max antal gæt)

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
                //DISPLAY: Display, "Du gættede rigtigt”
                Console.WriteLine("du har gættet rigtigt");


                //PROMPT: Spilleren kan vælge enten: 1. Spil igen, 2. Hovedmenu eller 3. Luk spillet


                //DISPLAY: “Du har tabt spillet”

                //INITIALIZE: Spiller kan vælge 1. Spille igen, 2. Hovedmenu, 3. Luk spillet:

                //PROMPT: Vælg 1,2 eller 3 (1. Spil igen. 2. Hovedmenu. 3. Luk spillet)
                    
                //INITIALIZE: Hvis tallet gættes, kan spilleren 1. Spille igen eller 2. Hovedmenu
                //INITIALIZE: Computer kalkulerer forskellen mellem Tilfældigt tal og Spilleren gæt











            }
        }
    }



}
    }
}
