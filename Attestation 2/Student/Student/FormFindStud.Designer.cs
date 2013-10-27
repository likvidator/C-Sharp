namespace Student
{
    partial class FormFindStud
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
            this.gridStud = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridStud)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStud
            // 
            this.gridStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStud.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridStud.Location = new System.Drawing.Point(0, 32);
            this.gridStud.Name = "gridStud";
            this.gridStud.Size = new System.Drawing.Size(688, 273);
            this.gridStud.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 32);
            this.panel1.TabIndex = 4;
            // 
            // FormFindStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 387);
            this.Controls.Add(this.gridStud);
            this.Controls.Add(this.panel1);
            this.Name = "FormFindStud";
            this.Text = "FormFindStud";
            this.Load += new System.EventHandler(this.FormFindStud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridStud;
        private System.Windows.Forms.Panel panel1;
    }
}