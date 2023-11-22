using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwMatice
{
    internal class Program
    {
        static int LoadNumber()//funkce načte vstup a zkontroluje, jestli je to integer
        {
            int output;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out output))
                {
                    return output;
                }
                else
                {
                    Console.WriteLine("Zadal si špatnou hodnotu");
                    EndProgram();
                }
            }
        }
        static int[,] getArray()//funkce vrací v int[,]
        {
            Random rnd = new Random();
            Console.WriteLine("Takže začneme tím, že vytvoříme matici a*b. Zadej prosím čísla a,b.");
            int a = LoadNumber();
            int b = LoadNumber();
            int [,] HelpArray = new int[a,b];
            Console.WriteLine("A mám ji naplnit\n a) náhodnými čísly\n\n b) čísli od 1 do a*b ");
            char o = Convert.ToChar(Console.ReadLine());
            switch(o)
            {
                case'a':
                    for (int i = 0; i < HelpArray.GetLength(0); i++) 
                    {
                        for (int j = 0; j < HelpArray.GetLength(1); j++)
                        {
                            HelpArray[i,j] = rnd.Next(1,51);
                        }
                    }
                    writeArray(HelpArray);
                    break;
                case 'b':
                    int count = 1;
                    for (int i = 0; i < HelpArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < HelpArray.GetLength(1); j++)
                        {
                            HelpArray[i, j] = count++ ;
                        }
                    }
                    writeArray(HelpArray);
                    break;
                default:
                    Console.WriteLine("tvá odpověď nebyl a nebo b");
                    EndProgram(); 
                    break;
            }
            return HelpArray;
        }
        static void EndProgram() //funkce ukončí program
        {
            Console.WriteLine("\nA to už by pro dnešek mohlo stačit."); ;
            Console.ReadKey();
            Environment.Exit(0); 
        }
        static void writeArray(int[,]Array)//do funkce vkládám int array
        {
            for (int i = 0; i < Array.GetLength(0); i++) //i radky
            {
                for (int j = 0; j < Array.GetLength(1); j++) //j sloupce
                {
                    Console.Write($"{Array[i, j]} ");
                }
                Console.Write("\n");
            }
        }
        static void switchRows(int[,]Array)//funkce vezme array
        {
            Console.WriteLine("\nA jaké dva řádky chceš prohodit (pamatuj, že v programovaní je 1. řádek 0)?");
            int Row1 = LoadNumber(); //funkce si spustí funkci na načtení integeru
            int Row2 = LoadNumber();
            for (int j = 0; j < Array.GetLength(1); j++) 
            {
                int storage = Array[Row1, j]; //storage protože uchovává koordinace
                Array[Row1, j] = Array[Row2, j];
                Array[Row2, j] = storage;
            }
            writeArray(Array);
        }
        static void switchColumns(int[,]Array)
        {
            Console.WriteLine("\nA jaké dva sloupce chceš prohodit (pamatuj, že v programovaní je 1. řádek 0)?");
            int Col1 = LoadNumber(); //funkce si spustí funkci na načtení integeru
            int Col2 = LoadNumber();
            for (int i = 0; i < Array.GetLength(1); i++) // i pro sloupce
            {
                int storage = Array[i,Col1];
                Array[i,Col1] = Array[i,Col2];
                Array[i,Col2] = storage;
            }
            writeArray(Array);
        }
        static void switchElements(int[,]Array)
        {
            Console.WriteLine("\nA jaké dva prvky chceš prohodit?");
            int x1 = LoadNumber();
            int y1 = LoadNumber();
            int x2 = LoadNumber();
            int y2 = LoadNumber();
            int storage = Array[x1, y1];
            Array[x1,y1] = Array[x2,y2];
            Array[x2,y2] = storage;
            writeArray(Array);
        }
        static void diagonal(int[,]Array)
        {
            for (int i = 0; i < Array.GetLength(0)/2; i++)
            {
                int storage = Array[i, i];
                int storage2 = Array.GetLength(0) - 1 - i;
                Array[i,i] = Array[storage2, storage2];
                Array[storage2, storage2] = storage;
            }
            writeArray(Array);
        }
        static void secondaryDiagonal(int[,]Array)
        {
            for (int i = Array.GetLength(0)-1; i >Array.GetLength(0)/2; i--)
            {
                int x = Array.GetLength(0) - 1 - i;//nenapadá mě kreativnější jméno pro variable než x
                int storage = Array[i, x];
                Array[i, x] = Array[x, i];
                Array[x, i] = storage;
            }
            writeArray(Array);
        }

        static void multiply(int[,]Array)
        {
            Console.WriteLine("Zadej číslo, kterým chceš celu matici vynásobit.\n");
            int mul = LoadNumber(); //multiplier
            for(int i = 0;i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(0); j++)
                {
                    int storage = Array[i, j];
                    Array[i, j] = storage * mul;
                }
            }
            writeArray(Array);
        }
        //transpozice matice, převrátit podle hlavní diagonály (osová souměrnost), když je obdélníková matice, tak musím otočit poměry stran(obdélník položím atd)
        static void onlyMultiply(int[,]Array) // násobí pouze jeden řádek nebo sloupec
        {
            Console.WriteLine("Zadej číslo, kterým chceš celý řádek/sloupec vynásobit.\n");
            int mul = LoadNumber(); //multiplier
            Console.WriteLine("Chceš násobit řádek nebo sloupec?\n r) řádek\n s) sloupec\n");
            char o = Convert.ToChar(Console.ReadLine());
            switch (o)
            {
                case 'r':

                    Console.WriteLine("Zadej který řádek chceš vynásobit.\n");
                    int numR = LoadNumber(); //číslo řádku
                    for (int i = 0; i < Array.GetLength(0); i++)
                    {
                        int storage = Array[numR,i];
                        Array[numR,i] = storage * mul;
                    }
                    writeArray(Array);
                    break;
                case 's':
                    Console.WriteLine("Zadej který sloupec chceš vynásobit.\n");
                    int numS = LoadNumber(); //číslo sloupce
                    for (int j = 0; j < Array.GetLength(0); j++)
                    {
                        int storage = Array[j,numS];
                        Array[j,numS] = storage * mul;
                    }
                    writeArray(Array);
                    break;
                default:
                    Console.WriteLine("tvá odpověď nebyla v nabídce");
                    EndProgram();
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj já jsem domácí úkol na 2D matice"); 
            int[,] myArray = getArray();
            Console.WriteLine("\nTak a teď mi řekni co s tou maticí provedeme\n r) prohodíme dva zadané řádky\n c) prohodíme dva zadané sloupce\n e) prohodíme dva prvky\n d) prohodime prvky na hlavni diagonale\n s) prohodime prvky na vedlejší diagonale\n t) vynásobíme celou matici zadaným číslem\n g) vynásobíme pouze jeden řádek/sloupec zadaným číslem \n");
            char o = Convert.ToChar(Console.ReadLine());
            switch(o)
            {
                case 'r':
                    switchRows(myArray);
                    break;

                case 'c':
                    switchColumns(myArray);
                    break;
                
                case 'e':
                    switchElements(myArray);
                    break;
                
                case 'd':
                    diagonal(myArray);
                    break;

                case 's':
                    secondaryDiagonal(myArray);
                    break;
                
                case 't':
                    multiply(myArray);
                    break;
                
                case 'g':
                    onlyMultiply(myArray);
                    break;

                default:
                    Console.WriteLine("tvá odpověď nebyla v nabídce");
                    break;

            }
            EndProgram();
        }
    }
}
