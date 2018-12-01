using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Washer : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (DataManager.Instance.DolppuPay == false)
        {
            if (collision.gameObject.tag.CompareTo("Player") == 0)  //플레이어 충돌
            {
                DataManager.Instance.PoketMoneyCurrent -= DataManager.Instance.WasherCost;
                DataManager.Instance.WasherCount += 1;
                if (DataManager.Instance.PoketMoneyCurrent >= 0)
                {
                    DataManager.Instance.Score += DataManager.Instance.WasherScore;
                    //세탁기엔딩인 계산대로 보내버리기
                    GameObject.Find("gameManager").GetComponent<GameManager>().WasherPay();
                } else
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
        /*gameObject.transform.Translate(-Time.deltaTime, 0, 0);*/
        if (transform.position.x <= -10f)
        {
            Destroy(gameObject);
        }
    }
}
