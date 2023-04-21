using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HourManagementApp2.Common
{
    public class EnumValue
    {
        /// <summary>
        /// ロックされているかどうか?
        /// </summary>
        public enum IsLock
        {
            NotLock = 0,
            Locked = 1
        }


        /// <summary>
        /// ユーザ種類
        /// </summary>
        public enum UserType
        {
            Admin = 1,
            Normal = 2
        }


        /// <summary>
        /// 表示非表示
        /// </summary>
        public enum IsVisible
        {
            NotVisible = 0,
            Visible = 1
        }


        /// <summary>
        /// 通知したかどうか
        /// </summary>
        public enum IsNotification
        {
            NotNotified = 0,
            Notified = 1
        }


        /// <summary>
        /// 通知したかどうか
        /// </summary>
        public enum Status
        {
            NotBegin = 1,
            Begin = 2,
            Done = 3
        }
    }
}
