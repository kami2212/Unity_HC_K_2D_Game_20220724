using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    private void Test()
    {
        print("きみ");
    }

    private void Start()
    {
        print(sense());
        Test();
    }

    private string sense()
    {
        return "あ～あ";
    }
}
