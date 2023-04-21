using CSharp_HourManagementApp2.Common;
using CSharp_HourManagementApp2.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HourManagementApp2
{
    public class Project
    {
        /// <summary>
        /// プロジェクト登録
        /// </summary>
        ///　2023/04/18
        public bool InsertProject(string projectName,
                                    int hour,
                                    string summary,
                                    DateTime startDate,
                                    DateTime endDate,
                                    string strStatus)
        {
            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //状態をint型にする
            int intStatus = otherFunc.StatusToInt(strStatus);

            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("ProjectName", projectName),
                new SqlParameter("Hour", hour),
                new SqlParameter("Summary", summary),
                new SqlParameter("StartDate", startDate),
                new SqlParameter("EndDate", endDate),
                new SqlParameter("Status", intStatus),
                new SqlParameter("Notification_Flag", EnumValue.IsNotification.NotNotified),
                new SqlParameter("Display_Flag", EnumValue.IsVisible.Visible)
            };

            //SQL取得
            string sql = Constant.INSERT_PROJECT_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// プロジェクト一覧取得
        /// </summary>
        ///　2023/04/18
        public List<ProjectData> GetProjectList()
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Display_Flag", EnumValue.IsVisible.Visible)
            };

            //SQL取得
            string sql = Constant.GET_PROJECTS_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(データ)を取得
            using (DataTable dt = db.GetDt(sql, paramList))
            {
                //プロジェクトリストに変換
                List<ProjectData> projectList = this.DtToProjectList(dt);

                return projectList;
            }
        }


        /// <summary>
        /// データテーブルをプロジェクトリストに変換する
        /// </summary>
        ///　2023/04/18
        private List<ProjectData> DtToProjectList(DataTable dt)
        {
            //リスト作成
            List<ProjectData> projectList = new List<ProjectData>();

            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //データテーブルの行数分繰り返す
            foreach (DataRow row in dt.Rows)
            {
                //インスタンス化
                ProjectData projectData = new ProjectData();

                //設定
                //ID
                int.TryParse(row["Id"].ToString(), out int id);
                projectData.Id = id;
                //プロジェクト名
                projectData.ProjectName = row["ProjectName"].ToString();
                //工数
                int.TryParse(row["Hour"].ToString(), out int hour);
                projectData.Hour = hour;
                //概要
                projectData.Summary = row["Summary"].ToString();
                //開始日時
                DateTime.TryParse(row["StartDate"].ToString(), out DateTime startDate);
                projectData.StartDate = startDate;
                //終了日時
                DateTime.TryParse(row["EndDate"].ToString(), out DateTime endDate);
                projectData.EndDate = endDate;
                //状態
                int.TryParse(row["Status"].ToString(), out int status);
                projectData.Status = otherFunc.StatusToString(status);

                //リストに追加
                projectList.Add(projectData);
            }

            return projectList;
        }


        /// <summary>
        /// プロジェクト削除
        /// </summary>
        ///　2023/04/18
        public bool DeleteProject(long deleteProjectID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", deleteProjectID)
            };

            //SQL取得
            string sql = Constant.DELETE_PROJECT_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// プロジェクト取得
        /// </summary>
        ///　2023/04/18
        public ProjectData GetProject(long projectID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", projectID)
            };

            //SQL取得
            string sql = Constant.GET_PROJECT_SQL;

            //インスタンス化
            ProjectData projectData = new ProjectData();

            //インスタンス化
            DB db = new DB();

            //実行結果(リーダー)を取得
            using (SqlDataReader reader = db.ExecuteReader(sql, paramList))
            {
                //読み込める間、繰り返す
                while (reader.Read())
                {
                    //設定
                    //ID
                    int.TryParse(reader[0].ToString(), out int id);
                    projectData.Id = id;
                    //プロジェクト名
                    projectData.ProjectName = reader[1].ToString();
                    //工数
                    int.TryParse(reader[2].ToString(), out int hour);
                    projectData.Hour = hour;
                    //概要
                    projectData.Summary = reader[3].ToString();
                    //開始日時
                    DateTime.TryParse(reader[4].ToString(), out DateTime startDate);
                    projectData.StartDate = startDate;
                    //終了日時
                    DateTime.TryParse(reader[5].ToString(), out DateTime endDate);
                    projectData.EndDate = endDate;
                    //状態
                    int.TryParse(reader[6].ToString(), out int status);
                    //インスタンス化
                    OtherFunc otherFunc = new OtherFunc();
                    projectData.Status = otherFunc.StatusToString(status);

                    return projectData;
                }
            }

            return projectData; 
        }


        /// <summary>
        /// プロジェクト更新
        /// </summary>
        ///　2023/04/18
        public bool UpdateProject(string projectName,
                                    int hour,
                                    string summary,
                                    DateTime startDate,
                                    DateTime endDate,
                                    string strStatus,
                                    long updateProjectID)
        {
            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //状態をint型にする
            int intStatus = otherFunc.StatusToInt(strStatus);

            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("ProjectName", projectName),
                new SqlParameter("Hour", hour),
                new SqlParameter("Summary", summary),
                new SqlParameter("StartDate", startDate),
                new SqlParameter("EndDate", endDate),
                new SqlParameter("Status", intStatus),
                new SqlParameter("Notification_Flag", EnumValue.IsNotification.NotNotified),
                new SqlParameter("Display_Flag", EnumValue.IsVisible.Visible),
                new SqlParameter("Id", updateProjectID)
            };

            //SQL取得
            string sql = Constant.UPDATE_PROJECT_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// プロジェクトリストを文字列のリストに変換
        /// </summary>
        ///　2023/04/19
        public List<string> ProjectListToStringList(List<ProjectData> projectList)
        {
            //リスト作成
            List<string> retList = new List<string>();

            //プロジェクトリストの要素数だけ繰り返す
            foreach (ProjectData project in projectList)
            {
                //リストに追加(プロジェクト名)
                retList.Add(project.ProjectName);
            }

            return retList;
        }


        /// <summary>
        /// プロジェクト名をIDに変換
        /// </summary>
        ///　2023/04/19
        public long ProjectNameToID(string projectName)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("ProjectName", projectName)
            };

            //SQL取得
            string sql = Constant.GET_PROJECTID_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(リーダー)を取得
            using (SqlDataReader reader = db.ExecuteReader(sql, paramList))
            {
                //読み込める間、繰り返す
                while (reader.Read())
                {
                    //long型に変換
                    long.TryParse(reader[0].ToString(), out long result);

                    return result;
                }
            }

            return 0;
        }


        /// <summary>
        /// Wiki情報を取得
        /// </summary>
        ///　2023/04/20
        public string GetWiki(long projectID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", projectID)
            };

            //SQL取得
            string sql = Constant.GET_PROJECTWIKI_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(リーダー)を取得
            using (SqlDataReader reader = db.ExecuteReader(sql, paramList))
            {
                //読み込める間、繰り返す
                while (reader.Read())
                {
                    return reader[0].ToString();
                }
            }

            return string.Empty;
        }


        /// <summary>
        /// Wiki更新
        /// </summary>
        ///　2023/04/20
        public bool UpdateWIki(string wiki,
                                long projectID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Wiki", wiki),
                new SqlParameter("Id", projectID)
            };

            //SQL取得
            string sql = Constant.UPDATE_PROJECTWIKI_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// 通知されていない本日の案件が存在するか?
        /// </summary>
        ///　2023/04/20
        public bool IsExistsTodayProject()
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("EndDate", DateTime.Today),
                new SqlParameter("Notification_Flag", EnumValue.IsNotification.NotNotified)
            };

            //SQL取得
            string sql = Constant.GET_TODAY_PROJECT_COUNT_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(件数)を取得
            long projectCount = db.ExecuteScalar(sql, paramList);

            //件数が1件以上かどうか?
            if (1 <= projectCount)
                return true;

            return false;
        }


        /// <summary>
        /// 通知
        /// </summary>
        ///　2023/04/20
        public bool Notification()
        {
            //本日の案件リストを取得

            //通知文言作成

            //通知
        }


        /// <summary>
        /// 本日の案件リスト取得
        /// </summary>
        ///　2023/04/20
        public List<ProjectData> GetTodayProjectList()
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("EndDate", DateTime.Today),
                new SqlParameter("Notification_Flag", EnumValue.IsNotification.NotNotified)
            };

            //SQL取得
            string sql = Constant.GET_TODAY_PROJECT_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(データ)を取得
            using (DataTable dt = db.GetDt(sql, paramList))
            {
                //プロジェクトリストに変換
                List<ProjectData> projectList = this.DtToProjectList(dt);

                return projectList;
            }
        }
    }
}
