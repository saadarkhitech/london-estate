namespace London_Estate
{
    partial class New_Plaza_Information
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
            this.label_Plazaname = new System.Windows.Forms.Label();
            this.label_Plazafloors = new System.Windows.Forms.Label();
            this.tb_plazaname = new System.Windows.Forms.TextBox();
            this.tb_plazafloors = new System.Windows.Forms.TextBox();
            this.btn_addplaza = new System.Windows.Forms.Button();
            this.checkBox_basment = new System.Windows.Forms.CheckBox();
            this.label_plazalocation = new System.Windows.Forms.Label();
            this.tb_plazalocation = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.tb_plazaaddress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Plazaname
            // 
            this.label_Plazaname.AutoSize = true;
            this.label_Plazaname.Location = new System.Drawing.Point(10, 72);
            this.label_Plazaname.Name = "label_Plazaname";
            this.label_Plazaname.Size = new System.Drawing.Size(35, 13);
            this.label_Plazaname.TabIndex = 0;
            this.label_Plazaname.Text = "Name";
            this.label_Plazaname.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Plazafloors
            // 
            this.label_Plazafloors.AutoSize = true;
            this.label_Plazafloors.Location = new System.Drawing.Point(10, 125);
            this.label_Plazafloors.Name = "label_Plazafloors";
            this.label_Plazafloors.Size = new System.Drawing.Size(114, 13);
            this.label_Plazafloors.TabIndex = 1;
            this.label_Plazafloors.Text = "Total Number of Floors";
            this.label_Plazafloors.Click += new System.EventHandler(this.label_Plazafloors_Click);
            // 
            // tb_plazaname
            // 
            this.tb_plazaname.Location = new System.Drawing.Point(264, 72);
            this.tb_plazaname.Name = "tb_plazaname";
            this.tb_plazaname.Size = new System.Drawing.Size(100, 20);
            this.tb_plazaname.TabIndex = 4;
            // 
            // tb_plazafloors
            // 
            this.tb_plazafloors.Location = new System.Drawing.Point(264, 123);
            this.tb_plazafloors.Name = "tb_plazafloors";
            this.tb_plazafloors.Size = new System.Drawing.Size(100, 20);
            this.tb_plazafloors.TabIndex = 7;
            this.tb_plazafloors.TextChanged += new System.EventHandler(this.tb_plazafloors_TextChanged);
            // 
            // btn_addplaza
            // 
            this.btn_addplaza.Location = new System.Drawing.Point(102, 314);
            this.btn_addplaza.Name = "btn_addplaza";
            this.btn_addplaza.Size = new System.Drawing.Size(350, 50);
            this.btn_addplaza.TabIndex = 8;
            this.btn_addplaza.Text = "Save";
            this.btn_addplaza.UseVisualStyleBackColor = true;
            this.btn_addplaza.Click += new System.EventHandler(this.btn_addplaza_Click);
            // 
            // checkBox_basment
            // 
            this.checkBox_basment.AutoSize = true;
            this.checkBox_basment.Location = new System.Drawing.Point(402, 125);
            this.checkBox_basment.Name = "checkBox_basment";
            this.checkBox_basment.Size = new System.Drawing.Size(189, 17);
            this.checkBox_basment.TabIndex = 9;
            this.checkBox_basment.Text = "Lower Ground/Basement Included";
            this.checkBox_basment.UseVisualStyleBackColor = true;
            // 
            // label_plazalocation
            // 
            this.label_plazalocation.AutoSize = true;
            this.label_plazalocation.Location = new System.Drawing.Point(10, 170);
            this.label_plazalocation.Name = "label_plazalocation";
            this.label_plazalocation.Size = new System.Drawing.Size(48, 13);
            this.label_plazalocation.TabIndex = 10;
            this.label_plazalocation.Text = "Location";
            // 
            // tb_plazalocation
            // 
            this.tb_plazalocation.Location = new System.Drawing.Point(264, 170);
            this.tb_plazalocation.Name = "tb_plazalocation";
            this.tb_plazalocation.Size = new System.Drawing.Size(100, 20);
            this.tb_plazalocation.TabIndex = 11;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(10, 224);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(64, 13);
            this.label_address.TabIndex = 12;
            this.label_address.Text = "Full Address";
            // 
            // tb_plazaaddress
            // 
            this.tb_plazaaddress.Location = new System.Drawing.Point(264, 224);
            this.tb_plazaaddress.Name = "tb_plazaaddress";
            this.tb_plazaaddress.Size = new System.Drawing.Size(100, 20);
            this.tb_plazaaddress.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 261);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // New_Plaza_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_plazaaddress);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.tb_plazalocation);
            this.Controls.Add(this.label_plazalocation);
            this.Controls.Add(this.checkBox_basment);
            this.Controls.Add(this.btn_addplaza);
            this.Controls.Add(this.tb_plazafloors);
            this.Controls.Add(this.tb_plazaname);
            this.Controls.Add(this.label_Plazafloors);
            this.Controls.Add(this.label_Plazaname);
            this.Name = "New_Plaza_Information";
            this.Text = "New_Plaza_Information";
            this.Load += new System.EventHandler(this.New_Plaza_Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Plazaname;
        private System.Windows.Forms.Label label_Plazafloors;
        private System.Windows.Forms.TextBox tb_plazaname;
        private System.Windows.Forms.TextBox tb_plazafloors;
        private System.Windows.Forms.Button btn_addplaza;
        private System.Windows.Forms.CheckBox checkBox_basment;
        private System.Windows.Forms.Label label_plazalocation;
        private System.Windows.Forms.TextBox tb_plazalocation;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox tb_plazaaddress;
        private System.Windows.Forms.Button button1;
    }
}