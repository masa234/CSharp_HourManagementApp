namespace CSharp_HourManagementApp2.Forms
{
    partial class FrmInsertTask
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
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TxtSummary = new System.Windows.Forms.TextBox();
            this.LblSummary = new System.Windows.Forms.Label();
            this.TxtHour = new System.Windows.Forms.TextBox();
            this.LblHour = new System.Windows.Forms.Label();
            this.TxtTaskName = new System.Windows.Forms.TextBox();
            this.LblTaskName = new System.Windows.Forms.Label();
            this.BtnInsertTask = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Location = new System.Drawing.Point(90, 538);
            this.CmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(150, 26);
            this.CmbStatus.TabIndex = 94;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(86, 493);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(44, 18);
            this.LblStatus.TabIndex = 93;
            this.LblStatus.Text = "状態";
            // 
            // TxtSummary
            // 
            this.TxtSummary.Location = new System.Drawing.Point(90, 344);
            this.TxtSummary.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSummary.Multiline = true;
            this.TxtSummary.Name = "TxtSummary";
            this.TxtSummary.Size = new System.Drawing.Size(539, 119);
            this.TxtSummary.TabIndex = 92;
            // 
            // LblSummary
            // 
            this.LblSummary.AutoSize = true;
            this.LblSummary.Location = new System.Drawing.Point(86, 294);
            this.LblSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSummary.Name = "LblSummary";
            this.LblSummary.Size = new System.Drawing.Size(44, 18);
            this.LblSummary.TabIndex = 91;
            this.LblSummary.Text = "概要";
            // 
            // TxtHour
            // 
            this.TxtHour.Location = new System.Drawing.Point(90, 217);
            this.TxtHour.Margin = new System.Windows.Forms.Padding(4);
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Size = new System.Drawing.Size(539, 25);
            this.TxtHour.TabIndex = 90;
            // 
            // LblHour
            // 
            this.LblHour.AutoSize = true;
            this.LblHour.Location = new System.Drawing.Point(86, 172);
            this.LblHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(44, 18);
            this.LblHour.TabIndex = 89;
            this.LblHour.Text = "工数";
            // 
            // TxtTaskName
            // 
            this.TxtTaskName.Location = new System.Drawing.Point(90, 109);
            this.TxtTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTaskName.Name = "TxtTaskName";
            this.TxtTaskName.Size = new System.Drawing.Size(539, 25);
            this.TxtTaskName.TabIndex = 88;
            // 
            // LblTaskName
            // 
            this.LblTaskName.AutoSize = true;
            this.LblTaskName.Location = new System.Drawing.Point(86, 60);
            this.LblTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTaskName.Name = "LblTaskName";
            this.LblTaskName.Size = new System.Drawing.Size(64, 18);
            this.LblTaskName.TabIndex = 87;
            this.LblTaskName.Text = "タスク名";
            // 
            // BtnInsertTask
            // 
            this.BtnInsertTask.Location = new System.Drawing.Point(450, 600);
            this.BtnInsertTask.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInsertTask.Name = "BtnInsertTask";
            this.BtnInsertTask.Size = new System.Drawing.Size(179, 52);
            this.BtnInsertTask.TabIndex = 86;
            this.BtnInsertTask.Text = "登録";
            this.BtnInsertTask.UseVisualStyleBackColor = true;
            this.BtnInsertTask.Click += new System.EventHandler(this.BtnInsertTask_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(227, 600);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 85;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmInsertTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 724);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.TxtSummary);
            this.Controls.Add(this.LblSummary);
            this.Controls.Add(this.TxtHour);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.TxtTaskName);
            this.Controls.Add(this.LblTaskName);
            this.Controls.Add(this.BtnInsertTask);
            this.Controls.Add(this.BtnBack);
            this.Name = "FrmInsertTask";
            this.Text = "FrmInsertTask";
            this.Load += new System.EventHandler(this.FrmInsertTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox CmbStatus;
        internal System.Windows.Forms.Label LblStatus;
        internal System.Windows.Forms.TextBox TxtSummary;
        internal System.Windows.Forms.Label LblSummary;
        internal System.Windows.Forms.TextBox TxtHour;
        internal System.Windows.Forms.Label LblHour;
        internal System.Windows.Forms.TextBox TxtTaskName;
        internal System.Windows.Forms.Label LblTaskName;
        internal System.Windows.Forms.Button BtnInsertTask;
        internal System.Windows.Forms.Button BtnBack;
    }
}