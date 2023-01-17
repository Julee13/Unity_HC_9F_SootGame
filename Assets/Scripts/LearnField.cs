using UnityEngine;

namespace Julee
{
    /// <summary>
    /// 摘要:不是必要但很重要!
    /// 學習欄位Field
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        #region 認識欄位

        // 欄位Field
        // 作用:儲存資料
        // EX:等級攻擊力圖片特效音效...
        // 語法:
        // 修飾詞 資料類型 欄位名稱 指定 預設值；
        // 指定符號: =
        // 將右邊結果指定給左邊
        // 修飾詞介紹:
        // 私人:僅在此類別允許存取 (預設值)         private
        // 公開:所有類別允許存取，顯示在屬性面板     public

        // 整數 等級
        public int level = 1;

        // 四大常用資料類型
        // 整  數: int (inteager)
        // 儲存正負沒有小數點的數值。
        private int skillCount = 4;

        // 浮點數: float
        // 儲存正負有小數點的數值。
        public float speedWalk = 10.5f;         // 浮點數後面一訂要加 f
        public float speedRun = 30.25F;         // 可大可小

        // 字  串: string
        // 儲存文字訊息。
        public string namePlayer = "#Julee";    // 字串要放在一對雙引號內

        // 布林直: bool (boolean)
        // 儲存正與反。
        public bool isPass = false;             // 否
        public bool hasWeapon = true;           // 是
        #endregion

        #region 欄位屬性
        // 欄位屬性 Field Atteritube
        // 作用:輔助欄位如:添加標題說明範圍限制及空間等...
        // 語法:要放在欄位上方或前面
        // [屬性名字(值)]

        // [標題(字串)]
        [Header("玩家的血量")]
        public int hp = 100;

        public int 血量 = 999;  // 不建議，一個獨立開發，公司允許

        // [說明(字串)]
        [Tooltip("這是代表玩家現在傭有的武器名稱")]
        public string weapon = "美工刀";

        // [範圍(最小值，最大值)] - 僅限於數值類型資料如:int float
        [Range(0, 10)]
        public float speed = 3.5f;
        [Range(0, 10)]
        public bool isDead; //不能用在非數值資料上

        // [序列化] - 將私人資料顯示在屬性面板上，保護資料並且顯示在屬性面板上
        [SerializeField]
        private string prop = "紅色藥水";

        [SerializeField]
        [Header("敵人數量")]
        private int countEnemy = 3;

        [SerializeField, Header("關卡數量"), Range(0, 30)]
        private int numberLevel = 10;
        #endregion

        #region 事件
        // 快速添加區域的方式:框選後按 Ctrl + K S
        private void Awake()
        {
            // * Unity 資料以屬性面板為主!

            // 存取欄位 Get Set
            // 取得
            // 語法:欄位名稱
            print("等級:" + level);

            // 設定
            // 語法:欄位名稱 指定 值;
            isPass = true;
            namePlayer = "TJuLee";
        } 
        #endregion
    }
}
