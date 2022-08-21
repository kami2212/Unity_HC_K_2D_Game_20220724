using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    private void Test()//無回傳值
    {
        print("きみ");
    }

    private void Start()
    {
        print(sense());
        Test();

        AddTen(7);
        Add(100, 300);
        Add(50, 999);
        Skill("火球", effect: "爆炸");
        Skill("冰球");
        Skill("電球", " 滋滋滋");
    }

    private string sense()//有回傳值
    {
        return "あ～あ";
    }

    private void AddTen(int number)
    {
        number = number + 10;
        print("數字加10後的結果:" + number);
    }

    private void Add(int numberA, int numberB)
    {
        print("<color=yellow>數字相加的結果:" + (numberA + numberB) + "</color>");
    }

    private void Skill(string skillType, string sound = "咻咻咻", string effect = "碎片")
    {
        print("施放技能特效:" + skillType);
        print("技能音效:" + sound);
        print($"技能附帶特效: {effect}");//有加$可帶出大誇號中變數的值
    }
}
