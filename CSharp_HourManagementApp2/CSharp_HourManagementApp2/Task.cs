using CSharp_HourManagementApp2.Common;
using CSharp_HourManagementApp2.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HourManagementApp2
{
    public class Task
    {
        /// <summary>
        /// タスク登録
        /// </summary>
        ///　2023/04/19
        public bool InsertTask(string taskName,
                                int hour,
                                string summary,
                                string strStatus,
                                long projectID)
        {
            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //状態をint型にする
            int intStatus = otherFunc.StatusToInt(strStatus);

            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("TaskName", taskName),
                new SqlParameter("Hour", hour),
                new SqlParameter("Summary", summary),
                new SqlParameter("InsertDate", DateTime.Today),
                new SqlParameter("UpdateDate", DateTime.Today),
                new SqlParameter("Status", intStatus),
                new SqlParameter("Display_Flag", EnumValue.IsVisible.Visible),
                new SqlParameter("Project_Id", projectID)
            };

            //SQL取得
            string sql = Constant.INSERT_TASK_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// プロジェクトのタスク一覧取得
        /// </summary>
        ///　2023/04/19
        public List<TaskData> GetProjectTaskList(long projectID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Project_Id", projectID),
                new SqlParameter("Display_Flag", EnumValue.IsVisible.Visible)
            };

            //SQL取得
            string sql = Constant.GET_TASKS_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(データ)を取得
            using (DataTable dt = db.GetDt(sql, paramList))
            {
                //タスクリストに変換
                List<TaskData> taskList = this.DtToTaskList(dt);

                return taskList;
            }
        }


        /// <summary>
        /// データテーブルをタスクリストに変換
        /// </summary>
        ///　2023/04/19
        private List<TaskData> DtToTaskList(DataTable dt)
        {
            //リスト作成
            List<TaskData> taskList = new List<TaskData>();

            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //データテーブルの行数分繰り返す
            foreach (DataRow row in dt.Rows)
            {
                //インスタンス化
                TaskData taskData = new TaskData();

                //設定
                //ID
                int.TryParse(row["Id"].ToString(), out int id);
                taskData.Id = id;
                //タスク名
                taskData.TaskName = row["TaskName"].ToString();
                //工数
                int.TryParse(row["Hour"].ToString(), out int hour);
                taskData.Hour = hour;
                //概要
                taskData.Summary = row["Summary"].ToString();
                //投稿日時
                DateTime.TryParse(row["InsertDate"].ToString(), out DateTime insertDate);
                taskData.InsertDate = insertDate;
                //更新日時
                DateTime.TryParse(row["UpdateDate"].ToString(), out DateTime updateDate);
                taskData.UpdateDate = updateDate;
                //状態
                int.TryParse(row["Status"].ToString(), out int status);
                taskData.Status = otherFunc.StatusToString(status);

                //リストに追加
                taskList.Add(taskData);
            }

            return taskList;
        }


        /// <summary>
        /// タスク削除
        /// </summary>
        ///　2023/04/19
        public bool DeleteTask(long deleteTaskID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", deleteTaskID)
            };

            //SQL取得
            string sql = Constant.DELETE_TASK_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// タスク削除
        /// </summary>
        ///　2023/04/19
        public TaskData GetTask(long taskID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", taskID)
            };

            //SQL取得
            string sql = Constant.GET_TASK_SQL;

            //インスタンス化
            TaskData taskData = new TaskData();

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
                    taskData.Id = id;
                    //タスク名
                    taskData.TaskName = reader[1].ToString();
                    //工数
                    int.TryParse(reader[2].ToString(), out int hour);
                    taskData.Hour = hour;
                    //概要
                    taskData.Summary = reader[3].ToString();
                    //投稿日時
                    DateTime.TryParse(reader[4].ToString(), out DateTime insertDate);
                    taskData.InsertDate = insertDate;
                    //更新日時
                    DateTime.TryParse(reader[5].ToString(), out DateTime updateDate);
                    taskData.UpdateDate = updateDate;
                    //インスタンス化
                    OtherFunc otherFunc = new OtherFunc();
                    //状態
                    int.TryParse(reader[6].ToString(), out int status);
                    taskData.Status = otherFunc.StatusToString(status);

                    return taskData;
                }
            }

            return taskData;
        }


        /// <summary>
        /// タスク更新
        /// </summary>
        ///　2023/04/19
        public bool UpdateTask(string taskName,
                                int hour,
                                string summary,
                                string strStatus,
                                long projectID,
                                long updateTaskID)
        {
            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //状態をint型にする
            int intStatus = otherFunc.StatusToInt(strStatus);

            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("TaskName", taskName),
                new SqlParameter("Hour", hour),
                new SqlParameter("Summary", summary),
                new SqlParameter("UpdateDate", DateTime.Today),
                new SqlParameter("Status", intStatus),
                new SqlParameter("Project_Id", projectID),
                new SqlParameter("Id", updateTaskID)
            };

            //SQL取得
            string sql = Constant.UPDATE_TASK_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// 検索結果(件数)を取得
        /// </summary>
        ///　2023/04/19
        public long GetSearchCount(long projectID,
                                    string searchTaskName)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Project_Id", projectID),
                new SqlParameter("TaskName", searchTaskName)
            };

            //SQL取得
            string sql = Constant.GET_TASK_SEARCH_COUNT_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(件数)を取得
            return db.ExecuteScalar(sql, paramList);
        }


        /// <summary>
        /// 検索結果を取得
        /// </summary>
        ///　2023/04/19
        public List<TaskData> FilterTaskList(long projectID,
                                    string searchTaskName)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Project_Id", projectID),
                new SqlParameter("TaskName", searchTaskName)
            };

            //SQL取得
            string sql = Constant.GET_SEARCH_TASK_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(データ)を取得
            using (DataTable dt = db.GetDt(sql, paramList))
            {
                //タスクリストに変換
                List<TaskData> taskList = this.DtToTaskList(dt);

                return taskList;
            }
        }


        /// <summary>
        /// タスク出力
        /// </summary>
        ///　2023/04/19
        public bool OutputCSV(List<TaskData> taskList,
                                string outputCSVPath)
        {
            //文字列のリストに変換
            List<string> outputList = this.TaskListToStringList(taskList);

            //区切り文字で区切る
            String.Join(",", outputList);

            //出力
            File.WriteAllLines(outputCSVPath, outputList);

            return true;
        }


        /// <summary>
        /// タスクリストを文字列のリストに変換
        /// </summary>
        ///　2023/04/19
        private List<string> TaskListToStringList(List<TaskData> taskList)
        {
            //リスト作成
            List<string> retList = new List<string>();

            //タスクリストの要素数だけ繰り返す
            foreach (TaskData task in taskList) 
            {
                //追加(タスク名)
                retList.Add(task.TaskName);
            }

            return retList;
        }


        /// <summary>
        /// ソート済みタスクリストを取得
        /// </summary>
        ///　2023/04/19
        public List<TaskData> GetSortedTaskList(long projectID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Project_Id", projectID),
                new SqlParameter("Display_Flag", EnumValue.IsVisible.Visible)
            };

            //SQL取得
            string sql = Constant.GET_SORTED_TASKS_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(データ)を取得
            using (DataTable dt = db.GetDt(sql, paramList))
            {
                //タスクリストに変換
                List<TaskData> taskList = this.DtToTaskList(dt);

                return taskList;
            }
        }


        /// <summary>
        /// アーカイブ化
        /// </summary>
        ///　2023/04/19
        public void Archive(long taskID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Display_Flag", EnumValue.IsVisible.NotVisible),
                new SqlParameter("Id", taskID)
            };

            //SQL取得
            string sql = Constant.UPDATE_DISPLAY_FLAG_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);
        }


        /// <summary>
        /// アーカイブされたタスク一覧を取得
        /// </summary>
        ///　2023/04/19
        public List<TaskData> GetAllArchivedTaskList()
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Display_Flag", EnumValue.IsVisible.NotVisible)
            };

            //SQL取得
            string sql = Constant.GET_ALL_ARCHIVED_TASKS_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(データ)を取得
            using (DataTable dt = db.GetDt(sql, paramList))
            {
                //タスクリストに変換
                List<TaskData> taskList = this.DtToTaskList(dt);

                return taskList;
            }
        }
    }
}
