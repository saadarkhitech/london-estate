namespace London_Estate
{
    partial class Add_New_Owner
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
            this.radio_plazaOwner = new System.Windows.Forms.RadioButton();
            this.radio_houseOwner = new System.Windows.Forms.RadioButton();
            this.panel_plazaOwnerInfo = new System.Windows.Forms.Panel();
            this.label_PlazaOwnerName = new System.Windows.Forms.Label();
            this.label_POwnerCNIC = new System.Windows.Forms.Label();
            this.label_POwnercontact = new System.Windows.Forms.Label();
            this.label_PownerBank = new System.Windows.Forms.Label();
            this.label_Powneraccount = new System.Windows.Forms.Label();
            this.labelPownerElectric = new System.Windows.Forms.Label();
            this.panel_houseOwnerInfo = new System.Windows.Forms.Panel();
            this.label_OwnershipType = new System.Windows.Forms.Label();
            this.comboBox_ownership = new System.Windows.Forms.ComboBox();
            this.label_Pownergas = new System.Windows.Forms.Label();
            this.numeric_gas = new System.Windows.Forms.NumericUpDown();
            this.numeric_electric = new System.Windows.Forms.NumericUpDown();
            this.panel_plazaOwnerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_gas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_electric)).BeginInit();
            this.SuspendLayout();
            // 
            // radio_plazaOwner
            // 
            this.radio_plazaOwner.AutoSize = true;
            this.radio_plazaOwner.Location = new System.Drawing.Point(180, 102);
            this.radio_plazaOwner.Name = "radio_plazaOwner";
            this.radio_plazaOwner.Size = new System.Drawing.Size(85, 17);
            this.radio_plazaOwner.TabIndex = 0;
            this.radio_plazaOwner.Text = "Plaza Owner";
            this.radio_plazaOwner.UseVisualStyleBackColor = true;
            // 
            // radio_houseOwner
            // 
            this.radio_houseOwner.AutoCheck = false;
            this.radio_houseOwner.AutoSize = true;
            this.radio_houseOwner.Location = new System.Drawing.Point(478, 102);
            this.radio_houseOwner.Name = "radio_houseOwner";
            this.radio_houseOwner.Size = new System.Drawing.Size(90, 17);
            this.radio_houseOwner.TabIndex = 1;
            this.radio_houseOwner.Text = "House Owner";
            this.radio_houseOwner.UseVisualStyleBackColor = true;
            // 
            // panel_plazaOwnerInfo
            // 
            this.panel_plazaOwnerInfo.Controls.Add(this.numeric_electric);
            this.panel_plazaOwnerInfo.Controls.Add(this.numeric_gas);
            this.panel_plazaOwnerInfo.Controls.Add(this.label_Pownergas);
            this.panel_plazaOwnerInfo.Controls.Add(this.comboBox_ownership);
            this.panel_plazaOwnerInfo.Controls.Add(this.label_OwnershipType);
            this.panel_plazaOwnerInfo.Controls.Add(this.panel_houseOwnerInfo);
            this.panel_plazaOwnerInfo.Controls.Add(this.labelPownerElectric);
            this.panel_plazaOwnerInfo.Controls.Add(this.label_Powneraccount);
            this.panel_plazaOwnerInfo.Controls.Add(this.label_PownerBank);
            this.panel_plazaOwnerInfo.Controls.Add(this.label_POwnercontact);
            this.panel_plazaOwnerInfo.Controls.Add(this.label_POwnerCNIC);
            this.panel_plazaOwnerInfo.Controls.Add(this.label_PlazaOwnerName);
            this.panel_plazaOwnerInfo.Location = new System.Drawing.Point(12, 176);
            this.panel_plazaOwnerInfo.Name = "panel_plazaOwnerInfo";
            this.panel_plazaOwnerInfo.Size = new System.Drawing.Size(460, 573);
            this.panel_plazaOwnerInfo.TabIndex = 2;
            this.panel_plazaOwnerInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_plazaOwnerInfo_Paint);
            // 
            // label_PlazaOwnerName
            // 
            this.label_PlazaOwnerName.AutoSize = true;
            this.label_PlazaOwnerName.Location = new System.Drawing.Point(86, 99);
            this.label_PlazaOwnerName.Name = "label_PlazaOwnerName";
            this.label_PlazaOwnerName.Size = new System.Drawing.Size(35, 13);
            this.label_PlazaOwnerName.TabIndex = 0;
            this.label_PlazaOwnerName.Text = "Name";
            // 
            // label_POwnerCNIC
            // 
            this.label_POwnerCNIC.AutoSize = true;
            this.label_POwnerCNIC.Location = new System.Drawing.Point(86, 142);
            this.label_POwnerCNIC.Name = "label_POwnerCNIC";
            this.label_POwnerCNIC.Size = new System.Drawing.Size(42, 13);
            this.label_POwnerCNIC.TabIndex = 1;
            this.label_POwnerCNIC.Text = "CNIC #";
            this.label_POwnerCNIC.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_POwnercontact
            // 
            this.label_POwnercontact.AutoSize = true;
            this.label_POwnercontact.Location = new System.Drawing.Point(86, 187);
            this.label_POwnercontact.Name = "label_POwnercontact";
            this.label_POwnercontact.Size = new System.Drawing.Size(84, 13);
            this.label_POwnercontact.TabIndex = 2;
            this.label_POwnercontact.Text = "Contact Number";
            // 
            // label_PownerBank
            // 
            this.label_PownerBank.AutoSize = true;
            this.label_PownerBank.Location = new System.Drawing.Point(86, 231);
            this.label_PownerBank.Name = "label_PownerBank";
            this.label_PownerBank.Size = new System.Drawing.Size(63, 13);
            this.label_PownerBank.TabIndex = 3;
            this.label_PownerBank.Text = "Bank Name";
            // 
            // label_Powneraccount
            // 
            this.label_Powneraccount.AutoSize = true;
            this.label_Powneraccount.Location = new System.Drawing.Point(86, 268);
            this.label_Powneraccount.Name = "label_Powneraccount";
            this.label_Powneraccount.Size = new System.Drawing.Size(87, 13);
            this.label_Powneraccount.TabIndex = 4;
            this.label_Powneraccount.Text = "Account Number";
            this.label_Powneraccount.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelPownerElectric
            // 
            this.labelPownerElectric.AutoSize = true;
            this.labelPownerElectric.Location = new System.Drawing.Point(86, 307);
            this.labelPownerElectric.Name = "labelPownerElectric";
            this.labelPownerElectric.Size = new System.Drawing.Size(113, 13);
            this.labelPownerElectric.TabIndex = 5;
            this.labelPownerElectric.Text = "Electricity Meter Count";
            // 
            // panel_houseOwnerInfo
            // 
            this.panel_houseOwnerInfo.Location = new System.Drawing.Point(386, 3);
            this.panel_houseOwnerInfo.Name = "panel_houseOwnerInfo";
            this.panel_houseOwnerInfo.Size = new System.Drawing.Size(374, 546);
            this.panel_houseOwnerInfo.TabIndex = 3;
            // 
            // label_OwnershipType
            // 
            this.label_OwnershipType.AutoSize = true;
            this.label_OwnershipType.Location = new System.Drawing.Point(89, 54);
            this.label_OwnershipType.Name = "label_OwnershipType";
            this.label_OwnershipType.Size = new System.Drawing.Size(84, 13);
            this.label_OwnershipType.TabIndex = 6;
            this.label_OwnershipType.Text = "Ownership Type";
            // 
            // comboBox_ownership
            // 
            this.comboBox_ownership.FormattingEnabled = true;
            this.comboBox_ownership.Location = new System.Drawing.Point(219, 51);
            this.comboBox_ownership.Name = "comboBox_ownership";
            this.comboBox_ownership.Size = new System.Drawing.Size(120, 21);
            this.comboBox_ownership.TabIndex = 7;
            this.comboBox_ownership.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_Pownergas
            // 
            this.label_Pownergas.AutoSize = true;
            this.label_Pownergas.Location = new System.Drawing.Point(89, 341);
            this.label_Pownergas.Name = "label_Pownergas";
            this.label_Pownergas.Size = new System.Drawing.Size(87, 13);
            this.label_Pownergas.TabIndex = 8;
            this.label_Pownergas.Text = "Gas Meter Count";
            // 
            // numeric_gas
            // 
            this.numeric_gas.Location = new System.Drawing.Point(219, 341);
            this.numeric_gas.Name = "numeric_gas";
            this.numeric_gas.Size = new System.Drawing.Size(120, 20);
            this.numeric_gas.TabIndex = 9;
            // 
            // numeric_electric
            // 
            this.numeric_electric.Location = new System.Drawing.Point(219, 305);
            this.numeric_electric.Name = "numeric_electric";
            this.numeric_electric.Size = new System.Drawing.Size(120, 20);
            this.numeric_electric.TabIndex = 10;
            // 
            // Add_New_Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.panel_plazaOwnerInfo);
            this.Controls.Add(this.radio_houseOwner);
            this.Controls.Add(this.radio_plazaOwner);
            this.Name = "Add_New_Owner";
            this.Text = "Add_New_Owner";
            this.panel_plazaOwnerInfo.ResumeLayout(false);
            this.panel_plazaOwnerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_gas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_electric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_plazaOwner;
        private System.Windows.Forms.RadioButton radio_houseOwner;
        private System.Windows.Forms.Panel panel_plazaOwnerInfo;
        private System.Windows.Forms.Label labelPownerElectric;
        private System.Windows.Forms.Label label_Powneraccount;
        private System.Windows.Forms.Label label_PownerBank;
        private System.Windows.Forms.Label label_POwnercontact;
        private System.Windows.Forms.Label label_POwnerCNIC;
        private System.Windows.Forms.Label label_PlazaOwnerName;
        private System.Windows.Forms.Panel panel_houseOwnerInfo;
        private System.Windows.Forms.ComboBox comboBox_ownership;
        private System.Windows.Forms.Label label_OwnershipType;
        private System.Windows.Forms.Label label_Pownergas;
        private System.Windows.Forms.NumericUpDown numeric_electric;
        private System.Windows.Forms.NumericUpDown numeric_gas;
    }
}