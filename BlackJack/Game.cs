using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Game : Form
    {

        private Point lastPoint;
        private int betsum = 0;
        private int userSum = 5000;
        public Game()
        {
            InitializeComponent();
            labelBet.BackColor = Color.Transparent;
            labelInitial.BackColor = Color.Transparent;
            MoneyText.Text = userSum.ToString();
            MoneyBet.Text = betsum.ToString();
        }

        int[] cardVect = new int[55];

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
    }
}
