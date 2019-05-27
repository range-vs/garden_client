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
    public partial class EducationForm : Form
    {
        public EducationForm()
        {
            InitializeComponent();
        }

        private void educationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.educationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parkDataSet);

        }

        private void EducationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkDataSet.education' table. You can move, or remove it, as needed.
            this.educationTableAdapter.Fill(this.parkDataSet.education);

        }
    }
}
