using System;
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
        // 語法:修飾詞 傳回資料類型 方法名稱 (參數1，參數2，...參數n) { 程式內容 }
        // 無回傳 void:此方法不會回傳資料
        // 參數語法:類型 參數名稱

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
            #region 方法練習
            // 呼叫語法:
            // 方法名稱:
            Test();
            Test();

            SkillFire();
            SkillIce();
            SkillThunder();

            // 呼叫參數的語法:
            // 方法名稱(對應的引數); - 必須放入跟參數相同類型的資料
            Skill("火", "轟轟轟");
            Skill("毒", "嘶嘶嘶");
            Skill("冰");            // 遇到有預設值參數可不填寫，會以預設值代入

            // 風，沒聲音，龍捲風
            Skill("風", effect: "龍捲風");

            // 使用傳回方法方式 1
            int result7 = Square(7);
            print("數字 7 的平方:" + result7);

            // 使用回傳方法方式 2
            print("數字 123 的平方:" + Square(123)); 
            #endregion

            // Julee BMI 146 42
            print("Julee 的 BMI:" + BMI(43, 1.46f));
            // Kate BMI 148 41
            print("Kate 的 BMI:" + BMI(41, 1.48f));
        }

        // 範例:
        // 火技能 冰技能 電技能
        // 轟轟轟 喀喀喀 滋滋滋
        #region 不使用參數的對照組
        private void SkillFire()
        {
            print("技能屬性:火");
            print("播放音效:轟轟轟");
        }

        private void SkillIce()
        {
            print("技能屬性:冰");
            print("播放音效:喀喀喀");
        }

        private void SkillThunder()
        {
            print("技能屬性:電");
            print("播放音效:滋滋滋");
        } 
        #endregion

        private void Skill(string type, string sound = "沒聲音", string effect = "沒特效")
        {
            print($"<color=yellow>技能屬性:{ type }</color>");
            print($"<color=#ff6699>播放音效:{ sound }</color>");
            print($"<color=#66ff99>播放特效:{ effect }</color>");
        }

        // 傳入數值，運算平方結果
        private int Square(int number)
        {
            return number * number;
        }

        // 計算 BMI:體重(公斤) / 身高(公尺) * 身高(公尺)

        // 除法 /
        // 乘法 *
        // 浮點數 float
        // 兩個參數:體重 身高
        /// <summary>
        /// 計算 BMI
        /// </summary>
        /// <param name="weight">體重，公斤</param>
        /// <param name="height">身高，公尺</param>
        /// <returns>BMI 結果</returns>
        private float BMI(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}
