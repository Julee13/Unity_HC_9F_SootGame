using UnityEngine;
using UnityEngine.Video;

namespace Julee
{
    /// <summary>
    /// 學習 Unity 常見的資料類型
    /// </summary>
    public class LearnDataType : MonoBehaviour
    {
        // 儲存資料如音樂影片圖片案件
        [Header("儲存資料類型")]
        public AudioClip sound;    // 可存放音樂 mp3 ogg avi
        public VideoClip video;    // 存放影片 mp4 ogg wmv
        public Sprite picture;     // 可存放圖片 png jpg psd
        public Material material;  // 可存放材質球
        public KeyCode key;        // 可存放滑鼠 鍵盤 搖桿

        // enum 列舉 (下拉選單)
        public KeyCode keyJump = KeyCode.Space;
        public KeyCode keyFire = KeyCode.Mouse0;   // 滑鼠左鍵

        [Header("顏色與座標")]
        public Color color;                                         // 預設顏色為黑色透明
        public Color red = Color.red;                               // 內建紅
        public Color yellow = Color.yellow;                         // 內建黃
        public Color colorCustom1 = new Color(1, 0.5f, 0);          // 自訂顏色 (R,G,B)
        public Color colorCustom2 = new Color(0, 0.5f, 1, 0.5f);    // 自訂顏色 (R,G,B,A)

        // 二維 三維 四維向量
        public Vector2 v2;
        public Vector3 v3;
        public Vector4 v4;

        public Vector3 v3Zero = Vector3.zero;  // 000
        public Vector3 v3One = Vector3.one;    // 111
        public Vector3 v3R = Vector3.right;    // 100 - X 右邊
        public Vector3 v3U = Vector3.up;       // 010 - Y 上方
        public Vector3 v3F = Vector3.forward;  // 001 - Z 前方

        public Vector3 v3Custom = new Vector3(0.5f, 99.9f, -3.35f);

        [Header("物件與元件")]
        // 物件: 場頸上的遊戲物件 傳案內的預置物
        public GameObject objectSpider;
        public GameObject prefabMarble;
        // 元件:物件屬性面板上可折疊的
        public Transform transformSpider;
        public Animator animatorSpider;
        public Camera cameraMain;
        public Light lightMain;
    }
}
