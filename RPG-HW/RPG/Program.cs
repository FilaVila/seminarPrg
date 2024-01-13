using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG
{
    internal class Program
    {
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
                Console.ReadKey();
                Environment.Exit(0);
                return '.';
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zdravím dobroduhu, jaké je tvé vznešené jméno?\n");//message 1
            string nameMainCh = Console.ReadLine(); //vytvoření postavy hráče
            MainCh mainCh = new MainCh();
            mainCh.name = nameMainCh;
            mainCh.Health = 100;
            mainCh.attack = 30;
            Enemy Appa = new Enemy(); //vytvoření hlavního záporáka
            Appa.name = "Appa";
            Appa.Health = 100;
            Appa.attack = 30;
            Enemy Bandit = new Enemy(); //bandita hlídající Reného
            Bandit.name = "Bandit";
            Bandit.Health = 60;
            Bandit.attack = 15;
            Hildegarda hildegarda = new Hildegarda();
            hildegarda.name = "Hildegarda"; //šlo by to napast mnohem, inteligentněji, ale množství Hildegardy na dva řádyk je více než komické
            Longinus longinus = new Longinus();
            longinus.name = "Longinus";
            string m1 = "\n" + mainCh.name + ", mladý rytíř s odvahou v srdci, dorazil do malebného města Harare. Zvěsti o nebezpečném banditovi jménem Appa, který terorizuje okolní oblasti, plnily ulice města. " + mainCh.name + ", odhodlaný postavit se zlu, se vydal do srdce města, kde narazil na dva obyvatele (NPC bez duše).\n\nNa hlavním náměstí stál Longinus, místní obchodník. Jeho krám byl plný lektvarů. Longinus nabídl "+ mainCh.name + " možnost posílit svou výbavu, a tak mladý rytíř stál před rozhodnutím:\n\nA) Přátelská Interakce s Longinem: " + mainCh.name + " si od něj koupil lektvary uzdravení.\n\nB) Nepřátelská Interakce s Longinem: "+ mainCh.name + " se rozhodl okrást obchodníka.\n";
            mainCh.LBL (m1);
            char d1 =LoadDecision();//decision 1
            longinus.interakce(d1, mainCh);
            string m5 = "Dále náš hrdina potkal Hildegardu, mladou dívku v nesnázích. Její bratr byl unesen Appyným pomocníkem, a ona zoufale potřebovala pomoc. "+ mainCh.name + " se ocitl před dalším rozhodnutím:\n\nA) Pomoc Hildegardě: " + mainCh.name + " se rozhodl pomoci Hildegardě.\n\nB) Ignorování Hildegardy: "+ mainCh.name + " se rozhodl ignorovat prosbu Hildegardy a zaměřil se na poražení hlavního bandity Appy.\n";
            mainCh.LBL (m5);
            char d2 =LoadDecision();
            hildegarda.interakce(d2, mainCh, Bandit);
            string m8 = "A konečně "+ mainCh.name + " našel tábor, kde Appa přebýval. Po bližšímn prozkoumání ho napadly tři možnosti, jak na Appu zaútočit:\n\nA) Přímý Útok: " + mainCh.name + " se postavil Appa tváří v tvář v otevřeném boji.(útok + 10, zdraví - 10)\n\nB) Taktický Útok: " + mainCh.name + " zvolil taktický přístup, využil okolní prostředí a léčky.(zdraví + 5, útok + 5)\n\nC) Skrytý Útok: " + mainCh.name + " se rozhodl zaútočit skrytě, získal překvapení nad banditou. (zdraví + 10, útok - 10)\n";
            mainCh.LBL (m8);
            char d3 =LoadDecision();
            mainCh.PFF(d3);
            string m13 = "Po zvolení strategie už nebylo na co čekat a "+ mainCh.name+ " vyrazil proti Appovi.\n";
            mainCh.LBL (m13);
            mainCh.Combat(mainCh,Appa);
            string m16 = "\nPodařilo se ti Appu porazit a záchranit celé město!!! \nGratuluji a děkuji, že si si zahrál moji hru!";
            mainCh.LBL (m16);
            mainCh.EndGame();
        }
    }
}
