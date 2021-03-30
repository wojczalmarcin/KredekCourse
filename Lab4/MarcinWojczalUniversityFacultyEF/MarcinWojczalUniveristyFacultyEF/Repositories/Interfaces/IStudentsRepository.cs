using MarcinWojczalUniveristyFacultyEF.ViewModels;
using MarcinWojczalUniversityFacultyEF.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Repositories.Interfaces
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
        List<StudentViewModel> GetStudents(List<int> fieldOfStudyIds, List<int> vintageIndexes);

        /// <summary>
        /// Abstrakcyjna funkcja dodająca studenta
        /// </summary>
        /// <param name="index"></param>
        /// <param name="fieldOfStudyName"></param>
        /// <param name="studyVintageYear"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <param name="pesel"></param>
        /// <param name="addressId"></param>
        /// <param name="deficit"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="eMail"></param>
        /// <returns></returns>
        bool AddStudent(int index, string fieldOfStudyName, int studyVintageYear, string firstName, string lastName, DateTime birthDate, string pesel,
              int addressId, short deficit,string phoneNumber, string eMail);

        /// <summary>
        /// Abstrakcyjna funkcja aktualizująca rekord studenta
        /// </summary>
        /// <param name="index"></param>
        /// <param name="fieldOfStudyName"></param>
        /// <param name="studyVintageYear"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <param name="pesel"></param>
        /// <param name="addressId"></param>
        /// <param name="deficit"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="eMail"></param>
        /// <returns></returns>
        bool UpdateStudent(int index, string fieldOfStudyName, int studyVintageYear, string firstName, string lastName, DateTime birthDate, string pesel,
              int addressId, short deficit, string phoneNumber, string eMail);


        /// <summary>
        /// Abstrakcyjna funkcja usuwająca rekord studenta o podanym Ideksie
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        bool DeleteStudent(int index);

        /// <summary>
        /// Abstrakcyjna metoda służąca do pobrania tabeli z jednym rekordem o określonym Indeksie
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        Student GetStudent(int studentId);
    }
}
