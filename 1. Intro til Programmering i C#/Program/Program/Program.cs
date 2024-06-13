using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ##################    
            ##  Variabler   ##
            ##################
            
            En variabel er en holder for at gemme en data værdi
            
            Som eksempel fra w3schools, nævner de:
                int - Som lagre heltal (30 eller -13)
                double - lagre tal, med kommatal (20.11 eller -1.11)
                char - Lagre enkelte bogstaver (a, A, b, B, c, C...). De markeres med ' rundt om bogstavet for eksempel 'J'
                string - Lagre en helttekst for eksempel "Hej med dig" eller "hello world!", som bliver markeret med " rundt om tekststrengen
                bool - Har kun 2 valgmuligheder at lagre, sandt eller falsk (true or false)

            Der er også 2 mere, som hedder long og double, som ka
            Syntaxen for at lave en variabel, skriver man
                typen variabelnavn = værdi;
            Det vigtigt mman afslutter med ; i C# så programmet kan fortælle at man er færdig med sin kodestykke 

            Teknisk set, på grund af den syntax regl, kan du lave et program på 1 linje, men jeg vil stærkt ikke anbefale at prøve
            */


            //Så hvis jeg vil lave en variabel ud fra syntaxen skriver jeg
            int heltal1 = 30;
            int heltal2 = -12;
            double decimaltal1 = 9.21;
            double decimaltal2 = -12.9;
            char bogstav1 = 'A';
            char bogstav2 = 'a';
            string tekststreng1 = "Hej verden!";
            string tekststreng2 = "Farvel verden!";
            bool boolean1 = false;
            bool boolean2 = true;

            //Man kan også definere flere variabler på samme tid, så længe man har komma imellem
            //Tror ikke det er vigtigt, men jeg skriver det ned alligevel
            int heltal3 = 4, heltal4 = -3;
            double decimaltal3=5.33,decimaltal4=-2.03;
            char bogstav3 = 'B', bogstav4 = 'b';
            string tekststreng3 = "Hej med dig!", tekststreng4 = "Farvel med dig";
            bool boolean3 = true, boolean4 = false;

            /*
            Man kan så ændre værdien på disse datatyper, og der er forskellige måder man kan gøre det på
                variabel=værdi; | Den ændre variablens værdi til at være en ny værdi
                variabel+=værdi; | Den tilfølger variabel værdien med den nye værdi. Det er egentlig en forkortelse af variabel = variabel + værdi. OBS virker ikke med char, da den kun kan være 1 værdi
                variabel-=værdi; | Gør det omvendte af overnævnte. OBS virker ikke med char eller string
                variabel++; | Den tager værdien, også går den op med 1. OBS: virker kun med variabler der bruger tal, såsom int og double
                variabel--; | Tager værdien og går ned med 1. OBS virker kun med variabler der bruger tal.

            Husk, man skal ikke putte datatypen igen foran for at ændre variablen
            */

            //For at vise ændringer, burde du putte Console.WriteLine(variabelnavn) før og efter ændring
            Console.WriteLine(heltal1);
            heltal1 = 4;
            Console.WriteLine(heltal1);
            Console.WriteLine(heltal2);
            heltal2++;
            Console.WriteLine(heltal2);
            Console.WriteLine(heltal3);
            heltal3--;
            Console.WriteLine(heltal3);
            Console.WriteLine(heltal4);
            heltal4 -= (3*4);//Du kan også lave matematik med talvariabler 
            Console.WriteLine(heltal4);
            Console.WriteLine(decimaltal1);
            decimaltal1 += 3.14;
            Console.WriteLine(decimaltal1);
            Console.WriteLine(bogstav1);
            bogstav1 = 'c';
            Console.WriteLine(bogstav1);
            Console.WriteLine(tekststreng1);
            tekststreng1 = "nå";
            Console.WriteLine(tekststreng1);
            Console.WriteLine(tekststreng2);
            tekststreng2 += tekststreng3;
            Console.WriteLine(tekststreng2);

            Console.ReadKey();//Tilføjer en console.readkey, så at vi kan nå at se dataen ændre før at der bliver lukket ned



            /*
            ##################
            ##  Data typer  ##
            ##################

            Datatyper er bare de typer man kan lagre med. Dem som blev nævnt af w3schools er
                int
                float
                double
                long
                string
                char
                bool

            Tjek https://www.w3schools.com/cs/cs_data_types.php, for mere information om hvad de kan indholde
            */



            /*
            ##################
            ##  Keywords    ##
            ##################

            Keywords er reserveret ord, som man ikke kan bruge som variabelnavn, for eksempel int, string eller double.
            Tjek den fulde liste her https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/

            */

            /*
            ###################################
            ##  Input og Output til konsolen ##
            ###################################




            */
        }
    }
}
