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
            this.components = new System.ComponentModel.Container();
            this.radio_plazaOwner = new System.Windows.Forms.RadioButton();
            this.radio_houseOwner = new System.Windows.Forms.RadioButton();
            this.panel_plazaOwnerInfo = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numeric_electric = new System.Windows.Forms.NumericUpDown();
            this.numeric_gas = new System.Windows.Forms.NumericUpDown();
            this.label_Pownergas = new System.Windows.Forms.Label();
            this.panel_houseOwnerInfo = new System.Windows.Forms.Panel();
            this.labelPownerElectric = new System.Windows.Forms.Label();
            this.label_Powneraccount = new System.Windows.Forms.Label();
            this.label_PownerBank = new System.Windows.Forms.Label();
            this.label_POwnercontact = new System.Windows.Forms.Label();
            this.label_POwnerCNIC = new System.Windows.Forms.Label();
            this.label_PlazaOwnerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Plaza = new System.Windows.Forms.ComboBox();
            this.label_floor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rsDbDataSet = new London_Estate.RsDbDataSet();
            this.plazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plazaTableAdapter = new London_Estate.RsDbDataSetTableAdapters.PlazaTableAdapter();
            this.rsDbDataSet1 = new London_Estate.RsDbDataSet1();
            this.rsDbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_plazaOwnerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_electric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_gas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsDbDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radio_plazaOwner
            // 
            this.radio_plazaOwner.AutoSize = true;
            this.radio_plazaOwner.Location = new System.Drawing.Point(43, 37);
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
            this.radio_houseOwner.Location = new System.Drawing.Point(346, 37);
            this.radio_houseOwner.Name = "radio_houseOwner";
            this.radio_houseOwner.Size = new System.Drawing.Size(90, 17);
            this.radio_houseOwner.TabIndex = 1;
            this.radio_houseOwner.Text = "House Owner";
            this.radio_houseOwner.UseVisualStyleBackColor = true;
            // 
            // panel_plazaOwnerInfo
            // 
            this.panel_plazaOwnerInfo.Controls.Add(this.comboBox2);
            this.panel_plazaOwnerInfo.Controls.Add(this.comboBox1);
            this.panel_plazaOwnerInfo.Controls.Add(this.label3);
            this.panel_plazaOwnerInfo.Controls.Add(this.label_floor);
            this.panel_plazaOwnerInfo.Controls.Add(this.comboBox_Plaza);
            this.panel_plazaOwnerInfo.Controls.Add(this.label1);
            this.panel_plazaOwnerInfo.Controls.Add(this.textBox5);
            this.panel_plazaOwnerInfo.Controls.Add(this.textBox4);
            this.panel_plazaOwnerInfo.Controls.Add(this.textBox3);
            this.panel_plazaOwnerInfo.Controls.Add(this.textBox2);
            this.panel_plazaOwnerInfo.Controls.Add(this.textBox1);
            this.panel_plazaOwnerInfo.Controls.Add(this.panel_houseOwnerInfo);
            this.panel_plazaOwnerInfo.Controls.Add(this.label_Powneraccount);
            this.panel_plazaOwnerInfo.Controls.Add(this.label_PownerBank);
            this.panel_plazaOwnerInfo.Controls.Add(this.label_POwnercontact);
            this.panel_plazaOwnerInfo.Controls.Add(this.label_POwnerCNIC);
            this.panel_plazaOwnerInfo.Controls.Add(this.label_PlazaOwnerName);
            this.panel_plazaOwnerInfo.Location = new System.Drawing.Point(12, 60);
            this.panel_plazaOwnerInfo.Name = "panel_plazaOwnerInfo";
            this.panel_plazaOwnerInfo.Size = new System.Drawing.Size(301, 541);
            this.panel_plazaOwnerInfo.TabIndex = 2;
            this.panel_plazaOwnerInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_plazaOwnerInfo_Paint);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(115, 286);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(115, 195);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 225);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 255);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 165);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 11;
            // 
            // numeric_electric
            // 
            this.numeric_electric.Location = new System.Drawing.Point(433, 248);
            this.numeric_electric.Name = "numeric_electric";
            this.numeric_electric.Size = new System.Drawing.Size(120, 20);
            this.numeric_electric.TabIndex = 10;
            // 
            // numeric_gas
            // 
            this.numeric_gas.Location = new System.Drawing.Point(433, 284);
            this.numeric_gas.Name = "numeric_gas";
            this.numeric_gas.Size = new System.Drawing.Size(120, 20);
            this.numeric_gas.TabIndex = 9;
            // 
            // label_Pownergas
            // 
            this.label_Pownergas.AutoSize = true;
            this.label_Pownergas.Location = new System.Drawing.Point(317, 285);
            this.label_Pownergas.Name = "label_Pownergas";
            this.label_Pownergas.Size = new System.Drawing.Size(87, 13);
            this.label_Pownergas.TabIndex = 8;
            this.label_Pownergas.Text = "Gas Meter Count";
            // 
            // panel_houseOwnerInfo
            // 
            this.panel_houseOwnerInfo.Location = new System.Drawing.Point(290, 3);
            this.panel_houseOwnerInfo.Name = "panel_houseOwnerInfo";
            this.panel_houseOwnerInfo.Size = new System.Drawing.Size(286, 546);
            this.panel_houseOwnerInfo.TabIndex = 3;
            // 
            // labelPownerElectric
            // 
            this.labelPownerElectric.AutoSize = true;
            this.labelPownerElectric.Location = new System.Drawing.Point(315, 248);
            this.labelPownerElectric.Name = "labelPownerElectric";
            this.labelPownerElectric.Size = new System.Drawing.Size(113, 13);
            this.labelPownerElectric.TabIndex = 5;
            this.labelPownerElectric.Text = "Electricity Meter Count";
            // 
            // label_Powneraccount
            // 
            this.label_Powneraccount.AutoSize = true;
            this.label_Powneraccount.Location = new System.Drawing.Point(-2, 286);
            this.label_Powneraccount.Name = "label_Powneraccount";
            this.label_Powneraccount.Size = new System.Drawing.Size(87, 13);
            this.label_Powneraccount.TabIndex = 4;
            this.label_Powneraccount.Text = "Account Number";
            this.label_Powneraccount.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_PownerBank
            // 
            this.label_PownerBank.AutoSize = true;
            this.label_PownerBank.Location = new System.Drawing.Point(3, 255);
            this.label_PownerBank.Name = "label_PownerBank";
            this.label_PownerBank.Size = new System.Drawing.Size(63, 13);
            this.label_PownerBank.TabIndex = 3;
            this.label_PownerBank.Text = "Bank Name";
            // 
            // label_POwnercontact
            // 
            this.label_POwnercontact.AutoSize = true;
            this.label_POwnercontact.Location = new System.Drawing.Point(3, 225);
            this.label_POwnercontact.Name = "label_POwnercontact";
            this.label_POwnercontact.Size = new System.Drawing.Size(84, 13);
            this.label_POwnercontact.TabIndex = 2;
            this.label_POwnercontact.Text = "Contact Number";
            // 
            // label_POwnerCNIC
            // 
            this.label_POwnerCNIC.AutoSize = true;
            this.label_POwnerCNIC.Location = new System.Drawing.Point(3, 197);
            this.label_POwnerCNIC.Name = "label_POwnerCNIC";
            this.label_POwnerCNIC.Size = new System.Drawing.Size(42, 13);
            this.label_POwnerCNIC.TabIndex = 1;
            this.label_POwnerCNIC.Text = "CNIC #";
            this.label_POwnerCNIC.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_PlazaOwnerName
            // 
            this.label_PlazaOwnerName.AutoSize = true;
            this.label_PlazaOwnerName.Location = new System.Drawing.Point(3, 165);
            this.label_PlazaOwnerName.Name = "label_PlazaOwnerName";
            this.label_PlazaOwnerName.Size = new System.Drawing.Size(35, 13);
            this.label_PlazaOwnerName.TabIndex = 0;
            this.label_PlazaOwnerName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Plaza name";
            // 
            // comboBox_Plaza
            // 
            this.comboBox_Plaza.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.plazaBindingSource, "p_name", true));
            this.comboBox_Plaza.DataSource = this.rsDbDataSet;
            this.comboBox_Plaza.DisplayMember = "Plaza.p_name";
            this.comboBox_Plaza.FormattingEnabled = true;
            this.comboBox_Plaza.Location = new System.Drawing.Point(117, 75);
            this.comboBox_Plaza.Name = "comboBox_Plaza";
            this.comboBox_Plaza.Size = new System.Drawing.Size(120, 21);
            this.comboBox_Plaza.TabIndex = 17;
            this.comboBox_Plaza.ValueMember = "Plaza.p_name";
            // 
            // label_floor
            // 
            this.label_floor.AutoSize = true;
            this.label_floor.Location = new System.Drawing.Point(3, 110);
            this.label_floor.Name = "label_floor";
            this.label_floor.Size = new System.Drawing.Size(40, 13);
            this.label_floor.TabIndex = 18;
            this.label_floor.Text = "Floor #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Shop/Flat Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.rsDbDataSet1BindingSource;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(117, 102);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // rsDbDataSet
            // 
            this.rsDbDataSet.DataSetName = "RsDbDataSet";
            this.rsDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plazaBindingSource
            // 
            this.plazaBindingSource.DataMember = "Plaza";
            this.plazaBindingSource.DataSource = this.rsDbDataSet;
            // 
            // plazaTableAdapter
            // 
            this.plazaTableAdapter.ClearBeforeFill = true;
            // 
            // rsDbDataSet1
            // 
            this.rsDbDataSet1.DataSetName = "RsDbDataSet1";
            this.rsDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rsDbDataSet1BindingSource
            // 
            this.rsDbDataSet1BindingSource.DataSource = this.rsDbDataSet1;
            this.rsDbDataSet1BindingSource.Position = 0;
            // 
            // Add_New_Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 602);
            this.Controls.Add(this.panel_plazaOwnerInfo);
            this.Controls.Add(this.radio_houseOwner);
            this.Controls.Add(this.radio_plazaOwner);
            this.Controls.Add(this.numeric_electric);
            this.Controls.Add(this.labelPownerElectric);
            this.Controls.Add(this.label_Pownergas);
            this.Controls.Add(this.numeric_gas);
            this.Name = "Add_New_Owner";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Add_New_Owner_Load);
            this.panel_plazaOwnerInfo.ResumeLayout(false);
            this.panel_plazaOwnerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_electric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_gas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsDbDataSet1BindingSource)).EndInit();
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
        private System.Windows.Forms.Label label_Pownergas;
        private System.Windows.Forms.NumericUpDown numeric_electric;
        private System.Windows.Forms.NumericUpDown numeric_gas;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_floor;
        private System.Windows.Forms.ComboBox comboBox_Plaza;
        private System.Windows.Forms.Label label1;
        private RsDbDataSet rsDbDataSet;
        private System.Windows.Forms.BindingSource plazaBindingSource;
        private RsDbDataSetTableAdapters.PlazaTableAdapter plazaTableAdapter;
        private System.Windows.Forms.BindingSource rsDbDataSet1BindingSource;
        private RsDbDataSet1 rsDbDataSet1;
    }
}