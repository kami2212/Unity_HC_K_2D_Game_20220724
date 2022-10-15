using UnityEngine;

namespace Su
{
    /// <summary>
    /// 敵人掉落物品
    /// </summary>
    public class ObjectpoolEnemy : ObjectpoolBase
    {
        public static ObjectpoolEnemy instance;
        private void Start()
        {
            instance = this;
        }
    }
}
