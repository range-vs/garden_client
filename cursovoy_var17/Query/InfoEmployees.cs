using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cursovoy_var17.Query
{
    public partial class InfoEmployees : Form
    {
        private SqlConnection connection;

        public InfoEmployees()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["cursovoy_var17.Properties.Settings.ParkConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridView.Rows.Clear();
            string sqlExpression = $"select last_name, first_name, middle_name, date_birth, phone from employee, work where " +
                $"work.date_work = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}' and work.employee_id = employee.id ";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    object[] data = new object[GridView.Columns.Count];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                            data[i] = reader.GetValue(i);
                    }
                    GridView.Rows.Add(data);
                }
            }
            reader.Close();
        }

        private void InfoEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }
    }
}
