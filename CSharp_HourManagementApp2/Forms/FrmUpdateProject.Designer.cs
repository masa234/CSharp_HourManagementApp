namespace CSharp_HourManagementApp2.Forms
{
    partial class FrmUpdateProject
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnUpdateProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtProjectName
            // 
            this.TxtProjectName.Location = new System.Drawing.Point(129, 113);
            this.TxtProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProjectName.Name = "TxtProjectName";
            this.TxtProjectName.Size = new System.Drawing.Size(539, 25);
            this.TxtProjectName.TabIndex = 106;
            // 
            // LblProjectName
            // 
            this.LblProjectName.AutoSize = true;
            this.LblProjectName.Location = new System.Drawing.Point(125, 61);
            this.LblProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProjectName.Name = "LblProjectName";
            this.LblProjectName.Size = new System.Drawing.Size(104, 18);
            this.LblProjectName.TabIndex = 105;
            this.LblProjectName.Text = "プロジェクト名";
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Location = new System.Drawing.Point(129, 744);
            this.CmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(150, 26);
            this.CmbStatus.TabIndex = 104;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(125, 698);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(44, 18);
            this.LblStatus.TabIndex = 103;
            this.LblStatus.Text = "状態";
            // 
            // DateEndDate
            // 
            this.DateEndDate.Location = new System.Drawing.Point(129, 637);
            this.DateEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.DateEndDate.Name = "DateEndDate";
            this.DateEndDate.Size = new System.Drawing.Size(249, 25);
            this.DateEndDate.TabIndex = 102;
            // 
            // LblEndDate
            // 
            this.LblEndDate.AutoSize = true;
            this.LblEndDate.Location = new System.Drawing.Point(125, 578);
            this.LblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEndDate.Name = "LblEndDate";
            this.LblEndDate.Size = new System.Drawing.Size(80, 18);
            this.LblEndDate.TabIndex = 101;
            this.LblEndDate.Text = "終了日時";
            // 
            // DateStartDate
            // 
            this.DateStartDate.Location = new System.Drawing.Point(129, 510);
            this.DateStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.DateStartDate.Name = "DateStartDate";
            this.DateStartDate.Size = new System.Drawing.Size(249, 25);
            this.DateStartDate.TabIndex = 100;
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Location = new System.Drawing.Point(125, 457);
            this.LblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(80, 18);
            this.LblStartDate.TabIndex = 99;
            this.LblStartDate.Text = "開始日時";
            // 
            // TxtSummary
            // 
            this.TxtSummary.Location = new System.Drawing.Point(129, 321);
            this.TxtSummary.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSummary.Multiline = true;
            this.TxtSummary.Name = "TxtSummary";
            this.TxtSummary.Size = new System.Drawing.Size(539, 119);
            this.TxtSummary.TabIndex = 98;
            // 
            // LblSummary
            // 
            this.LblSummary.AutoSize = true;
            this.LblSummary.Location = new System.Drawing.Point(125, 266);
            this.LblSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSummary.Name = "LblSummary";
            this.LblSummary.Size = new System.Drawing.Size(44, 18);
            this.LblSummary.TabIndex = 97;
            this.LblSummary.Text = "概要";
            // 
            // TxtHour
            // 
            this.TxtHour.Location = new System.Drawing.Point(129, 209);
            this.TxtHour.Margin = new System.Windows.Forms.Padding(4);
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Size = new System.Drawing.Size(539, 25);
            this.TxtHour.TabIndex = 96;
            // 
            // LblHour
            // 
            this.LblHour.AutoSize = true;
            this.LblHour.Location = new System.Drawing.Point(125, 164);
            this.LblHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(44, 18);
            this.LblHour.TabIndex = 95;
            this.LblHour.Text = "工数";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(251, 819);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 108;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnUpdateProject
            // 
            this.BtnUpdateProject.Location = new System.Drawing.Point(489, 819);
            this.BtnUpdateProject.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdateProject.Name = "BtnUpdateProject";
            this.BtnUpdateProject.Size = new System.Drawing.Size(179, 52);
            this.BtnUpdateProject.TabIndex = 107;
            this.BtnUpdateProject.Text = "更新";
            this.BtnUpdateProject.UseVisualStyleBackColor = true;
            this.BtnUpdateProject.Click += new System.EventHandler(this.BtnUpdateProject_Click);
            // 
            // FrmUpdateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1026);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnUpdateProject);
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
            this.Name = "FrmUpdateProject";
            this.Text = "FrmUpdateProject";
            this.Load += new System.EventHandler(this.FrmUpdateProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.Button BtnUpdateProject;
    }
}