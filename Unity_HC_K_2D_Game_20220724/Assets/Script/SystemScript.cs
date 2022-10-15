using UnityEngine;
namespace Su
{
    public class SystemScript : MonoBehaviour
    {
        #region 資料
        [Range(0,10),Tooltip("移動速度"),SerializeField]
        private int MoveSpeed = 10;//移動速度
        [Tooltip("移動動畫參數名稱"), SerializeField]
        private string MoveName = "關關跑步";//移動動畫參數名稱

        private Rigidbody2D rig;//剛體元件
        private Animator ani;//動畫元件
        #endregion


        #region 方法
        /// <summary>
        /// 移動方法
        /// </summary>
        private void Move()
        {
            float h = Input.GetAxis("Horizontal");
            //print("水平數值:" + h);
            rig.velocity = new Vector2(h * MoveSpeed, rig.velocity.y);
            ani.SetBool(MoveName, h != 0);
            if (Mathf.Abs(h) < 0.1f) return;
            float yangle = h > 0 ? 0 : 180;
            transform.eulerAngles = new Vector3(0, yangle, 0);       
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
            Move();
        }
        #endregion

        private void OnDisable()
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            rig.velocity= new Vector2(0, 0);
            ani.SetBool(MoveName, false);
        }
    }
}

