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
using static CSharp_HourManagementApp2.Common.EnumValue;

namespace CSharp_HourManagementApp2.Forms
{
    public partial class FrmMain : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmMain(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //ログイン画面に遷移
                commonFunc.HideAndOpen(this, new FrmLogin());
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

        private void FrmMain_Load(object sender, EventArgs e)
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


        private void BtnReleaseLock_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //アカウントロック解除画面に遷移
                commonFunc.HideAndOpen(this, new FrmReleaseLock(this.loginUserID));
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


        private void BtnInsertProject_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //プロジェクト登録画面に遷移
                commonFunc.HideAndOpen(this, new FrmInsertProject(this.loginUserID));
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


        private void BtnProjects_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //プロジェクト一覧画面に遷移
                commonFunc.HideAndOpen(this, new FrmProjects(this.loginUserID));
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


        private void BtnArchivedTasks_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //アーカイブ一覧画面に遷移
                commonFunc.HideAndOpen(this, new FrmArchiveTasks(this.loginUserID));
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


        private void BtnRequestProject_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //プロジェクト応募画面に遷移
                commonFunc.HideAndOpen(this, new FrmRequestProject(this.loginUserID));
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


        private void BtnProjectWikis_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //Wiki一覧画面に遷移
                commonFunc.HideAndOpen(this, new FrmProjectWikis(this.loginUserID));
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


        private void BtnCalcHour_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //工数計算画面に遷移
                commonFunc.HideAndOpen(this, new FrmCalcHour(this.loginUserID));
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
            //ボタンの表示非表示を設定
            SetBtnVisible();

            //インスタンス化
            User user = new User();

            //管理者の場合
            if (user.IsAdmin(this.loginUserID))
            {
                //インスタンス化
                Request　request = new Request();

                //リクエストが存在する場合
                if (request.IsExistsRequest())
                {
                    //通知
                    request.Notification();
                    //通知状態を更新
                    //TODO : 不具合あり
                    request.UpdateNotification();
                }

                //インスタンス化
                Project project = new Project();

                //通知されていない本日の案件が存在する場合
                if (project.IsExistsTodayProject())
                {
                    //通知
                    //TODO: 不具合あり
                    project.Notification();
                    //通知状態を更新
                    project.UpdateNotification();
                }
            }
        }


        /// <summary>
        /// ボタン表示非表示を設定
        /// </summary>
        /// 2023/04/14
        private void SetBtnVisible()
        {
            //インスタンス化
            User user = new User();

            //管理者でない場合
            if (! user.IsAdmin(this.loginUserID))
            {
                //ボタンを非表示にする
                //アカウントロック解除ボタン
                this.BtnReleaseLock.Visible = false;
            } 
            else
            {
                //管理者の場合
                //ボタンを非表示にする
                //プロジェクト応募ボタン
                this.BtnRequestProject.Visible = false;
            }
        }
    }
}
