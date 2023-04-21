namespace CSharp_HourManagementApp2.Forms
{
    partial class FrmTasks
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
            this.DgvTasks = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtInsertDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDeleteTask = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnUpdateTask = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnArchive = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblTaskName = new System.Windows.Forms.Label();
            this.TxtSearchTaskName = new System.Windows.Forms.TextBox();
            this.LblSearchCount = new System.Windows.Forms.Label();
            this.BtnOutputCSV = new System.Windows.Forms.Button();
            this.BtnSortStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(673, 569);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 61;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DgvTasks
            // 
            this.DgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.TxtTaskName,
            this.TxtHour,
            this.TxtSummary,
            this.TxtInsertDate,
            this.TxtUpdateDate,
            this.TxtStatus,
            this.BtnDeleteTask,
            this.BtnUpdateTask,
            this.BtnArchive});
            this.DgvTasks.Location = new System.Drawing.Point(157, 243);
            this.DgvTasks.Margin = new System.Windows.Forms.Padding(4);
            this.DgvTasks.Name = "DgvTasks";
            this.DgvTasks.RowHeadersWidth = 51;
            this.DgvTasks.RowTemplate.Height = 24;
            this.DgvTasks.Size = new System.Drawing.Size(685, 304);
            this.DgvTasks.TabIndex = 60;
            this.DgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTasks_CellContentClick);
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
            // BtnDeleteTask
            // 
            this.BtnDeleteTask.HeaderText = "削除";
            this.BtnDeleteTask.MinimumWidth = 6;
            this.BtnDeleteTask.Name = "BtnDeleteTask";
            this.BtnDeleteTask.Width = 125;
            // 
            // BtnUpdateTask
            // 
            this.BtnUpdateTask.HeaderText = "更新";
            this.BtnUpdateTask.MinimumWidth = 6;
            this.BtnUpdateTask.Name = "BtnUpdateTask";
            this.BtnUpdateTask.Width = 125;
            // 
            // BtnArchive
            // 
            this.BtnArchive.HeaderText = "アーカイブ化";
            this.BtnArchive.MinimumWidth = 6;
            this.BtnArchive.Name = "BtnArchive";
            this.BtnArchive.Width = 125;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(673, 174);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(179, 52);
            this.BtnSearch.TabIndex = 67;
            this.BtnSearch.Text = "検索";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblTaskName
            // 
            this.LblTaskName.AutoSize = true;
            this.LblTaskName.Location = new System.Drawing.Point(168, 82);
            this.LblTaskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTaskName.Name = "LblTaskName";
            this.LblTaskName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTaskName.Size = new System.Drawing.Size(64, 18);
            this.LblTaskName.TabIndex = 66;
            this.LblTaskName.Text = "タスク名";
            // 
            // TxtSearchTaskName
            // 
            this.TxtSearchTaskName.Location = new System.Drawing.Point(168, 126);
            this.TxtSearchTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSearchTaskName.Name = "TxtSearchTaskName";
            this.TxtSearchTaskName.Size = new System.Drawing.Size(684, 25);
            this.TxtSearchTaskName.TabIndex = 65;
            // 
            // LblSearchCount
            // 
            this.LblSearchCount.AutoSize = true;
            this.LblSearchCount.Location = new System.Drawing.Point(848, 129);
            this.LblSearchCount.Name = "LblSearchCount";
            this.LblSearchCount.Size = new System.Drawing.Size(0, 18);
            this.LblSearchCount.TabIndex = 68;
            // 
            // BtnOutputCSV
            // 
            this.BtnOutputCSV.Location = new System.Drawing.Point(457, 569);
            this.BtnOutputCSV.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOutputCSV.Name = "BtnOutputCSV";
            this.BtnOutputCSV.Size = new System.Drawing.Size(179, 52);
            this.BtnOutputCSV.TabIndex = 69;
            this.BtnOutputCSV.Text = "CSV出力";
            this.BtnOutputCSV.UseVisualStyleBackColor = true;
            this.BtnOutputCSV.Click += new System.EventHandler(this.BtnOutputCSV_Click);
            // 
            // BtnSortStatus
            // 
            this.BtnSortStatus.Location = new System.Drawing.Point(457, 174);
            this.BtnSortStatus.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSortStatus.Name = "BtnSortStatus";
            this.BtnSortStatus.Size = new System.Drawing.Size(179, 52);
            this.BtnSortStatus.TabIndex = 70;
            this.BtnSortStatus.Text = "状態でソート";
            this.BtnSortStatus.UseVisualStyleBackColor = true;
            this.BtnSortStatus.Click += new System.EventHandler(this.BtnSortStatus_Click);
            // 
            // FrmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 664);
            this.Controls.Add(this.BtnSortStatus);
            this.Controls.Add(this.BtnOutputCSV);
            this.Controls.Add(this.LblSearchCount);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LblTaskName);
            this.Controls.Add(this.TxtSearchTaskName);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DgvTasks);
            this.Name = "FrmTasks";
            this.Text = "FrmTasks";
            this.Load += new System.EventHandler(this.FrmTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.DataGridView DgvTasks;
        internal System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtTaskName;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtHour;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtSummary;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtInsertDate;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtUpdateDate;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtStatus;
        internal System.Windows.Forms.DataGridViewButtonColumn BtnDeleteTask;
        internal System.Windows.Forms.DataGridViewButtonColumn BtnUpdateTask;
        internal System.Windows.Forms.DataGridViewButtonColumn BtnArchive;
        internal System.Windows.Forms.Button BtnSearch;
        internal System.Windows.Forms.Label LblTaskName;
        internal System.Windows.Forms.TextBox TxtSearchTaskName;
        private System.Windows.Forms.Label LblSearchCount;
        internal System.Windows.Forms.Button BtnOutputCSV;
        internal System.Windows.Forms.Button BtnSortStatus;
    }
}