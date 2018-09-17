using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Weapons
{
    class Weapons
    {
        public int BaseDamage { get; set; }
        public int BaseRange { get; set; }
        public int ActionPoints { get; set; }
        public int CriticalDamage { get; set; }


        public Weapons(int BaseDamage, int BaseRange, int ActionPoints, int CriticalDamage)
        {
            this.BaseDamage = BaseDamage;
            this.BaseRange = BaseRange;
            this.ActionPoints = ActionPoints;
            this.CriticalDamage = CriticalDamage;
        }

        public int CriticalPoints()
        {
            return BaseDamage * 2;
        }
        
        public double GetRandomNumber(int percent)
        {
            Random random = new Random();
            return random.NextDouble();
        }
    }
}
