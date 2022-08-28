using UnityEngine;
namespace Su
{
    public class SystemScript : MonoBehaviour
    {
        #region ���
        [Range(0,10),Tooltip("���ʳt��"),SerializeField]
        private int MoveSpeed = 10;//���ʳt��
        [Tooltip("���ʰʵe�ѼƦW��"), SerializeField]
        private string MoveName = "�����]�B";//���ʰʵe�ѼƦW��

        private Rigidbody2D rig;//���餸��
        private Animator ani;//�ʵe����
        #endregion


        #region ��k
        /// <summary>
        /// ���ʤ�k
        /// </summary>
        private void Move()
        {
            float h = Input.GetAxis("Horizontal");
            //print("�����ƭ�:" + h);
            rig.velocity = new Vector2(h * MoveSpeed, rig.velocity.y);
            ani.SetBool(MoveName, h != 0);
            if (Mathf.Abs(h) < 0.1f) return;
            float yangle = h > 0 ? 0 : 180;
            transform.eulerAngles = new Vector3(0, yangle, 0);       
        }
        #endregion

        #region �ƥ�
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

    }
}

