using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (DataManager.Instance.DolppuPay == false)
        {
            if (collision.gameObject.tag.CompareTo("Player") == 0)  //플레이어 충돌
            {
                DataManager.Instance.PoketMoneyCurrent -= DataManager.Instance.BatteryCost;
                DataManager.Instance.BatteryCount += 1;
                if (DataManager.Instance.PoketMoneyCurrent >= 0)
                {
                    DataManager.Instance.Score += DataManager.Instance.BatteryScore;
                }
                else
                {
                    //보통엔딩인 계산대로 보내버리기
                    GameObject.Find("gameManager").GetComponent<GameManager>().Pay();
                }
                Destroy(gameObject);
            }
        }
    }

    private void Update()
    {
        if (transform.position.x <= -10f)
        {
            Destroy(gameObject);
        }
    }
}