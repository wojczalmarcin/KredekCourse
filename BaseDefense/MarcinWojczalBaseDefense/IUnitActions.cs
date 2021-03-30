using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalBaseDefense
{
    interface IUnitActions
    {
        /// <summary>
        /// Funkcja odpowiedzialna za atak
        /// </summary>
        /// <param name="enemyArmy"></param>
        /// <param name="random"></param>
        void Attack(Army enemyArmy,Random random);
    }
}
