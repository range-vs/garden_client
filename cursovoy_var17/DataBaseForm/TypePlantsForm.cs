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
    public partial class TypePlantsForm : Form
    {
        public TypePlantsForm()
        {
            InitializeComponent();
        }

        private void plant_typeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plant_typeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parkDataSet);

        }

        private void TypePlantsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkDataSet.plant_type' table. You can move, or remove it, as needed.
            this.plant_typeTableAdapter.Fill(this.parkDataSet.plant_type);

        }
    }
}
