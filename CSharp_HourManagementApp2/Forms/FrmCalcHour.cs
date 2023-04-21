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
    public partial class FrmCalcHour : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmCalcHour(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }

        private void FrmCalcHour_Load(object sender, EventArgs e)
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

        private void CmbProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                Project project = new Project();

                //プロジェクト名をプロジェクトIDに変換
                long projectID = project.ProjectNameToID(this.CmbProjectName.Text);

                //合計工数を取得
                int sumHours = project.GetSumHours(projectID);

                //画面に設定
                this.LblHours.Text = sumHours.ToString() + "時間";
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
        /// 2023/04/21
        private void InitForm()
        {
            //コンボボックスの設定
            SetCmb();
        }


        /// <summary>
        /// コンボボックスの設定
        /// </summary>
        /// 2023/04/21
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
            commonFunc.SetCmb(this.CmbProjectName, projectNameList);
        }
    }
}
