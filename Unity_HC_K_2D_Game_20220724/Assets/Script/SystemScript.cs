using UnityEngine;
namespace Su
{
    public class SystemScript : MonoBehaviour
    {
        #region ���ʨt��
        [Range(0,10),Tooltip("���ʳt��"),SerializeField]
        private int MoveSpeed = 10;//���ʳt��
        [Tooltip("���ʰʵe�ѼƦW��"), SerializeField]
        private string MoveName = "�����]�B";//���ʰʵe�ѼƦW��
        private Rigidbody2D rig;//���餸��
        private Animator ani;//�ʵe����
        #endregion
    }
}

