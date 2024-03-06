using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Program
    {    
        static void EndGame()
        {
            Console.ReadKey();
            Environment.Exit(0);
        }

        static char LoadDecision()
        {
            char vstup;
            string input = Console.ReadLine();
            if (char.TryParse(input, out vstup))
            {
                return vstup;
            }
            else
            {
                Console.WriteLine("Při rozmýšlení nad odpovědí jsi dostal mrtvici a zemřel jsi.....trapné");
                return '.';
                EndGame();
            }
        }
        static void LBL() //Letter by letter
        {
            
        }

        static void Combat() 
        {
        
        }

        static void CreateNPC() 
        {
            MainCh Appa = new MainCh();
            Appa.name = "Appa";
            Appa.Health = 100;
            Appa.attack = 30;
            Hildegarda Hildegarda = new Hildegarda();
            Hildegarda.name = "Hildegarda"; //šlo by to napast mnohem, inteligentněji, ale množství Hildegardy na dva řádyk je více než komické
            Longinus Longinus = new Longinus();
            Longinus.name = "Longinus";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zdravím dobroduhu, jaké je tvé vznešené jméno?");
            string nameMainCh = Console.ReadLine();
            MainCh mainCh = new MainCh();
            mainCh.name = nameMainCh;
            mainCh.Health = 100;
            mainCh.attack = 30;


        }
    }
}
