using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamenNuzkyPapir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hv = 0; // hráč vítězství
            int pv = 0; // počítač vátězství
            int hp = 0; // hod počítač
            int hh = 0; // hod hráče
            double vys;
            string hps = "";
            Random rnd = new Random();
            Console.WriteLine("Helou, pojď si zahrát kámen, nůžky, papír, tak na tři a hrajeme do tří \n\nkamen (1) \n \npapír (2)\n \nnůžky (3)\n");
            while (hv < 3 && pv < 3)
            {
                hp = rnd.Next(0,3);
                hh = Convert.ToInt32(Console.ReadLine());
                if (hp == 1)
                {
                    hps = " kámen";
                }
                else if (hp == 2)
                {
                    hps = " papír";
                }
                else if (hp == 3)
                {
                    hps = " nůžky";
                }

                vys = hh /hp ;
                
                if (vys == 1)
                {
                    Console.WriteLine("\n Remíza");
                }
                else if (vys < 1)
                {
                    hv++;
                    Console.WriteLine("damn....vyhráls");
                    Console.WriteLine("Já jsem dal" + hps);
                }
                else if (vys >1)
                {
                    pv++;
                    Console.WriteLine("Ha lol skill issue");
                    Console.WriteLine("Já jsem dal" + hps);
                }
            }
            if (hv ==3) 
            {
                Console.WriteLine("Gratuluji vyhráls");
            }
            else
            {
                Console.WriteLine("Ha lol nooob, vyhrál jsem");    
            }
            Console.ReadKey();
        }
    }
}
