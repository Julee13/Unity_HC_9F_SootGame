﻿using UnityEngine;

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

        // => Lambda 黏巴達
        // 轉換資料類型
        // (想要轉換的資料類型)資料名稱
        private DataEnemy dataEnemy => (DataEnemy)data;

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
                // 先取得要播放聲音再播放
                AudioClip sound = SoundSystem.instance.soundEnemyHurt;
                SoundSystem.instance.PlaySound(0.7f, 1.2f, sound);

                // 受到 玩家控制系統攻擊力 的傷害
                GetDamage(ControlSystem.instance.data.attack);
            }
        }

        // override 加上空格後可以選取可覆寫的內容
        protected override void Dead()
        {
            // base 父類別原有的內容
            base.Dead();

            // 先取得要播放聲音再播放
            AudioClip sound = SoundSystem.instance.soundEnemyDead;
            SoundSystem.instance.PlaySound(0.7f, 1.2f, sound);

            // 呼叫掉落金幣
            DropCoin();

            // 刪除此物件
            Destroy(gameObject);
        }

        /// <summary>
        /// 掉落金幣
        /// </summary>
        private void DropCoin()
        {
            // 判定是否再掉落機率類
            if (Random.value <= dataEnemy.coinProbability)
            {
                for (int i = 0; i < dataEnemy.coinDropCount; i++)
                {
                    int angle = Random.Range(0, 360);
                    // 就生成金幣在怪物頭上
                    Instantiate(
                        dataEnemy.prefabCoin,                              // 金幣
                        transform.position + new Vector3(0, 1.5f, 0),      // 座標 + 位移
                        Quaternion.Euler(90, angle, 0));                   // 歐拉角度(X，Y，Z)
                }
            }
        }
    }
}
