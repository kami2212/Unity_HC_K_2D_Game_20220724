using UnityEngine;


namespace Su
{
    /// <summary>
    /// �m��API
    /// </summary>
    public class PrapareAPI : MonoBehaviour
    {
        // Start is called before the first frame update
        private Vector3 v3a = new Vector3(1, 1, 1);
        private Vector3 v3b = new Vector3(22, 22, 22);
        void Start()
        {
            print($"��v���ƶq{Camera.allCamerasCount}");
            print($"���x{Application.platform}");
            Physics.sleepThreshold = 10;
            Time.timeScale = 0.5f;
            print(Mathf.Round(9.999f));
            print(Mathf.Ceil(9.999f));
            print(Mathf.Floor(9.999f));
            print($"���o���I���Z��{Vector3.Distance(v3a,v3b)}");
            Application.OpenURL("https://unity.com/");
        }

        // Update is called once per frame
        void Update()
        {
            print($"�O�_��J���N��{Input.anyKey}");
            print($"�C���g�L�ɶ�{Time.time}");
            print($"�O�_���U�ť���{Input.GetKeyDown(KeyCode.Space)}");
        }
    }
} 

