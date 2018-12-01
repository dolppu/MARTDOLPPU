using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    static DataManager instance;

    public static DataManager Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        //불러오기
        BestScore = PlayerPrefs.GetInt("SaveBestScore");
        ShoppingSuccess = PlayerPrefs.GetInt("SaveShoppingSuccess");
        

        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public bool DolppuPay = false;  //계산할때인지 아닌지

    public int PoketMoneyMax = 4000;
    public int PoketMoneyCurrent = 4000;
    public int Score = 0;
    public int BestScore = 0;
    public int ShoppingSuccess = 0;
    public int GoalNumber = 1;

    //목표체크
    public int GoalCheck = 0;

    public bool GoalApple = false;
    public bool GoalSnack = false;
    public bool GoalMilk = false;
    public bool GoalFish = false;

    public bool GoalSoap = false;
    public bool GoalPencil = false;
    public bool GoalClock = false;
    public bool GoalSocks = false;
    public bool GoalPlush = false;

    public bool GoalBattery = false;
    public bool GoalTv = false;
    public bool GoalDryer = false;
    public bool GoalMicrowave = false;

    public bool GoalWasher = false;

    //먹은거 갯수세기
    public int AppleCount = 0;
    public int SnackCount = 0;
    public int MilkCount = 0;
    public int FishCount = 0;

    public int SoapCount = 0;
    public int PencilCount = 0;
    public int ClockCount = 0;
    public int SocksCount = 0;
    public int PlushCount = 0;

    public int BatteryCount = 0;
    public int TvCount = 0;
    public int DryerCount = 0;
    public int MicrowaveCount = 0;
    public int WasherCount = 0;

    //1층 가격, 점수
    public int AppleCost = 200;
    public int SnackCost = 100;
    public int MilkCost = 100;
    public int FishCost = 300;

    public int AppleScore = 600;
    public int SnackScore = 100;
    public int MilkScore = 200;
    public int FishScore = 300;

    //2층
    public int SoapCost = 400;
    public int PencilCost = 200;
    public int ClockCost = 600;
    public int SocksCost = 400;
    public int PlushCost = 600;

    public int SoapScore = 400;
    public int PencilScore = 200;
    public int ClockScore = 600;
    public int SocksScore = 1200;
    public int PlushScore = 1200;

    //3층
    public int BatteryCost = 300;
    public int TvCost = 1000;
    public int DryerCost = 600;
    public int MicrowaveCost = 900;

    public int BatteryScore = 300;
    public int TvScore = 1000;
    public int DryerScore = 1800;
    public int MicrowaveScore = 900;


    //세탁기
    public int WasherCost = 4000;
    public int WasherScore = 2000;

}
