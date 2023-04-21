namespace CSharp_HourManagementApp2.Forms
{
    partial class FrmRequestProject
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnRequestProject = new System.Windows.Forms.Button();
            this.LblProject = new System.Windows.Forms.Label();
            this.CmbProject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(113, 320);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 77;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnRequestProject
            // 
            this.BtnRequestProject.Location = new System.Drawing.Point(325, 320);
            this.BtnRequestProject.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRequestProject.Name = "BtnRequestProject";
            this.BtnRequestProject.Size = new System.Drawing.Size(179, 52);
            this.BtnRequestProject.TabIndex = 76;
            this.BtnRequestProject.Text = "応募";
            this.BtnRequestProject.UseVisualStyleBackColor = true;
            this.BtnRequestProject.Click += new System.EventHandler(this.BtnRequestProject_Click);
            // 
            // LblProject
            // 
            this.LblProject.AutoSize = true;
            this.LblProject.Location = new System.Drawing.Point(296, 136);
            this.LblProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProject.Name = "LblProject";
            this.LblProject.Size = new System.Drawing.Size(104, 18);
            this.LblProject.TabIndex = 75;
            this.LblProject.Text = "プロジェクト名";
            // 
            // CmbProject
            // 
            this.CmbProject.FormattingEnabled = true;
            this.CmbProject.Location = new System.Drawing.Point(296, 194);
            this.CmbProject.Margin = new System.Windows.Forms.Padding(4);
            this.CmbProject.Name = "CmbProject";
            this.CmbProject.Size = new System.Drawing.Size(208, 26);
            this.CmbProject.TabIndex = 74;
            // 
            // FrmRequestProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRequestProject);
            this.Controls.Add(this.LblProject);
            this.Controls.Add(this.CmbProject);
            this.Name = "FrmRequestProject";
            this.Text = "FrmRequestProject";
            this.Load += new System.EventHandler(this.FrmRequestProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.Button BtnRequestProject;
        internal System.Windows.Forms.Label LblProject;
        internal System.Windows.Forms.ComboBox CmbProject;
    }
}