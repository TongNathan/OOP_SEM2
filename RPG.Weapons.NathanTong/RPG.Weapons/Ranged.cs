using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Weapons
{
    class Ranged : Weapons
    {
        public int RangedCriticalDamage { get; set; }

        public Ranged(int RangedCriticalDamage, int BaseDamage, int BaseRange, int ActionPoints, int CriticalDamage) : base(BaseDamage, BaseRange, ActionPoints, CriticalDamage)
        {
            this.RangedCriticalDamage = RangedCriticalDamage;
        }

        //public float RangedCritical()
        //{

        //}
    }
}
