using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07LabExer1
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();
        private int count = 0;

        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
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
        }

        private void cbProg_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void RefreshListOfClubMembers()
        {
           clubRegistrationQuery.DisplayList();
           dataGridView1.DataSource = clubRegistrationQuery.bindingSource;
        }

        private int RegistrationID()
        {
            count += 1;
            return count;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = RegistrationID();
                long studNo = Convert.ToInt64(txtStudNo1.Text);
                string firstN = txtFirstN.Text;
                string middleN = txtMDL.Text;
                string lastN = txtLastN.Text;
                int age = Convert.ToInt32(txtAge.Text);
                string gender = cbGender.SelectedItem.ToString();
                string program = cbProg.SelectedItem.ToString();

                clubRegistrationQuery.RegisterStudent(ID, studNo, firstN, middleN, lastN, age, gender, program);
                RefreshListOfClubMembers();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                int selectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                FrmUpdateMember updateForm = new FrmUpdateMember(selectedID);
                updateForm.FormClosed += UpdateForm_FormClosed;
                updateForm.Show();
            }
        }

        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void ClearInputs()
        {
            txtStudNo1.Clear();
            txtFirstN.Clear();
            txtMDL.Clear();
            txtLastN.Clear();
            txtAge.Clear();
            cbGender.SelectedIndex = -1;
            cbProg.SelectedIndex = -1;
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }
    }
}
