using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07LabExer1
{
    public partial class FrmUpdateMember : Form
    {
        private int memberID;
        private SqlCommand sqlCommand;
        private ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();
        private SqlDataReader sqlDataReader;
        private SqlConnection sqlConnect;
        private string connectionString =
       @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arnel_Carbonell\source\repos\07LabExer1\07LabExer1\ClubDB.mdf; Integrated Security=True";

        public FrmUpdateMember(int id)
        {
            InitializeComponent();
            memberID = id;
        }

        private void LoadStudentIDs()
        {
            cbStudNum.Items.Clear();
            sqlConnect.Open();
            sqlCommand = new SqlCommand("SELECT StudentID FROM ClubMembers", sqlConnect);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbStudNum.Items.Add(sqlDataReader["StudentID"].ToString());
            }
            sqlDataReader.Close();
            sqlConnect.Close();
        }


        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            sqlConnect = new SqlConnection(connectionString);
            LoadStudentIDs();
            clubRegistrationQuery.DisplayList();
            DataTable dt = clubRegistrationQuery.dataTable;

            cbProg.Items.AddRange(new string[] {
                "BSIT",
                "BSCS",
                "BSIS",
                "BSSE",
                "BSCE"
            });

            cbGender.Items.AddRange(new string[] {
                "Male",
                "Female"
            });

            DataRow[] rows = dt.Select("ID = " + memberID);
            if (rows.Length > 0)
            {
                DataRow row = rows[0];
                cbStudNum.Text = row["StudentID"].ToString();
                txtFirstN.Text = row["FirstName"].ToString();
                txtMDL.Text = row["MiddleName"].ToString();
                txtLastN.Text = row["LastName"].ToString();
                txtAge.Text = row["Age"].ToString();
                cbGender.SelectedItem = row["Gender"].ToString();
                cbProg.SelectedItem = row["Program"].ToString();
            }


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = memberID;
                long studentID = long.Parse(cbStudNum.Text);
                string firstName = txtFirstN.Text;
                string middleName = txtMDL.Text;
                string lastName = txtLastN.Text;
                int age = int.Parse(txtAge.Text);
                string Gender = cbGender.SelectedItem.ToString();
                string prog = cbProg.SelectedItem.ToString();

                clubRegistrationQuery.UpdateMember(ID, studentID, firstName, middleName, lastName, age, Gender, prog);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbProg_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
