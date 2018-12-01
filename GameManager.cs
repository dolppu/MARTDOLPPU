using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text ScoreText;
    public Text PoketMoneyText;
    public GameObject Receipt;
    public GameObject StartPanel;
    public GameObject StampSuccess;
    public GameObject StampWasher;
    public GameObject StampFail;
    public GameObject StampMissing;


    private void Start()
    {
        Time.timeScale = 0;
        DataManager.Instance.DolppuPay = true;

    }
    private void Update()
    {
        //UI에 점수랑 잔액보여주기
        ScoreText.text = DataManager.Instance.Score.ToString();
        PoketMoneyText.text = DataManager.Instance.PoketMoneyCurrent.ToString();

        if (StartPanel.activeSelf == true)
        {
            if((Input.GetKeyDown(KeyCode.Space)) || (Input.GetMouseButtonDown(0)))
            {
                StartPanel.SetActive(false);
                Time.timeScale = 1;
                DataManager.Instance.DolppuPay = false;
            }
        }

        /*
        if (DataManager.Instance.DolppuPay == false)
        {
            
            if (DataManager.Instance.PoketMoneyCurrent < 0)
            {
                Pay();
            }
            이거 역시 찜찜해...일단 막자

        //맵끝에 도착해도 pay <-이거는 도착지점 콜라이더 만들어서하자
        }
        */

    }
    public void Pay()
    {
        Debug.Log("계산대에요");
        DataManager.Instance.DolppuPay = true;
        //영수증(다시하기포함) 뿅~하고 나와야함. 아래는 그림판정일뿐

        //돌뿌 멈추고 점수 정산해야해 ->기여우니까 멈추진말자
        if (DataManager.Instance.GoalWasher == false)
        {
            if (DataManager.Instance.GoalApple == true) //사과
            {
                DataManager.Instance.GoalCheck += 1;
            }
            if (DataManager.Instance.GoalSnack == true) //과자
            {
                DataManager.Instance.GoalCheck += 1;
            }
            if (DataManager.Instance.GoalMilk == true) //우유
            {
                DataManager.Instance.GoalCheck += 1;
            }
            if (DataManager.Instance.GoalFish == true) //생선
            {
                DataManager.Instance.GoalCheck += 1;
            }

            //2층
            if (DataManager.Instance.GoalSoap == true) //세제
            {
                DataManager.Instance.GoalCheck += 1;
            }
            if (DataManager.Instance.GoalPencil == true) //연필
            {
                DataManager.Instance.GoalCheck += 1;
            }
            if (DataManager.Instance.GoalClock == true) //시계
            {
                DataManager.Instance.GoalCheck += 1;
            }
            if (DataManager.Instance.GoalSocks == true) //양말
            {
                DataManager.Instance.GoalCheck += 1;
            }
            if (DataManager.Instance.GoalPlush == true) //인형
            {
                DataManager.Instance.GoalCheck += 1;
            }

            //3층
            if (DataManager.Instance.GoalBattery == true) //건전지
            {
                DataManager.Instance.GoalCheck += 1;
            }
            if (DataManager.Instance.GoalTv == true) //tv
            {
                DataManager.Instance.GoalCheck += 1;
            }
            if (DataManager.Instance.GoalDryer == true) //드라이기
            {
                DataManager.Instance.GoalCheck += 1;
            }
            if (DataManager.Instance.GoalMicrowave == true) //전자렌지
            {
                DataManager.Instance.GoalCheck += 1;
            }

            //목표달성 확인하자
            if (DataManager.Instance.PoketMoneyCurrent >= 0)
            {
                if (DataManager.Instance.GoalCheck >= 5)
                {
                    DataManager.Instance.ShoppingSuccess += 1;
                    Debug.Log("와~ 다사왔어요 성공엔딩");
                    //와~ 다사왔어요 성공엔딩
                    StampSuccess.SetActive(true);
                    if (DataManager.Instance.Score > DataManager.Instance.BestScore)
                    {
                        DataManager.Instance.BestScore = DataManager.Instance.Score;
                    }
                    Receipt.SetActive(true);    //이거하고 성공이라고 띄워주면됨 
                    /*
                    PlayerPrefs.SetInt("SaveBestScore", DataManager.Instance.BestScore);
                    PlayerPrefs.SetInt("SaveShoppingSuccess", DataManager.Instance.ShoppingSuccess);
                    */
                    PlayerPrefs.SetInt("SaveBestScore", DataManager.Instance.BestScore);
                    PlayerPrefs.SetInt("SaveShoppingSuccess", DataManager.Instance.ShoppingSuccess);
                }
                else
                {
                    Debug.Log("잉 물건들 빼먹었다 실패엔딩");
                    //잉 물건들 빼먹었다 실패엔딩
                    DataManager.Instance.Score = 0;
                    Receipt.SetActive(true);    //이거하고 실패라구
                    StampMissing.SetActive(true);
                    PlayerPrefs.SetInt("SaveBestScore", DataManager.Instance.BestScore);
                    PlayerPrefs.SetInt("SaveShoppingSuccess", DataManager.Instance.ShoppingSuccess);
                }
            } else
            {
                Debug.Log("앗 너무 많이 담았다!ㅠㅠ실패엔딩");
                DataManager.Instance.Score = 0;
                Receipt.SetActive(true);    //이거하고 실패라구
                StampFail.SetActive(true);
                PlayerPrefs.SetInt("SaveBestScore", DataManager.Instance.BestScore);
                PlayerPrefs.SetInt("SaveShoppingSuccess", DataManager.Instance.ShoppingSuccess);
            }


        } else
        {
            //세탁기가 꼴이라는 뜻이니까
            if (DataManager.Instance.WasherCount >= 1)
            {
                Debug.Log("어찌된건진 몰라도 세탁기성공엔딩");
                //어찌된건진 몰라도 세탁기성공엔딩
                if (DataManager.Instance.Score > DataManager.Instance.BestScore)
                {
                    DataManager.Instance.BestScore = DataManager.Instance.Score;
                }
                Receipt.SetActive(true);    //이거하고 성공이라고 띄워주면됨
                StampWasher.SetActive(true);
                PlayerPrefs.SetInt("SaveBestScore", DataManager.Instance.BestScore);
                PlayerPrefs.SetInt("SaveShoppingSuccess", DataManager.Instance.ShoppingSuccess);
            } else
            {
                Debug.Log("그냥 못모인 실패엔딩 or 시간되면 세탁기못산 것만 그림따루");
                //그냥 못모인 실패엔딩 or 시간되면 세탁기못산 것만 그림따루
                DataManager.Instance.Score = 0;
                Receipt.SetActive(true);    //이거하고 실패라구
                StampMissing.SetActive(true);
                PlayerPrefs.SetInt("SaveBestScore", DataManager.Instance.BestScore);
                PlayerPrefs.SetInt("SaveShoppingSuccess", DataManager.Instance.ShoppingSuccess);
            }
        }

    }

    public void WasherPay()
    {
        Debug.Log("세탁기엔딩성공");
        DataManager.Instance.DolppuPay = true;
        //여기두 영수증 나와야지, 다시하기랑
        //세탁기 엔딩
        if (DataManager.Instance.GoalWasher == true)
        {
            DataManager.Instance.ShoppingSuccess += 1;
        }
        if (DataManager.Instance.Score > DataManager.Instance.BestScore)
        {
            DataManager.Instance.BestScore = DataManager.Instance.Score;
        }
        Receipt.SetActive(true);    //이거하고 성공이라고 띄워주면됨
        StampWasher.SetActive(true);
        PlayerPrefs.SetInt("SaveBestScore", DataManager.Instance.BestScore);
        PlayerPrefs.SetInt("SaveShoppingSuccess", DataManager.Instance.ShoppingSuccess);
    }

    //다시시작 버튼에 아래거를 연결하세용
    public void ReStart_Btn()
    {
        DataManager.Instance.PoketMoneyCurrent = DataManager.Instance.PoketMoneyMax;
        DataManager.Instance.Score = 0;

        DataManager.Instance.AppleCount = 0;
        DataManager.Instance.SnackCount = 0;
        DataManager.Instance.MilkCount = 0;
        DataManager.Instance.FishCount = 0;

        DataManager.Instance.SoapCount = 0;
        DataManager.Instance.PencilCount = 0;
        DataManager.Instance.ClockCount = 0;
        DataManager.Instance.SocksCount = 0;
        DataManager.Instance.PlushCount = 0;

        DataManager.Instance.BatteryCount = 0;
        DataManager.Instance.TvCount = 0;
        DataManager.Instance.DryerCount = 0;
        DataManager.Instance.MicrowaveCount = 0;
        DataManager.Instance.WasherCount = 0;

        DataManager.Instance.GoalCheck = 0;

        DataManager.Instance.GoalApple = false;
        DataManager.Instance.GoalSnack = false;
        DataManager.Instance.GoalMilk = false;
        DataManager.Instance.GoalFish = false;

        DataManager.Instance.GoalSoap = false;
        DataManager.Instance.GoalPencil = false;
        DataManager.Instance.GoalClock = false;
        DataManager.Instance.GoalSocks = false;
        DataManager.Instance.GoalPlush = false;

        DataManager.Instance.GoalBattery = false;
        DataManager.Instance.GoalTv = false;
        DataManager.Instance.GoalDryer = false;
        DataManager.Instance.GoalMicrowave = false;

        DataManager.Instance.GoalWasher = false;

        //씬을 다시시작
        SceneManager.LoadScene("ShoppingScene");
    }
}
