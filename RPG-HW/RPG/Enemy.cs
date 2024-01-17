using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Enemy: MainCh
    {
        public void Attack(int attack, MainCh mainCh)
        {
            int damage = attack;
            mainCh.TakeDamage(damage);
        }
    }
}
