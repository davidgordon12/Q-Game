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

        private void LevelDesign_Load(object sender, EventArgs e)
        {
            tblGame.RowStyles.Clear();
            tblGame.ColumnStyles.Clear();

            ClearGrid();
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
            ClearGrid();

            int rows = 0, columns = 0;

            try
            {
                rows = Convert.ToByte(txtRows.Text);
                columns = Convert.ToByte(txtColumns.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Please provide valid integers for Rows and Columns fields", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tblGame.ColumnCount = columns;
            tblGame.RowCount = rows;

            for(int i = 0; i < columns; i++)
            {
                tblGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.AutoSize));
            }

            for (int i = 0; i < rows; i++)
            {
                tblGame.RowStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.AutoSize));
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    var pBox = new PictureBox();
                    pBox.Height = 70;
                    pBox.Width = 70;
                    pBox.BorderStyle = BorderStyle.FixedSingle;
                    pBox.Click += pBox_ClickedEvent;
                    tblGame.Controls.Add(pBox, i, j);
                }
            }
        }

        void pBox_ClickedEvent(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Black;
        }

        private void ClearGrid()
        {
            while (tblGame.Controls.Count > 0)
            {
                tblGame.Controls[0].Dispose();
            }
        }
    }
}
