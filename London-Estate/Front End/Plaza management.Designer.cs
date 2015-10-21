namespace London_Estate
{
    partial class Plaza_management
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
            this.btn_viewallplaza = new System.Windows.Forms.Button();
            this.btn_addnewplaza = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_viewallplaza
            // 
            this.btn_viewallplaza.Location = new System.Drawing.Point(225, 42);
            this.btn_viewallplaza.Name = "btn_viewallplaza";
            this.btn_viewallplaza.Size = new System.Drawing.Size(160, 78);
            this.btn_viewallplaza.TabIndex = 0;
            this.btn_viewallplaza.Text = "All Plazas List";
            this.btn_viewallplaza.UseVisualStyleBackColor = true;
            this.btn_viewallplaza.Click += new System.EventHandler(this.btn_viewallplaza_Click);
            // 
            // btn_addnewplaza
            // 
            this.btn_addnewplaza.Location = new System.Drawing.Point(28, 42);
            this.btn_addnewplaza.Name = "btn_addnewplaza";
            this.btn_addnewplaza.Size = new System.Drawing.Size(160, 78);
            this.btn_addnewplaza.TabIndex = 1;
            this.btn_addnewplaza.Text = "Add New Plaza";
            this.btn_addnewplaza.UseVisualStyleBackColor = true;
            this.btn_addnewplaza.Click += new System.EventHandler(this.btn_addnewplaza_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(28, 556);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Plaza_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 612);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_addnewplaza);
            this.Controls.Add(this.btn_viewallplaza);
            this.Name = "Plaza_management";
            this.Text = "Plaza Mnagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_viewallplaza;
        private System.Windows.Forms.Button btn_addnewplaza;
        private System.Windows.Forms.Button btn_back;
    }
}