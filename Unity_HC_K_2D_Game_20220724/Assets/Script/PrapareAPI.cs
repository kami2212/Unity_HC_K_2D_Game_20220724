using UnityEngine;


namespace Su
{
    /// <summary>
    /// 練習API
    /// </summary>
    public class PrapareAPI : MonoBehaviour
    {
        // Start is called before the first frame update
        private Vector3 v3a = new Vector3(1, 1, 1);
        private Vector3 v3b = new Vector3(22, 22, 22);
        void Start()
        {
            print($"攝影機數量{Camera.allCamerasCount}");
            print($"平台{Application.platform}");
            Physics.sleepThreshold = 10;
            Time.timeScale = 0.5f;
            print(Mathf.Round(9.999f));
            print(Mathf.Ceil(9.999f));
            print(Mathf.Floor(9.999f));
            print($"取得兩點的距離{Vector3.Distance(v3a,v3b)}");
            Application.OpenURL("https://unity.com/");
        }

        // Update is called once per frame
        void Update()
        {
            print($"是否輸入任意鍵{Input.anyKey}");
            print($"遊戲經過時間{Time.time}");
            print($"是否按下空白鍵{Input.GetKeyDown(KeyCode.Space)}");
        }
    }
} 

