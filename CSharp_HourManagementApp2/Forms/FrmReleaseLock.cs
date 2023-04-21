using CSharp_HourManagementApp2.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HourManagementApp2.Forms
{
    public partial class FrmReleaseLock : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmReleaseLock(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }

        private void FrmReleaseLock_Load(object sender, EventArgs e)
        {
            try
            {
                //フォーム初期化
                InitForm();
            }
            catch (Exception ex)
            {
                //メッセージボックス
                MessageBox.Show(ex.Message,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void DgvLockedUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //アカウントロック解除ボタンが押されている場合
                if (DgvLockedUsers.Columns[e.ColumnIndex].Name == "btnReleaseLock")
                {
                    //インスタンス化
                    User user = new User();

                    //管理者かどうか
                    if (! user.IsAdmin(this.loginUserID))
                        return;

                    //ユーザ名
                    string lockedUserName = DgvLockedUsers.Rows[e.RowIndex].Cells[2].Value.ToString();

                    //アカウントロック解除
                    user.UpdateLock(lockedUserName, (long)EnumValue.IsLock.NotLock);

                    //データソースの再設定
                    SetDataSource();
                }
            }
            catch (Exception ex)
            {
                //メッセージボックス
                MessageBox.Show(ex.Message,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //メイン画面に遷移
                commonFunc.HideAndOpen(this, new FrmMain(this.loginUserID));
            }
            catch (Exception ex)
            {
                //メッセージボックス
                MessageBox.Show(ex.Message,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// フォーム初期化
        /// </summary>
        /// 2023/04/14
        private void InitForm()
        {
            //データソースの設定
            SetDataSource();
        }


        /// <summary>
        /// データソースの設定
        /// </summary>
        /// 2023/04/14
        private void SetDataSource()
        {
            //インスタンス化
            User user = new User();

            //データソースの設定
            this.DgvLockedUsers.DataSource = user.GetAllLockedUsers();
        }
    }
}
