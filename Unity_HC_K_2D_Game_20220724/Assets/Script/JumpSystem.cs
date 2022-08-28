using UnityEngine;
namespace Su
{
    public class JumpSystem : MonoBehaviour
    {
        #region ���
        [Range(0, 100), Tooltip("���D����"), SerializeField]
        private float jump = 5;//���ʳt��
        [Tooltip("���D�ѼƦW��"), SerializeField]
        private string JumpName = "�������D";//���ʰʵe�ѼƦW��

        private Rigidbody2D rig;//���餸��
        private Animator ani;//�ʵe����
        #endregion

        #region �a�O���
        [Header("�a�O�C��"), SerializeField]
        private Color background = new Color(1, 0, 0);
        [Header("�a�O�ؤo")]
        [SerializeField]private Vector3 backgroundsize;
        [SerializeField]private Vector3 backgroundoffset;

        private Rigidbody2D rig;//���餸��
        private Animator ani;//�ʵe����
        #endregion


        #region ��k
        /// <summary>
        /// ���D��k
        /// </summary>
        private void Jump()
        {
            
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
            Jump();
        }
        #endregion

    }
}

