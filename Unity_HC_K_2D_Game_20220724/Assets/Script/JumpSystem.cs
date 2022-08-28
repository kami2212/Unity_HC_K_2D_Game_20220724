using UnityEngine;
namespace Su
{
    public class JumpSystem : MonoBehaviour
    {
        #region ���
        [Range(0, 1000), Tooltip("���D����"), SerializeField]
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
        [SerializeField] private Vector3 backgroundsize;
        [SerializeField] private Vector3 backgroundoffset;
        [SerializeField, Header("�����a�O�ϼh")]
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

        #region ��k
        /// <summary>
        /// ���D��k
        /// </summary>
        private void Jump()
        {
            if (isGround && Input.GetKey(KeyCode.Space))
            {
                rig.AddForce(new Vector2(0,jump));
            }
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
            Groundhit();
            Jump();
        }
        #endregion

    }
}

