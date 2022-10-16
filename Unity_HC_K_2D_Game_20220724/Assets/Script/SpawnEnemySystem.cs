using UnityEngine;

namespace Su
{
    /// <summary>
    /// 生成敵人系統
    /// </summary>
    [DefaultExecutionOrder(200)]
    public class SpawnEnemySystem : MonoBehaviour
    {
        [SerializeField, Header("生成時間範圍")]
        private Vector2 rangeSpawn = new Vector2(0.5f, 1.5f);

        private GameObject tempEnemy;

        private void Start()
        {
            SpawnEnemy();
        }
        private void SpawnEnemy()
        {
            tempEnemy = ObjectpoolEnemy.instance.GetPoolObject();
            tempEnemy.transform.position = transform.position;
            tempEnemy.GetComponent<EnemyHealth>().onDead = EnemyRelease;
        }

        private void EnemyRelease()
        {
            ObjectpoolEnemy.instance.ReleasePoolObject(tempEnemy);

            Invoke("SpawnEnemy", Random.Range(rangeSpawn.x, rangeSpawn.y));
        }
    }
}
