using UnityEngine;

namespace Su
{
    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("敵人資料")]
        private EnemyData EnemyData;
        private Rigidbody2D rig;
        private Animator ani;
        private bool isGroundForward;
        private string parWalk = "開關走路";
        private bool lookAttackTarget;
        private Transform traAttackTarget;
        private EnemyAttack enemyAttack;

        [SerializeField, Header("動畫控制器攻擊動畫名稱")]
        private string nameAnimationAttack = "怪物_攻擊";

        private void Awake()
        {
            rig = GetComponent<Rigidbody2D>();
            ani = GetComponent<Animator>();
            enemyAttack= GetComponent<EnemyAttack>();
        }

        private void Update()
        {
            Wander();
            CheckGroundhit();
            Filp();
            CheckAttackTarget();
            LookAttackTarget();
        }

        private void OnDrawGizmos()
        {
            #region 檢查地板            
            Gizmos.color = EnemyData.checkGroundColor;
            Gizmos.DrawCube(transform.position + transform.TransformDirection(EnemyData.checkGroundoffset), EnemyData.checkFroundSize);
            #endregion
            #region 檢查攻擊目標           
            Gizmos.color = EnemyData.checkTargetColor;
            Gizmos.DrawCube(transform.position + transform.TransformDirection(EnemyData.checkTargetoffset), EnemyData.checkTargetSize);
            #endregion
            Gizmos.color = EnemyData.attackRangeColor;
            Gizmos.DrawLine(transform.position, transform.position + -transform.right * EnemyData.attackRange);
        }

        /// <summary>
        /// 偵測前方是否有地板
        /// </summary>
        private void CheckGroundhit()
        {
            Collider2D hits = Physics2D.OverlapBox(transform.position + transform.TransformDirection(EnemyData.checkGroundoffset), EnemyData.checkFroundSize, 0, EnemyData.checkGroundLayer);
            //print(hit.gameObject);
            isGroundForward = hits;

        }

        /// <summary>
        /// 遊走
        /// </summary>
        private void Wander()
        {
            if (ani.GetCurrentAnimatorStateInfo(0).IsName(nameAnimationAttack)) return;

            if (lookAttackTarget) return;
                rig.velocity = -transform.right * new Vector2(EnemyData.speed, rig.velocity.y);
            ani.SetBool(parWalk, rig.velocity.x != 0);
        }

        /// <summary>
        /// 翻面
        /// </summary>
        private void Filp()
        {
            if (!isGroundForward)
            {
                float yAngle = transform.eulerAngles.y;
                transform.eulerAngles = new Vector3(0, yAngle == 0 ? 180 : 0, 0);
            }
        }

        /// <summary>
        /// 前方是否有攻擊目標
        /// </summary>
        private void CheckAttackTarget()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(EnemyData.checkTargetoffset), EnemyData.checkTargetSize, 0, EnemyData.checkTargetLayer);
            lookAttackTarget = hit;
            if (hit) traAttackTarget = hit.transform;
        }

        /// <summary>
        /// 看見攻擊目標
        /// </summary>
        private void LookAttackTarget()
        {
            if (lookAttackTarget)
            {
                float dis = Vector3.Distance(transform.position, traAttackTarget.position);
                //print("距離:" + dis);

                if (ani.GetCurrentAnimatorStateInfo(0).IsName(nameAnimationAttack)) return;

                if (dis > EnemyData.attackRange)
                {
                    rig.velocity = -transform.right * new Vector2(EnemyData.speed, rig.velocity.y);
                }
                else
                {
                    Attack();
                }
                ani.SetBool(parWalk, rig.velocity.x !=0);
            }
            
        }

        /// <summary>
        /// 攻擊
        /// </summary>
        private void Attack()
        {
            rig.velocity = Vector3.zero;
            enemyAttack.StartAttack();
        }
    }

}
