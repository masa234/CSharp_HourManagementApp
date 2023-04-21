using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HourManagementApp2.Entity
{
    public class ProjectData
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// プロジェクト名
        /// </summary>
        public string ProjectName { get; set; }


        /// <summary>
        /// 工数
        /// </summary>
        public int Hour { get; set; }


        /// <summary>
        /// 概要
        /// </summary>
        public string Summary { get; set; }


        /// <summary>
        /// 開始日時
        /// </summary>
        public DateTime StartDate { get; set; }


        /// <summary>
        /// 終了日時
        /// </summary>
        public DateTime EndDate { get; set; }


        /// <summary>
        /// 状態
        /// </summary>
        public string Status { get; set; }
    }
}
