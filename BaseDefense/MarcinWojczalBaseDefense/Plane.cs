using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalBaseDefense
{
    class Plane : Unit
    {
        /// <summary>
        /// Mobilność samolotu, zależy od niej szansa na bycie trafionym
        /// </summary>
        public int Maneuverability { get; set; }

        /// <summary>
        /// Konstruktor samolotu
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="firePowerLight"></param>
        /// <param name="armorPenetration"></param>
        /// <param name="firePowerHeavy"></param>
        /// <param name="firePowerAir"></param>
        /// <param name="maneuverability"></param>
        /// <param name="target"></param>
        /// <param name="totalCost"></param>
        public Plane(string name,int health,int firePowerLight, int armorPenetration, int firePowerHeavy,
            int firePowerAir,int maneuverability, ETarget target, int totalCost)
        {
            Name = name;
            Health = health;
            FirePowerLight = firePowerLight;
            ArmorPenetration = armorPenetration;
            FirePowerHeavy = firePowerHeavy;
            FirePowerAir = firePowerAir;
            Maneuverability = maneuverability;
            Target = target;
            TotalCost = totalCost;
            BaseHealth = health;
        }
       
    }
}
