using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Hildegarda:NPC
    {
        public void interakce(char d, MainCh mainCh, Enemy Bandit)
        {
            switch (d) 
            {
                case 'A':
                    mainCh.attack = mainCh.attack + 5;
                    string m6 = mainCh.name + " se od Hildegardy dozvěděl, že jejího bratra Reného drží Appyn pomocník v jeskyni za městem. Náš dobrodruch se tedy do oné jeskyně vydal. Souboj byl nevyhnutelný.\n";
                    mainCh.LBL(m6);
                    mainCh.Combat(mainCh, Bandit);
                    string m7 = mainCh.name + " banditu porazil a jako odměnu dostal od reného jeho legendární meč 'NGGYUNGLYD', který měl celou dobu u sebe.(útok + 50)\n";
                    mainCh.attack = mainCh.attack + 50;
                    mainCh.LBL(m7);
                    mainCh.Stats(mainCh.Health, mainCh.attack);
                    return;
                case 'B':
                    string m9 = mainCh.name + " se rozhodl Hildegardě nepomoci, ta mu za projevenou ochotu prokopla koleno. (útok - 10)\n";
                    mainCh.LBL(m9);
                    mainCh.attack -= 10; //abych si dokázal, že to umím i zkrácenou variantou
                    mainCh.Stats(mainCh.Health, mainCh.attack);
                    return;
                default:
                    string dm = "Při rozmýšlení nad odpovědí jsi dostal mrtvici a zemřel jsi.....trapné";
                    mainCh.LBL(dm);
                    mainCh.EndGame();
                    return;
            }
            
        }
    }
}
