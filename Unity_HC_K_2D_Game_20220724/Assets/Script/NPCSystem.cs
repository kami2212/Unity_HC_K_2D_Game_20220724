
using UnityEngine;

namespace Su
{
    public class NPCSystem : MonoBehaviour
    {
        private CanvasGroup canvasGroup;
        private string witch = "巫師";
        private void Awake()
        {
            canvasGroup=GameObject.Find("畫布提示").GetComponent<CanvasGroup>();
        }
    }
}
