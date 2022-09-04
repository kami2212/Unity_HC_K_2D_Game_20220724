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
        private NPCData NPCData;
        private DialogueSystem DialogueSystem;
        #endregion

        #region 要停止的元件
        private JumpSystem jumpSystem;
        private SystemScript systemScript;
        #endregion


        private CanvasGroup canvasGroup;
        private string witch = "巫師";
        bool isInArea;
        bool isDialogue;


        private void Awake()
        {
            canvasGroup = GameObject.Find("畫布提示").GetComponent<CanvasGroup>();
            jumpSystem = FindObjectOfType<JumpSystem>();
            systemScript = FindObjectOfType<SystemScript>();
            DialogueSystem = FindObjectOfType<DialogueSystem>();
            
        }
        private void Update()
        {
            InputAndStartDialogue();
        }

        private void InputAndStartDialogue()
        {
            if (isDialogue) return;

            if (isInArea && Input.GetKeyDown(keyStartDialogue))
            {
                isDialogue = true;
                jumpSystem.enabled = false;
                systemScript.enabled = false;
                StopAllCoroutines();
                StartCoroutine(otenter(false));

                DialogueSystem.StartDialogue();
            }
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
