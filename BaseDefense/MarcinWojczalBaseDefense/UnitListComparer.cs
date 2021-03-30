using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalBaseDefense
{
    class UnitListComparer : IComparer<Unit>
    {
        /// <summary>
        /// Porównuje dwa obiekty klasy Unit po ich nazwie
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(Unit x, Unit y)
        {
            if (object.ReferenceEquals(x, y))
                return 0;

            if (x == null)
                return -1;

            if (y == null)
                return 1;

            return x.Name.CompareTo(y.Name);
        }
    }
}
