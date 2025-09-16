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
                int brugerTal = 0;
                //Viser tekst
                Console.WriteLine("GÆT ET TAL");
                //Beder brugeren indtaste sit navn
                Console.WriteLine("Venligst indtast dit navn:");

                //Dette er en tom linje
                Console.WriteLine(" ");

                //Viser brugerens indtastede tekst
                string navn = Console.ReadLine();

                //Forklarer spillet til brugeren 
                Console.WriteLine("Hej velkommen " + navn);
                Console.WriteLine("Gæt et tal mellem 1 og 100.");
                Console.WriteLine("Du har max 10 antal gæt");
                //Erklærer brugerens indTastning
                string indTastning = Console.ReadLine();

                //Computer genererer et tilfældigt tal (fundet på google)
                Random rnd = new Random();
                //Computeren genererer et tilfældigt tal ml. 1-100
                int pcTal = rnd.Next(1, 101);
                //Konverterer indTastning til int32
                brugerTal = Convert.ToInt32(indTastning);

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



            }
        }
    }



}
    }
}
