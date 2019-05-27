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
    public partial class DecoratorsForm : Form
    {
        public DecoratorsForm()
        {
            InitializeComponent();
        }

        private void decoratorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.decoratorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parkDataSet);

        }

        private void DecoratorsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkDataSet.decorator' table. You can move, or remove it, as needed.
            this.decoratorTableAdapter.Fill(this.parkDataSet.decorator);

        }
    }
}
