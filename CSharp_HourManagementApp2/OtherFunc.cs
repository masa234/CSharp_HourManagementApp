using CSharp_HourManagementApp2.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HourManagementApp2
{
    public class OtherFunc
    {
        /// <summary>
        /// 状態のリストを取得
        /// </summary>
        ///　2023/04/14
        public List<string> GetStatusList()
        {
            //リストを取得
            return new List<string>()
            {
                "未着手",
                "着手中",
                "完了"
            };
        }


        /// <summary>
        /// 状態をint型に変換する
        /// </summary>
        ///　2023/04/18
        public int StatusToInt(string strStatus)
        {
            //値によって分岐
            switch (strStatus)
            {
                case "未着手":
                    return (int)EnumValue.Status.NotBegin;
                case "着手中":
                    return (int)EnumValue.Status.Begin;
                case "完了":
                    return (int)EnumValue.Status.Done;
            }

            return 0;
        }


        /// <summary>
        /// 状態をString型に変換する
        /// </summary>
        ///　2023/04/18
        public string StatusToString(int intStatus)
        {
            //値によって分岐
            switch (intStatus)
            {
                case (int)EnumValue.Status.NotBegin:
                    return "未着手";
                case (int)EnumValue.Status.Begin:
                    return "着手中";
                case (int)EnumValue.Status.Done:
                    return "完了";
            }

            return string.Empty;
        }
    }
}
