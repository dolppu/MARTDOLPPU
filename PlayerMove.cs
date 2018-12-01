using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;

    public float Jump1 = 1f;
    public float Jump2 = 1f;

    int JumpCount = 0;

    //점프하기
    private void Update()
    {
        if((Input.GetKeyDown(KeyCode.Space)) || (Input.GetMouseButtonDown(0)))
        {
            if(JumpCount == 0)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, Jump1, 0);
                JumpCount += 1;
            }
            else if(JumpCount == 1)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, Jump2, 0);
                JumpCount += 1;
            }
        }
    }

    //충돌처리
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.CompareTo("Cart") == 0)
        {
            JumpCount = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //계산대
        if(collision.gameObject.tag.CompareTo("Finish") == 0)
        {
            GameObject.Find("gameManager").GetComponent<GameManager>().Pay();
        }

        //카트 채우기
        if(collision.gameObject.tag.CompareTo("2f") == 0)
        {
            Box1.SetActive(true);
        }
        if(collision.gameObject.tag.CompareTo("3f") == 0)
        {
            Box2.SetActive(true);
            Box3.SetActive(true);
        }
    }
}
