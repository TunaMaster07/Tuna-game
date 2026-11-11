
using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;
    public float expRate = 1.5f;

    [ContextMenu("정산")]
    void Settle()
    {
        int hour = playSeconds / 3600;
        int minute = (playSeconds % 3600) / 60;
        int second = playSeconds % 60;

        Debug.Log("플레이 시간: " + hour + ":" + minute + ":" + second);

        int share = gold / members;
        int bonus = gold % members;

        Debug.Log("1인당 골드: " + share);
        Debug.Log("남은 골드: " + bonus);

        int baseExp = kills * expPerKill;
        int finalExp = (int)(baseExp * expRate);

        Debug.Log("기본 경험치: " + baseExp);
        Debug.Log("최종 경험치: " + finalExp);

        int level = finalExp / 100 + 1;
        int nextExp = 100 - (finalExp % 100);

        Debug.Log("현재 레벨: " + level);
        Debug.Log("다음 레벨까지 경험치: " + nextExp);

        float damage = (float)totalDamage / hits;

        Debug.Log("평균 데미지: " + damage);
    }
}
