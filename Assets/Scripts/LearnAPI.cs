using UnityEngine;

namespace Julee
{
    /// <summary>
    /// 學習非靜態 API
    /// 指遊戲內的實體物件，所以使用這類的 API 前會先需要有一個物件
    /// </summary>
    public class LearnAPI : MonoBehaviour
    {
        public Transform Bear;  // 資料類型決定就是 API 的類型

        public Camera mainCamera;

        public Transform spiderGreen;

        private void Awake()
        {
            // 步驟 1. 先確定場頸上有實體物件存在
            // 步驟 2. 定義該物件的欄位 (決定資料類型)
            // 步驟 3. 存取非靜態屬性或方法

            // 非靜態屬性 Properties
            // 1. 取得非靜態屬性
            // 語法:
            // 欄位名稱.非靜態屬性
            print($"<color=#ff6633>Bear 的座標: { Bear.position }</color>");

            print($"<color=#ff6633>攝影機的深度: { mainCamera.depth }</color>");

            // 2. 取得非靜態屬性
            // 語法:
            // 欄位名稱.非靜態屬性 指定 值
            spiderGreen.localScale = Vector3.one * 10;
        }
    }
}