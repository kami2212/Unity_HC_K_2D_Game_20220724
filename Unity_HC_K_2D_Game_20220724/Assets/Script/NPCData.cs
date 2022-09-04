using UnityEngine;
namespace Su
{
    [CreateAssetMenu(fileName = "NPCData", menuName = "Su/NPCData")]
    public class NPCData : ScriptableObject
    {
        [Header("NPC名稱")]
        public string NPCName;
        [Header("對話內容"),TextArea(3,10)]
        public string[] NPCConst;
    }
}

