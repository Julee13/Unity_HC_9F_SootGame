using UnityEngine;

namespace Julee
{
    /// <summary>
    /// 敵人受傷系統
    /// 1. 碰到彈珠會受傷
    /// 2. 死亡會機率性掉落金幣
    /// 3. 死亡會刪除物件
    /// </summary>
    public class DamageEnemy : DamageSystemBasic
    {
        private string nameMarble = "彈珠";


        // 1. 怪物與彈珠都要有 Collider
        // 2. 怪物與彈珠其中一個要有 Rigibody
        // 3. 兩這都沒有勾 Is Trigger
        private void OnCollisionEnter(Collision collision)
        {
            print($"<color=#6699ff>碰到物件 { collision.gameObject } </color>");

            // 如果 碰到物件的名稱 包含 彈珠 才會受傷
            // 包含 Contains 可放在字串後面
            if (collision.gameObject.name.Contains(nameMarble))
            {
                GetDamage(100);
            }
        }
    }
}
