namespace CSharp_HourManagementApp2.Forms
{
    partial class FrmUpdateTask
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
            this.TxtSummary = new System.Windows.Forms.TextBox();
            this.LblSummary = new System.Windows.Forms.Label();
            this.TxtHour = new System.Windows.Forms.TextBox();
            this.LblHour = new System.Windows.Forms.Label();
            this.TxtTaskName = new System.Windows.Forms.TextBox();
            this.LblTaskName = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnUpdateTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSummary
            // 
            this.TxtSummary.Location = new System.Drawing.Point(114, 346);
            this.TxtSummary.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSummary.Multiline = true;
            this.TxtSummary.Name = "TxtSummary";
            this.TxtSummary.Size = new System.Drawing.Size(539, 119);
            this.TxtSummary.TabIndex = 103;
            // 
            // LblSummary
            // 
            this.LblSummary.AutoSize = true;
            this.LblSummary.Location = new System.Drawing.Point(111, 291);
            this.LblSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSummary.Name = "LblSummary";
            this.LblSummary.Size = new System.Drawing.Size(44, 18);
            this.LblSummary.TabIndex = 102;
            this.LblSummary.Text = "概要";
            // 
            // TxtHour
            // 
            this.TxtHour.Location = new System.Drawing.Point(114, 223);
            this.TxtHour.Margin = new System.Windows.Forms.Padding(4);
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Size = new System.Drawing.Size(539, 25);
            this.TxtHour.TabIndex = 101;
            // 
            // LblHour
            // 
            this.LblHour.AutoSize = true;
            this.LblHour.Location = new System.Drawing.Point(111, 170);
            this.LblHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(44, 18);
            this.LblHour.TabIndex = 100;
            this.LblHour.Text = "工数";
            // 
            // TxtTaskName
            // 
            this.TxtTaskName.Location = new System.Drawing.Point(114, 106);
            this.TxtTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTaskName.Name = "TxtTaskName";
            this.TxtTaskName.Size = new System.Drawing.Size(539, 25);
            this.TxtTaskName.TabIndex = 99;
            // 
            // LblTaskName
            // 
            this.LblTaskName.AutoSize = true;
            this.LblTaskName.Location = new System.Drawing.Point(111, 57);
            this.LblTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTaskName.Name = "LblTaskName";
            this.LblTaskName.Size = new System.Drawing.Size(64, 18);
            this.LblTaskName.TabIndex = 98;
            this.LblTaskName.Text = "タスク名";
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Location = new System.Drawing.Point(118, 539);
            this.CmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(150, 26);
            this.CmbStatus.TabIndex = 107;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(115, 493);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(44, 18);
            this.LblStatus.TabIndex = 106;
            this.LblStatus.Text = "状態";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(265, 593);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 105;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnUpdateTask
            // 
            this.BtnUpdateTask.Location = new System.Drawing.Point(480, 593);
            this.BtnUpdateTask.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdateTask.Name = "BtnUpdateTask";
            this.BtnUpdateTask.Size = new System.Drawing.Size(179, 52);
            this.BtnUpdateTask.TabIndex = 104;
            this.BtnUpdateTask.Text = "更新";
            this.BtnUpdateTask.UseVisualStyleBackColor = true;
            this.BtnUpdateTask.Click += new System.EventHandler(this.BtnUpdateTask_Click);
            // 
            // FrmUpdateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 724);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnUpdateTask);
            this.Controls.Add(this.TxtSummary);
            this.Controls.Add(this.LblSummary);
            this.Controls.Add(this.TxtHour);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.TxtTaskName);
            this.Controls.Add(this.LblTaskName);
            this.Name = "FrmUpdateTask";
            this.Text = "FrmUpdateTask";
            this.Load += new System.EventHandler(this.FrmUpdateTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TxtSummary;
        internal System.Windows.Forms.Label LblSummary;
        internal System.Windows.Forms.TextBox TxtHour;
        internal System.Windows.Forms.Label LblHour;
        internal System.Windows.Forms.TextBox TxtTaskName;
        internal System.Windows.Forms.Label LblTaskName;
        internal System.Windows.Forms.ComboBox CmbStatus;
        internal System.Windows.Forms.Label LblStatus;
        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.Button BtnUpdateTask;
    }
}