using cursovoy_var17.DataBaseForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using System.Configuration;
using cursovoy_var17.Query;

namespace cursovoy_var17
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void DecoratorsWindowClick(object sender, EventArgs e)
        {
            DecoratorsForm dec = new DecoratorsForm { Text = "Декораторы" };
            dec.ShowDialog();
        }

        private void EducationsWindowClick(object sender, EventArgs e)
        {
            EducationForm edu = new EducationForm { Text = "Образование" };
            edu.ShowDialog();
        }

        private void ParksWindowClick(object sender, EventArgs e)
        {
            ParkForm park = new ParkForm { Text = "Парки" };
            park.ShowDialog();
        }

        private void ZonesParksWindowClick(object sender, EventArgs e)
        {
            ZonesParksForm zp = new ZonesParksForm { Text = "Зоны парков" };
            zp.ShowDialog();
        }

        private void WateringWindowClick(object sender, EventArgs e)
        {
            WateringForm wat = new WateringForm { Text = "Полив" };
            wat.ShowDialog();
        }

        private void PlantsWindowClick(object sender, EventArgs e)
        {
            PlantsForm plan = new PlantsForm { Text = "Растения" };
            plan.ShowDialog();
        }

        private void TypePlantsWindowClick(object sender, EventArgs e)
        {
            TypePlantsForm typePlantsForm = new TypePlantsForm { Text = "Виды растений" };
            typePlantsForm.ShowDialog();
        }

        private void WorkWindowClick(object sender, EventArgs e)
        {
            WorkForm work = new WorkForm { Text = "График работы" };
            work.ShowDialog();
        }

        private void EmployeeWindowClick(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm { Text = "Сотрудники" };
            emp.ShowDialog();
        }

        private void QueryFirstWindowClick(object sender, EventArgs e)
        {
            InfoPlantsType inf = new InfoPlantsType() { Text = "Список растений"};
            inf.ShowDialog();
        }

        private void QuerySecondWindowClick(object sender, EventArgs e)
        {
            InfoEmployees inf = new InfoEmployees() { Text = "Список сотрудников" };
            inf.ShowDialog();
        }

        private void QueryThird_Click(object sender, EventArgs e)
        {
            InfoPlantsTime inf = new InfoPlantsTime() { Text = "Список растений" };
            inf.ShowDialog();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Компания \"ParkPro\". Клиент,для работы с базой данных.{Environment.NewLine}Создатель: range(Трубников Иван)(c){Environment.NewLine}ИСТ, Б2331, 3 курс, ВГТУ, 23.12.2018", "О программе");
        }
    }
}
