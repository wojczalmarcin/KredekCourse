using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFaculty.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Students
    /// </summary>
    interface IStudentsRepository
    {
        /// <summary>
        /// Abstrakcyjna metoda służąca do pobierania określonych studentów z tabeli Students
        /// </summary>
        /// <param name="fieldOfStudyIds"></param>
        /// <param name="vintageIndexes"></param>
        /// <returns></returns>
        DataTable GetStudents(List<int> fieldOfStudyIds, List<int> vintageIndexes);

        /// <summary>
        /// Abstrakcyjna funkcja dodająca studenta
        /// </summary>
        /// <param name="index"></param>
        /// <param name="fieldOfStudyId"></param>
        /// <param name="studyVintageIndex"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <param name="pesel"></param>
        /// <param name="residencePlaceId"></param>
        /// <param name="deficit"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="eMail"></param>
        void AddStudent(int index, int fieldOfStudyId, int studyVintageIndex, string firstName, string lastName, string birthDate, string pesel,
              int residencePlaceId, int deficit,int phoneNumber, string eMail);

        /// <summary>
        /// Abstrakcyjna funkcja aktualizująca rekord studenta
        /// </summary>
        /// <param name="index"></param>
        /// <param name="fieldOfStudyId"></param>
        /// <param name="studyVintageIndex"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <param name="pesel"></param>
        /// <param name="residencePlaceId"></param>
        /// <param name="deficit"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="eMail"></param>
        void UpdateStudent(int index, int fieldOfStudyId, int studyVintageIndex, string firstName, string lastName, string birthDate, string pesel,
              int residencePlaceId, int deficit,int phoneNumber, string eMail);


        /// <summary>
        /// Abstrakcyjna funkcja usuwająca rekord studenta o podanym Ideksie
        /// </summary>
        /// <param name="index"></param>
        void DeleteStudent(int index);

        /// <summary>
        /// Abstrakcyjna metoda służąca do pobrania tabeli z jednym rekordem o określonym Indeksie
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        DataTable GetStudent(int studentId);
    }
}
