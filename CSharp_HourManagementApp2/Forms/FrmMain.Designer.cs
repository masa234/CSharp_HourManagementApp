namespace CSharp_HourManagementApp2.Forms
{
    partial class FrmMain
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
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnReleaseLock = new System.Windows.Forms.Button();
            this.BtnInsertProject = new System.Windows.Forms.Button();
            this.BtnProjects = new System.Windows.Forms.Button();
            this.BtnArchivedTasks = new System.Windows.Forms.Button();
            this.BtnRequestProject = new System.Windows.Forms.Button();
            this.BtnProjectWikis = new System.Windows.Forms.Button();
            this.BtnCalcHour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(732, 433);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(161, 66);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.Text = "ログアウト";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnReleaseLock
            // 
            this.BtnReleaseLock.Location = new System.Drawing.Point(59, 50);
            this.BtnReleaseLock.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReleaseLock.Name = "BtnReleaseLock";
            this.BtnReleaseLock.Size = new System.Drawing.Size(161, 66);
            this.BtnReleaseLock.TabIndex = 6;
            this.BtnReleaseLock.Text = "アカウントロック解除";
            this.BtnReleaseLock.UseVisualStyleBackColor = true;
            this.BtnReleaseLock.Click += new System.EventHandler(this.BtnReleaseLock_Click);
            // 
            // BtnInsertProject
            // 
            this.BtnInsertProject.Location = new System.Drawing.Point(59, 167);
            this.BtnInsertProject.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsertProject.Name = "BtnInsertProject";
            this.BtnInsertProject.Size = new System.Drawing.Size(161, 66);
            this.BtnInsertProject.TabIndex = 7;
            this.BtnInsertProject.Text = "プロジェクト登録";
            this.BtnInsertProject.UseVisualStyleBackColor = true;
            this.BtnInsertProject.Click += new System.EventHandler(this.BtnInsertProject_Click);
            // 
            // BtnProjects
            // 
            this.BtnProjects.Location = new System.Drawing.Point(256, 167);
            this.BtnProjects.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProjects.Name = "BtnProjects";
            this.BtnProjects.Size = new System.Drawing.Size(161, 66);
            this.BtnProjects.TabIndex = 8;
            this.BtnProjects.Text = "プロジェクト一覧";
            this.BtnProjects.UseVisualStyleBackColor = true;
            this.BtnProjects.Click += new System.EventHandler(this.BtnProjects_Click);
            // 
            // BtnArchivedTasks
            // 
            this.BtnArchivedTasks.Location = new System.Drawing.Point(443, 167);
            this.BtnArchivedTasks.Margin = new System.Windows.Forms.Padding(4);
            this.BtnArchivedTasks.Name = "BtnArchivedTasks";
            this.BtnArchivedTasks.Size = new System.Drawing.Size(161, 66);
            this.BtnArchivedTasks.TabIndex = 9;
            this.BtnArchivedTasks.Text = "アーカイブしたタスク一覧";
            this.BtnArchivedTasks.UseVisualStyleBackColor = true;
            this.BtnArchivedTasks.Click += new System.EventHandler(this.BtnArchivedTasks_Click);
            // 
            // BtnRequestProject
            // 
            this.BtnRequestProject.Location = new System.Drawing.Point(59, 290);
            this.BtnRequestProject.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRequestProject.Name = "BtnRequestProject";
            this.BtnRequestProject.Size = new System.Drawing.Size(161, 66);
            this.BtnRequestProject.TabIndex = 10;
            this.BtnRequestProject.Text = "プロジェクト応募";
            this.BtnRequestProject.UseVisualStyleBackColor = true;
            this.BtnRequestProject.Click += new System.EventHandler(this.BtnRequestProject_Click);
            // 
            // BtnProjectWikis
            // 
            this.BtnProjectWikis.Location = new System.Drawing.Point(59, 402);
            this.BtnProjectWikis.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProjectWikis.Name = "BtnProjectWikis";
            this.BtnProjectWikis.Size = new System.Drawing.Size(161, 66);
            this.BtnProjectWikis.TabIndex = 11;
            this.BtnProjectWikis.Text = "Wiki一覧";
            this.BtnProjectWikis.UseVisualStyleBackColor = true;
            this.BtnProjectWikis.Click += new System.EventHandler(this.BtnProjectWikis_Click);
            // 
            // BtnCalcHour
            // 
            this.BtnCalcHour.Location = new System.Drawing.Point(256, 402);
            this.BtnCalcHour.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCalcHour.Name = "BtnCalcHour";
            this.BtnCalcHour.Size = new System.Drawing.Size(161, 66);
            this.BtnCalcHour.TabIndex = 12;
            this.BtnCalcHour.Text = "工数計算";
            this.BtnCalcHour.UseVisualStyleBackColor = true;
            this.BtnCalcHour.Click += new System.EventHandler(this.BtnCalcHour_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.BtnCalcHour);
            this.Controls.Add(this.BtnProjectWikis);
            this.Controls.Add(this.BtnRequestProject);
            this.Controls.Add(this.BtnArchivedTasks);
            this.Controls.Add(this.BtnProjects);
            this.Controls.Add(this.BtnInsertProject);
            this.Controls.Add(this.BtnReleaseLock);
            this.Controls.Add(this.BtnLogout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnLogout;
        internal System.Windows.Forms.Button BtnReleaseLock;
        internal System.Windows.Forms.Button BtnInsertProject;
        internal System.Windows.Forms.Button BtnProjects;
        internal System.Windows.Forms.Button BtnArchivedTasks;
        internal System.Windows.Forms.Button BtnRequestProject;
        internal System.Windows.Forms.Button BtnProjectWikis;
        internal System.Windows.Forms.Button BtnCalcHour;
    }
}