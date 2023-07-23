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
    public partial class FormGraphics : Form
    {
        public FormGraphics()
        {
            InitializeComponent();
        }
        
        SqlConnection connection = new SqlConnection("Data Source=DC\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void FormGraphics_Load(object sender, EventArgs e)
        {
            //Graphics1 Cities
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select EmpCity, Count(*) From Table_1 Group By EmpCity", connection);
            SqlDataReader dr1 = command1.ExecuteReader();   
            while (dr1.Read())
            {
                chart1.Series["Cities"].Points.AddXY(dr1[0], dr1[1]);
            }
            connection.Close();

            //Graphics2 Job-Salary
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select EmpJob, Avg(EmpSalary) From Table_1 Group By EmpJob", connection);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Job-Salary"].Points.AddXY(dr2[0], dr2[1]);
            }
            connection.Close();
        }
    }
}
