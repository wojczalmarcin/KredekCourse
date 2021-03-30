using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalBaseDefense
{
    abstract class Unit : IUnitActions
    {
        /// <summary>
        /// Nazwa jednostki
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ilość punktów życia jednostki
        /// </summary>
        public int Health { get; set; }
        /// <summary>
        /// Zadawane obrażenia przeciwko jednostkom lekko opancerzonym (piechocie)
        /// </summary>
        public int FirePowerLight { get; set; }
        /// <summary>
        /// Wartość maksymalnego przebicia pancerza
        /// </summary>
        public int ArmorPenetration { get; set; }
        /// <summary>
        /// Zadawane obrażenia przeciwko jednostkom silnie opancerzonym (czołgom)
        /// </summary>
        public int FirePowerHeavy { get; set; }
        /// <summary>
        /// Zadawane obrażenia przeciwko samolotom
        /// </summary>
        public int FirePowerAir { get; set; }
        /// <summary>
        /// Rodzaj celu, który jednostka ma atakować
        /// </summary>
        public ETarget Target { get; set; }
        /// <summary>
        /// Całkowity koszt jednostki
        /// </summary>
        public int TotalCost { get; set; }
        /// <summary>
        /// Bazowa wartość punktów życia
        /// </summary>
        public int BaseHealth { get; set; }

        /// <summary>
        /// Funkcja odpowiedzialna za zmniejszenie zdrowia jednostki o zadaną wartość
        /// </summary>
        /// <param name="damage"></param>
        public void GetDamage(int damage)
        {
            Health -= damage;
        }
  
        /// <summary>
        /// Funkcja odpowiadająca za wybranie oraz zaatakowanie celu
        /// </summary>
        /// <param name="infantryList"></param>
        /// <param name="tankList"></param>
        /// <param name="planeList"></param>
        public void Attack(Army enemyArmy, Random random)
        {
            if (Target == ETarget.Infantry)
            {
                if (enemyArmy.InfantryList.Any())
                    AttackInfantry(enemyArmy.InfantryList, random);
                else if (enemyArmy.TankList.Any())
                    AttackTank(enemyArmy.TankList, random);
                else if (enemyArmy.PlaneList.Any())
                    AttackPlane(enemyArmy.PlaneList, random);
            }
            else if(Target == ETarget.Tank)
            {
                if (enemyArmy.TankList.Any())
                    AttackTank(enemyArmy.TankList, random);
                else if (enemyArmy.InfantryList.Any())
                    AttackInfantry(enemyArmy.InfantryList, random);
                else if (enemyArmy.PlaneList.Any())
                    AttackPlane(enemyArmy.PlaneList, random);
            }
            else
            {
                if (enemyArmy.PlaneList.Any())
                    AttackPlane(enemyArmy.PlaneList, random);
                else if (enemyArmy.TankList.Any())
                    AttackTank(enemyArmy.TankList, random);
                else if (enemyArmy.InfantryList.Any())
                    AttackInfantry(enemyArmy.InfantryList, random);
            }
        }
       /// <summary>
       /// Funkcja odpowiadająca za atak na jednostki piechoty w liście
       /// </summary>
       /// <param name="infantryList"></param>
       /// <param name="random"></param>
        private void AttackInfantry(List<Infantry> infantryList, Random random)
        {
            int listIndex = random.Next(infantryList.Count);
            infantryList[listIndex].GetDamage(FirePowerLight);
            if (infantryList[listIndex].Health <= 0)
            {
                infantryList.RemoveAt(listIndex);
            }
        }
        /// <summary>
        /// Funkcja odpowiadająca za atak na czołgi w liście
        /// </summary>
        /// <param name="tankList"></param>
        /// <param name="random"></param>
        private void AttackTank(List<Tank> tankList, Random random)
        {
           
            // jeśli penetracja pancerza jest mniejsza od pancerza celu to zadaje się 1/4 obrażeń
            int listIndex = random.Next(tankList.Count);
            if (ArmorPenetration > tankList[listIndex].Armor)
                tankList[listIndex].GetDamage(FirePowerHeavy);
            else
                tankList[listIndex].GetDamage(FirePowerHeavy / 4);
            if (tankList[listIndex].Health <= 0)
            {
                tankList.RemoveAt(listIndex);
            }
        }
        /// <summary>
        /// Funkcja odpowiadająca za atak na samoloty w liście
        /// </summary>
        /// <param name="planeList"></param>
        /// <param name="random"></param>
        private void AttackPlane(List<Plane> planeList, Random random)
        {
            // im większa jest manewrowość samolotu tym ciężej trafić
            int listIndex = random.Next(planeList.Count);
            if (random.Next(planeList[listIndex].Maneuverability) <= 1)
                planeList[listIndex].GetDamage(FirePowerAir);
            if (planeList[listIndex].Health <= 0)
            {
                planeList.RemoveAt(listIndex);
            }
        }
    }
   
}
