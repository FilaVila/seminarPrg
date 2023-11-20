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
                            writeArray(HelpArray);
                        }
                    }
                    break;
                case 'b':
                    int count = 1;
                    for (int i = 0; i < HelpArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < HelpArray.GetLength(1); j++)
                        {
                            HelpArray[i, j] = count++ ;
                            writeArray(HelpArray);
                        }
                    }
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
            for (int i = 0; i < Array.GetLength(0); i++) //pres radky
            {
                for (int j = 0; j < Array.GetLength(1); j++) //pres sloupce
                {
                    Console.Write($"{Array[i, j]} ");
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj já jsem domácí úkol na 2D matice"); 
            int[,] myArray = getArray();
            Console.WriteLine("\nTak a teď mi řekni co s tou maticí provedeme\n p) prohodíme dva zadané řádky\n r) prohodíme dva zadané sloupce\n");
            char o2 = Convert.ToChar(Console.ReadLine());
            switch(o2)
            {
                case 'p':
                    int Row1 = LoadNumber();
                    int Row2 = LoadNumber();
                    for (int j = 0; j < myArray.GetLength(1); j++)
                    {
                        int helpVariable = myArray[Row1, j];
                        myArray[Row1, j] = myArray[Row2, j];
                        myArray[Row2, j] = helpVariable;
                    }
                    for (int i = 0; i < myArray.GetLength(0); i++) //pres radky
                    {
                        for (int j = 0; j < myArray.GetLength(1); j++) //pres sloupce
                        {
                            writeArray(myArray);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("tvá odpověď nebyla v nabídce");
                    EndProgram();
                    break;

            }
            EndProgram();
        }
    }
}
