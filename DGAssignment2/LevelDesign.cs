using DGAssignment2.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DGAssignment2
{
    public partial class LevelDesign : Form
    {
        Image image;

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
                tblGame.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            for (int i = 0; i < rows; i++)
            {
                tblGame.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
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
            (sender as PictureBox).Image = image;
        }

        private void ClearGrid()
        {
            while (tblGame.Controls.Count > 0)
            {
                tblGame.Controls[0].Dispose();
            }
        }

        private void btnImageType_Click(object sender, EventArgs e)
        {
            string imageControl = (sender as Control).Name;

            switch(imageControl)
            {
                case "btnNone":
                    image = Resources._null;
                    break;

                case "pbNone":
                    image = Resources._null;
                    break;

                case "btnWall":
                    image = Resources.wall;
                    break;

                case "pbWall":
                    image = Resources.wall;
                    break;

                case "btnRedDoor":
                    image = Resources.redDoor;
                    break;

                case "pbRedDoor":
                    image = Resources.redDoor;
                    break;

                case "btnGreenDoor":
                    image = Resources.greenDoor;
                    break;

                case "pbGreenDoor":
                    image = Resources.greenDoor;
                    break;

                case "btnRedBox":
                    image = Resources.redBox;
                    break;

                case "pbRedBox":
                    image = Resources.redBox;
                    break;

                case "btnGreenBox":
                    image = Resources.greenBox;
                    break;

                case "pbGreenBox":
                    image = Resources.greenBox;
                    break;
            }
        }
    }
}
