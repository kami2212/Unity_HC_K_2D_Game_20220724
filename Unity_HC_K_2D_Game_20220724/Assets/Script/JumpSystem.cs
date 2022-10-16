using UnityEngine;
namespace Su
{
    public class JumpSystem : MonoBehaviour
    {
        #region 資料
        [Range(0, 1000), Tooltip("跳躍高度"), SerializeField]
        private float jump = 5;//移動速度
        [Tooltip("跳躍參數名稱"), SerializeField]
        private string JumpName = "關關跳躍";//移動動畫參數名稱

        private Rigidbody2D rig;//剛體元件
        private Animator ani;//動畫元件
        #endregion

        #region 地板資料
        [Header("地板顏色"), SerializeField]
        private Color background = new Color(1, 0, 0);
        [Header("地板尺寸")]
        [SerializeField] private Vector3 backgroundsize;
        [SerializeField] private Vector3 backgroundoffset;
        [SerializeField, Header("偵測地板圖層")]
        private LayerMask layerMask;
        private bool isGround;
        #endregion
        private void OnDrawGizmos()
        {
            Gizmos.color = background;
            Gizmos.DrawCube(transform.position + backgroundoffset, backgroundsize);
        }

        private void Groundhit()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + backgroundoffset, backgroundsize, 0, layerMask);
            //print(hit);
            isGround = hit;
        }

        #region 方法
        /// <summary>
        /// 跳躍方法
        /// </summary>
        private void Jump()
        {
            if (isGround && Input.GetKeyDown(KeyCode.Space))
            {
                rig.AddForce(new Vector2(0, jump));
            }
        }
        #endregion

        #region 事件
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            Groundhit();
            Jump();
        }
        #endregion

    }
}

