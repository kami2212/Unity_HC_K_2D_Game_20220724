using UnityEngine;

namespace Su
{
    /// <summary>
    /// 血量系統
    /// </summary>
    public class HealthSystem : MonoBehaviour
    {
        [SerializeField, Header("血量資料")]
        protected HealthData HealthData;
        [SerializeField, Header("要關閉的元件")]
        private Behaviour[] behavioursToClose;

        protected float hp;
        protected float hpMax;

        private Animator ani;

        protected virtual void Awake()
        {
            ani = GetComponent<Animator>();
            hp = HealthData.hp;
            hpMax = hp;
        }

        /// <summary>
        /// 受傷
        /// </summary>
        /// <param name="getDamage"></param>
        public virtual void Hurt(float getDamage)
        {
            hp -= getDamage;
            if (hp <= 0) Dead();

            print(gameObject + "血量:" + hp);
        }

        /// <summary>
        /// 死亡
        /// </summary>
        protected virtual void Dead()
        {
            hp = 0;
            ani.SetBool(HealthData.parDead, true);

            for(int i=0;i<behavioursToClose.Length;i++)
            {
                behavioursToClose[i].enabled = false;
            }
        }

        protected virtual void OnEnable()
        {
            hp = HealthData.hp;

            for (int i = 0; i < behavioursToClose.Length; i++)
            {
                behavioursToClose[i].enabled = true;
            }
        }
    }
}

