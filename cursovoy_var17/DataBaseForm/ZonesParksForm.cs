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
    public partial class ZonesParksForm : Form
    {
        public ZonesParksForm()
        {
            InitializeComponent();
        }

        private void zoneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zoneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parkDataSet);

        }

        private void ZonesParks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkDataSet.zone' table. You can move, or remove it, as needed.
            this.zoneTableAdapter.Fill(this.parkDataSet.zone);

        }
    }
}
