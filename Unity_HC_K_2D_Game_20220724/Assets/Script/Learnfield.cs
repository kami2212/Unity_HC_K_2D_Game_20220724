using UnityEngine;

namespace Su
{   /// <summary>
    /// �ǲ����
    /// </summary>
    public class Learnfield : MonoBehaviour
    {
        #region ���y�k
        int number;

        //public ��Ƥ��}
        //private �������(�ʸ�)

        public int Carcc = 1500;
        public float weight = 3.5f;
        public string brand = "BMW";
        public bool hasSkyWindow = true;

        //[Header(���i)]���D
        //[Tooltip(���i)]����
        //[Range(min,max)]�d��
        //[SerializeField]�N���ê��ƭ����,�p�n�T�w�i�[Range

        [Header("����"),Tooltip("�����O")]
        public int attack = 200;
        [Tooltip("���m�O")]
        public int Defence = 50;
        [Tooltip("���B")]
        public int Luck = 30;
        [Range(0,100),Tooltip("��q")]
        public int Hp = 100;

        [SerializeField]
        private int speed = 10;
        #endregion

        #region Unity��¦�y�k

        //���w����
        public GameObject goCamera;

        //�C��
        public Color colorRed = Color.red;
        public Color colorYellow = Color.yellow;
        public Color colorCustom1 = new Color(0.5f, 0.5f, 0.5f);
        public Color colorCustom2 = new Color(0, 0, 1, 0.5f);
        
        //2���y��
        public Vector2 V2right = Vector2.right;
        public Vector2 V2left = Vector2.left;
        public Vector2 V2Custom = new Vector2(2,1);
        
        //3�B4���y��
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

