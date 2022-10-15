using UnityEngine;
namespace Su
{
    /// <summary>
    /// 血量系統
    /// </summary>
    public class PlayerHealth : HealthSystem
    {
        protected override void Dead()
        {
            base.Dead();

            gameObject.layer = 8;
        }
    }

}