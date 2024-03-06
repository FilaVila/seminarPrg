using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void Attack(int attack, Enemy enemy) 
        {
            int damage = attack;
            enemy.TakeDamage(damage);
        }
        public void block() 
        { 
            
        }
        public void Stats(int Health)
        {
            Console.WriteLine($"Po boji je každý generál, aktuálně máš {Health} životů.");
        }

    }
}
