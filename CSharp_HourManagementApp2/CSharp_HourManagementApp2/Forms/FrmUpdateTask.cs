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
    public partial class FrmUpdateTask : Form
    {
        //ログインユーザID
        private readonly long loginUserID;
        //プロジェクトID
        private readonly long projectID;
        //更新対象タスクID
        private readonly long updateTaskID;

        public FrmUpdateTask(long loginUserID,
                                long projectID,
                                long updateTaskID)
        {
            InitializeComponent();

            //設定
            //ログインユーザID
            this.loginUserID = loginUserID;
            //プロジェクトID
            this.projectID = projectID;
            //更新対象タスクID
            this.updateTaskID = updateTaskID;
        }

        private void FrmUpdateTask_Load(object sender, EventArgs e)
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

        private void BtnUpdateTask_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //タスク名
                string taskName = this.TxtTaskName.Text;
                //工数
                int hour = commonFunc.SafeCastInt(this.TxtHour.Text);
                //概要
                string summary = this.TxtSummary.Text;
                //状態
                string status = this.CmbStatus.Text;

                //文字数チェック(タスク名)
                if (! commonFunc.IsFitInText(taskName, Constant.TASKNAME_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.INVALID_TASKNAME_LENGTH,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //入力チェック(工数)
                if (! commonFunc.IsInputed(hour.ToString()))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.HOUR_MUST_INPUT,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //文字数チェック(概要)
                if (! commonFunc.IsFitInText(summary, Constant.SUMMARY_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.INVALID_SUMMARY_LENGTH,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //入力チェック(状態)
                if (! commonFunc.IsInputed(status))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.STATUS_MUST_INPUT,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //コンボボックスの選択肢内かどうか?(状態)
                if (! commonFunc.IsTextInCmb(this.CmbStatus, status))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.STATUS_MUST_IN_CMB,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //インスタンス化
                Task task = new Task();

                //更新
                if (! task.UpdateTask(taskName,
                                    hour,
                                    summary,
                                    status,
                                    this.projectID,
                                    this.updateTaskID))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.FAILED_UPDATE_TASK,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //成功メッセージ
                MessageBox.Show(Constant.SUCCESS_UPDATE_TASK,
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

            //プロジェクト情報の設定
            SetTask();
        }


        /// <summary>
        /// コンボボックスの設定
        /// </summary>
        /// 2023/04/19
        private void SetCmb()
        {
            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //状態のリストを取得
            List<string> statusList = otherFunc.GetStatusList();

            //インスタンス化
            CommonFunc commonFunc = new CommonFunc();

            //コンボボックスに設定
            commonFunc.SetCmb(this.CmbStatus, statusList);
        }


        /// <summary>
        /// タスク情報の設定
        /// </summary>
        /// 2023/04/19
        private void SetTask()
        {
            //インスタンス化
            Task task = new Task();

            //タスク情報を取得
            TaskData taskData = task.GetTask(this.updateTaskID);

            //画面に設定
            //タスク名
            this.TxtTaskName.Text = taskData.TaskName;
            //工数
            this.TxtHour.Text = taskData.Hour.ToString();
            //概要
            this.TxtSummary.Text = taskData.Summary;
            //状態
            this.CmbStatus.Text = taskData.Status;
        }
    }
}
