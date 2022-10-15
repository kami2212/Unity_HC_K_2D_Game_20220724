using UnityEngine;

namespace Su
{
    [CreateAssetMenu(fileName = "EnemyData", menuName = "Su/EnemyData")]
    public class EnemyData : attackdata
    {
        [Header("移動速度"), Range(0, 50)]
        public float speed = 3.5f;
        [Header("偵測前方是否有地板資料")]
        public Color checkGroundColor = new Color(1, 0.5f, 0.3f, 0.3f);
        public Vector3 checkGroundoffset;
        public Vector3 checkFroundSize = Vector3.one;
        public LayerMask checkGroundLayer;
        [Header("偵測前方是否有攻擊目標")]
        public Color checkTargetColor = new Color(1, 0.1f, 0.1f, 0.3f);
        public Vector3 checkTargetoffset;
        public Vector3 checkTargetSize = Vector3.one;
        public LayerMask checkTargetLayer;
        [Header("攻擊範圍")]
        public Color attackRangeColor = new Color(0, 1, 0, 0.5f);
        [Range(0, 5)]
        public float attackRange = 2;
    }
}

