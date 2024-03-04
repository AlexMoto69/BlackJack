namespace BlackJack
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
            this.button10 = new System.Windows.Forms.Button();
            this.labelBet = new System.Windows.Forms.Label();
            this.button25 = new System.Windows.Forms.Button();
            this.labelInitial = new System.Windows.Forms.Label();
            this.button50 = new System.Windows.Forms.Button();
            this.button100 = new System.Windows.Forms.Button();
            this.MoneyText = new System.Windows.Forms.Label();
            this.MoneyBet = new System.Windows.Forms.Label();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.labelDealerScore = new System.Windows.Forms.Label();
            this.buttonHIT = new System.Windows.Forms.Button();
            this.buttonStand = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.Panel();
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
            this.PanelDrag.Size = new System.Drawing.Size(1009, 35);
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
            this.ControlBox.Location = new System.Drawing.Point(899, 0);
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
            this.button10.Location = new System.Drawing.Point(306, 585);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 82);
            this.button10.TabIndex = 3;
            this.button10.Text = "10";
            this.button10.UseCompatibleTextRendering = true;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.BackColor = System.Drawing.Color.Transparent;
            this.labelBet.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBet.Location = new System.Drawing.Point(883, 97);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(49, 26);
            this.labelBet.TabIndex = 7;
            this.labelBet.Text = "Bet:";
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
            this.button25.Location = new System.Drawing.Point(396, 585);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(87, 82);
            this.button25.TabIndex = 4;
            this.button25.Text = "25";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // labelInitial
            // 
            this.labelInitial.AutoSize = true;
            this.labelInitial.BackColor = System.Drawing.Color.Transparent;
            this.labelInitial.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInitial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelInitial.Location = new System.Drawing.Point(850, 60);
            this.labelInitial.Name = "labelInitial";
            this.labelInitial.Size = new System.Drawing.Size(83, 26);
            this.labelInitial.TabIndex = 8;
            this.labelInitial.Text = "Money:";
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
            this.button50.Location = new System.Drawing.Point(489, 585);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(86, 82);
            this.button50.TabIndex = 5;
            this.button50.Text = "50";
            this.button50.UseVisualStyleBackColor = false;
            this.button50.Click += new System.EventHandler(this.button50_Click);
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
            this.button100.Location = new System.Drawing.Point(581, 585);
            this.button100.Name = "button100";
            this.button100.Size = new System.Drawing.Size(88, 82);
            this.button100.TabIndex = 6;
            this.button100.Text = "100";
            this.button100.UseVisualStyleBackColor = false;
            this.button100.Click += new System.EventHandler(this.button100_Click);
            // 
            // MoneyText
            // 
            this.MoneyText.AutoSize = true;
            this.MoneyText.BackColor = System.Drawing.Color.Transparent;
            this.MoneyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MoneyText.Location = new System.Drawing.Point(939, 62);
            this.MoneyText.Name = "MoneyText";
            this.MoneyText.Size = new System.Drawing.Size(21, 24);
            this.MoneyText.TabIndex = 10;
            this.MoneyText.Text = "0";
            // 
            // MoneyBet
            // 
            this.MoneyBet.AutoSize = true;
            this.MoneyBet.BackColor = System.Drawing.Color.Transparent;
            this.MoneyBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyBet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MoneyBet.Location = new System.Drawing.Point(939, 97);
            this.MoneyBet.Name = "MoneyBet";
            this.MoneyBet.Size = new System.Drawing.Size(21, 24);
            this.MoneyBet.TabIndex = 11;
            this.MoneyBet.Text = "0";
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPlayerScore.Location = new System.Drawing.Point(450, 567);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(70, 25);
            this.labelPlayerScore.TabIndex = 12;
            this.labelPlayerScore.Text = "label1";
            // 
            // labelDealerScore
            // 
            this.labelDealerScore.AutoSize = true;
            this.labelDealerScore.BackColor = System.Drawing.Color.Transparent;
            this.labelDealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDealerScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDealerScore.Location = new System.Drawing.Point(450, 38);
            this.labelDealerScore.Name = "labelDealerScore";
            this.labelDealerScore.Size = new System.Drawing.Size(70, 25);
            this.labelDealerScore.TabIndex = 13;
            this.labelDealerScore.Text = "label1";
            // 
            // buttonHIT
            // 
            this.buttonHIT.BackColor = System.Drawing.Color.Red;
            this.buttonHIT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buttonHIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHIT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHIT.Location = new System.Drawing.Point(888, 317);
            this.buttonHIT.Name = "buttonHIT";
            this.buttonHIT.Size = new System.Drawing.Size(84, 34);
            this.buttonHIT.TabIndex = 14;
            this.buttonHIT.Text = "Hit";
            this.buttonHIT.UseVisualStyleBackColor = false;
            this.buttonHIT.Click += new System.EventHandler(this.buttonHIT_Click);
            // 
            // buttonStand
            // 
            this.buttonStand.BackColor = System.Drawing.Color.Green;
            this.buttonStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStand.Location = new System.Drawing.Point(888, 379);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(84, 34);
            this.buttonStand.TabIndex = 15;
            this.buttonStand.Text = "Stand";
            this.buttonStand.UseVisualStyleBackColor = false;
            this.buttonStand.Click += new System.EventHandler(this.buttonStand_Click);
            // 
            // table
            // 
            this.table.BackgroundImage = global::BlackJack.Properties.Resources.table;
            this.table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.Controls.Add(this.buttonStand);
            this.table.Controls.Add(this.buttonHIT);
            this.table.Controls.Add(this.labelDealerScore);
            this.table.Controls.Add(this.labelPlayerScore);
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
            this.table.Size = new System.Drawing.Size(1009, 679);
            this.table.TabIndex = 10;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 679);
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
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Label labelInitial;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button100;
        private System.Windows.Forms.Label MoneyText;
        private System.Windows.Forms.Label MoneyBet;
        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.Label labelDealerScore;
        private System.Windows.Forms.Button buttonHIT;
        private System.Windows.Forms.Button buttonStand;
        private System.Windows.Forms.Panel table;
    }
}