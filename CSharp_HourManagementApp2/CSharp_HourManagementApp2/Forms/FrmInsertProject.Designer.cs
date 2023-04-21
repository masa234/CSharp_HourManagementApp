namespace CSharp_HourManagementApp2.Forms
{
    partial class FrmInsertProject
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
            this.BtnInsertProject = new System.Windows.Forms.Button();
            this.TxtProjectName = new System.Windows.Forms.TextBox();
            this.LblProjectName = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.DateEndDate = new System.Windows.Forms.DateTimePicker();
            this.LblEndDate = new System.Windows.Forms.Label();
            this.DateStartDate = new System.Windows.Forms.DateTimePicker();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.TxtSummary = new System.Windows.Forms.TextBox();
            this.LblSummary = new System.Windows.Forms.Label();
            this.TxtHour = new System.Windows.Forms.TextBox();
            this.LblHour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(251, 821);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 96;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnInsertProject
            // 
            this.BtnInsertProject.Location = new System.Drawing.Point(489, 821);
            this.BtnInsertProject.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInsertProject.Name = "BtnInsertProject";
            this.BtnInsertProject.Size = new System.Drawing.Size(179, 52);
            this.BtnInsertProject.TabIndex = 95;
            this.BtnInsertProject.Text = "登録";
            this.BtnInsertProject.UseVisualStyleBackColor = true;
            this.BtnInsertProject.Click += new System.EventHandler(this.BtnInsertProject_Click);
            // 
            // TxtProjectName
            // 
            this.TxtProjectName.Location = new System.Drawing.Point(128, 118);
            this.TxtProjectName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtProjectName.Name = "TxtProjectName";
            this.TxtProjectName.Size = new System.Drawing.Size(539, 25);
            this.TxtProjectName.TabIndex = 94;
            // 
            // LblProjectName
            // 
            this.LblProjectName.AutoSize = true;
            this.LblProjectName.Location = new System.Drawing.Point(124, 66);
            this.LblProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProjectName.Name = "LblProjectName";
            this.LblProjectName.Size = new System.Drawing.Size(104, 18);
            this.LblProjectName.TabIndex = 93;
            this.LblProjectName.Text = "プロジェクト名";
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Location = new System.Drawing.Point(128, 749);
            this.CmbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(150, 26);
            this.CmbStatus.TabIndex = 92;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(124, 703);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(44, 18);
            this.LblStatus.TabIndex = 91;
            this.LblStatus.Text = "状態";
            // 
            // DateEndDate
            // 
            this.DateEndDate.Location = new System.Drawing.Point(128, 642);
            this.DateEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateEndDate.Name = "DateEndDate";
            this.DateEndDate.Size = new System.Drawing.Size(249, 25);
            this.DateEndDate.TabIndex = 90;
            // 
            // LblEndDate
            // 
            this.LblEndDate.AutoSize = true;
            this.LblEndDate.Location = new System.Drawing.Point(124, 583);
            this.LblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEndDate.Name = "LblEndDate";
            this.LblEndDate.Size = new System.Drawing.Size(80, 18);
            this.LblEndDate.TabIndex = 89;
            this.LblEndDate.Text = "終了日時";
            // 
            // DateStartDate
            // 
            this.DateStartDate.Location = new System.Drawing.Point(128, 515);
            this.DateStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateStartDate.Name = "DateStartDate";
            this.DateStartDate.Size = new System.Drawing.Size(249, 25);
            this.DateStartDate.TabIndex = 88;
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Location = new System.Drawing.Point(124, 462);
            this.LblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(80, 18);
            this.LblStartDate.TabIndex = 87;
            this.LblStartDate.Text = "開始日時";
            // 
            // TxtSummary
            // 
            this.TxtSummary.Location = new System.Drawing.Point(128, 326);
            this.TxtSummary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSummary.Multiline = true;
            this.TxtSummary.Name = "TxtSummary";
            this.TxtSummary.Size = new System.Drawing.Size(539, 119);
            this.TxtSummary.TabIndex = 86;
            // 
            // LblSummary
            // 
            this.LblSummary.AutoSize = true;
            this.LblSummary.Location = new System.Drawing.Point(124, 271);
            this.LblSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSummary.Name = "LblSummary";
            this.LblSummary.Size = new System.Drawing.Size(44, 18);
            this.LblSummary.TabIndex = 85;
            this.LblSummary.Text = "概要";
            // 
            // TxtHour
            // 
            this.TxtHour.Location = new System.Drawing.Point(128, 214);
            this.TxtHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Size = new System.Drawing.Size(539, 25);
            this.TxtHour.TabIndex = 84;
            // 
            // LblHour
            // 
            this.LblHour.AutoSize = true;
            this.LblHour.Location = new System.Drawing.Point(124, 169);
            this.LblHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(44, 18);
            this.LblHour.TabIndex = 83;
            this.LblHour.Text = "工数";
            // 
            // FrmInsertProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1026);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnInsertProject);
            this.Controls.Add(this.TxtProjectName);
            this.Controls.Add(this.LblProjectName);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.DateEndDate);
            this.Controls.Add(this.LblEndDate);
            this.Controls.Add(this.DateStartDate);
            this.Controls.Add(this.LblStartDate);
            this.Controls.Add(this.TxtSummary);
            this.Controls.Add(this.LblSummary);
            this.Controls.Add(this.TxtHour);
            this.Controls.Add(this.LblHour);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmInsertProject";
            this.Text = "FrmInsertProject";
            this.Load += new System.EventHandler(this.FrmInsertProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.Button BtnInsertProject;
        internal System.Windows.Forms.TextBox TxtProjectName;
        internal System.Windows.Forms.Label LblProjectName;
        internal System.Windows.Forms.ComboBox CmbStatus;
        internal System.Windows.Forms.Label LblStatus;
        internal System.Windows.Forms.DateTimePicker DateEndDate;
        internal System.Windows.Forms.Label LblEndDate;
        internal System.Windows.Forms.DateTimePicker DateStartDate;
        internal System.Windows.Forms.Label LblStartDate;
        internal System.Windows.Forms.TextBox TxtSummary;
        internal System.Windows.Forms.Label LblSummary;
        internal System.Windows.Forms.TextBox TxtHour;
        internal System.Windows.Forms.Label LblHour;
    }
}