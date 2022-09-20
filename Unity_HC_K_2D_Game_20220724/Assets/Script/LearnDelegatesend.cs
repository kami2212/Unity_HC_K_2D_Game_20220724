using UnityEngine;

namespace Su
{
    public class LearnDelegatesend : MonoBehaviour
    {
        private int number = 99;
        private LearnDelegateReceive receive;

        #region 委派說明
        //1.需要傳遞的方法
        //2.定義委派
        //3.使用委派
        #endregion

        private void Awake()
        {
            receive = FindObjectOfType<LearnDelegateReceive>();
            receive.ReveoveData(number);

            //3.使用委派
            //3-2 參數傳遞
            receive.ReceiveMethod(MethodOne);
            receive.ReceiveMethodTwo(MethodTwo);
        }
        //1.定義方法
        //範例:無傳回無參數
        private void MethodOne()
        {
            print("我是方法一");
        }

        private void MethodTwo(int number)
        {
            number *= 100;
            print("武器真實傷害:" + number);
        }
    }
}