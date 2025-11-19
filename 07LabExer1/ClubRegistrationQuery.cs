using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07LabExer1
{
    internal class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect;
        private SqlConnection sqlCommand;
        private SqlDataAdapter sqlAdapter;
        public DataTable dataTable = new DataTable();
        public BindingSource bindingSource = new BindingSource();
        private string connectionString =
        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arnel_Carbonell\source\repos\07LabExer1\07LabExer1\ClubDB.mdf; Integrated Security=True";


        public ClubRegistrationQuery()
        {
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource.DataSource = dataTable;
        }

        public bool DisplayList()
        {
         
            string viewClubMembers =
                "SELECT ID, StudentID, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";
            sqlAdapter = new SqlDataAdapter(viewClubMembers, sqlConnect);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            return true;
        }

        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age,
            string Gender, string Program)
        {
            string registerMember =
                "INSERT INTO ClubMembers (ID, StudentID, FirstName, MiddleName, LastName, Age, Gender, Program) " +
                "VALUES (@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)";
            using (SqlCommand sqlCmd = new SqlCommand(registerMember, sqlConnect))
            {
                sqlCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                sqlCmd.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
                sqlCmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Value = FirstName;
                sqlCmd.Parameters.Add("@MiddleName", SqlDbType.NVarChar, 50).Value = MiddleName;
                sqlCmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Value = LastName;
                sqlCmd.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                sqlCmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 10).Value = Gender;
                sqlCmd.Parameters.Add("@Program", SqlDbType.NVarChar, 50).Value = Program;

                sqlConnect.Open();
                int rowsAffected = sqlCmd.ExecuteNonQuery();
                sqlConnect.Close();
                return rowsAffected > 0;
            }
        }

        public bool UpdateMember(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age,
            string Gender, string Program)
        {
            string updateMember =
                "UPDATE ClubMembers SET StudentID=@StudentID, FirstName=@FirstName, MiddleName=@MiddleName," +
                " LastName=@LastName, Age=@Age, Gender=@Gender, Program=@Program WHERE ID=@ID";
            using (SqlCommand sqlCmd = new SqlCommand(updateMember, sqlConnect))
            {
                sqlCmd.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
                sqlCmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Value = FirstName;
                sqlCmd.Parameters.Add("@MiddleName", SqlDbType.NVarChar, 50).Value = MiddleName;
                sqlCmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Value = LastName;
                sqlCmd.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                sqlCmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 10).Value = Gender;
                sqlCmd.Parameters.Add("@Program", SqlDbType.NVarChar, 50).Value = Program;
                sqlCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                sqlConnect.Open();
                int rowsAffected = sqlCmd.ExecuteNonQuery();
                sqlConnect.Close();
                return rowsAffected > 0;
            }
        }
    }









    }

