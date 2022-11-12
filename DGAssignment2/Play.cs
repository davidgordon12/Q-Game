using DGAssignment2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGAssignment2
{
    public partial class Play : Form
    {
        private Stream levelFile;
        int ROWS = 0, COLS = 0;

        public Play(Stream levelFile)
        {
            this.levelFile = levelFile;
            InitializeComponent();
        }

        private void Play_Load(object sender, EventArgs e)
        {
            // initialize grid
            List<string> levelGrid = new List<string>();

            using (var sr = new StreamReader(levelFile))
            {
                while(sr.ReadLine() != null)
                {
                    levelGrid.Add(sr.ReadLine());
                }
            }
            List<int> entity = new List<int>();

            // get rows
            for (int i = 0; i < levelGrid.ToList().Count; i+=2)
            {
                ROWS++;
            }
            // get columns
            for (int i = 1; i < levelGrid.ToList().Count; i += 2)
            {
                COLS++;
            }

            // create game board
            int[,] level = new int[COLS, ROWS];

            // get all the game level's entites
            for (int i = 2; i < levelGrid.ToList().Count; i += 2)
            {
                entity.Add(Convert.ToInt32(levelGrid.ToList()[i]));
            }

            // populate the array
            for(int i = 0; i < COLS; i++)
            {
                for (int j = 0; j < ROWS; j++)
                {
                    level[i, j] = entity[i];
                }
            }
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
            // them to the empty square type
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
