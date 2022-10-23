using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGAssignment2
{
    public partial class LevelDesign : Form
    {
        public LevelDesign()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int rows, columns = 0;
            try
            {
                rows = Convert.ToByte(txtRows.Text);
                columns = Convert.ToByte(txtColumns.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Please provide valid integers for Rows and Columns fields", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
