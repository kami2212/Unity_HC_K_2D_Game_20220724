using UnityEngine;
namespace Su
{
    /// <summary>
    /// 血量系統
    /// </summary>
    public class EnemyHealth : HealthSystem
    {
        public delegate void delegateDead();
        public delegateDead onDead;

        protected override void Dead()
        {
            base.Dead();

            onDead();
            DropProp();
            gameObject.layer = 9;
            
        }
        /// <summary>
        /// 掉落物品
        /// </summary>
        private void DropProp()
        {
            float probability = Random.value;
            print("掉落機率:" + probability);

            EnemyHealthData enemydata = (EnemyHealthData)HealthData;

            if(probability<=enemydata.dropProbility)
            {
                Vector3 pos = transform.position + Vector3.up * 1.5f;

                //Instantiate(enemydata.prefabprop, pos, Quaternion.identity);
                GameObject chestProp = ObjectpoolEnemyDrop.instance.GetPoolObject();
                chestProp.transform.position = pos;
                chestProp.transform.eulerAngles = Vector3.zero;
            }
        }
    }

}
