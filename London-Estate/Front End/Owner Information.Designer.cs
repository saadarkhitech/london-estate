namespace London_Estate
{
    partial class Owner_Information
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_plazaOwnerList = new System.Windows.Forms.Button();
            this.btn_housesOwnerlist = new System.Windows.Forms.Button();
            this.btn_AddOwner = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_housesOwnerlist);
            this.splitContainer1.Panel1.Controls.Add(this.btn_plazaOwnerList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_AddOwner);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(784, 761);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_plazaOwnerList
            // 
            this.btn_plazaOwnerList.Location = new System.Drawing.Point(3, 256);
            this.btn_plazaOwnerList.Name = "btn_plazaOwnerList";
            this.btn_plazaOwnerList.Size = new System.Drawing.Size(198, 54);
            this.btn_plazaOwnerList.TabIndex = 0;
            this.btn_plazaOwnerList.Text = "Plazas";
            this.btn_plazaOwnerList.UseVisualStyleBackColor = true;
            // 
            // btn_housesOwnerlist
            // 
            this.btn_housesOwnerlist.Location = new System.Drawing.Point(3, 316);
            this.btn_housesOwnerlist.Name = "btn_housesOwnerlist";
            this.btn_housesOwnerlist.Size = new System.Drawing.Size(198, 54);
            this.btn_housesOwnerlist.TabIndex = 1;
            this.btn_housesOwnerlist.Text = "Houses";
            this.btn_housesOwnerlist.UseVisualStyleBackColor = true;
            this.btn_housesOwnerlist.Click += new System.EventHandler(this.btn_housesOwnerlist_Click);
            // 
            // btn_AddOwner
            // 
            this.btn_AddOwner.Location = new System.Drawing.Point(3, 704);
            this.btn_AddOwner.Name = "btn_AddOwner";
            this.btn_AddOwner.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_AddOwner.Size = new System.Drawing.Size(570, 54);
            this.btn_AddOwner.TabIndex = 0;
            this.btn_AddOwner.Text = "Add New Owner";
            this.btn_AddOwner.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 695);
            this.dataGridView1.TabIndex = 1;
            // 
            // Owner_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Owner_Information";
            this.Text = "Owner_Information";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_housesOwnerlist;
        private System.Windows.Forms.Button btn_plazaOwnerList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AddOwner;


    }
}