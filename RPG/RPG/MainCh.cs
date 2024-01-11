using System;
using System.Collections.Generic;
using System.Linq;
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
        public void block() 
        { 
            
        }
        public void Combat() 
        { 
            
        }
        public void Stats(int Health, int attack)
        {
            string m =$"Aktuálně máš {Health} životů a tvá neomylná rána dokáže nepříteli ubrat {attack} životů.\n";
            LBL(m);
        }
        public void PFF(char d3) //PrepareForFight
        {
            switch (d3) 
            {
                case 'A':
                    string m10 = name + " se rozhodl pro Přímý útok. \nTvoje statistiky před hlavním soubojem jsou: \n";
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
                    Console.WriteLine("Při rozmýšlení nad odpovědí jsi dostal mrtvici a zemřel jsi.....trapné");
                    EndGame();
                    return;
            }
        }
        public void EndGame()
        {
            Console.ReadKey();
            Environment.Exit(0);
        }

    }
}
