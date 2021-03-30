using MarcinWojczalUniveristyFacultyEF.ViewModels;
using MarcinWojczalUniversityFacultyEF.Models.Entities;
using MarcinWojczalUniversityFacultyEF.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Students
    /// </summary>
    class StudentsRepository : Repository, IStudentsRepository
    {
        /// <summary>
        /// Funkcja dodająca nowego studenta do tabeli Students
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
        public bool AddStudent(int index, string fieldOfStudyName, int studyVintageYear, string firstName, string lastName, DateTime birthDate,
            string pesel, int addressId, short deficit, string phoneNumber, string eMail)
        {
            StudyVintage studyVintage = DbContext.StudyVintages.SingleOrDefault(s => s.Year == studyVintageYear);
            FieldOfStudy fieldOfStudy = DbContext.FieldsOfStudies.SingleOrDefault(f => f.Name == fieldOfStudyName);
            if (studyVintage == null || fieldOfStudy == null)
                return false;
            Student student = new Student()
            {
                Sindex = index,
                FieldOfStudy = fieldOfStudy,
                StudyVintage = studyVintage,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                Pesel = pesel,
                AddressId = addressId,
                ECTSDeficit = deficit,
                PhoneNumber = phoneNumber,
                EMail = eMail
            };
            DbContext.Students.Add(student);
            return DbContext.SaveChanges()>0;
        }

        /// <summary>
        /// Funkcja usuwająca studenta o podabym indeksie z tabeli Students 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteStudent(int index)
        {
            Student student = DbContext.Students.SingleOrDefault(s => s.Sindex == index);
            DbContext.Students.Remove(student);
            return DbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Funkcja zwracająca studenta o podanym indeksie
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public Student GetStudent(int studentId)
        {
            return DbContext.Students.SingleOrDefault(s => s.Sindex == studentId);
        }

        /// <summary>
        /// Funkcja zwracająca numer albumu, imię nazwisko, kierunek, rok rozpoczęcia studiów studenta 
        /// z tabel Students, StudyVintages, FieldsOfStudy
        /// w zależności od wybranych filtrów
        /// </summary>
        /// <param name="fieldOfStudyIds"></param>
        /// <param name="vintageIndexes"></param>
        /// <returns></returns>
        public List<StudentViewModel> GetStudents(List<int> fieldOfStudyIds, List<int> vintageIndexes)
        {

            List<Student> students = DbContext.Students.ToList();
            List<Student> filteredStudents = new List<Student>();

            if (fieldOfStudyIds.Any())
            {
                foreach (int value in fieldOfStudyIds)
                {
                    if (vintageIndexes.Any())
                    {
                        foreach (int vintage in vintageIndexes)
                        {
                            foreach (Student student in students)
                            {
                                if (student.FieldOfStudyId == value && student.StudyVintageIndex == vintage)
                                    filteredStudents.Add(student);
                            }
                        }
                    }
                    else
                    {
                        foreach (Student student in students)
                        {
                            if (student.FieldOfStudyId == value)
                                filteredStudents.Add(student);
                        }
                    }
                }
            }else if(vintageIndexes.Any())
            {
                foreach (int vintage in vintageIndexes)
                {
                    foreach (Student student in students)
                    {
                        if (student.StudyVintageIndex == vintage)
                            filteredStudents.Add(student);
                    }
                }
            }
            else
            {
                filteredStudents = students;
            }

            return Mapper.Map<List<Student>, List<StudentViewModel>>(filteredStudents);
        }

        /// <summary>
        /// Funkcja aktualizująca studenta o zadanym Id
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
        public bool UpdateStudent(int index, string fieldOfStudyName, int studyVintageYear, string firstName, string lastName, DateTime birthDate,
            string pesel, int addressId, short deficit, string phoneNumber, string eMail)
        {
            Student student = DbContext.Students.SingleOrDefault(s => s.Sindex == index);
            StudyVintage studyVintage = DbContext.StudyVintages.SingleOrDefault(s => s.Year == studyVintageYear);
            FieldOfStudy fieldOfStudy = DbContext.FieldsOfStudies.SingleOrDefault(f => f.Name == fieldOfStudyName);
            if (studyVintage == null || fieldOfStudy == null)
                return false;

            student.FieldOfStudy = fieldOfStudy;
            student.StudyVintage = studyVintage;
            student.FirstName = firstName;
            student.LastName = lastName;
            student.BirthDate = birthDate;
            student.Pesel = pesel;
            student.AddressId = addressId;
            student.ECTSDeficit = deficit;
            student.PhoneNumber = phoneNumber;
            student.EMail = eMail;

            return DbContext.SaveChanges() > 0;
        }

    }
}
