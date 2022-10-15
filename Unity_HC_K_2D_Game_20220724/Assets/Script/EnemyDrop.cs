using UnityEngine;

namespace Su
{
    /// <summary>
    /// 敵人道具:被目標碰到後回收到物件池
    /// </summary>
    public class EnemyDrop : MonoBehaviour
    {
        [SerializeField, Header("目標物件名稱")]
        private string nameTarget = "巫師";

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.name.Contains(nameTarget))
            {
                ObjectpoolEnemyDrop.instance.ReleasePoolObject(gameObject);
            }
        }
    }
}

