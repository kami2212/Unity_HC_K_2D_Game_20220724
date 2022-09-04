using UnityEngine;
using System.Collections;
using TMPro;

namespace Su
{
    public class DialogueSystem : MonoBehaviour
    {
        private CanvasGroup groupDialogue;
        private TextMeshProUGUI textNPC;
        private TextMeshProUGUI textContent;
        [SerializeField,Header("��ܮؤT����")]
        private GameObject goTriangle;
        private void Awake()
        {
            groupDialogue = GameObject.Find("��ܮ�").GetComponent<CanvasGroup>();
            textNPC = GameObject.Find("NPC�W��").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("��ܤ��e").GetComponent<TextMeshProUGUI>();
        }
        public void StartDialogue()
        {
                StartCoroutine(otenter());
            
        }
        private IEnumerator otenter(bool fadeIn = true)
        {
            groupDialogue.alpha = fadeIn ? 0 : 1;
            float increase = fadeIn ? 0.1f : -0.1f;
            for (float i = 0; i < 10; i++)
            {
                groupDialogue.alpha += increase;
                yield return new WaitForSeconds(0.08f);
            }
        }
    }
}

