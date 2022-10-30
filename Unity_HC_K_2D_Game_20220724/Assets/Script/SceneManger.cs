using UnityEngine;
using UnityEngine.SceneManagement;

namespace Su
{
    public class SceneManger : MonoBehaviour
    {
        public void Startgame()
        {
            SceneManager.LoadScene("�C������");
        }

        public void EndGame()
        {
            Application.Quit();
        }

        public void DeckOut()
        {
            SceneManager.LoadScene("����/�԰�����");
        }
    }
}

