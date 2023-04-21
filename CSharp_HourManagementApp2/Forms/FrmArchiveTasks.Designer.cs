namespace CSharp_HourManagementApp2.Forms
{
    partial class FrmArchiveTasks
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
            this.DgvArchiveTasks = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtInsertDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArchiveTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(564, 365);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 70;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DgvArchiveTasks
            // 
            this.DgvArchiveTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArchiveTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.TxtTaskName,
            this.TxtHour,
            this.TxtSummary,
            this.TxtInsertDate,
            this.TxtUpdateDate,
            this.TxtStatus});
            this.DgvArchiveTasks.Location = new System.Drawing.Point(58, 33);
            this.DgvArchiveTasks.Margin = new System.Windows.Forms.Padding(4);
            this.DgvArchiveTasks.Name = "DgvArchiveTasks";
            this.DgvArchiveTasks.RowHeadersWidth = 51;
            this.DgvArchiveTasks.RowTemplate.Height = 24;
            this.DgvArchiveTasks.Size = new System.Drawing.Size(685, 304);
            this.DgvArchiveTasks.TabIndex = 69;
            // 
            // txtID
            // 
            this.txtID.DataPropertyName = "Id";
            this.txtID.HeaderText = "ID";
            this.txtID.MinimumWidth = 6;
            this.txtID.Name = "txtID";
            this.txtID.Visible = false;
            this.txtID.Width = 125;
            // 
            // TxtTaskName
            // 
            this.TxtTaskName.DataPropertyName = "TaskName";
            this.TxtTaskName.HeaderText = "タスク名";
            this.TxtTaskName.MinimumWidth = 6;
            this.TxtTaskName.Name = "TxtTaskName";
            this.TxtTaskName.Width = 125;
            // 
            // TxtHour
            // 
            this.TxtHour.DataPropertyName = "Hour";
            this.TxtHour.HeaderText = "工数";
            this.TxtHour.MinimumWidth = 6;
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Width = 125;
            // 
            // TxtSummary
            // 
            this.TxtSummary.DataPropertyName = "Summary";
            this.TxtSummary.HeaderText = "概要";
            this.TxtSummary.MinimumWidth = 6;
            this.TxtSummary.Name = "TxtSummary";
            this.TxtSummary.Width = 125;
            // 
            // TxtInsertDate
            // 
            this.TxtInsertDate.DataPropertyName = "InsertDate";
            this.TxtInsertDate.HeaderText = "投稿日時";
            this.TxtInsertDate.MinimumWidth = 6;
            this.TxtInsertDate.Name = "TxtInsertDate";
            this.TxtInsertDate.Width = 125;
            // 
            // TxtUpdateDate
            // 
            this.TxtUpdateDate.DataPropertyName = "UpdateDate";
            this.TxtUpdateDate.HeaderText = "更新日時";
            this.TxtUpdateDate.MinimumWidth = 6;
            this.TxtUpdateDate.Name = "TxtUpdateDate";
            this.TxtUpdateDate.Width = 125;
            // 
            // TxtStatus
            // 
            this.TxtStatus.DataPropertyName = "Status";
            this.TxtStatus.HeaderText = "状態";
            this.TxtStatus.MinimumWidth = 6;
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Width = 125;
            // 
            // FrmArchiveTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DgvArchiveTasks);
            this.Name = "FrmArchiveTasks";
            this.Text = "FrmArchiveTasks";
            this.Load += new System.EventHandler(this.FrmArchiveTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArchiveTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.DataGridView DgvArchiveTasks;
        internal System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtTaskName;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtHour;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtSummary;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtInsertDate;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtUpdateDate;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtStatus;
    }
}