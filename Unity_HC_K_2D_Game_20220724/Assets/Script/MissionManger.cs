using TMPro;
using UnityEngine;

namespace Su
{
    public class MissionManger : MonoBehaviour
    {
        public static MissionManger instance;
        [SerializeField, Header("任務需求數量"), Range(0, 100)]
        private int countMax = 30;
        [SerializeField, Header("要更新的NPC")]
        private NPCSystem npcTarget;
        [SerializeField, Header("要更新的對話資料")]
        private NPCData NPCData;

        private int countCurrent;
        private TextMeshProUGUI textMission;

        private void Awake()
        {
            instance = this;

            textMission = GameObject.Find("任務數量文字").GetComponent<TextMeshProUGUI>();
            UpdateMissioncount();
        }
        public void UpdateMissioncount(int count=0)
        {
            countCurrent += count;
            textMission.text = $"寶箱數量:{countCurrent}/{countMax}";
            if (countCurrent >= countMax) MissionComlete();
        }
        private void MissionComlete()
        {
            npcTarget.NPCData = NPCData;
        }
    }
}

