
using UnityEngine;

namespace Su
{
    public class NPCSystem : MonoBehaviour
    {
        private CanvasGroup canvasGroup;
        private string witch = "�Ův";
        private void Awake()
        {
            canvasGroup=GameObject.Find("�e������").GetComponent<CanvasGroup>();
        }
    }
}
