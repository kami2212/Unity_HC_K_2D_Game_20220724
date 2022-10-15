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
        private void Start()
        {
            SpawnEnemy();
        }
        private void SpawnEnemy()
        {
            GameObject tempEnemy = ObjectpoolEnemy.instance.GetPoolObject();
            tempEnemy.transform.position = transform.position;
        }
    }
}
