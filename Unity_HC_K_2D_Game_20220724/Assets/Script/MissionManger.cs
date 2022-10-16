using TMPro;
using UnityEngine;

namespace Su
{
    public class MissionManger : MonoBehaviour
    {
        public static MissionManger instance;
        [SerializeField, Header("���ȻݨD�ƶq"), Range(0, 100)]
        private int countMax = 30;
        [SerializeField, Header("�n��s��NPC")]
        private NPCSystem npcTarget;
        [SerializeField, Header("�n��s����ܸ��")]
        private NPCData NPCData;

        private int countCurrent;
        private TextMeshProUGUI textMission;

        private void Awake()
        {
            instance = this;

            textMission = GameObject.Find("���ȼƶq��r").GetComponent<TextMeshProUGUI>();
            UpdateMissioncount();
        }
        public void UpdateMissioncount(int count=0)
        {
            countCurrent += count;
            textMission.text = $"�_�c�ƶq:{countCurrent}/{countMax}";
            if (countCurrent >= countMax) MissionComlete();
        }
        private void MissionComlete()
        {
            npcTarget.NPCData = NPCData;
        }
    }
}

