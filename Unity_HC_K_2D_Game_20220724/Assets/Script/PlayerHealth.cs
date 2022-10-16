using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Su
{
    /// <summary>
    /// 血量系統
    /// </summary>
    public class PlayerHealth : HealthSystem
    {
        private Image imgHp;
        protected override void Awake()
        {
            base.Awake();

            imgHp = GameObject.Find("血條").GetComponent<Image>();
        }
        public override void Hurt(float getDamage)
        {
            base.Hurt(getDamage);

            imgHp.fillAmount = hp / hpMax;
        }
        protected override void Dead()
        {
            base.Dead();

            gameObject.layer = 8;

            Invoke("Replay", 1);
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains("死亡區域")) Hurt(9999);
        }

        private void Replay()
        {
            SceneManager.LoadScene("遊戲場景");
        }
    }

}