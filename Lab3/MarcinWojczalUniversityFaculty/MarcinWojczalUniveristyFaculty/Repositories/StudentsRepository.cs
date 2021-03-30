using MarcinWojczalUniversityFaculty.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MarcinWojczalUniversityFaculty.Repositories
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
        public void AddStudent(int index, int fieldOfStudyId, int studyVintageIndex, string firstName, string lastName, string birthDate, 
            string pesel, int residencePlaceId,int deficit, int phoneNumber, string eMail)
        {
            Connection.Open();

            string insertStudentsQuery = "INSERT INTO Students VALUES (" + index + "," + fieldOfStudyId + 
                "," + studyVintageIndex + ",'" + firstName + "','" + lastName + "','" + birthDate + "','" +
                pesel + "'," + residencePlaceId  + "," + deficit  +"," + phoneNumber + ",'" + eMail + "'); ";
            SqlCommand commandInsertStudent = new SqlCommand(insertStudentsQuery, Connection);
            commandInsertStudent.ExecuteNonQuery();

            Connection.Close();
        }
        /// <summary>
        /// Funkcja usuwająca studenta o zadanym indeksie
        /// </summary>
        /// <param name="index"></param>
        public void DeleteStudent(int index)
        {
            string queryDeleteStudent = "DELETE FROM Students WHERE SIndex=" + index;

            Connection.Open();

            SqlCommand commandDeleteStudent = new SqlCommand(queryDeleteStudent, Connection);
            commandDeleteStudent.ExecuteNonQuery();

            Connection.Close();
        }
        /// <summary>
        /// Funkcja pobierająca tabelę z jednym rekordem studenta o zadanym indeksie z tabeli Students
        /// </summary>
        /// <param name="studentIdex"></param>
        /// <returns></returns>
        public DataTable GetStudent(int studentIdex)
        {
            string query = "SELECT * FROM Students WHERE SIndex = " + studentIdex + ";";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        /// <summary>
        /// Funkcja zwracająca numer albumu, imię nazwisko, kierunek, rok rozpoczęcia studiów studenta 
        /// z tabel Students, StudyVintages, FieldsOfStudy
        /// w zależności od wybranych filtrów
        /// </summary>
        /// <param name="fieldOfStudyIds"></param>
        /// <param name="vintageIndexes"></param>
        /// <returns></returns>
        public DataTable GetStudents(List<int> fieldOfStudyIds, List<int> vintageIndexes)
        {

            string query = "SELECT Sindex as 'Nr Albumu',LastName as 'Nazwisko',FirstName as 'Imię'," +
                " FieldsOfStudy.Name as 'Kierunek',StudyVintages.Year as 'Rok rozpoczęcia' ";
            if (fieldOfStudyIds.Any() || vintageIndexes.Any())
                query += "FROM (SELECT * FROM Students WHERE( ";
            else
                query += "FROM (SELECT * FROM Students ";
           
            if (fieldOfStudyIds.Any())
            {
                foreach (int value in fieldOfStudyIds)
                {
                    query += "FieldOfStudyId = " + value + " OR ";
                }
                query = query.Substring(0, query.Length - 3);
                if (vintageIndexes.Any())
                    query += ") AND (";
                else
                    query += ")";
            }
            if (vintageIndexes.Any())
            {
                foreach (int value in vintageIndexes)
                {
                    query += "StudyVintageIdex = " + value + " OR ";
                }
                query = query.Substring(0, query.Length - 3);
                query += ")";
            }
           
            query += ") AS Students LEFT JOIN FieldsOfStudy ON FieldsOfStudy.Id = Students.FieldOfStudyId " +
                    "LEFT JOIN StudyVintages ON StudyVintages.VIndex = Students.StudyVintageIdex; ";

            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        /// <summary>
        /// Funkcja aktualizująca rekord studenta
        /// </summary>
        /// <param name="index"></param>
        /// <param name="fieldOfStudyId"></param>
        /// <param name="studyVintageIndex"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <param name="pesel"></param>
        /// <param name="residencePlaceId"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="eMail"></param>
        public void UpdateStudent(int index, int fieldOfStudyId, int studyVintageIndex, string firstName, string lastName, string birthDate, string pesel, int residencePlaceId, int deficit,int phoneNumber, string eMail)
        {
            Connection.Open();

            string insertStudentsQuery = "UPDATE Students SET FieldOfStudyId =" + fieldOfStudyId +
                ",StudyVintageIdex=" + studyVintageIndex + ",FirstName='" + firstName + "',LastName='" + lastName +
                "',BirthDate='" + birthDate + "',Pesel='" + pesel + "',ResidencePlaceId=" + residencePlaceId + 
                ",ECTSDeficit=" + deficit + ",PhoneNumber=" + phoneNumber + ",EMail='" + eMail + "'WHERE SIndex=" + index + ";";
            SqlCommand commandInsertStudent = new SqlCommand(insertStudentsQuery, Connection);
            commandInsertStudent.ExecuteNonQuery();

            Connection.Close();
        }
    }
}
