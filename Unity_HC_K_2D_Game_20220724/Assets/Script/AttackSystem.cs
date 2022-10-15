using UnityEngine;
using System.Collections;

namespace Su
{
    public class AttackSystem : MonoBehaviour
    {
        [SerializeField, Header("攻擊資料")]
        private attackdata attackdata;

        private Animator ani;
        private bool isAttacking;

        protected virtual void Awake()
        {
            ani = GetComponent<Animator>();
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = attackdata.attackAreaColor;
            Gizmos.DrawCube(transform.position + transform.TransformDirection(attackdata.attackAreaOffset), attackdata.attackAreaSize);
        }

        /// <summary>
        /// 檢查攻擊區域
        /// </summary>
        private void CheckAttackArea()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(attackdata.attackAreaOffset), attackdata.attackAreaSize, 0, attackdata.attackAreaLayer);
            //print("攻擊到的物件:" + hit);

           if(hit) hit.GetComponent<HealthSystem>().Hurt(attackdata.attack);
            /*lookAttackTarget = hit;
            if (hit) traAttackTarget = hit.transform;*/
        }
        /// <summary>
        /// 開始攻擊
        /// </summary>
        //virtual 虛擬:允許子類別使用複寫關鍵字複寫 overrride
        public virtual void StartAttack()
        {
            if (isAttacking) return;
            isAttacking = true;
            ani.SetTrigger(attackdata.parAttack);
            StartCoroutine(Attacking());
        }

        /// <summary>
        /// 攻擊中
        /// </summary>
        /// <returns></returns>
        private IEnumerator Attacking()
        {
            yield return new WaitForSeconds(attackdata.delaySendDamage);
            CheckAttackArea();
            yield return new WaitForSeconds(attackdata.attackTime);
            isAttacking = false;
            StopAttack();
        }
        //protected 保護級別:允許子類別存取或複寫
        protected virtual void StopAttack()
        {

        }
    }
}

