using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Weapons
{
    class Melee : Weapons
    {
        public int MeleeCriticalDamage { get; set; }

        public Melee(int MeleeCriticalDamage, int BaseDamage, int BaseRange, int ActionPoints, int CriticalDamage) : base(BaseDamage, BaseRange, ActionPoints, CriticalDamage)
        {
            this.MeleeCriticalDamage = MeleeCriticalDamage;
        }

        //public int MeleeCritical()
        //{

        //}
    }
}
