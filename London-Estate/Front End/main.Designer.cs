namespace London_Estate
{
    partial class main
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
            this.lb_Logo = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Logo
            // 
            this.lb_Logo.AutoSize = true;
            this.lb_Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Logo.Location = new System.Drawing.Point(105, 81);
            this.lb_Logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Logo.Name = "lb_Logo";
            this.lb_Logo.Size = new System.Drawing.Size(779, 69);
            this.lb_Logo.TabIndex = 0;
            this.lb_Logo.Text = "London Estate Rental Book";
            this.lb_Logo.Click += new System.EventHandler(this.lb_Logo_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(251, 82);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(73, 17);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username";
            this.label_username.Click += new System.EventHandler(this.label_username_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(251, 132);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(61, 17);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Passkey";
            this.label_password.Click += new System.EventHandler(this.label_password_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(409, 132);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 4;
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.textBox1);
            this.panel_login.Controls.Add(this.textBox2);
            this.panel_login.Controls.Add(this.label_username);
            this.panel_login.Controls.Add(this.label_password);
            this.panel_login.Location = new System.Drawing.Point(105, 303);
            this.panel_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(833, 306);
            this.panel_login.TabIndex = 5;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(255, 229);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(288, 30);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Enter";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 937);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.lb_Logo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Logo;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Button btn_login;
    }
}

