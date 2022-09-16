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
        //string fotomap = "C:/fontys/leerjaar 5/periode 1/SCC/Opdrachten/Opdracht1/Memory Spel/fotostest/";

        public MemoryGame()
        {
            InitializeComponent();
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

            var i = 0;
            foreach (var pictureBox in Controls.OfType<PictureBox>())
            {
                //pictureBox.Visible = true;
                pictureBox.Enabled = true;
                pictureBox.Tag = GeschuddeKaarten[i].ToString();
                pictureBox.Image = System.Drawing.Image.FromFile("fotos/memoryfotos/" + "covercardpic.png");

                i++;
            }

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
            foreach (var pictureBox in Controls.OfType<PictureBox>())
            {
                pictureBox.Visible = true;
            }

            foreach (var Label in Controls.OfType<Label>())
            {
                Label.Visible = true;
            }

            btnBeginSpel.Visible = false;
            btnBeginSpel.Enabled = false;
            lblTitleScreen.Visible = false;

            Herstartspel();


        }

        private void KlikkenKaart(object sender, EventArgs e)
        {
            //Kiezen eerste kaart
            if (EersteKeus == false)
            {

                EersteKaart = sender as PictureBox;
                EersteKaart.Enabled = false;
                EersteKaart.Image = System.Drawing.Image.FromFile("fotos/memoryfotos/" + EersteKaart.Tag.ToString() + ".png");
                EersteKeus = true;
            }

            //Kiezen tweede kaart
            else if (TweedeKeus == false)
            {

                TweedeKaart = sender as PictureBox;
                TweedeKaart.Enabled = false;
                TweedeKaart.Image = System.Drawing.Image.FromFile("fotos/memoryfotos/" + TweedeKaart.Tag.ToString() + ".png");
                TweedeKaart.Refresh();
                TweedeKeus = true;
            }

            //Checken wanneer twee kaarten zijn aangeklikt
            if ((EersteKeus == true) & (TweedeKeus == true))
            {
                KaartChecken(EersteKaart, TweedeKaart, sender, e);
            }

        }

        //Bekijken of de twee kaarten gelijk zijn
        private void KaartChecken(PictureBox A, PictureBox B, object sender, EventArgs e)
        {


            //Kijken of kaarten gelijk
            if (A.Tag.ToString() == B.Tag.ToString())
            {
                //Is speler 1 aan de beurt?
                if ((Turn % 2) == 0)
                {
                    //Speler 1 krijgt een extra punt
                    Scorepl1++;
                    //Display text verandert
                    lblScorePlayer1.Text = Scorepl1.ToString();
                }

                //Speler 2 is aan de beurt
                else
                {
                    Scorepl2++;
                    lblScorePlayer2.Text = Scorepl2.ToString();
                }

            }

            //De foto's zijn niet gelijk
            else
            {
                //process pauzeren zodat foto's zichtbaar zijn
                System.Threading.Thread.Sleep(1000);

                // Foto terug veranderen naar achterkantfoto
                A.Image = System.Drawing.Image.FromFile("fotos/memoryfotos/" + "covercardpic.png");
                B.Image = System.Drawing.Image.FromFile("fotos/memoryfotos/" + "covercardpic.png");

                Turn++;

                //De kaarten weer
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

            //Gameover als de totale score 10 is
            if ((Scorepl1 + Scorepl2) == 10)
            {
                //GameOver(Scorepl1, Scorepl2, sender, e);
                GameOver(Scorepl1, Scorepl2);
            }

            //Keuzen leegmaken
            EersteKeus = false;
            TweedeKeus = false;

        }

        void GameOver(int Score1, int Score2)
        //void GameOver(int Score1, int Score2, object sender, EventArgs e)
        {
            //Speler 1 en 2 hebben een gelijke score
            if (Score1 == Score2)
            {
                DialogResult dialogResult = MessageBox.Show("Het is gelijkspel! Wil je nog een keer spelen voor de echter winnaar?", "Gamer over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Herstart het spel
                    Herstartspel();
                }
            }

            //Speler 1 heeft een hogere score
            if (Score1 > Score2)
            {
                DialogResult dialogResult = MessageBox.Show("Speler 1 heeft gewonnen! Wil je nog een keer spelen?", "Game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Herstart het spel
                    Herstartspel();
                }
            }

            ////Speler 2 heeft een hogere score
            if (Score2 > Score1)
            {
                DialogResult dialogResult = MessageBox.Show("Speler 2 heeft gewonnen! Wil je nog een keer spelen?", "Game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Herstart het spel
                    Herstartspel();
                }
            }
        }
    }
}
