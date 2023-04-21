using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HourManagementApp2.Common
{
    public class CommonFunc
    {
        /// <summary>
        /// 文字列がおさまっているかどうか?
        /// </summary>
        ///　2023/04/13 
        public bool IsFitInText(string str,
                                    long maxLength)
        {
            //空の場合
            if (String.IsNullOrEmpty(str))
                return false;

            //制限文字列を超えている場合
            if (maxLength < str.Length)
                return false;

            return true;
        }


        /// <summary>
        /// 画面遷移
        /// </summary>
        /// 2023/04/13 
        public void HideAndOpen(Form openedForm,
                                Form openForm)
        {
            //既に開いている画面を非表示にする
            openedForm.Hide();

            //画面を表示する
            openForm.Show();
        }


        /// <summary>
        /// コンボボックスの設定
        /// </summary>
        /// 2023/04/14 
        public void SetCmb(ComboBox cmb,
                           List<string> cmbTxtList)
        {
            //リストの要素数だけ繰り返す
            foreach (string cmbTxt in cmbTxtList)
            {
                //コンボボックスに追加
                cmb.Items.Add(cmbTxt);
            }
        }


        /// <summary>
        /// 安全にint型に変換する
        /// </summary>
        /// 2023/04/14 
        public int SafeCastInt(string str)
        {
            //int型に変換
            int.TryParse(str, out int result);

            //変換結果が0でない場合
            if (result != 0)
                return result;

            return 0;
        }


        /// <summary>
        /// 入力されているかどうか?
        /// </summary>
        /// 2023/04/14 
        public bool IsInputed(string str)
        {
            //空の場合
            if (String.IsNullOrEmpty(str))
                return false;

            return true;
        }


        /// <summary>
        /// コンボボックスの選択肢内かどうか
        /// </summary>
        ///　2023/04/18
        public bool IsTextInCmb(ComboBox cmb,
                                string str)
        {
            //リスト作成
            List<string> cmbTxtList = new List<string>();

            //コンボボックスの要素数だけ繰り返す
            foreach (string cmbTxt in cmb.Items)
            {
                //リストに追加
                cmbTxtList.Add(cmbTxt);
            }

            //リストに存在するかどうか?
            if (cmbTxtList.Contains(str))
                return true;

            return false;
        }
    }
}
