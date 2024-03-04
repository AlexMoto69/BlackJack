using System;
using System.CodeDom;
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

namespace BlackJack
{
    public partial class Game : Form
    {
        List<(string, bool)> playerHand = new List<(string, bool)>();
        List<(string, bool)> dealerHand = new List<(string, bool)>();
        Deck deck = new Deck();
        List<PictureBox> CardBoxes = new List<PictureBox>();
        private Point lastPoint;
        private int betsum = 0;
        private int userSum = 5000;
        int playerScore = 0;
        int dealerScore = 0;
        int hidenCard;
        int ivalue = 100;
        public Game()
        {
            InitializeComponent();
            labelBet.BackColor = Color.Transparent;
            labelInitial.BackColor = Color.Transparent;
            MoneyText.Text = userSum.ToString();
            MoneyBet.Text = betsum.ToString();
            startAgain();
        }
        
        private int GetCardValue(string name)
        {
            string number = name.Substring(name.Length-5, 1);
            if (number == "A")
                return 11;
            int number1  = int.Parse(number);
                if (number1 == 0)
                {
                    return 10;

                }
                else
                {
                    return number1;
                }

        }
        private void AddPictureBox(string imageName, Point Position)
        {
                try
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(Application.StartupPath + "\\cards\\" + imageName);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new System.Drawing.Size(128, 185);
                    pictureBox.Location = new Point(this.Width + Position.X, Position.Y);
                    pictureBox.BackColor = Color.Transparent;
                    this.Controls.Add(pictureBox);
                    pictureBox.BringToFront();
                    CardBoxes.Add(pictureBox);
                    Timer slideTimer = new Timer();
                    slideTimer.Interval = 5;
                    slideTimer.Tick += (sender, e) =>
                    {
                        pictureBox.Location = new Point(pictureBox.Location.X - 11, pictureBox.Location.Y);
                        if (pictureBox.Location.X <= Position.X)
                        {
                            slideTimer.Stop(); 
                        }
                    };
                    slideTimer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void UpdateLabels()
        {
            labelPlayerScore.Text = playerScore.ToString();
            labelDealerScore.Text = (dealerScore-hidenCard).ToString();
            MoneyText.Text = userSum.ToString();
            MoneyBet.Text = betsum.ToString();
        }
        private void Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Window_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void Minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PanelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void PanelDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            betsum += 10;
            userSum -= 10;
            UpdateLabels();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            betsum += 25;
            userSum -= 25;
            UpdateLabels();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            betsum += 50;
            userSum -= 50;
            UpdateLabels();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            betsum += 100;
            userSum -= 100;
            UpdateLabels();
        }

        private async void buttonStand_Click(object sender, EventArgs e)
        {
            revealHand();
            await Task.Delay(1000);
            while (dealerScore < 17)
            {
                   string dealerCard = deck.DrawCard();
                   dealerHand.Add((dealerCard,false));
                   dealerScore += GetCardValue(dealerCard);
                   AddPictureBox(dealerCard, new Point(this.Width * 2 / 7 + ivalue, this.Height * 1 / 9));
                   ivalue += 50;
                   await Task.Delay(1000);
                   UpdateLabels();
            }
            await Task.Delay(1000);
            if (dealerScore > 21 || dealerScore < playerScore)
            {
                userSum += betsum * 2;
                betsum = 0;
                MessageBox.Show("You won!");
                //startAgain();
            }
            else if (dealerScore == playerScore)
            {
                userSum += betsum;
                betsum = 0;
                MessageBox.Show("It's a draw!");
            }
            else
            {
                userSum -= betsum;
                betsum = 0;
                MessageBox.Show("You lost!");
            }
        }

        private async void buttonHIT_Click(object sender, EventArgs e)
        {
            string playerCard = deck.DrawCard();
            playerHand.Add((playerCard, false));
            playerScore += GetCardValue(playerCard);
            AddPictureBox(playerCard, new Point(this.Width * 2 / 7 + ivalue, this.Height * 5 / 9));
            ivalue += 50;
            UpdateLabels();
            if(playerScore > 21)
            {
                await Task.Delay(1000);
                userSum -= betsum;
                betsum = 0;
                MessageBox.Show("You lost!");
                UpdateLabels();
            }
        }
        private void revealHand()
        {

             string dealerCard = dealerHand[1].Item1;
             this.Controls.Remove(CardBoxes[3]);
             CardBoxes.RemoveAt(3);
             AddPictureBox(dealerCard, new Point(this.Width * 2 / 7 + 50, this.Height * 1 / 9));
             hidenCard=0;
             UpdateLabels();
        }
        private void startAgain()
        {
            playerScore = 0;
            dealerScore = 0;
            playerHand.Clear();
            dealerHand.Clear();
            for (int i = CardBoxes.Count - 1; i >= 0; i--)
            {
                this.Controls.Remove(CardBoxes[i]);
                CardBoxes[i].Dispose();
            }
            CardBoxes.Clear();
            ivalue = 100;
            deck.ResetDeck();
            for (int i = 0; i < 2; i++)
            {
                 string playerCard = deck.DrawCard();
                 playerHand.Add((playerCard,false));
                 playerScore += GetCardValue(playerCard);
                 AddPictureBox(playerCard, new Point(this.Width * 2 / 7 + i * 50, this.Height * 5 / 9));
            }
            for (int i = 0; i < 2; i++)
            {
                string dealerCard = deck.DrawCard();
                dealerHand.Add((dealerCard, false));
                dealerScore += GetCardValue(dealerCard);
                if (i == 1)
                {
                    AddPictureBox("back.png", new Point(this.Width * 2 / 7 + i * 50, this.Height * 1 / 9));
                    hidenCard = GetCardValue(dealerCard);
                }
                else
                {
                    AddPictureBox(dealerCard, new Point(this.Width * 2 / 7 + i * 50, this.Height * 1 / 9));
                }
            }
            UpdateLabels();
        }
    }
}
