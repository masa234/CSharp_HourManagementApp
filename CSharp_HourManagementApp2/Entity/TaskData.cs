using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HourManagementApp2.Entity
{
    public class TaskData
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// タスク名
        /// </summary>
        public string TaskName { get; set; }


        /// <summary>
        /// 工数
        /// </summary>
        public int Hour { get; set; }


        /// <summary>
        /// 概要
        /// </summary>
        public string Summary { get; set; }


        /// <summary>
        /// 投稿日時
        /// </summary>
        public DateTime InsertDate { get; set; }


        /// <summary>
        /// 更新日時
        /// </summary>
        public DateTime UpdateDate { get; set; }


        /// <summary>
        /// 状態
        /// </summary>
        public string Status { get; set; }
    }
}
