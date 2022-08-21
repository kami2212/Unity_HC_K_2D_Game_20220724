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
            
        }
        #endregion

        #region 事件
        private void Awake()
        {
            
        }
        private void Update()
        {
            
        }
        #endregion

    }
}

