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
            this.PanelDrag = new System.Windows.Forms.Panel();
            this.ControlBox = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Window = new System.Windows.Forms.PictureBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelStart = new System.Windows.Forms.Panel();
            this.LabelText = new System.Windows.Forms.Label();
            this.PanelDrag.SuspendLayout();
            this.ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDrag
            // 
            this.PanelDrag.BackColor = System.Drawing.Color.SeaGreen;
            this.PanelDrag.Controls.Add(this.ControlBox);
            this.PanelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDrag.Location = new System.Drawing.Point(0, 0);
            this.PanelDrag.Name = "PanelDrag";
            this.PanelDrag.Size = new System.Drawing.Size(1083, 35);
            this.PanelDrag.TabIndex = 0;
            this.PanelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDrag_MouseDown);
            this.PanelDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelDrag_MouseMove);
            // 
            // ControlBox
            // 
            this.ControlBox.Controls.Add(this.Close);
            this.ControlBox.Controls.Add(this.Minimize);
            this.ControlBox.Controls.Add(this.Window);
            this.ControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlBox.Location = new System.Drawing.Point(973, 0);
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
            this.Close.Click += new System.EventHandler(this.Close_Click);
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
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
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
            this.Window.Click += new System.EventHandler(this.Window_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonStart.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Location = new System.Drawing.Point(35, 185);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(414, 219);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Press to Play";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 685);
            this.panel2.TabIndex = 2;
            // 
            // panelStart
            // 
            this.panelStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelStart.AutoSize = true;
            this.panelStart.Controls.Add(this.LabelText);
            this.panelStart.Controls.Add(this.ButtonStart);
            this.panelStart.Location = new System.Drawing.Point(276, 107);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(484, 427);
            this.panelStart.TabIndex = 2;
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelText.Location = new System.Drawing.Point(88, 40);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(327, 90);
            this.LabelText.TabIndex = 2;
            this.LabelText.Text = "Welcome!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1083, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelDrag.ResumeLayout(false);
            this.ControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelDrag;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Window;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Panel ControlBox;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Label LabelText;
    }
}

