// 單行註解:說明
// Julee 2022.12.27
// 可放在程式上下或後面

using UnityEngine;  // 引用命名空間(倉庫) Unity 遊戲引擎(API)

// class 類別 等同於腳本 Script
// class 後面為腳本名稱須與檔案同名
public class FirstScripts : MonoBehaviour
{
    // Tab 縮排:大括號enter下一行
    // 格式化:Ctrl + K D (整理排版快捷鍵)

    // 大括號放置腳本內容
    private void Awake()
    {
        //此處要縮排兩次

        //輸出:將訊息顯示在Unity的控制台Console(Ctrl+shift+C)
        //輸出("文字訊息") 
        print("哈囉");
        print("2023");
        print("<color=#008080ff>新年快樂!</color>");
    }

    // 開始事件:在喚醒事件後執行一次
    private void Start()
    {
        print("<color=red>開始事件!</color>");

        // 計算1+2
        print("輸出1+2");
        print($"輸出{1 + 2}");
    }

    // 更新事件:一秒執行約60次，約60FPS
    private void Update()
    {
        print("<color=#3333ff>這是更新事件!</color>");
    }
}
