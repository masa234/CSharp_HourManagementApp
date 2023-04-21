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
    public class Request
    {
        /// <summary>
        /// リクエスト登録
        /// </summary>
        /// 2023/04/20
        public bool InsertRequest(string projectName,
                                long loginUserID)
        {
            //インスタンス化
            Project project = new Project();

            //プロジェクト名をIDに変換
            long projectID = project.ProjectNameToID(projectName);

            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Project_Id", projectID),
                new SqlParameter("ProjectName", projectName),
                new SqlParameter("User_Id", loginUserID),
                new SqlParameter("IsNotification", EnumValue.IsNotification.NotNotified)
            };

            //SQL取得
            string sql = Constant.INSERT_REQUEST_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// リクエストが存在するかどうか?
        /// </summary>
        /// 2023/04/20
        public bool IsExistsRequest()
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("IsNotification", EnumValue.IsNotification.NotNotified)
            };

            //SQL取得
            string sql = Constant.GET_REQUEST_COUNT_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(件数)を取得
            long requestCount = db.ExecuteScalar(sql, paramList);

            //件数が1件以上かどうか?
            if (1 <= requestCount)
                return true;

            return false; 
        }


        /// <summary>
        /// 通知
        /// </summary>
        /// 2023/04/20
        public void Notification()
        {
            //リクエストリストを取得
            List<RequestData> requestList = this.GetRequestList();

            //通知文言を作成
            string messageStr = this.GetNotificationStr(requestList);

            //通知    
            MessageBox.Show(messageStr,
                        Constant.CONFIRM,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }


        /// <summary>
        /// リクエストリストを取得
        /// </summary>
        /// 2023/04/20
        private List<RequestData> GetRequestList()
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("IsNotification", EnumValue.IsNotification.NotNotified)
            };

            //SQL取得
            string sql = Constant.GET_NOT_NOTIFIED_REQUEST_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(データ)を取得
            using (DataTable dt = db.GetDt(sql, paramList))
            {
                //リクエストリストに変換
                List<RequestData> requestList = this.DtToRequestList(dt);

                return requestList;
            }
        }


        /// <summary>
        /// データテーブルをリクエストリストに変換
        /// </summary>
        /// 2023/04/20
        private List<RequestData> DtToRequestList(DataTable dt)
        {
            //リスト作成
            List<RequestData> requestList = new List<RequestData>();

            //インスタンス化
            User user = new User();

            //データテーブルの行数分繰り返す
            foreach (DataRow row in dt.Rows)
            {
                //インスタンス化
                RequestData requestData = new RequestData();

                //設定
                //ユーザ名
                long.TryParse(row["User_Id"].ToString(), out long id);
                requestData.UserName = user.IDToUserName(id);
                //プロジェクト名
                requestData.ProjectName = row["ProjectName"].ToString();

                //リストに追加
                requestList.Add(requestData);
            }

            return requestList;
        }


        /// <summary>
        /// 通知文言を作成
        /// </summary>
        /// 2023/04/20
        private string GetNotificationStr(List<RequestData> requestList)
        {
            //文言初期化
            string retStr = string.Empty;

            //リクエストリストの要素数だけ繰り返す
            foreach (RequestData request in requestList)
            {
                //文言追加
                retStr = retStr + "【プロジェクト名】" + request.ProjectName + Environment.NewLine;
                retStr = retStr + "【ユーザ名】" + request.UserName + Environment.NewLine;

            }

            return retStr;
        }


        /// <summary>
        /// 通知状態を更新
        /// </summary>
        /// 2023/04/20
        public void UpdateNotification()
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("IsNotification", EnumValue.IsNotification.NotNotified)
            };

            //SQL取得
            string sql = Constant.UPDATE_ALL_NOTIFICATION_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);
        }
    }
}
