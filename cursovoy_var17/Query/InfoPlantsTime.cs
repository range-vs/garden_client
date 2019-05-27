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
    public partial class InfoPlantsTime : Form
    {
        private SqlConnection connection;

        public InfoPlantsTime()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["cursovoy_var17.Properties.Settings.ParkConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridView.Rows.Clear();
            string sqlExpression = $"select plant.[name], watering.date_action, watering.value from plant, watering, plant_type where " +
                $"plant.date_start = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}' and plant_type.[name] like '%{textBox1.Text}%' and watering.plant_id = plant.id";
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
    }
}
