using Cinemachine;
using System.Collections;
using UnityEngine;


namespace Su
{
    public class NPCSystem : MonoBehaviour
    {

        #region 公開資料
        [SerializeField, Header("開始對話按鍵")]
        private KeyCode keyStartDialogue = KeyCode.E;
        [SerializeField, Header("NPC資料")]
        public NPCData NPCData;
        private DialogueSystem DialogueSystem;
        #endregion

        #region 要停止的元件
        private JumpSystem jumpSystem;
        private SystemScript systemScript;
        private PlayerAttack PlayerAttack;
        #endregion

        #region 私人資料
        /// <summary>
        /// 畫布提示
        /// </summary>
        private CanvasGroup canvasGroup;

        private string witch = "巫師";
        bool isInArea;

        /// <summary>
        /// 是否對話中
        /// </summary>
        bool isDialogue;
        #endregion

        //Ctrl+R R 對有使用到該筆資料名稱重新命名
        /// <summary>
        /// NPC CM 攝影機
        /// </summary>
        private CinemachineVirtualCamera cvcCM;

        private void Awake()
        {
            canvasGroup = GameObject.Find("畫布提示").GetComponent<CanvasGroup>();

            cvcCM = GameObject.Find(NPCData.cameraname).GetComponent<CinemachineVirtualCamera>();
            jumpSystem = FindObjectOfType<JumpSystem>();
            systemScript = FindObjectOfType<SystemScript>();
            PlayerAttack = FindObjectOfType<PlayerAttack>();
            DialogueSystem = FindObjectOfType<DialogueSystem>();

        }

        private void Update()
        {
            InputAndStartDialogue();
        }

        /// <summary>
        /// 輸入按鍵偵測並且開始對話
        /// </summary>
        private void InputAndStartDialogue()
        {
            if (isDialogue) return;

            if (isInArea && Input.GetKeyDown(keyStartDialogue))
            {
                isDialogue = true;
                jumpSystem.enabled = false;
                systemScript.enabled = false;
                PlayerAttack.enabled = false;
                cvcCM.Priority = 11;

                StopAllCoroutines();
                StartCoroutine(otenter(false));

                StartCoroutine(DialogueSystem.StartDialogue(NPCData,DialogueFinish));
            }
        }

        /// <summary>
        /// 對話結束後處理
        /// </summary>
        private void DialogueFinish()
        {
            isDialogue = false;
            jumpSystem.enabled = true;
            systemScript.enabled = true;
            PlayerAttack.enabled = true;
            cvcCM.Priority = 9;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(witch))
            {
                isInArea = true;
                StopAllCoroutines();
                StartCoroutine(otenter());
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.name.Contains(witch))
            {
                isInArea = false;
                StopAllCoroutines();
                StartCoroutine(otenter(false));
            }
        }

        /// <summary>
        /// 淡入淡出
        /// </summary>
        /// <param name="fadeIn"></param>
        /// <returns></returns>
        private IEnumerator otenter(bool fadeIn = true)
        {
            canvasGroup.alpha = fadeIn ? 0 : 1;
            float increase = fadeIn ? 0.1f : -0.1f;
            for (float i = 0; i < 10; i++)
            {
                canvasGroup.alpha += increase;
                yield return new WaitForSeconds(0.08f);
            }
        }



    }
}
