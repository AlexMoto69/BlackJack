namespace BlackJack
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.signup_username = new System.Windows.Forms.TextBox();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signup_showPass = new System.Windows.Forms.CheckBox();
            this.signup_button = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_username
            // 
            this.signup_username.Location = new System.Drawing.Point(154, 160);
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(168, 20);
            this.signup_username.TabIndex = 0;
            // 
            // signup_password
            // 
            this.signup_password.Location = new System.Drawing.Point(154, 200);
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(168, 20);
            this.signup_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // signup_showPass
            // 
            this.signup_showPass.AutoSize = true;
            this.signup_showPass.Location = new System.Drawing.Point(221, 233);
            this.signup_showPass.Name = "signup_showPass";
            this.signup_showPass.Size = new System.Drawing.Size(101, 17);
            this.signup_showPass.TabIndex = 7;
            this.signup_showPass.Text = "Show password";
            this.signup_showPass.UseVisualStyleBackColor = true;
            this.signup_showPass.CheckedChanged += new System.EventHandler(this.signup_showPass_CheckedChanged);
            // 
            // signup_button
            // 
            this.signup_button.Location = new System.Drawing.Point(144, 270);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(97, 42);
            this.signup_button.TabIndex = 8;
            this.signup_button.Text = "SIGN UP";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(262, 377);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(86, 23);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "Login here";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack.Properties.Resources.bjlogo;
            this.pictureBox1.Location = new System.Drawing.Point(154, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(69, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 1);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.ForeColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(67, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 1);
            this.panel2.TabIndex = 10;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(121, 88);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(148, 32);
            this.labelLogin.TabIndex = 12;
            this.labelLogin.Text = "Register";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BlackJack.Properties.Resources.userlogo;
            this.pictureBox2.Location = new System.Drawing.Point(69, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BlackJack.Properties.Resources.passlogo;
            this.pictureBox3.Location = new System.Drawing.Point(67, 199);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Already have an account?";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 437);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.signup_showPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.signup_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox signup_showPass;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
    }
}