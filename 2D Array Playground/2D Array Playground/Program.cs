using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            int[,] pole = new int[5, 5];
            int numbertoAdd = 1;
            for (int i = 0;i < pole.GetLength(0);i++)
            {
                for (int j = 0;j < pole.GetLength(1);j++)
                {
                    pole[i, j] = numbertoAdd;
                    numbertoAdd++;
                    Console.Write(pole[i, j]+" ");
                }
                Console.WriteLine("\n");
            }

            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < pole.GetLength(1); j++)
            {
                Console.Write(pole[nRow, j]+" ");
            }
            Console.WriteLine("\n");

            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                Console.Write(pole[i, nColumn] + " ");
            }
            Console.WriteLine("\n + \n");

            //vypsání prvků na halvní diagonále

            Console.WriteLine("Hlavní diagonála");
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                Console.Write(pole[i, i]+" ");
            }
            Console.WriteLine("\n");

            //vedlejší diagonála

            Console.WriteLine("vedlejší diagonála");
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(pole[i, pole.GetLength(1)-i-1] + " ");
            }
            Console.WriteLine("\n");

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int xFirst, yFirst, xSecond, ySecond;

            xFirst = yFirst = 0;
            xSecond = ySecond = 4;
            int first = pole[xFirst, yFirst];
            pole[xFirst, yFirst] = pole[xSecond,ySecond];
            pole[xSecond, ySecond] = first;

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = numbertoAdd;
                    numbertoAdd++;
                    Console.Write(pole[i, j] + " ");
                }
                Console.WriteLine("\n");
            }


            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 1;



            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;

            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.

            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.


            Console.ReadKey();
        }
    }
}
