namespace London_Estate
{
    partial class House_Management
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
            this.btn_addnewhouse = new System.Windows.Forms.Button();
            this.btn_viewallhouses = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addnewhouse
            // 
            this.btn_addnewhouse.Location = new System.Drawing.Point(70, 94);
            this.btn_addnewhouse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addnewhouse.Name = "btn_addnewhouse";
            this.btn_addnewhouse.Size = new System.Drawing.Size(213, 96);
            this.btn_addnewhouse.TabIndex = 3;
            this.btn_addnewhouse.Text = "Add New House";
            this.btn_addnewhouse.UseVisualStyleBackColor = true;
            
            // 
            // btn_viewallhouses
            // 
            this.btn_viewallhouses.Location = new System.Drawing.Point(491, 94);
            this.btn_viewallhouses.Margin = new System.Windows.Forms.Padding(4);
            this.btn_viewallhouses.Name = "btn_viewallhouses";
            this.btn_viewallhouses.Size = new System.Drawing.Size(213, 96);
            this.btn_viewallhouses.TabIndex = 2;
            this.btn_viewallhouses.Text = "View All Houses";
            this.btn_viewallhouses.UseVisualStyleBackColor = true;
            
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(36, 698);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 28);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            
            // 
            // House_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_addnewhouse);
            this.Controls.Add(this.btn_viewallhouses);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "House_Management";
            this.Text = "House Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addnewhouse;
        private System.Windows.Forms.Button btn_viewallhouses;
        private System.Windows.Forms.Button btn_back;
    }
}