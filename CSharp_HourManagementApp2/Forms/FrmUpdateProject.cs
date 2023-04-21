﻿using CSharp_HourManagementApp2.Common;
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
    public partial class FrmUpdateProject : Form
    {
        //ログインユーザID
        private readonly long loginUserID;
        //更新対象プロジェクトID
        private readonly long updateProjectID;

        public FrmUpdateProject(long loginUserID,
                                long updateProjectID)
        {
            InitializeComponent();

            //設定
            //ログインユーザID
            this.loginUserID = loginUserID;
            //更新対象プロジェクトID
            this.updateProjectID = updateProjectID;
        }

        private void FrmUpdateProject_Load(object sender, EventArgs e)
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

        private void BtnUpdateProject_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //プロジェクト名
                string projectName = this.TxtProjectName.Text;
                //工数
                int hour = commonFunc.SafeCastInt(this.TxtHour.Text);
                //概要
                string summary = this.TxtSummary.Text;
                //開始日時
                DateTime startDate = this.DateStartDate.Value;
                //終了日時
                DateTime endDate = this.DateEndDate.Value;
                //状態
                string status = this.CmbStatus.Text;

                //文字数チェック(プロジェクト名)
                if (! commonFunc.IsFitInText(projectName, Constant.PROJECTNAME_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.INVALID_PROJECTNAME_LENGTH,
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

                //入力チェック(開始日時)
                if (! commonFunc.IsInputed(startDate.ToString()))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.STARTDATE_MUST_INPUT,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //入力チェック(終了日時)
                if (! commonFunc.IsInputed(endDate.ToString()))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.ENDDATE_MUST_INPUT,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //開始日時が終了日時を超えていないか?
                if (endDate < startDate)
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.START_DATE_MUST_BEFORE_END_DATE,
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
                Project project = new Project();

                //更新
                if (! project.UpdateProject(projectName,
                                            hour,
                                            summary,
                                            startDate,
                                            endDate,
                                            status,
                                            this.updateProjectID))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.FAILED_UPDATE_PROJECT,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //成功メッセージ
                MessageBox.Show(Constant.SUCCESS_UPDATE_PROJECT,
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
        /// 2023/04/18
        private void InitForm()
        {
            //コンボボックスの設定
            SetCmb();

            //プロジェクト情報の設定
            SetProject();
        }


        /// <summary>
        /// コンボボックスの設定
        /// </summary>
        /// 2023/04/18
        private void SetCmb()
        {
            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //状態のリストを取得
            List<string> statusList = otherFunc.GetStatusList();

            //インスタンス化
            CommonFunc commonFunc = new CommonFunc();

            //コンボボックス設定
            commonFunc.SetCmb(this.CmbStatus, statusList);
        }


        /// <summary>
        /// プロジェクト情報を画面に設定
        /// </summary>
        /// 2023/04/18
        private void SetProject()
        {
            //インスタンス化
            Project project = new Project();

            //プロジェクト情報取得
            ProjectData projectData = project.GetProject(this.updateProjectID);

            //画面に設定
            //プロジェクト名
            this.TxtProjectName.Text = projectData.ProjectName;
            //工数
            this.TxtHour.Text = projectData.Hour.ToString();
            //概要
            this.TxtSummary.Text = projectData.Summary;
            //開始日時
            this.DateStartDate.Value = projectData.StartDate;
            //終了日時
            this.DateEndDate.Value = projectData.EndDate;
            //状態
            this.CmbStatus.Text = projectData.Status;
        }
    }
}
