namespace London_Estate
{
    partial class Agreement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_AgreementOwner = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_agreementstart = new System.Windows.Forms.DateTimePicker();
            this.dt_agreementend = new System.Windows.Forms.DateTimePicker();
            this.tb_agreementperiod = new System.Windows.Forms.TextBox();
            this.tb_monthlyrent = new System.Windows.Forms.TextBox();
            this.num_rentincrease = new System.Windows.Forms.NumericUpDown();
            this.btn_addagreement = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_rentincrease)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_addagreement);
            this.panel1.Controls.Add(this.num_rentincrease);
            this.panel1.Controls.Add(this.tb_monthlyrent);
            this.panel1.Controls.Add(this.tb_agreementperiod);
            this.panel1.Controls.Add(this.dt_agreementend);
            this.panel1.Controls.Add(this.dt_agreementstart);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox_AgreementOwner);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 729);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Owner";
            // 
            // comboBox_AgreementOwner
            // 
            this.comboBox_AgreementOwner.FormattingEnabled = true;
            this.comboBox_AgreementOwner.Location = new System.Drawing.Point(258, 42);
            this.comboBox_AgreementOwner.Name = "comboBox_AgreementOwner";
            this.comboBox_AgreementOwner.Size = new System.Drawing.Size(200, 24);
            this.comboBox_AgreementOwner.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Agreement Period";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rent Increase % per year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Monthly Rent";
            // 
            // dt_agreementstart
            // 
            this.dt_agreementstart.Location = new System.Drawing.Point(258, 100);
            this.dt_agreementstart.Name = "dt_agreementstart";
            this.dt_agreementstart.Size = new System.Drawing.Size(200, 22);
            this.dt_agreementstart.TabIndex = 7;
            // 
            // dt_agreementend
            // 
            this.dt_agreementend.Location = new System.Drawing.Point(258, 156);
            this.dt_agreementend.Name = "dt_agreementend";
            this.dt_agreementend.Size = new System.Drawing.Size(200, 22);
            this.dt_agreementend.TabIndex = 8;
            // 
            // tb_agreementperiod
            // 
            this.tb_agreementperiod.Location = new System.Drawing.Point(258, 207);
            this.tb_agreementperiod.Name = "tb_agreementperiod";
            this.tb_agreementperiod.Size = new System.Drawing.Size(200, 22);
            this.tb_agreementperiod.TabIndex = 9;
            // 
            // tb_monthlyrent
            // 
            this.tb_monthlyrent.Location = new System.Drawing.Point(258, 256);
            this.tb_monthlyrent.Name = "tb_monthlyrent";
            this.tb_monthlyrent.Size = new System.Drawing.Size(200, 22);
            this.tb_monthlyrent.TabIndex = 10;
            // 
            // num_rentincrease
            // 
            this.num_rentincrease.Location = new System.Drawing.Point(259, 317);
            this.num_rentincrease.Name = "num_rentincrease";
            this.num_rentincrease.Size = new System.Drawing.Size(199, 22);
            this.num_rentincrease.TabIndex = 11;
            // 
            // btn_addagreement
            // 
            this.btn_addagreement.Location = new System.Drawing.Point(50, 420);
            this.btn_addagreement.Name = "btn_addagreement";
            this.btn_addagreement.Size = new System.Drawing.Size(408, 23);
            this.btn_addagreement.TabIndex = 12;
            this.btn_addagreement.Text = "Save Details";
            this.btn_addagreement.UseVisualStyleBackColor = true;
            // 
            // Agreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.panel1);
            this.Name = "Agreement";
            this.Text = "Agreement";
            this.Load += new System.EventHandler(this.Agreement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_rentincrease)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_addagreement;
        private System.Windows.Forms.NumericUpDown num_rentincrease;
        private System.Windows.Forms.TextBox tb_monthlyrent;
        private System.Windows.Forms.TextBox tb_agreementperiod;
        private System.Windows.Forms.DateTimePicker dt_agreementend;
        private System.Windows.Forms.DateTimePicker dt_agreementstart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_AgreementOwner;
        private System.Windows.Forms.Label label1;
    }
}