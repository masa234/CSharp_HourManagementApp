namespace CSharp_HourManagementApp2.Forms
{
    partial class FrmProjectWikis
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
            this.BtnUpdateWiki = new System.Windows.Forms.Button();
            this.LblWiki = new System.Windows.Forms.Label();
            this.TxtWIki = new System.Windows.Forms.TextBox();
            this.LblProject = new System.Windows.Forms.Label();
            this.CmbProject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(489, 793);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 83;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnUpdateWiki
            // 
            this.BtnUpdateWiki.Location = new System.Drawing.Point(702, 793);
            this.BtnUpdateWiki.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdateWiki.Name = "BtnUpdateWiki";
            this.BtnUpdateWiki.Size = new System.Drawing.Size(179, 52);
            this.BtnUpdateWiki.TabIndex = 82;
            this.BtnUpdateWiki.Text = "更新";
            this.BtnUpdateWiki.UseVisualStyleBackColor = true;
            this.BtnUpdateWiki.Click += new System.EventHandler(this.BtnUpdateWiki_Click);
            // 
            // LblWiki
            // 
            this.LblWiki.AutoSize = true;
            this.LblWiki.Location = new System.Drawing.Point(115, 167);
            this.LblWiki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblWiki.Name = "LblWiki";
            this.LblWiki.Size = new System.Drawing.Size(37, 18);
            this.LblWiki.TabIndex = 81;
            this.LblWiki.Text = "Wiki";
            // 
            // TxtWIki
            // 
            this.TxtWIki.Location = new System.Drawing.Point(115, 202);
            this.TxtWIki.Margin = new System.Windows.Forms.Padding(4);
            this.TxtWIki.Multiline = true;
            this.TxtWIki.Name = "TxtWIki";
            this.TxtWIki.Size = new System.Drawing.Size(764, 543);
            this.TxtWIki.TabIndex = 80;
            // 
            // LblProject
            // 
            this.LblProject.AutoSize = true;
            this.LblProject.Location = new System.Drawing.Point(115, 60);
            this.LblProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProject.Name = "LblProject";
            this.LblProject.Size = new System.Drawing.Size(104, 18);
            this.LblProject.TabIndex = 79;
            this.LblProject.Text = "プロジェクト名";
            // 
            // CmbProject
            // 
            this.CmbProject.FormattingEnabled = true;
            this.CmbProject.Location = new System.Drawing.Point(115, 118);
            this.CmbProject.Margin = new System.Windows.Forms.Padding(4);
            this.CmbProject.Name = "CmbProject";
            this.CmbProject.Size = new System.Drawing.Size(764, 26);
            this.CmbProject.TabIndex = 78;
            this.CmbProject.SelectedIndexChanged += new System.EventHandler(this.CmbProject_SelectedIndexChanged);
            // 
            // FrmProjectWikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 904);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnUpdateWiki);
            this.Controls.Add(this.LblWiki);
            this.Controls.Add(this.TxtWIki);
            this.Controls.Add(this.LblProject);
            this.Controls.Add(this.CmbProject);
            this.Name = "FrmProjectWikis";
            this.Text = "FrmProjectWikis";
            this.Load += new System.EventHandler(this.FrmProjectWikis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.Button BtnUpdateWiki;
        internal System.Windows.Forms.Label LblWiki;
        internal System.Windows.Forms.TextBox TxtWIki;
        internal System.Windows.Forms.Label LblProject;
        internal System.Windows.Forms.ComboBox CmbProject;
    }
}