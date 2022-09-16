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
        int Turn = 1;
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

        //File menu strip
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //Tooltip popup
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        //Nieuw game event
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Wil je een nieuw spel beginnen?", "Nieuw spel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                InitialiserenScherm(sender, e);
            }
        }

        //Nieuw random rng voor list kaarten
        private static Random rng = new Random();

        //Functie om spel te herstarten
        public void Herstartspel()
        {
            //Kaarten volgorde opnieuw schudden
            GeschuddeKaarten = GeschuddeKaarten.OrderBy(a => Guid.NewGuid()).ToList();

            //Labels resetten
            lblScorePlayer1.Text = "0";
            lblScorePlayer2.Text = "0";
            Scorepl1 = 0;
            Scorepl2 = 0;
            lblCurrentPlayer.Text = "Player 1";

            //Elke pictureBox naar de achterkant foto veranderen
            var i = 0;
            foreach (var pictureBox in Controls.OfType<PictureBox>())
            {
                pictureBox.Enabled = true;
                pictureBox.Tag = GeschuddeKaarten[i].ToString();
                pictureBox.Image = System.Drawing.Image.FromFile("fotos/memoryfotos/covercardpic.png");

                i++;
            }

        }



        private void InitialiserenScherm(object sender, EventArgs e)
        {
            //Maak elke picturebox zichtbaar
            foreach (var pictureBox in Controls.OfType<PictureBox>())
            {
                pictureBox.Visible = true;
            }

            //Spel informatie labels zichtbaar maken
            foreach (var Label in Controls.OfType<Label>())
            {
                Label.Visible = true;
            }
            
            //Hoofdscherm elementen ontzichtbaar maken
            btnBeginSpel.Visible = false;
            btnBeginSpel.Enabled = false;
            lblTitleScreen.Visible = false;

            //spel herstarten
            Herstartspel();


        }

        //Functie om naar hoofdscherm te gaan
        void HoofdScherm()
        {
            foreach (var pictureBox in Controls.OfType<PictureBox>())
            {
                pictureBox.Visible = false;
                pictureBox.Enabled = false;
                pictureBox.Image = null;
            }

            foreach (var Label in Controls.OfType<Label>())
            {
                Label.Visible = false;
                Label.Visible = false;
            }

            btnBeginSpel.Visible = true;
            btnBeginSpel.Enabled = true;
            lblTitleScreen.Visible = true;
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
                //oneven beurt modulo 2 is 1
                Console.WriteLine(Turn);
                Console.WriteLine(Turn % 2);
                if ((Turn % 2) == 1)
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

                

                //De kaarten weer
                EersteKaart.Enabled = true;
                TweedeKaart.Enabled = true;

                //Speler veranderen
                //oneven beurt modulo 2 is 1
                Console.WriteLine(Turn % 2);
                if ((Turn % 2) == 1)
                {
                    lblCurrentPlayer.Text = "Player 1";
                }
                else
                {
                    lblCurrentPlayer.Text = "Player 2";
                }

                Turn++;
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

                if (dialogResult == DialogResult.No)
                {
                    //Ga naar schoofdscherm
                    HoofdScherm();
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


                if (dialogResult == DialogResult.No)
                {
                    //Ga naar schoofdscherm
                    HoofdScherm();
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

                if (dialogResult == DialogResult.No)
                {
                    //Ga naar schoofdscherm
                    HoofdScherm();
                }

            }
        }
    }
}
