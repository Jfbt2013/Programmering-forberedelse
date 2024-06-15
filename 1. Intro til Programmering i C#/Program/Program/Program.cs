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
            double decimaltal3 = 5.33, decimaltal4 = -2.03;
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
            Flere kan findes her https://www.w3schools.com/cs/cs_operators.php
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
            heltal4 -= (3 * 4);//Du kan også lave matematik med talvariabler 
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

            For at smide noget ud i konsolen, bruger man Console.WriteLine();, hvor du indsætter en værdi i parenteserene på writeline
            
            For så at få en bruger input i konsolen, skal du bruge Console.ReadLine();
            Den tager inputtet fra konsolen, og returner det som en string værdi
            Det er en meget vigtig viden, fordi hvis du skal bruge en talværdi, skal du konvertere string værdien til et tal
            
            En simpel måde at gøre det, er ved at skrive Convert.ToInt32(Console.ReadLine());
            Så får du en værdi som bliver et tal, dog kan der slå fejl, hvis man inputter andet end tal
            Og så skal du i gang med fejlhåndtering
            */

            //Vi tager noget input og lader konsollen printe det ud
            Console.WriteLine("Skriv noget sejt:");
            string tekstinput = Console.ReadLine();
            Console.WriteLine("Du skrev: " + tekstinput);

            Console.WriteLine("Skriv et tal");
            int talinput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Du skrev: " + talinput);
            Console.WriteLine("Jeg plusser dit tal med 2: " + (talinput + 2)); //Hurtig matematik kan lave også
            Console.ReadKey();

            /*
            ######################################################
            ##  Kontrolstrukturer, både betingelser og løkker   ##
            ######################################################

            Vi skal nu have struktur.
            Der forskellige måder man kan lave kontrol
            Vi starter med betingelse og erklæring (conditions and statement)
            Mere kan findes her https://www.w3schools.com/cs/cs_conditions.php

            Betingelse
            Vi skal først lave have betingelser, før vi kan lave erklæringer
            En betingelse kan være:
                a==b    | a er lig med b
                a<b     | b er større end a
                a<=b    | b er større eller lig med a
                a>b     | b er mindre end a
                a>=b    | b er mindre eller lig med a
                a!=b    | b er ikke lig med a
            Hvis disse betingelser er usande, slår den fejl
            De her er simple betingelser som er vigtigt at kende. 

            Så kommer vi til erklæringer
            Vi kan starte med if erklæringer(if statements)
            Man laver sådan en ved

            if(betingelse){
                Gør funktion()
            }

            Hvis betingelsen er opfyldt, så vil den lave det er inde for {}
            Så findes der en if else, som ser sådan her ud

            if(betingelse){
                funktionA()
            } else {
                funktionB()
            }

            Hvis betingelsen bliver opfyldt, laver den funktionA, hvis den ikke er opfyldt, går den til funktionB
            Så findes der "else if", som ser sådan her ud

            if(betingelse1){
                funktionA1()
            } else if(betingelse2) {
                funktionA2()
            }else{
                funktionB()
            }

            I sådan en erklæring/statement, kan du lave flere betingelser, men det går i rækkefølge. 
            Så hvis betingelse1 ikke bliver opfyldt, kigger den på betingelse2, og ser om den er opfyldt.
            funktionA1 og funktionA2 kunne godt være den samme funktion, hvis man ønsker

            Så reglerne for if erklærigner er:
                Den skal altid starte på "if(betingelse)"
                Vil du have flere betingelser, tilføjer du "else if(betingelse)"
                Og hvis ingen af betingelserne er opfyldt,  og du vil have den laver plan b, istedet for den går ind i resten af koden skriver du else
                Man må maks have 1 else 

            */

            //Lad os demonstrere
            Console.WriteLine("Vi tjekker om heltal1 er over 2");
            if (heltal1 > 2)
            {
                Console.WriteLine("Heltal1 er over 2");
            }


            Console.WriteLine("Hvis heltal2 er over 0, skal den sige ja, ellers skal den sige nej");
            if(heltal2 > 0) {
                Console.WriteLine("Ja");//Funktion A
            }
            else { 
                Console.WriteLine("Nej");//Funktion B
            }


            if(heltal3 < 0)
            {
                Console.WriteLine("Condition 1 virkede");
            }
            else if(heltal4 < 0) {
                Console.WriteLine("Condition 2 virkede");
            }
            else
            {
                Console.WriteLine("Ingen condition virkede");
            }

            Console.ReadKey();

        }
    }
}
