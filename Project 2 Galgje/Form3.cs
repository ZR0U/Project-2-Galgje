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
    public partial class frmLevelCreator : Form
    {
        public static String[] Custom = new String[11];
        public static int tel = 0;
        public static bool used = false;

        public frmLevelCreator()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtToevoegen.Focus();
            btnVerwijder.Enabled = false;
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {


            if (tel > 10)
            {
                MessageBox.Show("Je kan niet meer woorden toevoegen");
            }
            else if (tel < 10)
            {
                if (txtToevoegen.Text == "")
                {
                    MessageBox.Show("Gelieve een woord in te vullen");
                }
                else
                {

                    lbxToevoegen.Items.Add(txtToevoegen.Text);
                    txtToevoegen.Text = "";
                    lbxToevoegen.Font = txtToevoegen.Font;
                    txtToevoegen.Focus();
                }
            }
            tel++;
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            int itemCount = lbxToevoegen.Items.Count;

            if (itemCount < 10)
            {
                MessageBox.Show("Geef 10 woorden in om een lijst te maken");
            }
            else
            {


                for (int i = 0; i < itemCount; i++)
                {
                    Custom[i] = (string)lbxToevoegen.Items[i];
                }

                used = true;
                this.Close();
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            int m = lbxToevoegen.SelectedIndex;
            lbxToevoegen.Items.Remove(lbxToevoegen.SelectedItem);
            int j = 0;
            for (j = m + 1; j < tel; j++)
            {
                Custom[j - 1] = Custom[j];
            }

            tel--;
        }

        private void lbxToevoegen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxToevoegen.SelectedItem != null)
            {
                btnVerwijder.Enabled = true;
            }
            else
            {
                btnVerwijder.Enabled = false;
            }
        }
    }
}
