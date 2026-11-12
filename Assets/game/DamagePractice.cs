using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    public int attack; 
    public int defense;
    public bool isCritical;
    public bool targetIsBoss;


    [ContextMenu("데미지")]
    void Calc()
    {
        int damage = attack - defense;
        

        if (isCritical == true)
        {
            damage = damage * 2;
        }
        if (damage < 1)
        {
            damage = 1;
        }
        if (targetIsBoss)
        {
            damage = damage / 2;
        }


            Debug.Log(damage);
    }

}
