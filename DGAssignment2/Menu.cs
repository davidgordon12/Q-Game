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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "QGame Level|*.qgame";
            openFileDialog.Title = "Open QGame Level";
            openFileDialog.ShowDialog();
            try
            {
                // if a valid file was selected, load it into the Play form
                var file = openFileDialog.OpenFile();
                Form gameForm = new Play(file);
                gameForm.Show();
            }
            catch (Exception)
            {
                // otherwise cancel the execution
                openFileDialog.Dispose();
                MessageBox.Show("Invalid file selected", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            Form designForm = new LevelDesign();
            designForm.Show();
        }
    }
}
