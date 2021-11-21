using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2_Galgje
{
    public partial class frmSelectGame : Form
    {
        public frmSelectGame()
        {
            InitializeComponent();
        }

        public static String[] Willekeurig = new string[30];
        public static String[] Animals = new string[15];
        public static String[] Food = new string[15];
        public static String[] Custom = new string[10];
        public static int keuze = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            rdbRandom.Checked = true;

            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rdbRandom.Checked == true)
            {
                keuze = 0;
            }
            else if (rdbAnimals.Checked == true)
            {
                keuze = 1;
            }
            else if (rdbFood.Checked == true)
            {
                keuze = 2;
            }
            else if (rdbCustom.Checked == true)
            {
                keuze = 3;
            }
            frmGalgje Form4_instantie = new frmGalgje();
            Form4_instantie.Show();
        }
    }
}
