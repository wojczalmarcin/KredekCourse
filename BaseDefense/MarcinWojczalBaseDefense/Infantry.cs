using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalBaseDefense
{
    class Infantry : Unit
    {
        /// <summary>
        /// Konstruktor klasy piechota
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="firePowerLight"></param>
        /// <param name="armorPenetration"></param>
        /// <param name="firePowerHeavy"></param>
        /// <param name="firePowerAir"></param>
        /// <param name="target"></param>
        /// <param name="totalCost"></param>
        public Infantry(string name, int health, int firePowerLight, int armorPenetration, int firePowerHeavy,
           int firePowerAir, ETarget target, int totalCost)
        {
            Name = name;
            Health = health;
            FirePowerLight = firePowerLight;
            ArmorPenetration = armorPenetration;
            FirePowerHeavy = firePowerHeavy;
            FirePowerAir = firePowerAir;
            Target = target;
            TotalCost = totalCost;
            BaseHealth = health;
        }
    }
}
