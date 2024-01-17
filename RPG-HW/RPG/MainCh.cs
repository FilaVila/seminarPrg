using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace RPG
{
    internal class MainCh
    {
        public string name;
        public int Health;
        public int attack;

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        static char LoadDecision2() //kvůli funkci combat jsem musel dát LoadDecision i sem
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
        public void LBL(string message) //Letter by letter
        {
            foreach (char l in message)
            {
                Console.Write(l);
                Thread.Sleep(25);
            }
            Console.WriteLine("\n");
        }
        public void Attack(int attack, Enemy enemy) 
        {
            int damage = attack;
            enemy.TakeDamage(damage);
        }
        public void Combat(MainCh mainch,Enemy enemy)
        {
            string m14 = "Boj začal!!!\n\nA) Útok!!!\n\nB) Obrana je nejlepší útok.";
            LBL(m14);
            int o = 0;
            while (Health > 0 && enemy.Health > 0)
            {
                if (o>0) //tento vskutku barbarský if zamezuje tomu, aby se zpráva, že nepřítel pořád stojí opakovala i po zabití bandity
                {
                    Stats(Health, attack);
                    string m = "Nepřítel pořád stojí!!!\n\nA) Útok!!!\n\nB) Obrana je nejlepší útok.\n";
                    LBL(m);
                }
                o++;
                char d4 = LoadDecision2();
                if (d4== 'A')
                {
                    mainch.Attack(attack, enemy);
                    enemy.Attack(enemy.attack, mainch);
                    string z = "Zaútočil jsi na protivnika!!! A on ti útok, než bys řekl Raksakorikofalapatorius, vrátil\n";
                    LBL(z);                
                }
                else if (d4 == 'B')
                {
                    enemy.Attack(enemy.attack, mainch);
                    mainch.Health += 10;
                    string z2 = "Zkusil si zastavit protivníkovu ránu, ale moc se to nepovedlo...\n ";
                    LBL(z2);
                }
                else 
                {
                    string dm = "Při rozmýšlení nad odpovědí jsi dostal mrtvici a zemřel jsi.....trapné";
                    LBL(dm);
                    EndGame();
                }
            }
        }
        public void Stats(int Health, int attack) //vypíše hrdinovi životy a útok
        {
            string m =$"Aktuálně máš {Health} životů a tvá neomylná rána dokáže nepříteli ubrat {attack} životů.\n";
            LBL(m);
        }
        public void PFF(char d3) //PrepareForFight, funkce, která změní hráčovi staty před final bossem
        {
            switch (d3) 
            {
                case 'A':
                    string m10 = name + " se rozhodl pro Přímý útok. \n\nTvoje statistiky před hlavním soubojem jsou: \n";
                    LBL(m10);
                    Health -= 10;
                    attack += 10;
                    Stats(Health, attack);
                    return;
                case 'B':
                    string m11 = name + " se rozhodl pro Taktický útok. \nTvoje statistiky před hlavním soubojem jsou: \n";
                    LBL(m11);
                    Health += 5;
                    attack += 5;
                    Stats(Health, attack);
                    return;
                case 'C':
                    string m12 = name + " se rozhodl pro Skrytý útok. \nTvoje statistiky před hlavním soubojem jsou: \n";
                    LBL(m12);
                    Health += 10;
                    attack -= 10;
                    Stats(Health, attack);
                    return;
                default:
                    string dm = "Při rozmýšlení nad odpovědí jsi dostal mrtvici a zemřel jsi.....trapné";
                    LBL(dm);
                    EndGame();
                    return;
            }
        }
        public void EndGame() //funkce vypne hru
        {
            Console.ReadKey();
            Environment.Exit(0);
        }

    }
}
