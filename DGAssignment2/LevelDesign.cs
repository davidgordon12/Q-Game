using DGAssignment2.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DGAssignment2
{
    public partial class LevelDesign : Form
    {
        // global variables
        Image image;
        int rows = 0, columns = 0, type = 0;

        public LevelDesign()
        {
            InitializeComponent();
        }

        private void LevelDesign_Load(object sender, EventArgs e)
        {
            // immediately clear the grid on form load so its
            // ready to be created by the user
            tblGame.RowStyles.Clear();
            tblGame.ColumnStyles.Clear();

            ClearGrid();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] level = new int[columns, rows];
            int block = 0;
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    var pBox = tblGame.GetControlFromPosition(i, j);
                    

                    // look for the image name to know which type of block it was
                    switch(pBox.Name)
                    {
                        case "0":
                            block = 0;
                            break;
                        case "1":
                            block = 1;
                            break;
                        case "2":
                            block = 2;
                            break;
                        case "3":
                            block = 3;
                            break;
                        case "4":
                            block = 4;
                            break;
                        case "5":
                            block = 5;
                            break;
                    }

                    // save that in a 2D array so we can easily write
                    // the index and value to the text file for saving
                    level[i, j] = block;
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // closes the form
            FindForm().Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ClearGrid(); // calls the clear grid function I created

            try
            {
                // if the textBoxes aren't valid integers
                rows = Convert.ToByte(txtRows.Text);
                columns = Convert.ToByte(txtColumns.Text);
            }
            catch (Exception)
            {
                // this error will be thrown
                MessageBox.Show("Please provide valid integers for Rows and Columns fields", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // set the column and row count to the user input
            tblGame.ColumnCount = columns;
            tblGame.RowCount = rows;

            // loop through the rows and columns and add the row / column 
            for (int i = 0; i < columns; i++)
            {
                tblGame.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            for (int i = 0; i < rows; i++)
            {
                tblGame.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            // creates the grid of picture boxes and initializes
            // them to the empty square type
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    var pBox = new PictureBox();
                    pBox.Height = 70;
                    pBox.Width = 70;
                    pBox.BorderStyle = BorderStyle.FixedSingle;
                    pBox.Image = Resources._null;
                    pBox.Name = "0";
                    pBox.Click += pBox_ClickedEvent;
                    tblGame.Controls.Add(pBox, i, j);
                }
            }
        }

        void pBox_ClickedEvent(object sender, EventArgs e)
        {
            // sets the image and name to the corresponding properties
            (sender as PictureBox).Image = image;
            (sender as PictureBox).Name = type.ToString();
        }

        private void ClearGrid()
        {
            // goes through the entire grid and disposes each control
            while (tblGame.Controls.Count > 0)
            {
                tblGame.Controls[0].Dispose();
            }
        }

        private void btnImageType_Click(object sender, EventArgs e)
        {
            string imageControl = (sender as Control).Name;

            // gets the image or 'block type' from the toolbox and sets
            // it as the active image and type

            switch (imageControl)
            {
                case "btnNone":
                    image = Resources._null; // 0
                    type = 0;
                    break;

                case "pbNone":
                    image = Resources._null; // 0
                    type = 0;
                    break;

                case "btnWall":
                    image = Resources.wall; // 1
                    type = 1;
                    break;

                case "pbWall":
                    image = Resources.wall; // 1
                    type = 1;
                    break;

                case "btnRedDoor":
                    image = Resources.redDoor; // 2
                    type = 2;
                    break;

                case "pbRedDoor":
                    image = Resources.redDoor; // 2
                    type = 2;
                    break;

                case "btnGreenDoor":
                    image = Resources.greenDoor; // 3
                    type = 3;
                    break;

                case "pbGreenDoor":
                    image = Resources.greenDoor; // 3
                    type = 3;
                    break;

                case "btnRedBox":
                    image = Resources.redBox; // 4
                    type = 4;
                    break;

                case "pbRedBox":
                    image = Resources.redBox; // 4
                    type = 4;
                    break;

                case "btnGreenBox":
                    image = Resources.greenBox; // 5 
                    type = 5;
                    break;

                case "pbGreenBox":
                    image = Resources.greenBox; // 5
                    type = 5;
                    break;
            }
        }
    }
}
