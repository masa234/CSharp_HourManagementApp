using CSharp_HourManagementApp2.Common;
using CSharp_HourManagementApp2.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSharp_HourManagementApp2.Forms
{
    public partial class FrmRequestProject : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmRequestProject(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }

        private void FrmRequestProject_Load(object sender, EventArgs e)
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

        private void BtnRequestProject_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                User user = new User();

                //管理者の場合
                if (user.IsAdmin(this.loginUserID))
                    return;

                //プロジェクト名
                string projectName = this.CmbProject.Text;

                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //入力チェック(プロジェクト名)
                if (! commonFunc.IsInputed(projectName))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.PROJECTNAME_MUST_INPUT,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //コンボボックスの選択肢内かどうか(プロジェクト名)
                if (! commonFunc.IsTextInCmb(this.CmbProject, projectName))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.PROJECTNAME_MUST_IN_CMB,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //インスタンス化
                Request request = new Request();

                //プロジェクト応募
                if (! request.InsertRequest(projectName, this.loginUserID))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.FAILED_REQUEST_PROJECT,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //成功メッセージ
                MessageBox.Show(Constant.SUCCESS_REQUEST_PROJECT,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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
        /// 2023/04/19
        private void InitForm()
        {
            //コンボボックスの設定
            SetCmb();
        }


        /// <summary>
        /// コンボボックスの設定
        /// </summary>
        /// 2023/04/19
        private void SetCmb()
        {
            //インスタンス化
            Project project = new Project();

            //プロジェクトリストを取得
            List<ProjectData> projectList = project.GetProjectList();

            //文字列のリストに変換
            List<string> projectNameList = project.ProjectListToStringList(projectList);

            //インスタンス化
            CommonFunc commonFunc = new CommonFunc();

            //コンボボックスに設定
            commonFunc.SetCmb(this.CmbProject, projectNameList);
        }
    }
}
