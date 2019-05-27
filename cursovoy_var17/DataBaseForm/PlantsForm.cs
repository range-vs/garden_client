using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cursovoy_var17.DataBaseForm
{
    public partial class PlantsForm : Form
    {
        public PlantsForm()
        {
            InitializeComponent();
        }

        private void plantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parkDataSet);

        }

        private void PlantsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkDataSet.plant' table. You can move, or remove it, as needed.
            this.plantTableAdapter.Fill(this.parkDataSet.plant);

        }
    }
}
