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
    public partial class FrmProjects : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmProjects(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }

        private void FrmProjects_Load(object sender, EventArgs e)
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

        private void DgvProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //プロジェクトID
                long.TryParse(DgvProjects.Rows[e.RowIndex].Cells[4].Value.ToString(), out long projectID);

                //削除ボタンが押されている場合
                if (DgvProjects.Columns[e.ColumnIndex].Name == "BtnProjectDelete")
                {
                    //インスタンス化
                    Project project = new Project();

                    //削除
                    if (! project.DeleteProject(projectID))
                    {
                        //メッセージボックス
                        MessageBox.Show(Constant.FAILED_DELETE_PROJECT,
                                        Constant.CONFIRM,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }

                    //データソースの再設定
                    SetDataSource();
                }

                //更新ボタンが押されている場合
                if (DgvProjects.Columns[e.ColumnIndex].Name == "BtnProjectUpdate")
                {
                    //インスタンス化
                    CommonFunc commonFunc = new CommonFunc();

                    //プロジェクト更新画面に遷移
                    commonFunc.HideAndOpen(this, new FrmUpdateProject(this.loginUserID, projectID));
                }


                //タスク登録ボタンが押されている場合
                if (DgvProjects.Columns[e.ColumnIndex].Name == "BtnInsertTask")
                {
                    //インスタンス化
                    CommonFunc commonFunc = new CommonFunc();

                    //タスク登録画面に遷移
                    commonFunc.HideAndOpen(this, new FrmInsertTask(this.loginUserID, projectID));
                }

                //タスク一覧ボタンが押されている場合
                if (DgvProjects.Columns[e.ColumnIndex].Name == "BtnTasks")
                {
                    //インスタンス化
                    CommonFunc commonFunc = new CommonFunc();

                    //タスク一覧画面に遷移
                    commonFunc.HideAndOpen(this, new FrmTasks(this.loginUserID, projectID));
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
        /// 2023/04/18
        private void InitForm()
        {
            //データソースの設定
            SetDataSource();
        }


        /// <summary>
        /// データソースの設定
        /// </summary>
        /// 2023/04/18
        private void SetDataSource()
        {
            //インスタンス化
            Project project = new Project();

            //データソースの設定
            this.DgvProjects.DataSource = project.GetProjectList();
        }
    }
}
