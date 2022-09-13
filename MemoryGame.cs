using Memory.Properties;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Diagnostics;

namespace Memory
{
    public partial class MemoryGame : Form
    {
        int Scorepl1 = 0;
        int Scorepl2 = 0;
        int Turn = 0;
        string CurrentPlayer = "Player 1";
        bool EersteKeus;
        bool TweedeKeus;
        PictureBox EersteKaart;
        PictureBox TweedeKaart;
        List<int> GeschuddeKaarten = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };

        public MemoryGame()
        {
            InitializeComponent();
        }

        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)

        {

        }

        private static Random rng = new Random();

        public void Herstartspel()
        {
            GeschuddeKaarten = GeschuddeKaarten.OrderBy(a => Guid.NewGuid()).ToList();

            lblScorePlayer1.Text = "0";
            lblScorePlayer2.Text = "0";
            Scorepl1 = 0;
            Scorepl2 = 0;
            lblCurrentPlayer.Text = "Player 1";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Wil je een nieuw spel beginnen?", "Nieuw spel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                InitialiserenScherm(sender, e);
            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void InitialiserenScherm(object sender, EventArgs e)
        {

            Herstartspel();

            var i = 0;

            foreach (var pictureBox in Controls.OfType<PictureBox>())
            {
                pictureBox.Visible = true;
                pictureBox.Enabled = true;
                pictureBox.Tag = GeschuddeKaarten[i].ToString();

                string test1 = "C:\\fontys\\leerjaar 5\\periode 1\\SCC\\Opdrachten\\Opdracht1\\Memory Spel\\fotostest\\covercardpic.png";
                pictureBox.Image = System.Drawing.Image.FromFile(@test1);

                i++;
            }

            foreach (var Label in Controls.OfType<Label>())
            {
                Label.Visible = true;
            }
            btnBeginSpel.Visible = false;
            btnBeginSpel.Enabled = false;
            lblTitleScreen.Visible = false;


        }

        private void KlikkenKaart(object sender, EventArgs e)
        {
            if (EersteKeus == false)
            {
                EersteKaart = sender as PictureBox;
                EersteKaart.Enabled = false;
                string fullPath1 = Path.GetFullPath(@"C:\fontys\leerjaar 5\periode 1\SCC\Opdrachten\Opdracht1\Memory Spel\fotostest\" + EersteKaart.Tag.ToString() + ".png");
                EersteKaart.Image = System.Drawing.Image.FromFile(fullPath1);
                EersteKeus = true;
            }

            else if (TweedeKeus == false)
            {

                TweedeKaart = sender as PictureBox;
                TweedeKaart.Enabled = false;
                string fullPath2 = Path.GetFullPath(@"C:\fontys\leerjaar 5\periode 1\SCC\Opdrachten\Opdracht1\Memory Spel\fotostest\" + TweedeKaart.Tag.ToString() + ".png");
                TweedeKaart.Image = System.Drawing.Image.FromFile(fullPath2);
                TweedeKaart.Refresh();
                TweedeKeus = true;


            }

            if ((EersteKeus == true) & (TweedeKeus == true))
            //else
            {
                KaartChecken(EersteKaart, TweedeKaart, sender, e);
            }

        }

        private void KaartChecken(PictureBox A, PictureBox B, object sender, EventArgs e)
        {
            if (A.Tag.ToString() == B.Tag.ToString())
            {
                EersteKeus = false;
                TweedeKeus = false;
                if ((Turn % 2) == 0)
                {
                    Scorepl1++;
                    lblScorePlayer1.Text = Scorepl1.ToString();
                }

                else
                {
                    Scorepl2++;
                    lblScorePlayer2.Text = Scorepl2.ToString();
                }

            }
            else
            {
                System.Threading.Thread.Sleep(1000);

                A.Image = System.Drawing.Image.FromFile("C:\\fontys\\leerjaar 5\\periode 1\\SCC\\Opdrachten\\Opdracht1\\Memory Spel\\fotostest\\covercardpic.png");
                B.Image = System.Drawing.Image.FromFile("C:\\fontys\\leerjaar 5\\periode 1\\SCC\\Opdrachten\\Opdracht1\\Memory Spel\\fotostest\\covercardpic.png");
                EersteKeus = false;
                TweedeKeus = false;
                Turn++;
                EersteKaart.Enabled = true;
                TweedeKaart.Enabled = true;


                if ((Turn % 2) == 0)
                {
                    lblCurrentPlayer.Text = "Player 1";
                }
                else
                {
                    lblCurrentPlayer.Text = "Player 2";
                }
            }

            if ((Scorepl1 + Scorepl2) == 10)
            {
                GameOver(Scorepl1, Scorepl2, sender, e);
            }
        }

        void GameOver(int Score1, int Score2, object sender, EventArgs e)
        {
            if (Score1 == Score2)
            {
                DialogResult dialogResult = MessageBox.Show("Het is gelijkspel! Wil je nog een keer spelen voor de echter winnaar?", "Gamer over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    InitialiserenScherm(sender, e);
                }
            }
            if (Score1 > Score2)
            {
                DialogResult dialogResult = MessageBox.Show("Speler 1 heeft gewonnen! Wil je nog een keer spelen?", "Game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    InitialiserenScherm(sender, e);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Speler 2 heeft gewonnen! Wil je nog een keer spelen?", "Game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    InitialiserenScherm(sender, e);
                }
            }
        }


    }
}
