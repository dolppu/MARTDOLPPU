using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (DataManager.Instance.DolppuPay == false) 
        {
            if (collision.gameObject.tag.CompareTo("Player") == 0)  //플레이어 충돌
            {
                DataManager.Instance.PoketMoneyCurrent -= DataManager.Instance.AppleCost;
                DataManager.Instance.AppleCount += 1;
                if (DataManager.Instance.PoketMoneyCurrent >= 0)
                {
                    DataManager.Instance.Score += DataManager.Instance.AppleScore;
                } else
                {
                    //보통엔딩인 계산대로 보내버리기
                    GameObject.Find("gameManager").GetComponent<GameManager>().Pay();
                }
                Destroy(gameObject);
                //돈이 모자를때를 어디에 넣지?
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
