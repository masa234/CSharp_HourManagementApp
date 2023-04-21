using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HourManagementApp2.Common
{
    public class Constant
    {
        /// <summary>
        /// バリデーションメッセージ
        /// </summary>
        public const string INVALID_USERNAME_LENGTH = "ユーザ名は1～255文字で指定してください。";
        public const string INVALID_PASSWORD_LENGTH = "パスワードは1～255文字で指定してください。";
        public const string INVALID_PROJECTNAME_LENGTH = "プロジェクト名は1～255文字で指定してください。";
        public const string INVALID_TASKNAME_LENGTH = "タスク名は1～255文字で指定してください。";
        public const string INVALID_SUMMARY_LENGTH = "概要は1～255文字で指定してください。";
        public const string INVALID_WIKI_LENGTH = "Wikiは1～1000文字で指定してください。";
        public const string HOUR_MUST_INPUT = "工数は必須です。";
        public const string STARTDATE_MUST_INPUT = "開始日時は必須です。";
        public const string ENDDATE_MUST_INPUT = "終了日時は必須です。";
        public const string STATUS_MUST_INPUT = "状態は必須です。";
        public const string PROJECTNAME_MUST_INPUT = "プロジェクト名は必須です。";
        public const string STATUS_MUST_IN_CMB = "状態はコンボボックスから選択してください。";
        public const string PROJECTNAME_MUST_IN_CMB = "プロジェクト名はコンボボックスから選択してください。";
        public const string START_DATE_MUST_BEFORE_END_DATE = "開始日時は終了日時より前でなければいけません。";
        /// <summary>
        /// 失敗メッセージ
        /// </summary>
        public const string FAILED_LOGIN = "ログインに失敗しました。";
        public const string FAILED_INSERT_PROJECT = "プロジェクト登録に失敗しました。";
        public const string FAILED_DELETE_PROJECT = "プロジェクト削除に失敗しました。";
        public const string FAILED_UPDATE_PROJECT = "プロジェクト更新に失敗しました。";
        public const string FAILED_INSERT_TASK = "タスク登録に失敗しました。";
        public const string FAILED_DELETE_TASK = "タスク削除に失敗しました。";
        public const string FAILED_UPDATE_TASK = "タスク更新に失敗しました。";
        public const string FAILED_OUTPUT_CSV = "CSV出力に失敗しました。";
        public const string FAILED_REQUEST_PROJECT = "プロジェクト応募に失敗しました。";
        public const string FAILED_UPDATE_WIKI = "Wiki更新に失敗しました。";
        /// <summary>
        /// 成功メッセージ
        /// </summary>
        public const string SUCCESS_INSERT_PROJECT = "プロジェクト登録に成功しました。";
        public const string SUCCESS_UPDATE_PROJECT = "プロジェクト更新に成功しました。";
        public const string SUCCESS_INSERT_TASK = "タスク登録に成功しました。";
        public const string SUCCESS_DELETE_TASK = "タスク削除に成功しました。";
        public const string SUCCESS_UPDATE_TASK = "タスク更新に成功しました。";
        public const string SUCCESS_OUTPUT_CSV = "CSV出力に成功しました。";
        public const string SUCCESS_REQUEST_PROJECT = "プロジェクト応募に成功しました。";
        public const string SUCCESS_UPDATE_WIKI = "Wiki更新に成功しました。";
        /// <summary>
        /// 最大文字数
        /// </summary>
        public const long USERNAME_MAX_LENGTH = 255;
        public const long PASSWORD_MAX_LENGTH = 255;
        public const long PROJECTNAME_MAX_LENGTH = 255;
        public const long SUMMARY_MAX_LENGTH = 255;
        public const long TASKNAME_MAX_LENGTH = 255;
        public const long WIKI_MAX_LENGTH = 1000;
        /// <summary>
        /// 接続文字列
        /// </summary>
        public const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=testDB4;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        /// <summary>
        /// メッセージタイトル
        /// </summary>
        public const string CONFIRM = "確認";
        public const string WARNING = "警告";
        /// <summary>
        /// その他
        /// </summary>
        public const long LOCK_COUNT = 3;
        public const string USER_IS_LOCKED = "アカウントがロックされています。管理者に問い合わせてください。";
        public const string USER_IS_LOCK = "アカウントがロックされました。管理者に問い合わせてください。";
        public const string OUTPUT_CSV_PATH = "\"C:\\Users\\bfmt1\\OneDrive\\デスクトップ";
        /// <summary>
        /// SQL
        /// </summary>
        public const string GET_USER_COUNT_SQL = "SELECT " +
                                               "    COUNT(*)" +
                                               "  FROM" +
                                               "    Users " +
                                               "  WHERE " +
                                               "    UserName = @UserName " +
                                               "  AND" +
                                               "    Password = @Password";
        public const string GET_USERID_SQL = "SELECT " +
                                            "   Id " +
                                            " FROM " +
                                            "   Users " +
                                            " WHERE " +
                                            "   UserName = @UserName " +
                                            " AND" +
                                            "   Password = @Password";
        public const string GET_USERNAME_COUNT_SQL = "SELECT " +
                                                    "   COUNT(*) " +
                                                    " FROM " +
                                                    "   Users " +
                                                    " WHERE " +
                                                    "   UserName = @UserName ";
        public const string GET_LOCKFLAG_SQL = "SELECT " +
                                        "     LockFlag " +
                                        "   FROM " +
                                        "     Users " +
                                        "   WHERE " +
                                        "     UserName = @UserName ";
        public const string GET_ADMIN_SQL = " SELECT " +
                                            "   Admin " +
                                            " FROM " +
                                            "   Users " +
                                            " WHERE " +
                                            "   Id = @Id ";
        public const string GET_USERNAME_SQL = "SELECT " +
                                            "     UserName " +
                                            "   FROM " +
                                            "     Users " +
                                            "   WHERE " +
                                            "     Id = @Id ";
        public const string GET_LOCKED_USERS_SQL = "SELECT " +
                                                "     Id, " +
                                                "     UserName, " +
                                                "     Password " +
                                                "   FROM " +
                                                "     Users " +
                                                "   WHERE " +
                                                "     LockFlag = @LockFlag " +
                                                "   ORDER BY " +
                                                "     Id ASC ";
        public const string UPDATE_LOCKFLAG_SQL = "UPDATE " +
                                                "    Users " +
                                                "  SET " +
                                                "    LockFlag = @LockFlag " +
                                                "  WHERE " +
                                                "    UserName = @UserName ";
        public const string INSERT_PROJECT_SQL = "INSERT " +
                                                "   INTO " +
                                                " Projects " +
                                                "   (ProjectName, " +
                                                "   Hour, " +
                                                "   Summary, " +
                                                "   StartDate, " +
                                                "   EndDate, " +
                                                "   Status, " +
                                                "   Notification_Flag, " +
                                                "   Display_Flag) " +
                                                " VALUES" +
                                                "   (@ProjectName, " +
                                                "   @Hour, " +
                                                "   @Summary, " +
                                                "   @StartDate, " +
                                                "   @EndDate, " +
                                                "   @Status, " +
                                                "   @Notification_Flag, " +
                                                "   @Display_Flag) ";
        public const string GET_PROJECTS_SQL = "SELECT " +
                                            "     Id, " +
                                            "     ProjectName, " +
                                            "     Hour, " +
                                            "     Summary, " +
                                            "     StartDate, " +
                                            "     EndDate, " +
                                            "     Status " +
                                            "   FROM " +
                                            "     Projects " +
                                            "   WHERE " +
                                            "     Display_Flag = @Display_Flag ";
        public const string GET_PROJECT_SQL = "SELECT " +
                                            "    Id, " +
                                            "    ProjectName, " +
                                            "    Hour, " +
                                            "    Summary, " +
                                            "    StartDate, " +
                                            "    EndDate, " +
                                            "    Status " +
                                            "  FROM " +
                                            "    Projects " +
                                            "  WHERE " +
                                            "    Id = @Id ";
        public const string GET_PROJECTID_SQL = "SELECT " +
                                            "      Id " +
                                            "    FROM " +
                                            "      Projects " +
                                            "    WHERE " +
                                            "      ProjectName = @ProjectName ";
        public const string GET_TODAY_PROJECT_COUNT_SQL = "SELECT " +
                                                        "    COUNT(*) " +
                                                        "  FROM " +
                                                        "    Projects " +
                                                        "  WHERE " +
                                                        "    EndDate = @EndDate " +
                                                        "  AND " +
                                                        "    Notification_Flag = @Notification_Flag ";
        public const string GET_TODAY_PROJECT_SQL = "SELECT " +
                                                    "  ProjectName " +
                                                    "FROM " +
                                                    "  Projects " +
                                                    "WHERE " +
                                                    "  EndDate = @EndDate " +
                                                    "AND " +
                                                    "  Notification_Flag = @Notification_Flag ";
        public const string GET_PROJECTWIKI_SQL = "SELECT " +
                                                "    Wiki " +
                                                "  FROM " +
                                                "    Projects " +
                                                "  WHERE " +
                                                "    Id = @Id ";
        public const string GET_SUM_PROJECT_HOURS_SQL = "SELECT " +
                                                    "      SUM(Hour) " +
                                                    "    FROM " +
                                                    "      Tasks " +
                                                    "    WHERE " +
                                                    "      Project_Id = @Project_Id ";
        public const string DELETE_PROJECT_SQL = "DELETE " +
                                                "   FROM " +
                                                " Projects " +
                                                " WHERE " +
                                                "   Id = @Id ";
        public const string UPDATE_PROJECT_SQL = "UPDATE " +
                                                "   Projects " +
                                                " SET " +
                                                "   ProjectName = @ProjectName, " +
                                                "   Hour = @Hour, " +
                                                "   Summary = @Summary, " +
                                                "   StartDate = @StartDate, " +
                                                "   EndDate = @EndDate, " +
                                                "   Status = @Status " +
                                                " WHERE " +
                                                "   Id = @Id ";
        public const string UPDATE_PROJECTWIKI_SQL = "UPDATE " +
                                                    "   Projects " +
                                                    " SET " +
                                                    "   Wiki = @Wiki " +
                                                    " WHERE " +
                                                "   Id = @Id ";
        public const string INSERT_TASK_SQL = "INSERT " +
                                            "    INTO " +
                                            "  Tasks " +
                                            "    (TaskName, " +
                                            "    Hour, " +
                                            "    Summary, " +
                                            "    InsertDate, " +
                                            "    UpdateDate, " +
                                            "    Status, " +
                                            "    Display_Flag, " +
                                            "    Project_Id) " +
                                            "  VALUES" +
                                            "    (@TaskName, " +
                                            "    @Hour, " +
                                            "    @Summary, " +
                                            "    @InsertDate, " +
                                            "    @UpdateDate, " +
                                            "    @Status, " +
                                            "    @Display_Flag, " +
                                            "    @Project_Id) ";
        public const string GET_TASKS_SQL = "SELECT " +
                                            "  Id, " +
                                            "  TaskName, " +
                                            "  Hour, " +
                                            "  Summary, " +
                                            "  InsertDate, " +
                                            "  UpdateDate, " +
                                            "  Status " +
                                            "FROM " +
                                            "  Tasks " +
                                            "WHERE " +
                                            "  Project_Id = @Project_Id " +
                                            "AND " +
                                            "  Display_Flag = @Display_Flag ";
        public const string GET_TASK_SQL = "SELECT " +
                                        "     Id, " +
                                        "     TaskName, " +
                                        "     Hour, " +
                                        "     Summary, " +
                                        "     InsertDate, " +
                                        "     UpdateDate, " +
                                        "     Status " +
                                        "   FROM " +
                                        "     Tasks " +
                                        "   WHERE " +
                                        "     Id = @Id ";
        public const string GET_TASK_SEARCH_COUNT_SQL = "SELECT " +
                                                        "  COUNT(*) " +
                                                        "FROM " +
                                                        "  Tasks " +
                                                        "WHERE " +
                                                        "  Project_Id = @Project_Id " +
                                                        "AND " +
                                                        "  TaskName Like @TaskName ";
        public const string GET_SEARCH_TASK_SQL = "SELECT " +
                                                "    Id, " +
                                                "    TaskName, " +
                                                "    Hour, " +
                                                "    Summary, " +
                                                "    InsertDate, " +
                                                "    UpdateDate, " +
                                                "    Status " +
                                                "  FROM " +
                                                "    Tasks " +
                                                "  WHERE " +
                                                "    Project_Id = @Project_Id " +
                                                "  AND " +
                                                "    TaskName Like @TaskName ";
        public const string GET_SORTED_TASKS_SQL = "SELECT " +
                                                "     Id, " +
                                                "     TaskName, " +
                                                "     Hour, " +
                                                "     Summary, " +
                                                "     InsertDate, " +
                                                "     UpdateDate, " +
                                                "     Status " +
                                                "   FROM " +
                                                "     Tasks " +
                                                "   WHERE " +
                                                "     Project_Id = @Project_Id " +
                                                "   AND " +
                                                "     Display_Flag = @Display_Flag " +
                                                "   ORDER BY Status DESC ";
        public const string GET_ALL_ARCHIVED_TASKS_SQL = " SELECT " +
                                                        "    Id, " +
                                                        "    TaskName, " +
                                                        "    Hour, " +
                                                        "    Summary, " +
                                                        "    InsertDate, " +
                                                        "    UpdateDate, " +
                                                        "    Status " +
                                                        "  FROM " +
                                                        "    Tasks " +
                                                        "  WHERE " +
                                                        "    Display_Flag = @Display_Flag ";
        public const string DELETE_TASK_SQL = "DELETE " +
                                            "  FROM " +
                                            "    Tasks " +
                                            "  WHERE " +
                                            "    Id = @Id ";
        public const string UPDATE_TASK_SQL = "UPDATE " +
                                            "    Tasks " +
                                            "  SET " +
                                            "    TaskName = @TaskName, " +
                                            "    Hour = @Hour, " +
                                            "    Summary = @Summary, " +
                                            "    UpdateDate = @UpdateDate, " +
                                            "    Status = @Status " +
                                            "  WHERE " +
                                            "    Id = @Id ";
        public const string UPDATE_DISPLAY_FLAG_SQL = "UPDATE " +
                                                    "    Tasks " +
                                                    "  SET " +
                                                    "    Display_Flag = @Display_Flag " +
                                                    "  WHERE " +
                                                    "    Id = @Id ";
        public const string INSERT_REQUEST_SQL = "INSERT " +
                                                "   INTO " +
                                                " Requests " +
                                                "   (Project_Id, " +
                                                "   User_Id, " +
                                                "   ProjectName, " +
                                                "   IsNotification) " +
                                                " VALUES" +
                                                "   (@Project_Id, " +
                                                "   @User_Id, " +
                                                "   @ProjectName, " +
                                                "   @IsNotification) ";
        public const string GET_REQUEST_COUNT_SQL = "SELECT " +
                                                "      COUNT(*) " +
                                                "    FROM " +
                                                "      Requests " +
                                                "    WHERE " +
                                                "      IsNotification = @IsNotification ";
        public const string GET_NOT_NOTIFIED_REQUEST_SQL = "SELECT " +
                                                        "     User_Id, " +
                                                        "     ProjectName " +
                                                        "   FROM " +
                                                        "     Requests " +
                                                        "   WHERE " +
                                                        "     IsNotification = @IsNotification ";
        public const string UPDATE_ALL_NOTIFICATION_SQL = "UPDATE " +
                                                         "   Requests " +
                                                         " SET " +
                                                         "   IsNotification = @IsNotification ";
    }
}
