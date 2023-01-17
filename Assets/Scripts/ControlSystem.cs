using UnityEngine;

namespace Julee
{
    /// <summary>
    /// 控制系統:控制玩家角色旋轉 發射彈珠行為
    /// </summary>
    public class ControlSystem : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("旋轉速度"), Range(0, 60)]
        private float speedTure = 10.5f;
        [SerializeField, Header("可發射彈珠數量"), Range(0, 100)]
        private int contMarbleTotal = 10;
        [SerializeField, Header("彈珠速度"), Range(0, 5000)]
        private int speedMarble = 1500;
        [SerializeField, Header("發射間隔"), Range(0, 0.5f)]
        private float intervalshoot = 0.5f;
        [SerializeField, Header("彈珠預置物")]
        private GameObject prefabMarble;

        private string parAttack = "觸發攻擊";
        #endregion

        #region 事件
        #endregion

        #region 方法
        #endregion
    }
}
