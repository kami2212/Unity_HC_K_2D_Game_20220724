using UnityEngine;

namespace Su
{
    /// <summary>
    /// �ǲ�API�R�A
    /// </summary>
    public class LearnAPI : MonoBehaviour
    {
        private void Start()
        {
            //�R�A�ݩ�
            //1.���o Get
            //�y�k:���O�W��.�R�A�ݩ�
            print($"<color=red>{Random.value}</color>");

            //2.�]�w(Read Only����]�w)
            //�y�k:���O�W��.�R�A�ݩ� ���w ��;
            Cursor.visible = false;
        }

        private void Update()
        {
            //�R�A��k
            //3.�ϥΤ�k
            //�y�k:���O�W��.�R�A��k(�����޼�)
            print(Random.Range(0, 3));

        }
    }
}

