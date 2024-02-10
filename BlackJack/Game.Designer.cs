﻿namespace BlackJack
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.PanelDrag = new System.Windows.Forms.Panel();
            this.ControlBox = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Window = new System.Windows.Forms.PictureBox();
            this.table = new System.Windows.Forms.Panel();
            this.MoneyBet = new System.Windows.Forms.Label();
            this.MoneyText = new System.Windows.Forms.Label();
            this.button100 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.labelInitial = new System.Windows.Forms.Label();
            this.button25 = new System.Windows.Forms.Button();
            this.labelBet = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.PanelDrag.SuspendLayout();
            this.ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window)).BeginInit();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDrag
            // 
            this.PanelDrag.BackColor = System.Drawing.Color.SeaGreen;
            this.PanelDrag.Controls.Add(this.ControlBox);
            this.PanelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDrag.Location = new System.Drawing.Point(0, 0);
            this.PanelDrag.Name = "PanelDrag";
            this.PanelDrag.Size = new System.Drawing.Size(800, 35);
            this.PanelDrag.TabIndex = 1;
            this.PanelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDrag_MouseDown);
            this.PanelDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelDrag_MouseMove);
            // 
            // ControlBox
            // 
            this.ControlBox.Controls.Add(this.Close);
            this.ControlBox.Controls.Add(this.Minimize);
            this.ControlBox.Controls.Add(this.Window);
            this.ControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlBox.Location = new System.Drawing.Point(690, 0);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(110, 35);
            this.ControlBox.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Close.ErrorImage")));
            this.Close.Image = global::BlackJack.Properties.Resources.close;
            this.Close.Location = new System.Drawing.Point(75, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(29, 29);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close.TabIndex = 3;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click_1);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.Image = global::BlackJack.Properties.Resources.Minimize;
            this.Minimize.Location = new System.Drawing.Point(3, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 29);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 1;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click_1);
            // 
            // Window
            // 
            this.Window.BackColor = System.Drawing.Color.Transparent;
            this.Window.Image = global::BlackJack.Properties.Resources.Maximize;
            this.Window.Location = new System.Drawing.Point(39, 3);
            this.Window.Name = "Window";
            this.Window.Size = new System.Drawing.Size(30, 29);
            this.Window.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Window.TabIndex = 2;
            this.Window.TabStop = false;
            this.Window.Click += new System.EventHandler(this.Window_Click_1);
            // 
            // table
            // 
            this.table.BackgroundImage = global::BlackJack.Properties.Resources.table;
            this.table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.Controls.Add(this.MoneyBet);
            this.table.Controls.Add(this.MoneyText);
            this.table.Controls.Add(this.button100);
            this.table.Controls.Add(this.button50);
            this.table.Controls.Add(this.labelInitial);
            this.table.Controls.Add(this.button25);
            this.table.Controls.Add(this.labelBet);
            this.table.Controls.Add(this.button10);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(800, 450);
            this.table.TabIndex = 10;
            // 
            // MoneyBet
            // 
            this.MoneyBet.AutoSize = true;
            this.MoneyBet.BackColor = System.Drawing.Color.Transparent;
            this.MoneyBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyBet.Location = new System.Drawing.Point(741, 90);
            this.MoneyBet.Name = "MoneyBet";
            this.MoneyBet.Size = new System.Drawing.Size(21, 24);
            this.MoneyBet.TabIndex = 11;
            this.MoneyBet.Text = "0";
            // 
            // MoneyText
            // 
            this.MoneyText.AutoSize = true;
            this.MoneyText.BackColor = System.Drawing.Color.Transparent;
            this.MoneyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyText.Location = new System.Drawing.Point(741, 55);
            this.MoneyText.Name = "MoneyText";
            this.MoneyText.Size = new System.Drawing.Size(21, 24);
            this.MoneyText.TabIndex = 10;
            this.MoneyText.Text = "0";
            // 
            // button100
            // 
            this.button100.BackColor = System.Drawing.Color.Transparent;
            this.button100.BackgroundImage = global::BlackJack.Properties.Resources.black_chip;
            this.button100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button100.FlatAppearance.BorderSize = 0;
            this.button100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button100.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button100.Location = new System.Drawing.Point(483, 368);
            this.button100.Name = "button100";
            this.button100.Size = new System.Drawing.Size(88, 82);
            this.button100.TabIndex = 6;
            this.button100.Text = "100";
            this.button100.UseVisualStyleBackColor = false;
            this.button100.Click += new System.EventHandler(this.button100_Click);
            // 
            // button50
            // 
            this.button50.BackColor = System.Drawing.Color.Transparent;
            this.button50.BackgroundImage = global::BlackJack.Properties.Resources.orange_chip;
            this.button50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button50.FlatAppearance.BorderSize = 0;
            this.button50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button50.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button50.Location = new System.Drawing.Point(391, 368);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(86, 82);
            this.button50.TabIndex = 5;
            this.button50.Text = "50";
            this.button50.UseVisualStyleBackColor = false;
            this.button50.Click += new System.EventHandler(this.button50_Click);
            // 
            // labelInitial
            // 
            this.labelInitial.AutoSize = true;
            this.labelInitial.BackColor = System.Drawing.Color.Transparent;
            this.labelInitial.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInitial.Location = new System.Drawing.Point(652, 53);
            this.labelInitial.Name = "labelInitial";
            this.labelInitial.Size = new System.Drawing.Size(83, 26);
            this.labelInitial.TabIndex = 8;
            this.labelInitial.Text = "Money:";
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Transparent;
            this.button25.BackgroundImage = global::BlackJack.Properties.Resources.red_chip;
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button25.Location = new System.Drawing.Point(298, 368);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(87, 82);
            this.button25.TabIndex = 4;
            this.button25.Text = "25";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.BackColor = System.Drawing.Color.Transparent;
            this.labelBet.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBet.Location = new System.Drawing.Point(685, 90);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(49, 26);
            this.labelBet.TabIndex = 7;
            this.labelBet.Text = "Bet:";
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImage = global::BlackJack.Properties.Resources.blue_chip;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.Location = new System.Drawing.Point(208, 368);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 82);
            this.button10.TabIndex = 3;
            this.button10.Text = "10";
            this.button10.UseCompatibleTextRendering = true;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelDrag);
            this.Controls.Add(this.table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.Text = "Game";
            this.PanelDrag.ResumeLayout(false);
            this.ControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window)).EndInit();
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelDrag;
        private System.Windows.Forms.Panel ControlBox;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Window;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button100;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.Label labelInitial;
        private System.Windows.Forms.Panel table;
        private System.Windows.Forms.Label MoneyBet;
        private System.Windows.Forms.Label MoneyText;
        private System.Windows.Forms.Button button25;
    }
}