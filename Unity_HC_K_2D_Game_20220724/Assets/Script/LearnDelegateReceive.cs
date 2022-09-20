using UnityEngine;

namespace Su
{
    public class LearnDelegateReceive : MonoBehaviour
    {
        public void ReveoveData(int getNumberData)
        {
            getNumberData++;
            print("接收到的資料:" + getNumberData);
        }
        //2.定義委派:簽章必須與方法一樣
        //範例:無傳回無參數
        //簽章:傳回類型、參數數量與類型
        //委派語法:修飾詞 委派關鍵詞 傳回類型 委派名稱(參數)
        public delegate void delegateOne();
        public delegate void delegateTwo(int number);
        //3.使用委派
        //3-1 參數定義
        public void ReceiveMethod(delegateOne one)
        {
            //3-3使用委派
            one();
        }

        public void ReceiveMethodTwo(delegateTwo Two)
        {
            //3-3使用委派
            int weaponA = 9;
            Two(weaponA);
        }
    }
}
