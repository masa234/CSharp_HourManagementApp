namespace CSharp_HourManagementApp2.Forms
{
    partial class FrmProjects
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
            this.DgvProjects = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnProjectDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnProjectUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnInsertTask = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnTasks = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(564, 367);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 59;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DgvProjects
            // 
            this.DgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.TxtProjectName,
            this.TxtHour,
            this.TxtSummary,
            this.TxtStartDate,
            this.EndDate,
            this.TxtStatus,
            this.BtnProjectDelete,
            this.BtnProjectUpdate,
            this.BtnInsertTask,
            this.BtnTasks});
            this.DgvProjects.Location = new System.Drawing.Point(58, 31);
            this.DgvProjects.Margin = new System.Windows.Forms.Padding(4);
            this.DgvProjects.Name = "DgvProjects";
            this.DgvProjects.RowHeadersWidth = 51;
            this.DgvProjects.RowTemplate.Height = 24;
            this.DgvProjects.Size = new System.Drawing.Size(685, 304);
            this.DgvProjects.TabIndex = 58;
            this.DgvProjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProjects_CellContentClick);
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
            // TxtProjectName
            // 
            this.TxtProjectName.DataPropertyName = "ProjectName";
            this.TxtProjectName.HeaderText = "プロジェクト名";
            this.TxtProjectName.MinimumWidth = 6;
            this.TxtProjectName.Name = "TxtProjectName";
            this.TxtProjectName.Width = 125;
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
            // TxtStartDate
            // 
            this.TxtStartDate.DataPropertyName = "StartDate";
            this.TxtStartDate.HeaderText = "開始日時";
            this.TxtStartDate.MinimumWidth = 6;
            this.TxtStartDate.Name = "TxtStartDate";
            this.TxtStartDate.Width = 125;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "終了日時";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 125;
            // 
            // TxtStatus
            // 
            this.TxtStatus.DataPropertyName = "Status";
            this.TxtStatus.HeaderText = "状態";
            this.TxtStatus.MinimumWidth = 6;
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Width = 125;
            // 
            // BtnProjectDelete
            // 
            this.BtnProjectDelete.HeaderText = "削除";
            this.BtnProjectDelete.MinimumWidth = 6;
            this.BtnProjectDelete.Name = "BtnProjectDelete";
            this.BtnProjectDelete.Width = 125;
            // 
            // BtnProjectUpdate
            // 
            this.BtnProjectUpdate.HeaderText = "更新";
            this.BtnProjectUpdate.MinimumWidth = 6;
            this.BtnProjectUpdate.Name = "BtnProjectUpdate";
            this.BtnProjectUpdate.Width = 125;
            // 
            // BtnInsertTask
            // 
            this.BtnInsertTask.HeaderText = "タスク追加";
            this.BtnInsertTask.MinimumWidth = 6;
            this.BtnInsertTask.Name = "BtnInsertTask";
            this.BtnInsertTask.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnInsertTask.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnInsertTask.Width = 125;
            // 
            // BtnTasks
            // 
            this.BtnTasks.HeaderText = "タスク一覧";
            this.BtnTasks.MinimumWidth = 6;
            this.BtnTasks.Name = "BtnTasks";
            this.BtnTasks.Width = 125;
            // 
            // FrmProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DgvProjects);
            this.Name = "FrmProjects";
            this.Text = "FrmProjects";
            this.Load += new System.EventHandler(this.FrmProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.DataGridView DgvProjects;
        internal System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtProjectName;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtHour;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtSummary;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtStartDate;
        internal System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtStatus;
        internal System.Windows.Forms.DataGridViewButtonColumn BtnProjectDelete;
        internal System.Windows.Forms.DataGridViewButtonColumn BtnProjectUpdate;
        internal System.Windows.Forms.DataGridViewButtonColumn BtnInsertTask;
        internal System.Windows.Forms.DataGridViewButtonColumn BtnTasks;
    }
}