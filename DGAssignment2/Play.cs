using DGAssignment2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGAssignment2
{
    public partial class Play : Form
    {
        private string levelFile;
        int ROWS = 0, COLS = 0;

        public Play(string levelFile)
        {
            this.levelFile = levelFile;
            InitializeComponent();
        }

        private void Play_Load(object sender, EventArgs e)
        {
            // initialize grid
            var levelGrid = File.ReadAllLines(levelFile);

            List<int> cellData = new List<int>();

            // get all the cell values
            for(int i = 2; i < levelGrid.ToList().Count; i+=3)
            {
                cellData.Add(Convert.ToInt32(levelGrid[i]));
            }

            // get the number of rows
            for(int i = 0; i < levelGrid.Length; i+=3)
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
            for(int i = 0; i < COLS; i++)
            {
                for (int j = 0; j < ROWS; j++)
                {
                    level[i, j] = cellData[buf];
                    buf++;
                }
            }

            // Draw the game board
            Draw(level);
        }

        void Draw(int[,] level)
        {
            ClearGrid(); // calls the clear grid function I created

            // set the column and row count to the user input
            tblGame.ColumnCount = COLS;
            tblGame.RowCount = ROWS;

            // loop through the rows and columns and add the row / column 
            for (int i = 0; i < COLS; i++)
            {
                tblGame.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            for (int i = 0; i < ROWS; i++)
            {
                tblGame.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            // creates the grid of picture boxes and initializes
            // them to the level's value
            for (int i = 0; i < COLS; i++)
            {
                for (int j = 0; j < ROWS; j++)
                {
                    var pBox = new PictureBox();
                    pBox.Height = 70;
                    pBox.Width = 70;
                    pBox.BorderStyle = BorderStyle.FixedSingle;
                    pBox.Image = Resources._null;
                    pBox.Name = "0";
                    tblGame.Controls.Add(pBox, i, j);
                }
            }
        }

        void ClearGrid()
        {
            // goes through the entire grid and disposes each control
            while (tblGame.Controls.Count > 0)
            {
                tblGame.Controls[0].Dispose();
            }
        }
    }
}
