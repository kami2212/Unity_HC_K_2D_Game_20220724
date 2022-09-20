using UnityEngine;
using System.Collections;
using TMPro;

namespace Su
{
    public class DialogueSystem : MonoBehaviour
    {
        [SerializeField, Header("對話框三角形")]
        private GameObject goTriangle;
        [SerializeField, Header("對話打字間隔"), Range(0, 0.5f)]
        private float intervalTypeEffect = 0.05f;
        [SerializeField, Header("對話按鍵")]
        private KeyCode keyDialogue = KeyCode.E;

        /// <summary>
        /// 畫布對話
        /// </summary>
        private CanvasGroup groupDialogue;
        /// <summary>
        /// NPC名稱
        /// </summary>
        private TextMeshProUGUI textNPC;
        /// <summary>
        /// 對話內容
        /// </summary>
        private TextMeshProUGUI textContent;
        /// <summary>
        /// 當前NPC資料
        /// </summary>
        private NPCData NPCData;

        public delegate void delegateDialogueFinish();
        private delegateDialogueFinish dialogueFinish;

        private void Awake()
        {
            groupDialogue = GameObject.Find("對話框").GetComponent<CanvasGroup>();
            textNPC = GameObject.Find("NPC名稱").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("對話內容").GetComponent<TextMeshProUGUI>();
        }

        /// <summary>
        /// 開始對話
        /// </summary>
        public IEnumerator StartDialogue(NPCData _NPCData,delegateDialogueFinish _Finish)
        {
            dialogueFinish = _Finish;


            NPCData = _NPCData;
            textNPC.text = NPCData.NPCName;
            textContent.text = "";
            yield return StartCoroutine(otenter());


            StartCoroutine(TypeEffect());

        }

        /// <summary>
        /// 淡入淡出
        /// </summary>
        /// <param name="fadeIn"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 打字效果
        /// </summary>
        /// <returns></returns>
        private IEnumerator TypeEffect()
        {
            for (int j = 0; j < NPCData.NPCConst.Length; j++)
            {
                string content = NPCData.NPCConst[j];
                goTriangle.SetActive(false);
                textContent.text = "";

                for (int i = 0; i < content.Length; i++)
                {
                    textContent.text += content[i];
                    yield return new WaitForSeconds(0.1f);
                }

                goTriangle.SetActive(true);
                while (!Input.GetKeyDown(keyDialogue))
                {
                    yield return null;
                }
            }

            StartCoroutine(otenter(false));
            dialogueFinish();
        }
    }
}

