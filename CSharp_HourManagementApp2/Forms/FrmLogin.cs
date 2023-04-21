using CSharp_HourManagementApp2.Common;
using CSharp_HourManagementApp2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HourManagementApp2
{
    public partial class FrmLogin : Form
    {
        //ログインカウント
        private long loginCount;
        public FrmLogin()
        {
            InitializeComponent();

            //ログインカウント初期化
            this.loginCount = 0;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //ユーザ名
                string userName = this.TxtUserName.Text;
                //パスワード
                string password = this.TxtPassword.Text;

                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //文字数チェック(ユーザ名)
                if (! commonFunc.IsFitInText(userName, Constant.USERNAME_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.INVALID_USERNAME_LENGTH,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //文字数チェック(パスワード)
                if (! commonFunc.IsFitInText(password, Constant.PASSWORD_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.INVALID_PASSWORD_LENGTH,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //インスタンス化
                User user = new User();

                //ユーザ名が存在するかどうか?
                if (! user.IsExistsUserName(userName))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.FAILED_LOGIN,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;

                }

                //アカウントがロックされているかどうか?
                if (user.IsLockedUserName(userName))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.USER_IS_LOCKED,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //ユーザが存在するかどうか?
                if (! user.IsExistsUser(userName, password))
                {
                    //ログインカウントをカウントアップ
                    this.loginCount++;

                    //ログインカウントが指定回数を超えた場合
                    if (Constant.LOCK_COUNT <= loginCount)
                    {
                        //アカウントロック
                        user.UpdateLock(userName, (long)EnumValue.IsLock.Locked);

                        //メッセージボックス
                        MessageBox.Show(Constant.USER_IS_LOCK,
                                        Constant.CONFIRM,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }

                    //メッセージボックス
                    MessageBox.Show(Constant.FAILED_LOGIN,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //ユーザID取得
                long loginUserID = user.GetUserID(userName, password);

                //メイン画面に遷移
                commonFunc.HideAndOpen(this, new FrmMain(loginUserID));
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
    }
}
