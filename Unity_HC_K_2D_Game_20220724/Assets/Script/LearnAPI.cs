using UnityEngine;

namespace Su
{
    /// <summary>
    /// 學習API靜態
    /// </summary>
    public class LearnAPI : MonoBehaviour
    {
        private void Start()
        {
            //靜態屬性
            //1.取得 Get
            //語法:類別名稱.靜態屬性
            print($"<color=red>{Random.value}</color>");

            //2.設定(Read Only不能設定)
            //語法:類別名稱.靜態屬性 指定 值;
            Cursor.visible = false;
        }

        private void Update()
        {
            //靜態方法
            //3.使用方法
            //語法:類別名稱.靜態方法(對應引數)
            print(Random.Range(0, 3));

        }
    }
}

