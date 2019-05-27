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
    public partial class ParkForm : Form
    {
        public ParkForm()
        {
            InitializeComponent();
        }

        private void parkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.parkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parkDataSet);

        }

        private void ParkForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkDataSet.park' table. You can move, or remove it, as needed.
            this.parkTableAdapter.Fill(this.parkDataSet.park);

        }
    }
}
