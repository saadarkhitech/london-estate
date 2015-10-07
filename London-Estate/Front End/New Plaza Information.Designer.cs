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
            this.label_totalshops = new System.Windows.Forms.Label();
            this.label_totalflats = new System.Windows.Forms.Label();
            this.tb_plazaname = new System.Windows.Forms.TextBox();
            this.tb_plazaflats = new System.Windows.Forms.TextBox();
            this.tb_plazashops = new System.Windows.Forms.TextBox();
            this.tb_plazafloors = new System.Windows.Forms.TextBox();
            this.btn_addplaza = new System.Windows.Forms.Button();
            this.checkBox_basment = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_Plazaname
            // 
            this.label_Plazaname.AutoSize = true;
            this.label_Plazaname.Location = new System.Drawing.Point(96, 96);
            this.label_Plazaname.Name = "label_Plazaname";
            this.label_Plazaname.Size = new System.Drawing.Size(35, 13);
            this.label_Plazaname.TabIndex = 0;
            this.label_Plazaname.Text = "Name";
            this.label_Plazaname.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Plazafloors
            // 
            this.label_Plazafloors.AutoSize = true;
            this.label_Plazafloors.Location = new System.Drawing.Point(96, 149);
            this.label_Plazafloors.Name = "label_Plazafloors";
            this.label_Plazafloors.Size = new System.Drawing.Size(114, 13);
            this.label_Plazafloors.TabIndex = 1;
            this.label_Plazafloors.Text = "Total Number of Floors";
            this.label_Plazafloors.Click += new System.EventHandler(this.label_Plazafloors_Click);
            // 
            // label_totalshops
            // 
            this.label_totalshops.AutoSize = true;
            this.label_totalshops.Location = new System.Drawing.Point(96, 204);
            this.label_totalshops.Name = "label_totalshops";
            this.label_totalshops.Size = new System.Drawing.Size(112, 13);
            this.label_totalshops.TabIndex = 2;
            this.label_totalshops.Text = "Total number of shops";
            // 
            // label_totalflats
            // 
            this.label_totalflats.AutoSize = true;
            this.label_totalflats.Location = new System.Drawing.Point(96, 265);
            this.label_totalflats.Name = "label_totalflats";
            this.label_totalflats.Size = new System.Drawing.Size(103, 13);
            this.label_totalflats.TabIndex = 3;
            this.label_totalflats.Text = "Total number of flats";
            // 
            // tb_plazaname
            // 
            this.tb_plazaname.Location = new System.Drawing.Point(350, 96);
            this.tb_plazaname.Name = "tb_plazaname";
            this.tb_plazaname.Size = new System.Drawing.Size(100, 20);
            this.tb_plazaname.TabIndex = 4;
            // 
            // tb_plazaflats
            // 
            this.tb_plazaflats.Location = new System.Drawing.Point(350, 258);
            this.tb_plazaflats.Name = "tb_plazaflats";
            this.tb_plazaflats.Size = new System.Drawing.Size(100, 20);
            this.tb_plazaflats.TabIndex = 5;
            // 
            // tb_plazashops
            // 
            this.tb_plazashops.Location = new System.Drawing.Point(350, 201);
            this.tb_plazashops.Name = "tb_plazashops";
            this.tb_plazashops.Size = new System.Drawing.Size(100, 20);
            this.tb_plazashops.TabIndex = 6;
            // 
            // tb_plazafloors
            // 
            this.tb_plazafloors.Location = new System.Drawing.Point(350, 146);
            this.tb_plazafloors.Name = "tb_plazafloors";
            this.tb_plazafloors.Size = new System.Drawing.Size(100, 20);
            this.tb_plazafloors.TabIndex = 7;
            // 
            // btn_addplaza
            // 
            this.btn_addplaza.Location = new System.Drawing.Point(99, 355);
            this.btn_addplaza.Name = "btn_addplaza";
            this.btn_addplaza.Size = new System.Drawing.Size(350, 50);
            this.btn_addplaza.TabIndex = 8;
            this.btn_addplaza.Text = "Add plaza";
            this.btn_addplaza.UseVisualStyleBackColor = true;
            // 
            // checkBox_basment
            // 
            this.checkBox_basment.AutoSize = true;
            this.checkBox_basment.Location = new System.Drawing.Point(488, 149);
            this.checkBox_basment.Name = "checkBox_basment";
            this.checkBox_basment.Size = new System.Drawing.Size(189, 17);
            this.checkBox_basment.TabIndex = 9;
            this.checkBox_basment.Text = "Lower Ground/Basement Included";
            this.checkBox_basment.UseVisualStyleBackColor = true;
            // 
            // New_Plaza_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.checkBox_basment);
            this.Controls.Add(this.btn_addplaza);
            this.Controls.Add(this.tb_plazafloors);
            this.Controls.Add(this.tb_plazashops);
            this.Controls.Add(this.tb_plazaflats);
            this.Controls.Add(this.tb_plazaname);
            this.Controls.Add(this.label_totalflats);
            this.Controls.Add(this.label_totalshops);
            this.Controls.Add(this.label_Plazafloors);
            this.Controls.Add(this.label_Plazaname);
            this.Name = "New_Plaza_Information";
            this.Text = "New_Plaza_Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Plazaname;
        private System.Windows.Forms.Label label_Plazafloors;
        private System.Windows.Forms.Label label_totalshops;
        private System.Windows.Forms.Label label_totalflats;
        private System.Windows.Forms.TextBox tb_plazaname;
        private System.Windows.Forms.TextBox tb_plazaflats;
        private System.Windows.Forms.TextBox tb_plazashops;
        private System.Windows.Forms.TextBox tb_plazafloors;
        private System.Windows.Forms.Button btn_addplaza;
        private System.Windows.Forms.CheckBox checkBox_basment;
    }
}