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

namespace CSharp_HourManagementApp2.Forms
{
    public partial class FrmTasks : Form
    {
        //ログインユーザID
        private readonly long loginUserID;
        //プロジェクトID
        private readonly long projectID;

        public FrmTasks(long loginUserID,
                        long projectID)
        {
            InitializeComponent();

            //設定
            //ログインユーザID
            this.loginUserID = loginUserID;
            //プロジェクトID
            this.projectID = projectID;
        }

        private void FrmTasks_Load(object sender, EventArgs e)
        {
            try
            {
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

        private void DgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //タスクID
                long.TryParse(DgvTasks.Rows[e.RowIndex].Cells[3].Value.ToString(), out long taskID);

                //削除ボタンが押されている場合
                if (DgvTasks.Columns[e.ColumnIndex].Name == "BtnDeleteTask")
                {
                    //インスタンス化
                    Task task = new Task();

                    //削除
                    if (! task.DeleteTask(taskID))
                    {
                        //メッセージボックス
                        MessageBox.Show(Constant.FAILED_DELETE_TASK,
                                        Constant.CONFIRM,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }

                    //データソースの再設定
                    SetDataSource();
                }

                //更新ボタンが押されている場合
                if (DgvTasks.Columns[e.ColumnIndex].Name == "BtnUpdateTask")
                {
                    //インスタンス化
                    CommonFunc commonFunc = new CommonFunc();

                    //タスク更新画面に遷移
                    commonFunc.HideAndOpen(this, new FrmUpdateTask(this.loginUserID, this.projectID, taskID));
                }

                //アーカイブ化ボタンが押されている場合
                if (DgvTasks.Columns[e.ColumnIndex].Name == "BtnArchive")
                {
                    //インスタンス化
                    Task task = new Task();

                    //アーカイブ化
                    task.Archive(taskID);

                    //データソースの設定
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


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //タスク名
                string searchTaskName = this.TxtSearchTaskName.Text;

                //インスタンス化
                Task task = new Task();

                //件数取得
                long taskCount = task.GetSearchCount(this.projectID, searchTaskName);

                //画面に設定
                this.LblSearchCount.Text = taskCount.ToString() + "件";

                //検索用データソースの設定
                //TODO：　不具合あり
                SetSearchDataSource(searchTaskName);
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


        private void BtnOutputCSV_Click(object sender, EventArgs e)
        {
            try
            { 
                //インスタンス化
                Task task = new Task();

                //タスクリストを取得
                List<TaskData> taskList = task.GetProjectTaskList(this.projectID);

                //CSV出力
                //TODO ：不具合あり
                if (! task.OutputCSV(taskList, Constant.OUTPUT_CSV_PATH))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.FAILED_OUTPUT_CSV,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //成功メッセージ
                MessageBox.Show(Constant.SUCCESS_OUTPUT_CSV,
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


        private void BtnSortStatus_Click(object sender, EventArgs e)
        {
            try
            {
                //ソート済みデータソースの設定
                SetSortedDataSource();
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
            //データソースの設定
            SetDataSource();
        }


        /// <summary>
        /// データソースの設定
        /// </summary>
        /// 2023/04/19
        private void SetDataSource()
        {
            //インスタンス化
            Task task = new Task();

            //データソースの設定
            this.DgvTasks.DataSource = task.GetProjectTaskList(this.projectID);
        }


        /// <summary>
        /// 検索用データソースの設定
        /// </summary>
        /// 2023/04/19
        private void SetSearchDataSource(string searchTaskName)
        {
            //インスタンス化
            Task task = new Task();

            //データソースの設定
            this.DgvTasks.DataSource = task.FilterTaskList(this.projectID, searchTaskName);
        }


        /// <summary>
        /// ソート済みデータソースの設定
        /// </summary>
        /// 2023/04/19
        private void SetSortedDataSource()
        {
            //インスタンス化
            Task task = new Task();

            //データソースの設定
            this.DgvTasks.DataSource = task.GetSortedTaskList(this.projectID);
        }
    }
}
