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
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DC\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void FormStatistics_Load(object sender, EventArgs e)
        {
            //Total Number of Employee
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select Count(*) From Table_1", connection);
            SqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read())
            {
                lblTotalEmp.Text = dr1[0].ToString();   
            }
            connection.Close();

            // Total Number of Married
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select Count(*) From Table_1 Where EmpStatus = 1", connection);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                lblMarried.Text = dr2[0].ToString();    
            }
            connection.Close();

            //Total Number of Single
            connection.Open();
            SqlCommand command3 = new SqlCommand("Select Count(*) From Table_1 Where EmpStatus = 0", connection);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
               lblEmpSingle.Text = dr3[0].ToString();
            }
            connection.Close();

            //Number of Cities
            connection.Open();
            SqlCommand command4 = new SqlCommand("Select Count(distinct(EmpCity)) From Table_1", connection);
            SqlDataReader dr4 = command4.ExecuteReader();
            while (dr4.Read())
            {
                lblTotalCities.Text = dr4[0].ToString();    
            }
            connection.Close();

            // Total Salary 
            connection.Open();
            SqlCommand command5 = new SqlCommand("Select Sum(EmpSalary) From Table_1", connection);
            SqlDataReader dr5 = command5.ExecuteReader();
            while (dr5.Read())
            {
                lblTotalSalary.Text = dr5[0].ToString();    
            }
            connection.Close();

            // Average Salary
            connection.Open();
            SqlCommand command6 = new SqlCommand("Select Avg(EmpSalary) From Table_1", connection);
            SqlDataReader dr6 = command6.ExecuteReader();
            while (dr6.Read())
            {
                lblAvgSalary.Text = dr6[0].ToString();
            }
            connection.Close();
        }
    }
}
