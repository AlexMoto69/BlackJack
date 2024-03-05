using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        private Point lastPoint;
        public Form1()
        {
            InitializeComponent();
            InitializePanel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Window_Click(object sender, EventArgs e)
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

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void InitializePanel()
        {
            panelStart = new Panel();
            panelStart.Size = new Size(200, 100);
            panelStart.AutoSize = true;
            panelStart.Location = GetPanelLocation();
            panelStart.Anchor = AnchorStyles.None;
            Controls.Add(panelStart);
        }

        private Point GetPanelLocation()
        {
            int x = (ClientSize.Width - panelStart.Width) / 2;
            int y = (ClientSize.Height - panelStart.Height) / 2;
            return new Point(x, y);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            panelStart.Location = GetPanelLocation();
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

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            LoginForm Game = new LoginForm();
            Game.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
