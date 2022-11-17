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
        int moves, boxes, redBoxes, greenBoxes = 0;
        int greenDoors, redDoors = 0;

        public Play()
        {
            InitializeComponent();
        }

        private void Play_Load(object sender, EventArgs e)
        {
            tblGame2.MaximumSize = new Size(950, 950);
        }

        void LoadGame(string levelFile)
        {
            // initialize grid
            var levelGrid = File.ReadAllLines(levelFile);
            ROWS = 0;
            COLS = 0;

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
                    if (name != "0")
                        pBox.Image = image;
                    pBox.Name = name;
                    pBox.Click += pBox_ClickedEvent;
                    tblGame2.Controls.Add(pBox, i, j);
                }
            }

            GetBoxesAndDoors();

            timer1.Enabled = true;
        }

        void GetBoxesAndDoors()
        {
            // check box count
            foreach (Control control in tblGame2.Controls)
            {
                if (control.Name == "4" || control.Name == "5")
                    boxes++;
            }
            lblBoxCounter.Text = $"Boxes Left: {boxes}";

            // get all the doors
            foreach (Control control in tblGame2.Controls)
            {
                if (control.Name == "2")
                {
                    redDoors++;
                }
                if (control.Name == "3")
                {
                    greenDoors++;
                }
            }

            // get all green boxes
            foreach (Control control in tblGame2.Controls)
            {
                if (control.Name == "5")
                {
                    greenBoxes++;
                }
            }

            // get red boxes
            foreach (Control control in tblGame2.Controls)
            {
                if (control.Name == "4")
                {
                    redBoxes++;
                }
            }
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

        void pBox_ClickedEvent(object sender, EventArgs e)
        {
            if (activeBox != null)
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

        void EndGame()
        {
            foreach (var control in Controls)
            {
                if (control is Button)
                {
                    (control as Button).Enabled = false;
                }
            }

            timer1.Stop();
            timer1.Enabled = false;
            MessageBox.Show("You win!", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            ClearGrid();
        }

        private void moveBox_Event(object sender, EventArgs e)
        {
            if (activeBox is null)
                MessageBox.Show("Select a box", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);

            switch ((sender as Button).Name)
            {
                case "btnUp":
                    Move("Row", -1);
                    break;
                case "btnDown":
                    Move("Row", 1);
                    break;
                case "btnLeft":
                    Move("Column", -1);
                    break;
                case "btnRight":
                    Move("Column", 1);
                    break;
            }

            // increment total move count after each move attempt
            moves++;
            lblMoveCounter.Text = $"Total Moves: {moves}";
        }

        new void Move(string direction, int value)
        {
            var currentPosition = tblGame2.GetPositionFromControl(activeBox);

            if (direction == "Row")
            {
                // get the box control within the tableLayoutPanel
                Control box = tblGame2.GetControlFromPosition(currentPosition.Column, currentPosition.Row);

                // and get the picturebox where we want our box to go
                Control cellToSwap = tblGame2.GetControlFromPosition(currentPosition.Column, currentPosition.Row + value);

                SwapCellsVertical(box, cellToSwap, direction, value);
            }
            if (direction == "Column")
            {
                // get the box control within the tableLayoutPanel
                Control box = tblGame2.GetControlFromPosition(currentPosition.Column, currentPosition.Row);

                // and get the picturebox where we want our box to go
                Control cellToSwap = tblGame2.GetControlFromPosition(currentPosition.Column + value, currentPosition.Row);

                SwapCellsVertical(box, cellToSwap, direction, value);
            }

        }

        /// <summary>
        /// Swaps two given cells' location within the tableLayoutPanel tblGame2
        /// </summary>
        /// <param name="box">The Box control</param>
        /// <param name="cellToSwap">The cell where the Box is to be moved</param>
        /// <param name="direction">The direction to move the Box (+1 or -1)</param>
        void SwapCellsHorizontal(
            Control box, Control cellToSwap, string direction, int value)
        {
            if (cellToSwap.Name == "1")
            {
                // if this control is a wall, we cannot move further
                return;
            }

            if (cellToSwap.Name == "2" && activeBox.Name == "4")
            {
                tblGame2.Controls.Remove(activeBox);
                redBoxes--;
                boxes--;
                lblBoxCounter.Text = $"Boxes Left: {boxes}";
                return;
            }

            if (cellToSwap.Name == "3" && activeBox.Name == "5")
            {
                tblGame2.Controls.Remove(activeBox);
                greenBoxes--;
                boxes--;
                lblBoxCounter.Text = $"Boxes Left: {boxes}";
                return;
            }

            if (cellToSwap.Name != "0")
            {
                // if none of the win conditions were met, and the next space isn't null, return
                return;
            }

            // get the box current location and store it in this buffer
            TableLayoutPanelCellPosition buffer = tblGame2.GetCellPosition(box);

            // set the cell position of the box to it's new cell
            tblGame2.SetCellPosition(box, tblGame2.GetCellPosition(cellToSwap));

            // and place the old cell where the box was before
            tblGame2.SetCellPosition(cellToSwap, buffer);

            // call the method again to see if we can move even farther
            Move(direction, value);
        }

        /// <summary>
        /// Swaps two given cells' location within the tableLayoutPanel tblGame2
        /// </summary>
        /// <param name="box">The Box control</param>
        /// <param name="cellToSwap">The cell where the Box is to be moved</param>
        /// <param name="direction">The direction to move the Box (+1 or -1)</param>
        void SwapCellsVertical(
            Control box, Control cellToSwap, string direction, int value)
        {
            if (cellToSwap.Name == "1")
            {
                // if this control is a wall, we cannot move further
                return;
            }

            // check if the box hits a door with matching color (red)
            if (cellToSwap.Name == "2" && activeBox.Name == "4")
            {
                tblGame2.Controls.Remove(activeBox);
                boxes--;
                redBoxes--;
                lblBoxCounter.Text = $"Boxes Left: {boxes}";
                return;
            }

            // check if the box hits a door with matching color (green)
            if (cellToSwap.Name == "3" && activeBox.Name == "5")
            {
                tblGame2.Controls.Remove(activeBox);
                boxes--;
                greenBoxes--;
                lblBoxCounter.Text = $"Boxes Left: {boxes}";
                return;
            }

            if (cellToSwap.Name != "0")
            {
                // if none of the win conditions were met, and the next space isn't null, return
                return;
            }

            // get the box current location and store it in this buffer
            TableLayoutPanelCellPosition buffer = tblGame2.GetCellPosition(box);

            // set the cell position of the box to it's new cell
            tblGame2.SetCellPosition(box, tblGame2.GetCellPosition(cellToSwap));

            // and place the old cell where the box was before
            tblGame2.SetCellPosition(cellToSwap, buffer);

            // call the method again to see if we can move even farther
            Move(direction, value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(redDoors == 0 && greenDoors > 0)
            {
                if (greenBoxes == 0)
                {
                    EndGame();
                }
            }
            if (redDoors > 0 && greenDoors == 0)
            {
                if (redBoxes == 0)
                {
                    EndGame();
                }
            }
        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FindForm().Close();
        }
        void ResetVariables()
        {
            moves = 0;
            boxes = 0;
            greenDoors = 0;
            redDoors = 0;
            redBoxes = 0;
            greenBoxes = 0;

            lblMoveCounter.Text = $"Total Moves: {moves}";
            lblBoxCounter.Text = $"Boxes Left: {boxes}";
        }

        void ClearGrid()
        {
            ResetVariables();
            // goes through the entire grid and disposes each control
            while (tblGame2.Controls.Count > 0)
            {
                tblGame2.Controls[0].Dispose();
            }
        }
    }
}
