using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private object dataGridView1;

        public Form1()
        {
            InitializeComponent();
        }

        private void icyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.icyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iCYGIRLDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iCYGIRLDataSet.icy' table. You can move, or remove it, as needed.
            this.icyTableAdapter.Fill(this.iCYGIRLDataSet.icy);

        }

        private void icyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
