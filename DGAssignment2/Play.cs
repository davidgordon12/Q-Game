using DGAssignment2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DGAssignment2
{
    public partial class Play : Form
    {
        PictureBox activeBox;
        int ROWS = 0, COLS = 0;
        int[,] level;
        public Play()
        {
            InitializeComponent();
        }

        private void Play_Load(object sender, EventArgs e)
        {
            tblGame2.MaximumSize = new Size(950, 950);
        }

        void Draw(int[,] level)
        {
            ClearGrid(); // calls the clear grid function I created

            // set the column and row count to the user input
            tblGame2.ColumnCount = COLS;
            tblGame2.RowCount = ROWS;

            // loop through the rows and columns and add the row / column 
            for (int i = 0; i < COLS; i++)
            {
                tblGame2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            for (int i = 0; i < ROWS; i++)
            {
                tblGame2.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            // creates the grid of picture boxes and assigns each
            // cell to the level's value
            for (int i = 0; i < COLS; i++)
            {
                for (int j = 0; j < ROWS; j++)
                {
                    var image = Resources._null;
                    string name = "0";
                    switch (level[i, j])
                    {
                        case 0:
                            image = null;
                            name = "0";
                            break;
                        case 1:
                            image = Resources.wall;
                            name = "1";
                            break;
                        case 2:
                            image = Resources.redDoor;
                            name = "2";
                            break;
                        case 3:
                            image = Resources.greenDoor;
                            name = "3";
                            break;
                        case 4:
                            image = Resources.redBox;
                            name = "4";
                            break;
                        case 5:
                            image = Resources.greenBox;
                            name = "5";
                            break;
                    }

                    var pBox = new PictureBox();
                    pBox.Height = 70;
                    pBox.Width = 70;
                    pBox.BorderStyle = BorderStyle.None;
                    if(name != "0")
                        pBox.Image = image;
                    pBox.Name = name;
                    pBox.Click += pBox_ClickedEvent;
                    tblGame2.Controls.Add(pBox, i, j);
                }
            }

            lblBoxCounter.Text = "Boxes left: 2";
            lblBoxCounter.Text = "Boxes left: 2";
        }

        void pBox_ClickedEvent(object sender, EventArgs e)
        {
            if(activeBox != null)
                activeBox.BorderStyle = BorderStyle.None;

            // checks to see which box was clicked on
            // and sets it as the active box
            if ((sender as PictureBox).Name == "4")
            {
                activeBox = sender as PictureBox;
                activeBox.BorderStyle = BorderStyle.Fixed3D;
            }
            if ((sender as PictureBox).Name == "5")
            {
                activeBox = sender as PictureBox;
                activeBox.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        void LoadGame(string levelFile)
        {
            // initialize grid
            var levelGrid = File.ReadAllLines(levelFile);

            List<int> cellData = new List<int>();

            // get all the cell values
            for (int i = 2; i < levelGrid.ToList().Count; i += 3)
            {
                cellData.Add(Convert.ToInt32(levelGrid[i]));
            }

            // get the number of rows
            for (int i = 0; i < levelGrid.Length; i += 3)
            {
                if (Convert.ToInt32(levelGrid[i]) < Convert.ToInt32(levelGrid[i + 3]))
                {
                    ROWS++;
                }
                else
                {
                    ROWS++;
                    break;
                }
            }

            // get the number of columns
            COLS = (levelGrid.Length / 3) / ROWS;

            int[,] level = new int[COLS, ROWS];

            int buf = 0;
            for (int i = 0; i < COLS; i++)
            {
                for (int j = 0; j < ROWS; j++)
                {
                    level[i, j] = cellData[buf];
                    buf++;
                }
            }

            this.level = level;

            // Draw the game board
            Draw(level);
        }

        private void moveBox_Event(object sender, EventArgs e)
        {
            if (activeBox is null)
                MessageBox.Show("Select a box", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // DONT MOVE CELL, JUST SWAP PICTUREBOX IMAGES INSTEAD

            switch ((sender as Button).Name)
            {
                case "btnUp":
                    MoveUp();
                    break;
                case "btnDown":
                    MoveDown();
                    break;
                case "btnLeft":
                    MoveLeft();
                    break;
                case "btnRight":
                    MoveRight();
                    break;
            }
        }

        void MoveUp()
        {
            // how far can we move down? find out
            var currentPosition = tblGame2.GetPositionFromControl(activeBox);

            Control c1 = tblGame2.GetControlFromPosition(currentPosition.Column, currentPosition.Row);
            Control c2 = tblGame2.GetControlFromPosition(currentPosition.Column, currentPosition.Row - 1);

            if (c2.Name == "1")
            {
                // if this control is a wall, we cannot move further
                return;
            }

            if (c2.Name == "4" && activeBox.Name == "2")
            {
                // box and door match, remove box
                return;
            }

            if (c2.Name == "5" && activeBox.Name == "3")
            {
                // box and door match, remove box
                return;
            }

            if (c2.Name != "0")
            {
                // if none of the win conditions were met, and the next space isn't null, return
                return;
            }

            TableLayoutPanelCellPosition cell1 = tblGame2.GetCellPosition(c1);
            tblGame2.SetCellPosition(c1, tblGame2.GetCellPosition(c2));
            tblGame2.SetCellPosition(c2, cell1);

            // call the method again to see if we can move even farther
            MoveUp();
        }
        void MoveDown()
        {
            // how far can we move down? find out
            var currentPosition = tblGame2.GetPositionFromControl(activeBox);

            Control c1 = tblGame2.GetControlFromPosition(currentPosition.Column, currentPosition.Row);
            Control c2 = tblGame2.GetControlFromPosition(currentPosition.Column, currentPosition.Row + 1);

            if(c2.Name == "1")
            {
                // if this control is a wall, we cannot move further
                return;
            }

            if (c2.Name == "4" && activeBox.Name == "2")
            {
                // box and door match, remove box
                return;
            }

            if (c2.Name == "5" && activeBox.Name == "3")
            {
                // box and door match, remove box
                return;
            }

            if(c2.Name != "0")
            {
                // if none of the win conditions were met, and the next space isn't null, return
                return;
            }

            TableLayoutPanelCellPosition cell1 = tblGame2.GetCellPosition(c1);
            tblGame2.SetCellPosition(c1, tblGame2.GetCellPosition(c2));
            tblGame2.SetCellPosition(c2, cell1);

            // call the method again to see if we can move even farther
            MoveDown();
        }
        void MoveLeft()
        {
            // how far can we move down? find out
            var currentPosition = tblGame2.GetPositionFromControl(activeBox);

            Control c1 = tblGame2.GetControlFromPosition(currentPosition.Column, currentPosition.Row);
            Control c2 = tblGame2.GetControlFromPosition(currentPosition.Column - 1, currentPosition.Row);

            if (c2.Name == "1")
            {
                // if this control is a wall, we cannot move further
                return;
            }

            if (c2.Name == "4" && activeBox.Name == "2")
            {
                // box and door match, remove box
                return;
            }

            if (c2.Name == "5" && activeBox.Name == "3")
            {
                // box and door match, remove box
                return;
            }

            if (c2.Name != "0")
            {
                // if none of the win conditions were met, and the next space isn't null, return
                return;
            }

            TableLayoutPanelCellPosition cell1 = tblGame2.GetCellPosition(c1);
            tblGame2.SetCellPosition(c1, tblGame2.GetCellPosition(c2));
            tblGame2.SetCellPosition(c2, cell1);

            // call the method again to see if we can move even farther
            MoveLeft();
        }
        void MoveRight()
        {
            // how far can we move down? find out
            var currentPosition = tblGame2.GetPositionFromControl(activeBox);

            Control c1 = tblGame2.GetControlFromPosition(currentPosition.Column, currentPosition.Row);
            Control c2 = tblGame2.GetControlFromPosition(currentPosition.Column + 1, currentPosition.Row);

            if (c2.Name == "1")
            {
                // if this control is a wall, we cannot move further
                return;
            }

            if (c2.Name == "4" && activeBox.Name == "2")
            {
                // box and door match, remove box
                return;
            }

            if (c2.Name == "5" && activeBox.Name == "3")
            {
                // box and door match, remove box
                return;
            }

            if (c2.Name != "0")
            {
                // if none of the win conditions were met, and the next space isn't null, return
                return;
            }

            TableLayoutPanelCellPosition cell1 = tblGame2.GetCellPosition(c1);
            tblGame2.SetCellPosition(c1, tblGame2.GetCellPosition(c2));
            tblGame2.SetCellPosition(c2, cell1);

            // call the method again to see if we can move even farther
            MoveRight();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // closes the form
            FindForm().Close();
        }

        private void loadGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "QGame Level|*.qgame";
            openFileDialog.Title = "Open QGame Level";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadGame(openFileDialog.FileName);
                foreach (var control in Controls)
                {
                    if (control is Button)
                    {
                        (control as Button).Enabled = true;
                    }
                }
            }
            else
            {
                openFileDialog.Dispose();
                MessageBox.Show("Invalid file selected", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ClearGrid()
        {
            // goes through the entire grid and disposes each control
            while (tblGame2.Controls.Count > 0)
            {
                tblGame2.Controls[0].Dispose();
            }
        }
    }
}
