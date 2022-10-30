using UnityEngine;
using UnityEngine.SceneManagement;

namespace Su
{
    public class SceneManger : MonoBehaviour
    {
        public void Startgame()
        {
            SceneManager.LoadScene("遊戲場景");
        }

        public void EndGame()
        {
            Application.Quit();
        }

        public void DeckOut()
        {
            SceneManager.LoadScene("場景/戰鬥場景");
        }
    }
}

