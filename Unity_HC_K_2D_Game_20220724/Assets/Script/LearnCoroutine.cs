using System.Collections;
using UnityEngine;

namespace Su
{
    public class LearnCoroutine : MonoBehaviour
    {
        /// <summary>
        /// �ǲߨ�P�{��
        /// </summary>
        private void Awake()
        {
            StartCoroutine(TEST());
        }
        public IEnumerator TEST()
        {
            yield return new WaitForSeconds(3);
            yield return new WaitForSeconds(4);
        }
    }
}

