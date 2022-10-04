using CollectionsExercise.ExerciseStudent.Models;
using System.Data;
using System.Data.SqlClient;

namespace CollectionsExercise.ExerciseStudent.Repositories
{
    public partial class StudentRepository
    {
        List<Student> _studentsdata = new List<Student>();
        List<Academy> _academis = new List<Academy>();
        List<StudentsAcademy> _studentsacademis = new List<StudentsAcademy>();
        private const string _connectionString = @"Data Source=DESKTOP-LPIQIBR\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

        private SqlConnection ConnectWithDatabase()
        {
            var sqlConnection = new SqlConnection(_connectionString);

            return sqlConnection;
        }

        public List<Student> GetAll()
        {
            var sqlConnection = ConnectWithDatabase();
            var sqlDataAdapter = new SqlDataAdapter("Select * from Students", sqlConnection);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Students");

            _studentsdata = dataSet.Tables[0].AsEnumerable()
                .Select(dataRow => new Student
                {
                    Id = dataRow.Field<int>("ID"),
                    FirstName = dataRow.Field<string>("FIRSTNAME"),
                    Surname = dataRow.Field<string>("SURNAME"),
                    IndexNumber = dataRow.Field<int>("INDEXNUMBER"),
                    Sex = dataRow.Field<string>("SEX"),
                    Birthdate = dataRow.Field<DateTime>("BIRTHDATE"),
                    DateAdd = dataRow.Field<DateTime>("ADDDATE")
                }).ToList();

            return _studentsdata;
        }

        public List<StudentsAcademy> GetStudentsAcademy()
        {
            var sqlConnection = ConnectWithDatabase();
            var sqlDataAdapter = new SqlDataAdapter("Select * from Student_Academy", sqlConnection);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Student_Academy");

            _studentsacademis = dataSet.Tables[0].AsEnumerable()
                .Select(dataRow => new StudentsAcademy
                {
                    Id = dataRow.Field<int>("STUDENT_ID"),

                    AcademyId = dataRow.Field <int?>("ACADEMY_ID"),
                    DateAdd = dataRow.Field<DateTime>("ADDDATE")
                }).ToList();
            
            return _studentsacademis;
        }


        public List<Academy> GetAllAcademis()
        {
            var sqlConnection = ConnectWithDatabase();
            var sqlDataAdapter = new SqlDataAdapter("Select * from Academy", sqlConnection);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Academy");

            _academis = dataSet.Tables[0].AsEnumerable()
                .Select(dataRow => new Academy
                {
                    Id = dataRow.Field<int>("ID"),
                    Name = dataRow.Field<string>("NAME"),
                    City = dataRow.Field<string>("CITY"),
                    DateAdd = dataRow.Field<DateTime>("ADDDATE")
                }).ToList();

            return _academis;
        }


        public bool Add(Student student)
        {
            var sqlConnection = ConnectWithDatabase();
            
            try
            {
                int id = student.Id;
                string firstname = student.FirstName;
                string surname = student.Surname;
                string indexNumber = student.IndexNumber.ToString();
                string sex = student.Sex;
                string birthdate = student.Birthdate.ToString("yyyy-MM-dd");
                string adddate = student.DateAdd.ToString("yyyy-MM-dd");

                string query = "";
                if (id > 0)
                {
                    query = $"UPDATE STUDENTS SET FIRSTNAME = '{firstname}', SURNAME = '{surname}', INDEXNUMBER = {indexNumber}, SEX = '{sex}'," +
                       $"BIRTHDATE = '{birthdate}', ADDDATE = '{adddate}' where ID = {id}";
                }
                else
                {
                    query = "insert into Students (FIRSTNAME, SURNAME, INDEXNUMBER, SEX, BIRTHDATE, ADDDATE) values " +
                   $"('{firstname}','{surname}', {indexNumber}, '{sex}', '{birthdate}','{adddate}')";
                }

                var sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();

                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
                
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public bool Delete(int idStudentToDelete)
        {
            var sqlConnection = ConnectWithDatabase();
            string query = "DELETE FROM STUDENTS where ID = @ID";


            try
            {
                using (sqlConnection)
                {
                    
                    var sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();

                    sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                    sqlCommand.Parameters["@ID"].Value = idStudentToDelete;

                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    return true;

                }

            }
            catch (Exception)
            {
                sqlConnection.Close();
                throw;
            }
        }

    }
}