using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Project_2_Galgje
{
    public partial class frmHomeScreen : Form
    {
        public frmHomeScreen()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.Home);
            sound.PlayLooping();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmSelectGame Form2_instantie = new frmSelectGame();
            Form2_instantie.Show();
            
        }

        private void btnLvl_Click(object sender, EventArgs e)
        {
            frmLevelCreator Form3_instantie = new frmLevelCreator();
            Form3_instantie.Show();
            
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("made by Jan and Davis");
        }
    }
}
