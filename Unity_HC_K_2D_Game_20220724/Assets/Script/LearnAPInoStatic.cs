using UnityEngine;

namespace Su
{
    /// <summary>
    /// �ǲ߫D�R�A API
    /// �P�R�A���ϧO:�ݭn���骫��
    /// </summary>
    public class LearnAPInoStatic : MonoBehaviour
    {
        //1.�����O�����
        //2.�ݩʭ��O�ݨ��o���骫��
        //3.�ϥΫD�R�A�ݩʩΤ�k
        public GameObject gowitch;
        public Camera cma;
        public SphereCollider sphereCollider;
        public Transform capsuleCollider;
        public Transform trasphere, trasqure;
        public Rigidbody rigcapsule;

        private void Start()
        {
            //�D�R�A�ݩ�
            //1.���o Get
            //�y�k:���W��.�D�R�A�ݩ�
            print($"�Ův�ϼh{gowitch.layer}");

            //2.�]�w
            //�y�k:���W��.�D�R�A�ݩ� ���w ��;
            gowitch.layer = 4;

            gowitch.SetActive(false);

            print($"��v���`��{cma.depth}");
            print($"�y��b�|{sphereCollider.radius}");

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
