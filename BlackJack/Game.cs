using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace BlackJack
{
    public partial class Game : Form
    {
        SqlConnection connect;
        List<(string, bool)> playerHand = new List<(string, bool)>();
        List<(string, bool)> dealerHand = new List<(string, bool)>();
        Deck deck = new Deck();
        List<PictureBox> CardBoxes = new List<PictureBox>();
        private Point lastPoint;
        private int betsum = 0;
        private int userSum = 1000;
        int playerScore = 0;
        int dealerScore = 0;
        int hidenCard;
        int ivalue = 100;
        int ivalue2 = 100;
        string EndMessage = "Place Your Bet";
        string usernameString;
        int ok = 1;
        int ok2 = 0;
        public Game()
        {
            InitializeComponent();
            string debugFolderPath = Directory.GetParent(Application.StartupPath).FullName;
            string solutionFolderPath = Directory.GetParent(debugFolderPath).FullName;
            string databasePath = Path.Combine(solutionFolderPath, "DatabaseLogin.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";
            connect = new SqlConnection(connectionString);
            labelBet.BackColor = Color.Transparent;
            labelInitial.BackColor = Color.Transparent;
            MoneyText.Text = userSum.ToString();
            MoneyBet.Text = betsum.ToString();
            endScreen();

            ///

            LoginForm loginForm = new LoginForm();
            // Retrieve the username string from LoginForm and store it in usernameString
            usernameString = loginForm.UsernameText;

            ///

        }

        private int GetCardValue(string name)
        {
            string number = name.Substring(name.Length - 5, 1);
            if (number == "A")
                return 11;
            int number1 = int.Parse(number);
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
                pictureBox.Location = new Point(0 - 100, Position.Y);
                pictureBox.BackColor = Color.Transparent;
                this.Controls.Add(pictureBox);
                pictureBox.BringToFront();
                CardBoxes.Add(pictureBox);
                Timer slideTimer = new Timer();
                slideTimer.Interval = 5;
                slideTimer.Tick += (sender, e) =>
                {
                    pictureBox.Location = new Point(pictureBox.Location.X + 15, pictureBox.Location.Y);
                    if (pictureBox.Location.X >= Position.X)
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

        private void SlideDown(string imageName, Point Position)
        {
            try
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(Application.StartupPath + "\\cards\\" + imageName);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new System.Drawing.Size(128, 185);
                pictureBox.Location = new Point(Position.X, 0 - Position.Y);
                pictureBox.BackColor = Color.Transparent;
                this.Controls.Add(pictureBox);
                pictureBox.BringToFront();
                CardBoxes.Add(pictureBox);
                Timer slideTimer = new Timer();
                slideTimer.Interval = 5;
                slideTimer.Tick += (sender, e) =>
                {
                    pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y + 15);
                    if (pictureBox.Location.Y >= Position.Y)
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
            labelPlayerScore.Text = CalculateScore(playerHand).ToString();
            labelDealerScore.Text = (CalculateScore(dealerHand) - hidenCard).ToString();
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
            if (ok2 == 0)
            {
                betsum += 10;
                userSum -= 10;
                UpdateLabels();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (ok2 == 0)
            {
                betsum += 25;
                userSum -= 25;
                UpdateLabels();
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (ok2 == 0)
            {
                betsum += 50;
                userSum -= 50;
                UpdateLabels();
            }
        }

        private void button100_Click(object sender, EventArgs e)
        {
            if (ok2 == 0)
            {
                betsum += 100;
                userSum -= 100;
                UpdateLabels();
            }
        }
        private int CalculateScore(List<(string, bool)> hand)
        {
            int score = 0;
            int aceCount = 0;

            foreach (var card in hand)
            {
                int cardValue = GetCardValue(card.Item1);
                score += cardValue;
                if (cardValue == 11)
                {
                    aceCount++;
                }
            }
            while (score > 21 && aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }

            return score;
        }


        private async void buttonStand_Click(object sender, EventArgs e)
        {
            if (ok == 0)
            {
                revealHand();
                await Task.Delay(1000);
                while (dealerScore < 17 || CalculateScore(dealerHand) < CalculateScore(playerHand))
                {
                    string dealerCard = deck.DrawCard();
                    dealerHand.Add((dealerCard, false));
                    dealerScore += GetCardValue(dealerCard);
                    AddPictureBox(dealerCard, new Point(this.Width * 2 / 7 + ivalue2, this.Height * 1 / 9));
                    ivalue2 += 50;
                    await Task.Delay(1000);
                    UpdateLabels();
                }
                await Task.Delay(1000);
                if (CalculateScore(dealerHand) > 21 || CalculateScore(dealerHand) < CalculateScore(playerHand))
                {
                    userSum += betsum * 2;
                    betsum = 0;
                    EndMessage = "You won!";
                    endScreen();
                }
                else if (CalculateScore(dealerHand) == CalculateScore(playerHand))
                {
                    userSum += betsum;
                    betsum = 0;
                    EndMessage = "It's a draw!";
                    endScreen();
                }
                else
                {
                    betsum = 0;
                    EndMessage = "You lost!";
                    endScreen();
                }
            }
        }

        private async void buttonHIT_Click(object sender, EventArgs e)
        {
            if (ok == 0)
            {
                string playerCard = deck.DrawCard();
                playerHand.Add((playerCard, false));
                playerScore += GetCardValue(playerCard);
                AddPictureBox(playerCard, new Point(this.Width * 2 / 7 + ivalue, this.Height * 5 / 9));
                ivalue += 50;
                UpdateLabels();
                if (CalculateScore(playerHand) > 21)
                {
                    await Task.Delay(1000);
                    betsum = 0;
                    revealHand();
                    await Task.Delay(1000);
                    EndMessage = "You lost!";
                    UpdateLabels();
                    endScreen();
                }
            }
        }

        private void revealHand()
        {
            string dealerCard = dealerHand[1].Item1;
            this.Controls.Remove(CardBoxes[3]);
            CardBoxes.RemoveAt(3);
            SlideDown(dealerCard, new Point(this.Width * 2 / 7 + 50, this.Height * 1 / 9));
            hidenCard = 0;
            UpdateLabels();
        }

        public async void endScreen()
        {
            ok = 1;
            Panel panel = new Panel();
            panel.BackColor = Color.DarkSlateGray;
            panel.Size = new Size(this.Width / 2, this.Height / 2);
            panel.Location = new Point((this.Width - panel.Width) / 2, (this.Height - panel.Height) / 2);
            panel.BringToFront();

            Label label = new Label();
            label.Text = EndMessage;
            label.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            label.AutoSize = true;
            label.Location = new Point((panel.Width - label.Width - 50) / 2, 100);

            Button button = new Button();
            button.Text = "Play";
            button.Font = new Font("Comic Sans MS", 48, FontStyle.Bold);
            button.AutoSize = true;
            button.Location = new Point((panel.Width - button.Width - 130) / 2, (panel.Height - button.Height) / 2);

            button.Click += (sender, e) =>
            {
                if (betsum > 0)
                {
                    this.Controls.Remove(panel);
                    startAgain();
                }
                else
                    MessageBox.Show("Bet can't be 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            panel.Controls.Add(label);
            panel.Controls.Add(button);

            this.Controls.Add(panel);
            UpdateLabels();
            panel.BringToFront();
        }
        private void startAgain()
        {
            ok2 = 0;
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
            deck.ResetDeck();
            UpdateLabels();
            if (betsum > 0)
            {
                ok = 0;
                ivalue = 100;
                ivalue2 = 100;
                for (int i = 0; i < 2; i++)
                {
                    string playerCard = deck.DrawCard();
                    playerHand.Add((playerCard, false));
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
}