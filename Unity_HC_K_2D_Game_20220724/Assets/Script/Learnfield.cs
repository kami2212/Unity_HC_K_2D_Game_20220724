using UnityEngine;

namespace Su
{   /// <summary>
    /// 學習欄位
    /// </summary>
    public class Learnfield : MonoBehaviour
    {
        #region 欄位語法
        int number;

        //public 資料公開
        //private 資料隱藏(封裝)

        public int Carcc = 1500;
        public float weight = 3.5f;
        public string brand = "BMW";
        public bool hasSkyWindow = true;

        //[Header(都可)]標題
        //[Tooltip(都可)]註釋
        //[Range(min,max)]範圍
        //[SerializeField]將隱藏的數值顯示,如要固定可加Range

        [Header("角色"),Tooltip("攻擊力")]
        public int attack = 200;
        [Tooltip("防禦力")]
        public int Defence = 50;
        [Tooltip("幸運")]
        public int Luck = 30;
        [Range(0,100),Tooltip("血量")]
        public int Hp = 100;

        [SerializeField]
        private int speed = 10;
        #endregion

        #region Unity基礎語法

        //指定物件
        public GameObject goCamera;

        //顏色
        public Color colorRed = Color.red;
        public Color colorYellow = Color.yellow;
        public Color colorCustom1 = new Color(0.5f, 0.5f, 0.5f);
        public Color colorCustom2 = new Color(0, 0, 1, 0.5f);
        
        //2維座標
        public Vector2 V2right = Vector2.right;
        public Vector2 V2left = Vector2.left;
        public Vector2 V2Custom = new Vector2(2,1);
        
        //3、4維座標
        public Vector3 V3Custom = new Vector3(0, 0, 1);
        public Vector4 V4Custom = new Vector4(0, 2, 1, 3);

        //
        public LayerMask Layer;

        public LightType LightType;
        public LightType LightTypeArea = LightType.Area;

        public KeyCode keyA;
        public KeyCode jump = KeyCode.Space;

        public Transform tri;
        public Animator ani;
        public SpriteRenderer spi;

        #endregion
    }
}  

