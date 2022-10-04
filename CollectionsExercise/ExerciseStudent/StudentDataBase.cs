using CollectionsExercise.ExerciseStudent.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace CollectionsExercise.ExerciseStudent
{
    public class StudentDataBase
    {
        private const string _connectionString = @"Data Source=DESKTOP-LPIQIBR\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

        private SqlConnection ConnectWithDatabase()
        {
            var sqlConnection = new SqlConnection(_connectionString);

            return sqlConnection;
        }

        public void GetStudents()
        {
            var sqlConnection = ConnectWithDatabase();

            using (sqlConnection)
            {
                string query = "Select * from Students";

                var sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();

                var sqlDataReader = sqlCommand.ExecuteReader();

                try
                {
                    var students = new List<Student>();

                    while (sqlDataReader.Read())
                    {
                        int id = Convert.ToInt32(sqlDataReader[0]);
                        string firstname = sqlDataReader[1].ToString();
                        string surname = sqlDataReader[2].ToString();
                        int indexnumber = Convert.ToInt32(sqlDataReader[3]);
                        string sex = sqlDataReader[4].ToString();

                        DateTime Birthdate = Convert.ToDateTime(sqlDataReader[5]);
                        DateTime adddate = Convert.ToDateTime(sqlDataReader[6]);

                        var student = new Student();
                        student.Id = id;
                        student.FirstName = firstname;
                        student.Surname = surname;
                        student.IndexNumber = indexnumber;
                        student.Sex = sex;

                        student.Birthdate = Birthdate;
                        student.DateAdd = adddate;

                        students.Add(student);
                    }
                    sqlConnection.Close();
                    sqlDataReader.Close();
                }
                catch (Exception)
                {
                    sqlConnection.Close();
                    sqlDataReader.Close();
                    throw;
                }
            }
        }

        public void GetAcademy()
        {
            var sqlConnection = ConnectWithDatabase();

            using (sqlConnection)
            {
                string query = "Select * from Academy";

                var sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();

                var sqlDataReader = sqlCommand.ExecuteReader();


                try
                {
                    var academis = new List<Academy>();

                    while (sqlDataReader.Read())
                    {
                        int id = Convert.ToInt32(sqlDataReader[0]);
                        string name = sqlDataReader[1].ToString();
                        string city = sqlDataReader[2].ToString();
                        DateTime adddate = Convert.ToDateTime(sqlDataReader[3]);

                        var academy = new Academy();
                        academy.Id = id;
                        academy.Name = name;
                        academy.City = city;
                        academy.DateAdd = adddate;

                        academis.Add(academy);
                    }
                    sqlConnection.Close();
                    sqlDataReader.Close();
                }
                catch (Exception)
                {
                    sqlConnection.Close();
                    sqlDataReader.Close();
                    throw;
                }
            }
        }
        public void GetAcademyStudents()
        {
            var sqlConnection = ConnectWithDatabase();

            using (sqlConnection)
            {
                string query = "Select * from Student_Academy";

                var sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();

                var sqlDataReader = sqlCommand.ExecuteReader();


                try
                {
                    var studentsAcademy = new List<StudentsAcademy>();

                    while (sqlDataReader.Read())
                    {
                        int id = Convert.ToInt32(sqlDataReader[0]);
                        int indexnumber = Convert.ToInt32(sqlDataReader[1]);
                        int academyid = Convert.ToInt32(sqlDataReader[2]); ;
                        
                        DateTime adddate = Convert.ToDateTime(sqlDataReader[3]);

                        var studentAcademy = new StudentsAcademy();
                        studentAcademy.Id = id;
                        
                        studentAcademy.AcademyId = academyid;

                        studentAcademy.DateAdd = adddate;

                        studentsAcademy.Add(studentAcademy);
                    }
                    sqlConnection.Close();
                    sqlDataReader.Close();
                }
                catch (Exception)
                {
                    sqlConnection.Close();
                    sqlDataReader.Close();
                    throw;
                }
            }
        }
    }

}
