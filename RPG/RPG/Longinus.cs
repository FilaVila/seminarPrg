using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG
{
    internal class Longinus:NPC
    {
        public void interakce(char d, MainCh mainCh) 
        { 
            Random rnd = new Random();
            switch (d) 
            { 
                case 'A':
                    string m2 = mainCh.name + " zvolil přátelskou variantu a koupil od Longinuse lektvar uzdravení (zdraví + 10, útok -1).\n";
                    mainCh.LBL(m2);
                    mainCh.Health = mainCh.Health + 10;
                    mainCh.attack = mainCh.attack -1;
                    return;
                case 'B':
                    int a = rnd.Next(1,7);
                    if (a == 1)
                    { 
                        string m3 = mainCh.name + " se zachoval jako skutečný hrdina. Dal Longinusovi hrnec přes hlavu a okradl ho o jeho elixíry. (zdraví + 30)\n";
                        mainCh.LBL(m3);
                        mainCh.Health = mainCh.Health + 30;
                    }
                    else
                    {
                        string m4 = mainCh.name + " byl přistižen při pokusu o krádež. Když se snažil utéci před rozzuřeným prodavačem lektvarům, praštil se hlavou o futra. (zdraví - 20)\n";
                        mainCh.LBL(m4);
                        mainCh.Health = mainCh.Health -20;
                    }
                    return;
                default:
                    Console.WriteLine("Při rozmýšlení nad odpovědí jsi dostal mrtvici a zemřel jsi.....trapné");
                    mainCh.EndGame();
                    return;
            }  
        }
    }
}
