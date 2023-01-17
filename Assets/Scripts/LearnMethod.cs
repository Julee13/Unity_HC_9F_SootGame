using UnityEngine;

namespace Julee
{
    /// <summary>
    /// 學習方法，稱為:函式 功能
    /// Unity 稱為 Method or Function
    /// </summary>
    public class LearnMethod : MonoBehaviour
    {
        // 方法 Method
        // 作用:存放複雜的程式內容處理一些遊戲行為
        // ex:移動方法讓怪物移動，發射彈珠方法，生成並且發射彈珠
        // 語法:修飾詞 傳回資料類型 方法名稱 () { 程式內容 }
        // 無回傳 void:此方法不會回傳資料

        // 定義方法不會執行，需要呼叫他才會執行
        /// <summary>
        /// 這式測試方法
        /// </summary>
        private void Test()
        {
            print("<color=#ff6666>測試方法的內容。</color>");
        }

        private void Awake()
        {
            // 呼叫語法:
            // 方法名稱:
            Test();
            Test();
        }
    }
}
