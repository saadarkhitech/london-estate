namespace London_Estate
{
    partial class dashboard
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
            this.btn_housemanagement = new System.Windows.Forms.Button();
            this.btn_plazamanagement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_renterinfo = new System.Windows.Forms.Button();
            this.btn_ownerinfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_housemanagement
            // 
            this.btn_housemanagement.Location = new System.Drawing.Point(0, 84);
            this.btn_housemanagement.Name = "btn_housemanagement";
            this.btn_housemanagement.Size = new System.Drawing.Size(218, 50);
            this.btn_housemanagement.TabIndex = 0;
            this.btn_housemanagement.Text = "Houses Managment";
            this.btn_housemanagement.UseVisualStyleBackColor = true;
            this.btn_housemanagement.Click += new System.EventHandler(this.btn_housemanagement_Click);
            // 
            // btn_plazamanagement
            // 
            this.btn_plazamanagement.AllowDrop = true;
            this.btn_plazamanagement.Location = new System.Drawing.Point(222, 189);
            this.btn_plazamanagement.Name = "btn_plazamanagement";
            this.btn_plazamanagement.Size = new System.Drawing.Size(218, 47);
            this.btn_plazamanagement.TabIndex = 1;
            this.btn_plazamanagement.Text = "Plaza Managment";
            this.btn_plazamanagement.UseVisualStyleBackColor = true;
            this.btn_plazamanagement.Click += new System.EventHandler(this.btn_plazamanagement_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_renterinfo);
            this.panel1.Controls.Add(this.btn_ownerinfo);
            this.panel1.Controls.Add(this.btn_housemanagement);
            this.panel1.Controls.Add(this.btn_plazamanagement);
            this.panel1.Location = new System.Drawing.Point(74, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 539);
            this.panel1.TabIndex = 2;
            // 
            // btn_renterinfo
            // 
            this.btn_renterinfo.AllowDrop = true;
            this.btn_renterinfo.Location = new System.Drawing.Point(225, 402);
            this.btn_renterinfo.Name = "btn_renterinfo";
            this.btn_renterinfo.Size = new System.Drawing.Size(218, 54);
            this.btn_renterinfo.TabIndex = 3;
            this.btn_renterinfo.Text = "Rental Information ";
            this.btn_renterinfo.UseVisualStyleBackColor = true;
            // 
            // btn_ownerinfo
            // 
            this.btn_ownerinfo.AllowDrop = true;
            this.btn_ownerinfo.Location = new System.Drawing.Point(0, 297);
            this.btn_ownerinfo.Name = "btn_ownerinfo";
            this.btn_ownerinfo.Size = new System.Drawing.Size(218, 50);
            this.btn_ownerinfo.TabIndex = 2;
            this.btn_ownerinfo.Text = "Owner Information";
            this.btn_ownerinfo.UseVisualStyleBackColor = true;
            this.btn_ownerinfo.Click += new System.EventHandler(this.btn_ownerinfo_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 602);
            this.Controls.Add(this.panel1);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_housemanagement;
        private System.Windows.Forms.Button btn_plazamanagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_renterinfo;
        private System.Windows.Forms.Button btn_ownerinfo;
    }
}