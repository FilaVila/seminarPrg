using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] myArray = {10,20,30,40,50};

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            foreach (int nums in myArray)
            {  
             
                Console.WriteLine(nums); 
            
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum =0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum = sum + myArray[i];
            }
            Console.WriteLine(sum);

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average = sum/myArray.Length;
            Console.WriteLine(average);

            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (max<myArray[i])
                {
                    max = myArray[i];
                }
            }
            Console.WriteLine(max);

            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = myArray.Min();
            Console.WriteLine(min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
          
            int input = Convert.ToInt32(Console.ReadLine());
            int index = Array.IndexOf(myArray,input);
            Console.WriteLine(index);

            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.

            Random rnd = new Random();
            myArray = new int[100];
            for (int i = 0;i<100;i++)
            {
                myArray[i] = rnd.Next(0,10);
            }
            Console.WriteLine(myArray);
            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];
            foreach (int num in myArray)
            {
                counts[num]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine(counts[i]);
            }
            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.

            int[] nArray;


            Console.ReadKey();
        }
    }
}
