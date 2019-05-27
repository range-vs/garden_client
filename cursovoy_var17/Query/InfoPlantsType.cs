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
    public partial class InfoPlantsType : Form
    {
        private SqlConnection connection;
        private List<string> namesColumns;
        public InfoPlantsType()
        {
            InitializeComponent();
            namesColumns = new List<string>
            {
                "Наименование растения",
                "Дата посадки",
                "Возраст",
                "Тип",
                "Дата полива",
                "Объём(в литрах)",
                "Зона парка",
                "Парк",
                "Имя декоратора",
                "Фамилия декоратора",
                "Отчество декоратора",
                "Телефон декоратора",
                "Адрес декоратора",
                "Дата рождения декоратора",
                "Специальность декоратора",
                "Категория декоратора",
                "Учебное заведение декоратора",
                "Дата работ",
                "Имя работника",
                "Фамилия работника",
                "Отчество работника",
                "Телефон работника",
                "Адрес работника",
                "Дата рождения работника"
            };
            string connectionString = ConfigurationManager.ConnectionStrings["cursovoy_var17.Properties.Settings.ParkConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridView.Rows.Clear();
            string sqlExpression = $"select * from plant, plant_type, watering, [zone], park, decorator, education, work, employee where " +
                $"plant_type.[name] like '%{textBox1.Text}%' and plant.plant_type_id = plant_type.id and " +
                $"watering.plant_id = plant.id and " +
                $"[zone].id = plant.zone_id and " +
                $"[zone].park_id = park.id and " +
                $"decorator.park_id = park.id and " +
                $"decorator.education_id = education.id and " +
                $"work.plant_id = plant.id and " +
                $"work.employee_id = employee.id";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = null;

            try
            {
                reader = command.ExecuteReader();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }
            if (reader.HasRows)
            {
                if (GridView.Columns.Count == 0)
                {
                   for(int i = 0, j = 0;i< reader.FieldCount;i++)
                    {
                        if(!reader.GetName(i).Contains("id_") && !reader.GetName(i).Contains("_id") && reader.GetName(i) != "id")
                        {
                            GridView.Columns.Add(reader.GetName(i), namesColumns[j++]);
                        }
                    }
                }
                while (reader.Read()) 
                {
                    object[] data = new object[GridView.Columns.Count];
                    for (int i = 0, j = 0; i < reader.FieldCount; i++)
                    {
                        if (!reader.GetName(i).Contains("id_") && !reader.GetName(i).Contains("_id") && reader.GetName(i) != "id")
                        {
                            data[j++] = reader.GetValue(i);
                        }
                    }
                    GridView.Rows.Add(data);
                }
            }

            reader.Close();
        }

        private void InfoPlantsType_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }
    }
}

