using UnityEngine;
namespace Su
{
    public class FirstScript : MonoBehaviour
    {   /// <summary>
        /// 開始事件
        /// </summary>
        #region //程式區塊
        
        private void Start()
        {
            int i = 0;
            while (i < 5)
            {
                print("うるさい～～");
                i++;
            }
        }
        /// <summary>
        /// 更新事件
        /// </summary>
        private void Update()
        {
            print("ばか　へんたい　うるさい　もしらない");

        }
        #endregion
    }
}

