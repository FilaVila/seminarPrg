using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by Filip Viktor Čermák.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou result do konzole
             * 
             * Mozna rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */
            
        

            int er = 0;
            double result =0;
            double n1 =0;
            double n2 =0;
            Console.WriteLine("Zdravím počtáři, prosím, zadej první číslo! (čárku za celým číslem ve svém vlastním zájmu piš takto , )");
            Console.WriteLine("A bacha počítám ti chyby <3");
            while (er <3)
            {
            string a = Console.ReadLine();
            bool jeDouble = Double.TryParse(a, out double d);
            if (jeDouble)
            {
                Console.WriteLine("ok píšu si... tvoje první číslo je "+ a);
                n1 = double.Parse(a);
                break;
            }
            else
            {
              er++;
              Console.WriteLine("Hele to asi nebude číslo"+ ", máš již " + er + "/3 povolených chyb.");
            }
            }
            Console.WriteLine("Uff, tak dobrá čtvrtina je za náma, teď zadej to druhý číslo");
            while (er < 3)
            {
                string b = Console.ReadLine();
                bool jeDouble2 = Double.TryParse(b, out double d);
                if (jeDouble2)
                {
                    Console.WriteLine("zapsáno... tvoje druhé číslo je " + b);
                    n2 = double.Parse(b);
                    break;
                }
                else
                {
                    er++;
                    Console.WriteLine("Hele to asi nebude číslo" + ", máš již " + er + "/3 povolených chyb.");
                }
            }
            Console.WriteLine("Tak a teď mi řekni co s tím obrovským kvantem dat chceš udělat. Na výběr máme: \n \n scitani (s)\n \n odcitani (o)\n \n nasobeni (n)\n \n deleni (d)\n\nčislo a na číslo b (m) \n\nodmocnina(w)\n");
            while(er < 3)
            {
                char o = Convert.ToChar(Console.ReadLine());
                if (o == 's')
                {
                    result = n1 + n2;
                    break;   
                }
                else if (o == 'o')
                {
                    result= n1 - n2;
                    break;
                }
                else if (o == 'n')
                {
                    result = n1 * n2;
                    break;
                }
                else if (o == 'd')
                {
                    result = n1 / n2;
                    break;
                }
                else if (o == 'm')
                {
                    result = Math.Pow(n1,n2);
                    break;
                }
                else if (o == 'w')
                {
                    result = Math.Pow(n1,1/n2);
                    break;
                }
                else
                {
                    er++;
                    Console.WriteLine("Není se čemu divit šance, že by si našel správnou klávesu byla jen 1/26. Btw už máš "+ er + "/3 chyb");
                }
            }
            if(er < 3)
            {
                Console.WriteLine("No tak byla to fuška, ale výsledek je " + result + " a po cestě si udělal/a jen " + er + " chyb");
            }
            else
            {
                Console.WriteLine("S tebou se fakt nedá pracovat. Nazdar!");
            }
            Console.ReadKey();
        }
    }
}
