namespace CSharp_HourManagementApp2.Forms
{
    partial class FrmCalcHour
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
            this.LblHours = new System.Windows.Forms.Label();
            this.LblHour = new System.Windows.Forms.Label();
            this.LblProjectName = new System.Windows.Forms.Label();
            this.CmbProjectName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(336, 347);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 68;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblHours
            // 
            this.LblHours.AutoSize = true;
            this.LblHours.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblHours.Location = new System.Drawing.Point(393, 192);
            this.LblHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHours.Name = "LblHours";
            this.LblHours.Size = new System.Drawing.Size(70, 24);
            this.LblHours.TabIndex = 67;
            this.LblHours.Text = "0時間";
            // 
            // LblHour
            // 
            this.LblHour.AutoSize = true;
            this.LblHour.Location = new System.Drawing.Point(382, 134);
            this.LblHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(44, 18);
            this.LblHour.TabIndex = 66;
            this.LblHour.Text = "工数";
            // 
            // LblProjectName
            // 
            this.LblProjectName.AutoSize = true;
            this.LblProjectName.Location = new System.Drawing.Point(109, 134);
            this.LblProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProjectName.Name = "LblProjectName";
            this.LblProjectName.Size = new System.Drawing.Size(104, 18);
            this.LblProjectName.TabIndex = 65;
            this.LblProjectName.Text = "プロジェクト名";
            // 
            // CmbProjectName
            // 
            this.CmbProjectName.FormattingEnabled = true;
            this.CmbProjectName.Location = new System.Drawing.Point(109, 192);
            this.CmbProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.CmbProjectName.Name = "CmbProjectName";
            this.CmbProjectName.Size = new System.Drawing.Size(208, 26);
            this.CmbProjectName.TabIndex = 64;
            this.CmbProjectName.SelectedIndexChanged += new System.EventHandler(this.CmbProjectName_SelectedIndexChanged);
            // 
            // FrmCalcHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblHours);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.LblProjectName);
            this.Controls.Add(this.CmbProjectName);
            this.Name = "FrmCalcHour";
            this.Text = "FrmCalcHour";
            this.Load += new System.EventHandler(this.FrmCalcHour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.Label LblHours;
        internal System.Windows.Forms.Label LblHour;
        internal System.Windows.Forms.Label LblProjectName;
        internal System.Windows.Forms.ComboBox CmbProjectName;
    }
}