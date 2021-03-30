using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFaculty.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący postawowe funkcje Klas definiujących metody związane z komunikacją z bazą danych
    /// </summary>
    interface IBasicRepositoryFunctions
    {
        /// <summary>
        /// Abstrakcyjna metoda do pobierania określonych odpowiednim zapytaniem rekordów z tabeli
        /// </summary>
        /// <returns></returns>
        DataTable GetRepository();
    }
}
