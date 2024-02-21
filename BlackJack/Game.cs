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
        List<(string, bool)> deck = new List<(string, bool)>();
        List<(string, bool)> playerHand = new List<(string, bool)>();
        List<(string, bool)> dealerHand = new List<(string, bool)>();
        private Point lastPoint;
        private int betsum = 0;
        private int userSum = 5000;
        int playerScore = 0;
        int dealerScore = 0;
        Random random = new Random();
        public Game()
        {
            InitializeComponent();
            labelBet.BackColor = Color.Transparent;
            labelInitial.BackColor = Color.Transparent;
            MoneyText.Text = userSum.ToString();
            MoneyBet.Text = betsum.ToString();
            
            InitializeDeck();
            for (int i = 0; i < 2; i++)
            {
                int number = random.Next(0, deck.Count-2);
                if (deck[number].Item2 == false)
                {
                    playerHand.Add(deck[number]);
                    playerScore += GetCardValue(deck[number].Item1);
                    deck[number] = (deck[number].Item1, true);
                    AddPictureBox(number, new Point(this.Width*2/7 + i * 50, this.Height*5/9));
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                int number = random.Next(0, deck.Count-2);
                if (deck[number].Item2 == false)
                {
                    dealerHand.Add(deck[number]);
                    
                    deck[number] = (deck[number].Item1, true);
                    if(i == 1)
                    {
                        AddPictureBox(deck.Count-1, new Point(this.Width*2/7 + i * 50, this.Height*1/9));
                    }
                    else
                    {
                        dealerScore += GetCardValue(deck[number].Item1);
                        AddPictureBox(number, new Point(this.Width*2/7 + i * 50, this.Height*1/9));
                    }
                }
                else
                {
                    i--;
                }  
                
            }
            labelPlayerScore.Text = playerScore.ToString();
            labelDealerScore.Text = dealerScore.ToString();
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
        private void AddPictureBox(int x, Point Position)
        {
            string imageName = deck[x].Item1;
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
        private void UpdateMoney()
        {
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
            UpdateMoney();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            betsum += 25;
            userSum -= 25;
            UpdateMoney();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            betsum += 50;
            userSum -= 50;
            UpdateMoney();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            betsum += 100;
            userSum -= 100;
            UpdateMoney();
        }

        private void InitializeDeck()
        {
            deck.Add(("2IR02.png", false));
            deck.Add(("3IR03.png", false));
            deck.Add(("4IR04.png", false));
            deck.Add(("5IR05.png", false));
            deck.Add(("6IR06.png", false));
            deck.Add(("7IR07.png", false));
            deck.Add(("8IR08.png", false));
            deck.Add(("9IR09.png", false));
            deck.Add(("10IR10.png", false));
            deck.Add(("AIRA.png", false));
            deck.Add(("JIR10.png", false));
            deck.Add(("QIR10.png", false));
            deck.Add(("KIR10.png", false));
            deck.Add(("2T02.png", false));
            deck.Add(("3T03.png", false));
            deck.Add(("4T04.png", false));
            deck.Add(("5T05.png", false));
            deck.Add(("6T06.png", false));
            deck.Add(("7T07.png", false));
            deck.Add(("8T08.png", false));
            deck.Add(("9T09.png", false));
            deck.Add(("10T10.png", false));
            deck.Add(("ATA.png", false));
            deck.Add(("JT10.png", false));
            deck.Add(("QT10.png", false));
            deck.Add(("KT10.png", false));
            deck.Add(("2R02.png", false));
            deck.Add(("3R03.png", false));
            deck.Add(("4R04.png", false));
            deck.Add(("5R05.png", false));
            deck.Add(("6R06.png", false));
            deck.Add(("7R07.png", false));
            deck.Add(("8R08.png", false));
            deck.Add(("9R09.png", false));
            deck.Add(("10R10.png", false));
            deck.Add(("ARA.png", false));
            deck.Add(("JR10.png", false));
            deck.Add(("QR10.png", false));
            deck.Add(("KR10.png", false));
            deck.Add(("2IN02.png", false));
            deck.Add(("3IN03.png", false));
            deck.Add(("4IN04.png", false));
            deck.Add(("5IN05.png", false));
            deck.Add(("6IN06.png", false));
            deck.Add(("7IN07.png", false));
            deck.Add(("8IN08.png", false));
            deck.Add(("9IN09.png", false));
            deck.Add(("10IN10.png", false));
            deck.Add(("AINA.png", false));
            deck.Add(("JIN10.png", false));
            deck.Add(("QIN10.png", false));
            deck.Add(("KIN10.png", false));
            deck.Add(("back.png", false));
        }
    }
}
