using UnityEngine;

namespace Julee
{
    /// <summary>
    /// 基本資料:血量與攻擊力
    /// </summary>
    //  腳本畫物件 ScriptableObject
    //  1. 將繼承類別改為 ScriptableObject
    //  2. 添加類別屬性 CreateAssetMenu
    //  3. 屬性內使用 menuName 自訂菜單名稱

    [CreateAssetMenu(menuName = "Julee/Data Basic")]
    public class DataBasic : ScriptableObject
    {
        #region 資料
        [Header("血量"), Range(0, 1000)]
        public float hp = 200;
        [Header("攻擊力"), Range(10, 500)]
        public float attack = 50; 
        #endregion


    }
}