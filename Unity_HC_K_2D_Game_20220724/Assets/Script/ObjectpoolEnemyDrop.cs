using UnityEngine;
using UnityEngine.Pool;

namespace Su
{
    /// <summary>
    /// 敵人掉落物品
    /// </summary>
    public class ObjectpoolEnemyDrop : ObjectpoolBase
    {
        public static ObjectpoolEnemyDrop instance;
        private void Start()
        {
            instance = this;
        }
    }
}