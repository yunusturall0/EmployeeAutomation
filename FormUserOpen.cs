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
    public partial class FormUserOpen : Form
    {
        public FormUserOpen()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DC\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select * From UserAdmin Where UserName=@c1 and Password=@c2", connection);
            command1.Parameters.AddWithValue("@c1", txtBoxUserName.Text);
            command1.Parameters.AddWithValue("@c2", txtBoxPass.Text);
            SqlDataReader dr1 = command1.ExecuteReader();
            if (dr1.Read())
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong.");
            }
            connection.Close();
        }
    }
}
