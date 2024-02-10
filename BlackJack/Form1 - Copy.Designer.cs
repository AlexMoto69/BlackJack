namespace BlackJack
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ControlBox = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Window = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.ControlBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 35);
            this.panel1.TabIndex = 0;
            // 
            // ControlBox
            // 
            this.ControlBox.Controls.Add(this.Close);
            this.ControlBox.Controls.Add(this.Minimize);
            this.ControlBox.Controls.Add(this.Window);
            this.ControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlBox.Location = new System.Drawing.Point(898, 0);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(149, 35);
            this.ControlBox.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Close.ErrorImage")));
            this.Close.Image = global::BlackJack.Properties.Resources.close;
            this.Close.Location = new System.Drawing.Point(117, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(29, 29);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close.TabIndex = 3;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.Image = global::BlackJack.Properties.Resources.Minimize;
            this.Minimize.Location = new System.Drawing.Point(45, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 29);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 1;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Window
            // 
            this.Window.BackColor = System.Drawing.Color.Transparent;
            this.Window.Image = global::BlackJack.Properties.Resources.Maximize;
            this.Window.Location = new System.Drawing.Point(81, 3);
            this.Window.Name = "Window";
            this.Window.Size = new System.Drawing.Size(30, 29);
            this.Window.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Window.TabIndex = 2;
            this.Window.TabStop = false;
            this.Window.Click += new System.EventHandler(this.Window_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1047, 781);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Window;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Panel ControlBox;
    }
}

