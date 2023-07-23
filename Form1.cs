using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeRecordNET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DC\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        void clear()
        {
            txtBoxEmpId.Text = "";
            txtBoxEmpName.Text = "";
            txtBoxEmpSurname.Text = "";
            cmbBoxEmpCity.Text = "";
            mskdTxtBoxEmpSalary.Text = "";
            rdBtnSingle.Checked = false;
            rdBtnMarried.Checked = false;
            txtBoxEmpJob.Text = "";
            txtBoxEmpName.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.Table_1' table. You can move, or remove it, as needed.
            

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.table_1TableAdapter.Fill(this.personelVeriTabaniDataSet.Table_1);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("insert into Table_1 (EmpName, EmpSurname, EmpCity, EmpSalary, EmpJob, EmpStatus) values (@c1, @c2, @c3, @c4, @c5, @c6)", connection);
            command.Parameters.AddWithValue("@c1", txtBoxEmpName.Text);
            command.Parameters.AddWithValue("@c2", txtBoxEmpSurname.Text);
            command.Parameters.AddWithValue("@c3", cmbBoxEmpCity.Text);
            command.Parameters.AddWithValue("@c4", mskdTxtBoxEmpSalary.Text);
            command.Parameters.AddWithValue("@c5", txtBoxEmpJob.Text);
            command.Parameters.AddWithValue("@c6", lblControl.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Employee added");

            connection.Close();
        }

        private void rdBtnSingle_CheckedChanged(object sender, EventArgs e)
        {
            lblControl.Text = "False";
        }

        private void rdBtnMarried_CheckedChanged(object sender, EventArgs e)
        {
            lblControl.Text = "True";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtBoxEmpId.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            txtBoxEmpName.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txtBoxEmpSurname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();   
            cmbBoxEmpCity.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();  
            mskdTxtBoxEmpSalary.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            lblControl.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
            txtBoxEmpJob.Text = dataGridView1.Rows[chosen].Cells[6].Value.ToString();

        }

        private void lblControl_TextChanged(object sender, EventArgs e)
        {
            if(lblControl.Text == "True")
            {
                rdBtnSingle.Checked = false;
                rdBtnMarried.Checked = true;
            }
            else if(lblControl.Text == "False")
            {
                rdBtnMarried.Checked = false;
                rdBtnSingle.Checked = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commandDelete = new SqlCommand("Delete From Table_1 Where EmployeeId = @cd1", connection);
            commandDelete.Parameters.AddWithValue("@cd1", txtBoxEmpId.Text);
            commandDelete.ExecuteNonQuery();    
            connection.Close();
            MessageBox.Show("Record deleted.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commandUpdate = new SqlCommand("Update Table_1 Set EmpName=@cu1, EmpSurname=@cu2, EmpCity=@cu3, EmpSalary=@cu4, EmpStatus=@cu5, EmpJob=@cu6 where EmployeeId=@cu7", connection);
            commandUpdate.Parameters.AddWithValue("@cu1", txtBoxEmpName.Text);
            commandUpdate.Parameters.AddWithValue("@cu2", txtBoxEmpSurname.Text);
            commandUpdate.Parameters.AddWithValue("@cu3", cmbBoxEmpCity.Text);
            commandUpdate.Parameters.AddWithValue("@cu4", mskdTxtBoxEmpSalary.Text);
            commandUpdate.Parameters.AddWithValue("@cu5", lblControl.Text);
            commandUpdate.Parameters.AddWithValue("@cu6", txtBoxEmpJob.Text);
            commandUpdate.Parameters.AddWithValue("@cu7", txtBoxEmpId.Text);
            commandUpdate.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Employee information is updated.");
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics();   
            formStatistics.Show();    
        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
            FormGraphics formGraphics = new FormGraphics();
            formGraphics.Show();
        }
    }
}
