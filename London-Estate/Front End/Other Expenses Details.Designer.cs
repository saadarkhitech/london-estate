namespace London_Estate.Front_End
{
    partial class Other_Expenses_Details
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_otherexpensesave = new System.Windows.Forms.Button();
            this.btn_otherexpensecancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(29, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 575);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Expense Details";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Action";
            this.Column4.Name = "Column4";
            // 
            // btn_otherexpensesave
            // 
            this.btn_otherexpensesave.Location = new System.Drawing.Point(582, 684);
            this.btn_otherexpensesave.Name = "btn_otherexpensesave";
            this.btn_otherexpensesave.Size = new System.Drawing.Size(132, 35);
            this.btn_otherexpensesave.TabIndex = 1;
            this.btn_otherexpensesave.Text = "Save";
            this.btn_otherexpensesave.UseVisualStyleBackColor = true;
            // 
            // btn_otherexpensecancel
            // 
            this.btn_otherexpensecancel.Location = new System.Drawing.Point(29, 688);
            this.btn_otherexpensecancel.Name = "btn_otherexpensecancel";
            this.btn_otherexpensecancel.Size = new System.Drawing.Size(127, 31);
            this.btn_otherexpensecancel.TabIndex = 2;
            this.btn_otherexpensecancel.Text = "Cancel";
            this.btn_otherexpensecancel.UseVisualStyleBackColor = true;
            this.btn_otherexpensecancel.Click += new System.EventHandler(this.btn_otherexpensecancel_Click);
            // 
            // Other_Expenses_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 731);
            this.Controls.Add(this.btn_otherexpensecancel);
            this.Controls.Add(this.btn_otherexpensesave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Other_Expenses_Details";
            this.Text = "Other Expenses Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_otherexpensesave;
        private System.Windows.Forms.Button btn_otherexpensecancel;
    }
}