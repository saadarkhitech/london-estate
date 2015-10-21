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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_housesOwnerlist = new System.Windows.Forms.Button();
            this.btn_plazaOwnerList = new System.Windows.Forms.Button();
            this.Btn_newhouseowner = new System.Windows.Forms.Button();
            this.dg_ownersinfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddplazaOwner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ownersinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_back);
            this.splitContainer1.Panel1.Controls.Add(this.btn_housesOwnerlist);
            this.splitContainer1.Panel1.Controls.Add(this.btn_plazaOwnerList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Btn_newhouseowner);
            this.splitContainer1.Panel2.Controls.Add(this.dg_ownersinfo);
            this.splitContainer1.Panel2.Controls.Add(this.btn_AddplazaOwner);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1233, 741);
            this.splitContainer1.SplitterDistance = 201;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(57, 683);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 28);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_housesOwnerlist
            // 
            this.btn_housesOwnerlist.Location = new System.Drawing.Point(0, 343);
            this.btn_housesOwnerlist.Margin = new System.Windows.Forms.Padding(4);
            this.btn_housesOwnerlist.Name = "btn_housesOwnerlist";
            this.btn_housesOwnerlist.Size = new System.Drawing.Size(202, 66);
            this.btn_housesOwnerlist.TabIndex = 1;
            this.btn_housesOwnerlist.Text = "Houses";
            this.btn_housesOwnerlist.UseVisualStyleBackColor = true;
            this.btn_housesOwnerlist.Click += new System.EventHandler(this.btn_housesOwnerlist_Click);
            // 
            // btn_plazaOwnerList
            // 
            this.btn_plazaOwnerList.Location = new System.Drawing.Point(0, 252);
            this.btn_plazaOwnerList.Margin = new System.Windows.Forms.Padding(4);
            this.btn_plazaOwnerList.Name = "btn_plazaOwnerList";
            this.btn_plazaOwnerList.Size = new System.Drawing.Size(202, 66);
            this.btn_plazaOwnerList.TabIndex = 0;
            this.btn_plazaOwnerList.Text = "Plazas";
            this.btn_plazaOwnerList.UseVisualStyleBackColor = true;
            this.btn_plazaOwnerList.Click += new System.EventHandler(this.btn_plazaOwnerList_Click);
            // 
            // Btn_newhouseowner
            // 
            this.Btn_newhouseowner.Location = new System.Drawing.Point(510, 675);
            this.Btn_newhouseowner.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_newhouseowner.Name = "Btn_newhouseowner";
            this.Btn_newhouseowner.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_newhouseowner.Size = new System.Drawing.Size(517, 66);
            this.Btn_newhouseowner.TabIndex = 2;
            this.Btn_newhouseowner.Text = "Add New House Owner";
            this.Btn_newhouseowner.UseVisualStyleBackColor = true;
            this.Btn_newhouseowner.Click += new System.EventHandler(this.Btn_newhouseowner_Click);
            // 
            // dg_ownersinfo
            // 
            this.dg_ownersinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ownersinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dg_ownersinfo.Location = new System.Drawing.Point(4, 4);
            this.dg_ownersinfo.Margin = new System.Windows.Forms.Padding(4);
            this.dg_ownersinfo.Name = "dg_ownersinfo";
            this.dg_ownersinfo.Size = new System.Drawing.Size(1019, 671);
            this.dg_ownersinfo.TabIndex = 1;
            this.dg_ownersinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CNIC";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Contact Number";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Bank Name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Account #";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Plaza/House Number";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Plaza/House Address";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Plaza Floor";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Shop/Flat ID";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Electric Meter Count";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Ref #";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Gas Meter Count";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Ref #";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Action";
            this.Column14.Name = "Column14";
            // 
            // btn_AddplazaOwner
            // 
            this.btn_AddplazaOwner.Location = new System.Drawing.Point(4, 675);
            this.btn_AddplazaOwner.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddplazaOwner.Name = "btn_AddplazaOwner";
            this.btn_AddplazaOwner.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_AddplazaOwner.Size = new System.Drawing.Size(508, 66);
            this.btn_AddplazaOwner.TabIndex = 0;
            this.btn_AddplazaOwner.Text = "Add New Plaza Owner";
            this.btn_AddplazaOwner.UseVisualStyleBackColor = true;
            this.btn_AddplazaOwner.Click += new System.EventHandler(this.btn_AddOwner_Click);
            // 
            // Owner_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 741);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Owner_Information";
            this.Text = "Owner_Information";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ownersinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_housesOwnerlist;
        private System.Windows.Forms.Button btn_plazaOwnerList;
        private System.Windows.Forms.DataGridView dg_ownersinfo;
        private System.Windows.Forms.Button btn_AddplazaOwner;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button Btn_newhouseowner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;


    }
}