
using UnityEngine;

public class ClassPractice : MonoBehaviour
{
    public string name = "낡은 검";
    public int durability = 2;

    public bool Use()
    {
        if (durability <= 0)
        {
            return false;
        }

        durability--;
        return true;
    }

    [ContextMenu("클래스 실습")]
    void ShowWeapon()
    {
        for (int i = 0; i < 3; i++)
        {
            if (Use())
            {
                Debug.Log(name + " 사용, 남은 내구도 " + durability);
            }
            else
            {
                Debug.Log(name + " 부서짐");
            }
        }
    }
}
