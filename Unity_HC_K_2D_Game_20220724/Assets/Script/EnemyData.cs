using UnityEngine;

namespace Su
{
    [CreateAssetMenu(fileName = "EnemyData", menuName = "Su/EnemyData")]
    public class EnemyData : ScriptableObject
    {
        [Header("移動速度"), Range(0, 50)]
        public float speed = 3.5f;
        [Header("偵測前方是否有地板資料")]
        public Color checkGroundColor = new Color(1, 0.5f, 0.3f, 0.3f);
        public Vector3 checkGroundoffset;
        public Vector3 checkFroundSize = Vector3.one;
        public LayerMask checkGroundLayer;
    }
}

