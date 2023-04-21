namespace CSharp_HourManagementApp2.Forms
{
    partial class FrmReleaseLock
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
            this.DgvLockedUsers = new System.Windows.Forms.DataGridView();
            this.txtUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReleaseLock = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLockedUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(482, 337);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(143, 43);
            this.BtnBack.TabIndex = 48;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DgvLockedUsers
            // 
            this.DgvLockedUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLockedUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtUserName,
            this.txtPassword,
            this.btnReleaseLock,
            this.txtID});
            this.DgvLockedUsers.Location = new System.Drawing.Point(176, 70);
            this.DgvLockedUsers.Margin = new System.Windows.Forms.Padding(2);
            this.DgvLockedUsers.Name = "DgvLockedUsers";
            this.DgvLockedUsers.RowHeadersWidth = 62;
            this.DgvLockedUsers.RowTemplate.Height = 27;
            this.DgvLockedUsers.Size = new System.Drawing.Size(436, 223);
            this.DgvLockedUsers.TabIndex = 47;
            this.DgvLockedUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLockedUsers_CellContentClick);
            // 
            // txtUserName
            // 
            this.txtUserName.DataPropertyName = "UserName";
            this.txtUserName.HeaderText = "ユーザ名";
            this.txtUserName.MinimumWidth = 8;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Width = 150;
            // 
            // txtPassword
            // 
            this.txtPassword.DataPropertyName = "Password";
            this.txtPassword.HeaderText = "パスワード";
            this.txtPassword.MinimumWidth = 8;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Visible = false;
            this.txtPassword.Width = 150;
            // 
            // btnReleaseLock
            // 
            this.btnReleaseLock.HeaderText = "ロック解除";
            this.btnReleaseLock.MinimumWidth = 8;
            this.btnReleaseLock.Name = "btnReleaseLock";
            this.btnReleaseLock.Width = 150;
            // 
            // txtID
            // 
            this.txtID.DataPropertyName = "Id";
            this.txtID.HeaderText = "ID";
            this.txtID.MinimumWidth = 8;
            this.txtID.Name = "txtID";
            this.txtID.Visible = false;
            this.txtID.Width = 150;
            // 
            // FrmReleaseLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DgvLockedUsers);
            this.Name = "FrmReleaseLock";
            this.Text = "FrmReleaseLock";
            this.Load += new System.EventHandler(this.FrmReleaseLock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLockedUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.DataGridView DgvLockedUsers;
        internal System.Windows.Forms.DataGridViewTextBoxColumn txtUserName;
        internal System.Windows.Forms.DataGridViewTextBoxColumn txtPassword;
        internal System.Windows.Forms.DataGridViewButtonColumn btnReleaseLock;
        internal System.Windows.Forms.DataGridViewTextBoxColumn txtID;
    }
}