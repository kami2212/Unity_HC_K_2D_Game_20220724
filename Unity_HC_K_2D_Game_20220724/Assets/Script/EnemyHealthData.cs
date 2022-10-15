using UnityEngine;

namespace Su
{
    /// <summary>
    /// 敵人血量系統
    /// </summary>
    [CreateAssetMenu(menuName = "Su/EnemyHealthData")]
    public class EnemyHealthData : HealthData
    {
        [Header("掉落機率"), Range(0f, 1f)]
        public float dropProbility;
        [Header("掉落物件")]
        public GameObject prefabprop;
    }
}
