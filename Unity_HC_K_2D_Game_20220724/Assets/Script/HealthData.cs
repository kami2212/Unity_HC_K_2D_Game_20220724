using UnityEngine;

namespace Su
{
    [CreateAssetMenu(fileName = "Health Data", menuName = "Su/Health Data")]
    public class HealthData : ScriptableObject
    {
        [Header("血量"), Range(0, 1000)]
        public float hp;
        [Header("死亡動畫參數")]
        public string parDead;
    }
}
