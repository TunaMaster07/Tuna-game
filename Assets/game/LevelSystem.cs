using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int expPerKill = 35000;
    public int killCount = 3;

    [ContextMenu("레벨 계산")]
    void CalculateLevel()
    {
        int level = 3;
        int exp = 0;

        for (int i = 0; i < killCount; i++)
        {
            exp += expPerKill;
            

            while (exp >= level * 10000) 
            {
                exp = exp - (level * 10000);
                level++;
                Debug.Log("레벨업! Lv" + level +"(" + killCount + "마리째)");
            }
        }
        


        Debug.Log("현재 레벨: " + level);
        Debug.Log("현재 경험치: " + exp);
    }

}
