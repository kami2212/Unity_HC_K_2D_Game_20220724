using UnityEngine;
namespace Su
{
    [CreateAssetMenu(fileName = "NPCData", menuName = "Su/NPCData")]
    public class NPCData : ScriptableObject
    {
        [Header("NPC�W��")]
        public string NPCName;
        [Header("��ܤ��e"),TextArea(3,10)]
        public string[] NPCConst;
    }
}

