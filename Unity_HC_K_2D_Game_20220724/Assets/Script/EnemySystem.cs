using UnityEngine;

namespace Su
{
    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("敵人資料")]
        private EnemyData EnemyData;
        private Rigidbody2D rig;
        private bool isGroundForward;

        private void Awake()
        {
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Wander();
            CheckGroundhit();
            Filp();
        }
        private void OnDrawGizmos()
        {
            Gizmos.color = EnemyData.checkGroundColor;
            Gizmos.DrawCube(transform.position + EnemyData.checkGroundoffset, EnemyData.checkFroundSize);
        }

        private void CheckGroundhit()
        {
            Collider2D hits = Physics2D.OverlapBox(transform.position + EnemyData.checkGroundoffset, EnemyData.checkFroundSize, 0, EnemyData.checkGroundLayer);
            //print(hit.gameObject);
            isGroundForward = hits;

        }
        /// <summary>
        /// 遊走
        /// </summary>
        private void Wander()
        {
            rig.velocity = new Vector2(-EnemyData.speed, rig.velocity.y);
        }

        private void Filp()
        {
            if(!isGroundForward)
            {
                float yAngle = transform.eulerAngles.y;
                transform.eulerAngles = new Vector3(0, yAngle == 0 ? 180 : 0, 0);
            }
        }
    }

}
