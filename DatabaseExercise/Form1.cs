using DatabaseExercise.Models;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseExercise
{
    public partial class Form1 : Form
    {
        private const string _connectionString = @"Data Source=DESKTOP-LPIQIBR\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmployees();
            //AddEmployee();
            ModifyEmployee();


            //DeleteEmployee();
        }

        private SqlConnection ConnectWithDatabase()
        {
            var sqlConnection = new SqlConnection(_connectionString);

            return sqlConnection;
        }

        private void AddEmployee()
        {
            var sqlConnection = ConnectWithDatabase();
            try
            {
                using (sqlConnection)
                {
                    string query = " insert into pracownicy (nazwisko, etat, id_szefa, zatrudniony, płaca_pod, płaca_dod, id_zesp) values " +
                                    "('iksinski', 'adiunkt', 100, GETDATE(), 1000, 200, 20)";

                    var sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();

                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.ExecuteNonQuery();

                   sqlConnection.Close();
                }
            }
            catch (Exception)
            {
                sqlConnection.Close();
                throw;
            }
            
        }

        private void DeleteEmployee()
        {
            var sqlConnection = ConnectWithDatabase();
            string query = "DELETE FROM PRACOWNICY where ID_PRAC = @IDPRAC";

            try
            {
                using(sqlConnection)
                {
                    
                    var sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();

                    sqlCommand.Parameters.Add("@IDPRAC", SqlDbType.Int);
                    sqlCommand.Parameters["@IDPRAC"].Value = 510;

                    //sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                }
                
            }
            catch (Exception)
            {
                sqlConnection.Close();
                throw;
            }
        }
        private void ModifyEmployee()
        {
            var sqlConnection = ConnectWithDatabase();
            string query = "UPDATE PRACOWNICY  SET NAZWISKO = 'Zielony' WHERE ID_PRAC = 220";

            try
            {
                using (sqlConnection)
                {
                    var sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();

                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                }

            }
            catch (Exception)
            {
                sqlConnection.Close();
                throw;
            }
        }

        private void GetEmployees()
        {
            var sqlConnection = ConnectWithDatabase();

            using (sqlConnection)
            {
                string query = "Select * from PRACOWNICY";

                var sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();

                var sqlDataReader = sqlCommand.ExecuteReader();

                try
                {
                    var employees = new List<Employee>();

                    while (sqlDataReader.Read())
                    {
                        int id = Convert.ToInt32(sqlDataReader[0]);
                        string surname = sqlDataReader[1].ToString();
                        string job = sqlDataReader[2].ToString();
                        int? supervisor = null;

                        if (!Convert.IsDBNull(sqlDataReader[3]))
                        {
                            supervisor = Convert.ToInt32(sqlDataReader[3]);

                        }

                        DateTime dateOfEnmployment = Convert.ToDateTime(sqlDataReader[4]);
                        decimal basicCompensation = Convert.ToDecimal(sqlDataReader[5]);
                        decimal? premium = null;

                        if (!Convert.IsDBNull(sqlDataReader[6]))
                        {
                            premium = Convert.ToDecimal(sqlDataReader[6]);

                        }

                        var employee = new Employee();
                        employee.Id = id;
                        employee.Surname = surname;
                        employee.Job = job;
                        employee.Supervisor = supervisor;
                        employee.DateOfEnmployment = dateOfEnmployment;
                        employee.BasicSalary = basicCompensation;
                        employee.Premimum = premium;

                        employees.Add(employee);
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