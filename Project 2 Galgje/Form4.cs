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
    public partial class frmGalgje : Form
    {
        public frmGalgje()
        {
            InitializeComponent();
        }

        public static String[] Willekeurig = new string[30];
        public static String[] Animals = new string[15];
        public static String[] Food = new string[15];
        
        int keuze;
        int levens = 11;
        String woord = "sheeeee";
        Label[] LBL = new Label[25];

        private void Form4_Load(object sender, EventArgs e)
        {
            pbxGalgje.Image = Properties.Resources.Galows0_1;
            String[] Custom;
            keuze = frmSelectGame.keuze;
            String[] Willekeurig = new String[] { "stoel", "vliegtuig", "brandweerwagen", "xylofoon", "tafel",
                                              "computer", "laptop", "vork", "horloge", "auto",
                                              "valei", "masker", "xenofoob", "bank", "vogel",
                                              "elektriciteit", "galgje", "straat", "niemandsland", "telefoon",
                                              "connectie", "computerprogramma", "schooluniform", "lantaarnpaal", "orgaan",
                                              "stripverhaal", "voetbaltoernooi", "augustdams", "nieuwsartikel", "maagzuur"};

            String[] Animals = new String[] { "hond", "kat", "zwaluw", "leeuw", "wolf",
                                              "papegaai", "oerangoetang", "walvis", "orka", "hyena",
                                              "dingo", "kongfupanda", "augustdams", "eend", "hamster"};

            String[] Food = new String[] { "spaghetti", "kaassoufle", "augustdams", "frikandel", "fishsticks",
                                           "kippenborstjes", "rijsttaart", "salamipizza", "pesto", "schnitzel",
                                           "appeltaart", "gummibeertjes", "patat", "appel", "aardbij"};

            Custom = frmLevelCreator.Custom;
            //Verschillende arrays
            Random random = new Random();
            int will;
            int lengte;

            if (keuze == 0)
            {
                will = random.Next(30);
                woord = Willekeurig[will];
                lengte = woord.Length;
                MessageBox.Show(woord);
                for (int i = 1; i < lengte + 1; i++)
                {
                    LBL[i] = new Label();
                    LBL[i].Location = LBL1.Location;
                    LBL[i].Left = 100 + i * 50;
                    LBL[i].Size = LBL1.Size;
                    LBL[i].AutoSize = LBL1.AutoSize;
                    LBL[i].BackColor = LBL1.BackColor;
                    LBL[i].BorderStyle = LBL1.BorderStyle;
                    LBL[i].TextAlign = LBL1.TextAlign;
                    LBL[i].ForeColor = LBL1.ForeColor;
                    LBL[i].Font = LBL1.Font;
                    LBL[i].Text = "_";
                    LBL[i].Visible = true;
                    LBL[i].BringToFront();
                    Controls.Add(LBL[i]);
                }
            }
            else if (keuze == 1)
            {
                will = random.Next(15);
                woord = Animals[will];
                lengte = woord.Length;
                MessageBox.Show(woord);
                for (int i = 1; i < lengte + 1; i++)
                {
                    LBL[i] = new Label();
                    LBL[i].Location = LBL1.Location;
                    LBL[i].Left = 100 + i * 50;
                    LBL[i].Size = LBL1.Size;
                    LBL[i].AutoSize = LBL1.AutoSize;
                    LBL[i].BackColor = LBL1.BackColor;
                    LBL[i].BorderStyle = LBL1.BorderStyle;
                    LBL[i].TextAlign = LBL1.TextAlign;
                    LBL[i].ForeColor = LBL1.ForeColor;
                    LBL[i].Font = LBL1.Font;
                    LBL[i].Text = "_";
                    LBL[i].Visible = true;
                    LBL[i].BringToFront();
                    Controls.Add(LBL[i]);
                }
            }
            else if (keuze == 2)
            {
                will = random.Next(15);
                woord = Food[will];
                lengte = woord.Length;
                MessageBox.Show(woord);
                for (int i = 1; i < lengte + 1; i++)
                {
                    LBL[i] = new Label();
                    LBL[i].Location = LBL1.Location;
                    LBL[i].Left = 100 + i * 50;
                    LBL[i].Size = LBL1.Size;
                    LBL[i].AutoSize = LBL1.AutoSize;
                    LBL[i].BackColor = LBL1.BackColor;
                    LBL[i].BorderStyle = LBL1.BorderStyle;
                    LBL[i].TextAlign = LBL1.TextAlign;
                    LBL[i].ForeColor = LBL1.ForeColor;
                    LBL[i].Font = LBL1.Font;
                    LBL[i].Text = "_";
                    LBL[i].Visible = true;
                    LBL[i].BringToFront();
                    Controls.Add(LBL[i]);
                }
            }
            else if (keuze == 3)
            {
                will = random.Next(11);
                woord = Custom[will];
                lengte = woord.Length;
                MessageBox.Show(woord);
                MessageBox.Show(Convert.ToString(lengte));
                for (int i = 1; i < lengte + 1; i++)
                {
                    LBL[i] = new Label();
                    LBL[i].Location = LBL1.Location;
                    LBL[i].Left = 100 + i * 50;
                    LBL[i].Size = LBL1.Size;
                    LBL[i].AutoSize = LBL1.AutoSize;
                    LBL[i].BackColor = LBL1.BackColor;
                    LBL[i].BorderStyle = LBL1.BorderStyle;
                    LBL[i].TextAlign = LBL1.TextAlign;
                    LBL[i].ForeColor = LBL1.ForeColor;
                    LBL[i].Font = LBL1.Font;
                    LBL[i].Text = "_";
                    LBL[i].Visible = true;
                    LBL[i].BringToFront();
                    Controls.Add(LBL[i]);
                }
            }

            //case select gebruiken; zegt welk spel je geselecteert hebt
            //kijkt welk spel je geselecteert hebt, kiest een random woord van de array maakt een label voor iedere leter van het woord

        }

        private void galgje() 
        {
            pbxGalgje.Image = Properties.Resources.Galows1_1;
            switch (levens)
            {
                case 10: pbxGalgje.Image = Properties.Resources.Galows1_1; break;
                case 9: pbxGalgje.Image = Properties.Resources.Galows2_1; break;
                case 8: pbxGalgje.Image = Properties.Resources.Galows3_1; break;
                case 7: pbxGalgje.Image = Properties.Resources.Galows4_1; break;
                case 6: pbxGalgje.Image = Properties.Resources.Galows5_1; break;
                case 5: pbxGalgje.Image = Properties.Resources.Galows6_1; break;
                case 4: pbxGalgje.Image = Properties.Resources.Galows8_1; break;
                case 3: pbxGalgje.Image = Properties.Resources.Galows9_1; break;
                case 2: pbxGalgje.Image = Properties.Resources.Galows10_1; break;
                case 1: pbxGalgje.Image = Properties.Resources.Galows11_1; 
                    const string message = "Will je en advertentie kijken voor een extra leven?";
                    const string caption = "advertentie";
                    if (MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmAdd Form5_instantie = new frmAdd();
                        Form5_instantie.Show();
                    }
                    break;
                    //Form voor advertentie
                case 0: pbxGalgje.Image = Properties.Resources.GalowsA1_1; break;
                default: pbxGalgje.Image = Properties.Resources.GalowsA1_1; break;
            }
            // Immage van galgje tonen en veranderen

        }

        //Dit stukje is om de kleur te veranderen voor de buttons eenmaal ze aangeroepen worden.

        private void btn_Click(object sender, EventArgs e)
        {
            string buttonNaam = (sender as Button).Name;
            switch (buttonNaam)
            {
                case "btnA": if (woord.Contains("a")) { btnA.BackColor = Color.Green; btnA.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "a") { LBL[i].Text = "A"; } } }
                             else{ btnA.BackColor = Color.Red; btnA.Enabled = false; levens--; galgje(); }; break;

                case "btnB": if (woord.Contains("b")) { btnB.BackColor = Color.Green; btnB.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "b") { LBL[i].Text = "B"; } } }
                             else{ btnB.BackColor = Color.Red; btnB.Enabled = false; levens--; galgje(); }; break;

                case "btnC": if (woord.Contains("c")) { btnC.BackColor = Color.Green; btnC.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "c") { LBL[i].Text = "C"; } } }
                             else{ btnC.BackColor = Color.Red; btnC.Enabled = false; levens--; galgje(); }; break;

                case "btnD": if (woord.Contains("d")) { btnD.BackColor = Color.Green; btnD.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "d") { LBL[i].Text = "D"; } } }
                             else{ btnD.BackColor = Color.Red; btnD.Enabled = false; levens--; galgje(); }; break;

                case "btnE": if (woord.Contains("e")) { btnE.BackColor = Color.Green; btnE.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "e") { LBL[i].Text = "E"; } } }
                             else{ btnE.BackColor = Color.Red; btnE.Enabled = false; levens--; galgje(); }; break;

                case "btnF": if (woord.Contains("f")) { btnF.BackColor = Color.Green; btnF.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "f") { LBL[i].Text = "F"; } } }
                             else{ btnF.BackColor = Color.Red; btnF.Enabled = false; levens--; galgje(); }; break;

                case "btnG": if (woord.Contains("g")) { btnG.BackColor = Color.Green; btnG.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "g") { LBL[i].Text = "G"; } } }
                             else{ btnG.BackColor = Color.Red; btnG.Enabled = false; levens--; galgje(); }; break;

                case "btnH": if (woord.Contains("h")) { btnH.BackColor = Color.Green; btnH.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "h") { LBL[i].Text = "H"; } } }
                             else{ btnH.BackColor = Color.Red; btnH.Enabled = false; levens--; galgje(); }; break;

                case "btnI": if (woord.Contains("i")) { btnI.BackColor = Color.Green; btnI.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "i") { LBL[i].Text = "I"; } } }
                             else{ btnI.BackColor = Color.Red; btnI.Enabled = false; levens--; galgje(); }; break;

                case "btnJ": if (woord.Contains("j")) { btnJ.BackColor = Color.Green; btnJ.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "j") { LBL[i].Text = "J"; } } }
                             else{ btnJ.BackColor = Color.Red; btnJ.Enabled = false; levens--; galgje(); }; break;

                case "btnK": if (woord.Contains("k")) { btnK.BackColor = Color.Green; btnK.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "k") { LBL[i].Text = "K"; } } }
                             else{ btnK.BackColor = Color.Red; btnK.Enabled = false; levens--; galgje(); }; break;

                case "btnL": if (woord.Contains("l")) { btnL.BackColor = Color.Green; btnL.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "l") { LBL[i].Text = "L"; } } }
                             else{ btnL.BackColor = Color.Red; btnL.Enabled = false; levens--; galgje(); }; break;

                case "btnM": if (woord.Contains("m")) { btnM.BackColor = Color.Green; btnM.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "m") { LBL[i].Text = "M"; } } }
                             else{ btnM.BackColor = Color.Red; btnM.Enabled = false; levens--; galgje(); }; break;

                case "btnN": if (woord.Contains("n")) { btnN.BackColor = Color.Green; btnN.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "n") { LBL[i].Text = "N"; } } }
                             else{ btnN.BackColor = Color.Red; btnN.Enabled = false; levens--; galgje(); }; break;

                case "btnO": if (woord.Contains("o")) { btnO.BackColor = Color.Green; btnO.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "o") { LBL[i].Text = "O"; } } }
                             else{ btnO.BackColor = Color.Red; btnO.Enabled = false; levens--; galgje(); }; break;

                case "btnP": if (woord.Contains("p")) { btnP.BackColor = Color.Green; btnP.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "p") { LBL[i].Text = "P"; } } }
                             else{ btnP.BackColor = Color.Red; btnP.Enabled = false; levens--; galgje(); }; break;

                case "btnQ": if (woord.Contains("q")) { btnQ.BackColor = Color.Green; btnQ.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "q") { LBL[i].Text = "Q"; } } }
                             else{ btnQ.BackColor = Color.Red; btnQ.Enabled = false; levens--; galgje(); }; break;

                case "btnR": if (woord.Contains("r")) { btnR.BackColor = Color.Green; btnR.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "r") { LBL[i].Text = "R"; } } }
                             else{ btnR.BackColor = Color.Red; btnR.Enabled = false; levens--; galgje(); }; break;

                case "btnS": if (woord.Contains("s")) { btnS.BackColor = Color.Green; btnS.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "s") { LBL[i].Text = "S"; } } }
                             else{ btnS.BackColor = Color.Red; btnS.Enabled = false; levens--; galgje(); }; break;

                case "btnT": if (woord.Contains("t")) { btnT.BackColor = Color.Green; btnT.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "t") { LBL[i].Text = "T"; } } }
                             else{ btnT.BackColor = Color.Red; btnT.Enabled = false; levens--; galgje(); }; break;

                case "btnU": if (woord.Contains("u")) { btnU.BackColor = Color.Green; btnU.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "u") { LBL[i].Text = "U"; } } }
                             else{ btnU.BackColor = Color.Red; btnU.Enabled = false; levens--; galgje(); }; break;

                case "btnV": if (woord.Contains("v")) { btnV.BackColor = Color.Green; btnV.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "v") { LBL[i].Text = "V"; } } }
                             else{ btnV.BackColor = Color.Red; btnV.Enabled = false; levens--; galgje(); }; break;

                case "btnW": if (woord.Contains("w")) { btnW.BackColor = Color.Green; btnW.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "w") { LBL[i].Text = "W"; } } }
                             else{ btnW.BackColor = Color.Red; btnW.Enabled = false; levens--; galgje(); }; break;

                case "btnX": if (woord.Contains("x")) { btnX.BackColor = Color.Green; btnX.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "x") { LBL[i].Text = "X"; } } }
                             else{ btnX.BackColor = Color.Red; btnX.Enabled = false; levens--; galgje(); }; break;

                case "btnY": if (woord.Contains("y")) { btnY.BackColor = Color.Green; btnY.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "y") { LBL[i].Text = "Y"; } } }
                             else{ btnY.BackColor = Color.Red; btnY.Enabled = false; levens--; galgje(); }; break;

                case "btnZ": if (woord.Contains("z")) { btnZ.BackColor = Color.Green; btnZ.Enabled = false; 
                             for (int i = 1; i < woord.Length + 1; i++) { if (woord.Substring(i - 1, 1) == "z") { LBL[i].Text = "Z"; } } }
                             else{ btnZ.BackColor = Color.Red; btnZ.Enabled = false; levens--; galgje(); }; break;

                default: break;
            }
        }
        // iedere button laten werken
    }
}
