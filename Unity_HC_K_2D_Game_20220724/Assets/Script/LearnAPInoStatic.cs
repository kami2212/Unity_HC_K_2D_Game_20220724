using UnityEngine;

namespace Su
{
    /// <summary>
    /// 學習非靜態 API
    /// 與靜態的區別:需要實體物件
    /// </summary>
    public class LearnAPInoStatic : MonoBehaviour
    {
        //1.該類別的欄位
        //2.屬性面板需取得實體物件
        //3.使用非靜態屬性或方法
        public GameObject gowitch;
        public Camera cma;
        public SphereCollider sphereCollider;
        public Transform capsuleCollider;
        public Transform trasphere, trasqure;
        public Rigidbody rigcapsule;

        private void Start()
        {
            //非靜態屬性
            //1.取得 Get
            //語法:欄位名稱.非靜態屬性
            print($"巫師圖層{gowitch.layer}");

            //2.設定
            //語法:欄位名稱.非靜態屬性 指定 值;
            gowitch.layer = 4;

            gowitch.SetActive(false);

            print($"攝影機深度{cma.depth}");
            print($"球體半徑{sphereCollider.radius}");

            cma.backgroundColor = Random.ColorHSV();
            capsuleCollider.localScale = new Vector3(3, 2, 1);
        }
        private void Update()
        {
            trasqure.RotateAround(trasphere.position, trasphere.forward, 1);
            rigcapsule.AddForce(new Vector3(0, 5, 0));
        }
    }

}
