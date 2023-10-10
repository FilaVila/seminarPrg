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
        static int er = 0;

        static float LoadNumber()//funkce načte vstup a zkontroluje, jestli je to float
        {
            //se strukturou funkcí jsem si nechal poradit od ChatGPT
            float vstup = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (float.TryParse(input, out vstup))
                {
                    return vstup;
                }
                else
                {
                    er++;
                    Console.WriteLine("Hele, jsem fakt dobrej, ale s tímhle fakt počítat neumím. Máš již " + er + "/3 povolených chyb.");
                    if (er >= 3) //nahrazuje 3*while(er<3)
                    {
                        EndProgram();
                        Console.ReadKey();
                    }
                }
            }  
        }
        static void EndProgram() //funkce ukončí program
        {
            Console.WriteLine("S tebou se fakt nedá pracovat. Nazdar!"); ;
            Environment.Exit(0); // command ze stackoverflow
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            float result =0;
            float n1 =0;  //number1
            float n2 =0;  //number2 
            Console.WriteLine("Zdravím počtáři, prosím, zadej první číslo! (čárku za celým číslem ve svém vlastním zájmu piš takto , )");
            Console.WriteLine("A bacha počítám ti chyby <3 \ntak zadej první číslo");
            n1 = LoadNumber();//"povolá" funkci LoadNumber
            Console.WriteLine("ok píšu si... tvoje první číslo je "+ n1 + "\nUff, tak dobrá čtvrtina je za náma, teď zadej to druhý číslo");
            n2 = LoadNumber();
            Console.WriteLine("zapsáno... tvoje druhé číslo je " + n2);
            Console.WriteLine("Tak a teď mi řekni co s tím obrovským kvantem dat chceš udělat. Na výběr máme: \n \n scitani (s)\n \n odcitani (o)\n \n nasobeni (n)\n \n deleni (d)\n\nčislo a na číslo b (m) \n\nodmocnina(w)\n");
            
            char o = Convert.ToChar(Console.ReadLine()); //přečte vstup uživatele a metodou switch rozhodne co s n1 a n2 má udělat
            switch (o)
            {
                case 's':
                    result = n1 + n2;
                    break;
                case 'o':
                    result = n1 - n2;
                    break;
                case 'n':
                    result = n1 * n2;
                    break;
                case 'd':
                    if (n2 == 0)
                    { 
                     Console.WriteLine("tak to je naposledy co si zkusil dělit nulou!!!");
                     Environment.Exit(0);
                     Console.ReadKey();
                    }
                     result = n1 / n2; // když jsem sem dal i else, tak to přestalo fungovat....netuším proč
                     break; 
                case 'm':
                    result = (float)Math.Pow(n1, n2);
                    break;
                case 'w':
                    result = (float)Math.Pow(n1, 1 / n2); //(float) mi poradil přítel na telefonu a nebyl schopen mi vysvětlit proč to tam má být, ale když to tam není, tak to nefachá
                    break;
                default:
                    
                    EndProgram();
                    Console.WriteLine("navíc se není čemu divit, šance, že by si našel správnou klávesu byla jen 1/26.");
                    break;
            }
            Console.WriteLine("No tak byla to fuška, ale výsledek je " + result + " a po cestě si udělal/a jen " + er + " chyb");
            
            
            /*Zdroje:
             * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * ChatGPT
             * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements
             * https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * all mighty https://stackoverflow.com                       
            */

            Console.ReadKey();
        }
    }
}
