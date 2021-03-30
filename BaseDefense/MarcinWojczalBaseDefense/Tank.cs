using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalBaseDefense
{
    class Tank : Unit
    {
        /// <summary>
        /// Pancerz, określa jak ciężko jest zadać obrażenia pojazdowi
        /// </summary>
        public int Armor { get; set; }
        /// <summary>
        /// Konstruktor czołgu
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="firePowerLight"></param>
        /// <param name="armorPenetration"></param>
        /// <param name="firePowerHeavy"></param>
        /// <param name="firePowerAir"></param>
        /// <param name="armor"></param>
        /// <param name="target"></param>
        /// <param name="totalCost"></param>
        public Tank(string name, int health, int firePowerLight, int armorPenetration, int firePowerHeavy,
           int firePowerAir, int armor, ETarget target, int totalCost)
        {
            Name = name;
            Health = health;
            FirePowerLight = firePowerLight;
            ArmorPenetration = armorPenetration;
            FirePowerHeavy = firePowerHeavy;
            FirePowerAir = firePowerAir;
            Armor = armor;
            Target = target;
            TotalCost = totalCost;
            BaseHealth = health;
        }
    }
}
