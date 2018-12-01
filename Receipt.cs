using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Receipt : MonoBehaviour
{
    public Text DateTimeText;
    public Text QuantityText;
    public Text AmountText;
    public Text TotalScoreText;

    private void Start()
    {
        DateTimeText.text = System.DateTime.Now.ToString("yyyy-MM-dd  HH : mm");

        QuantityText.text =
            DataManager.Instance.AppleCount.ToString() + "\n" +
            DataManager.Instance.SnackCount.ToString() + "\n" +
            DataManager.Instance.MilkCount.ToString() + "\n" +
            DataManager.Instance.FishCount.ToString() + "\n" +
            DataManager.Instance.SoapCount.ToString() + "\n" +
            DataManager.Instance.PencilCount.ToString() + "\n" +
            DataManager.Instance.ClockCount.ToString() + "\n" +
            DataManager.Instance.SocksCount.ToString() + "\n" +
            DataManager.Instance.PlushCount.ToString() + "\n" +
            DataManager.Instance.BatteryCount.ToString() + "\n" +
            DataManager.Instance.TvCount.ToString() + "\n" +
            DataManager.Instance.DryerCount.ToString() + "\n" +
            DataManager.Instance.MicrowaveCount.ToString() + "\n" +
            DataManager.Instance.WasherCount.ToString();

        AmountText.text =
            AApple.ToString() + "\n" +
            ASnack.ToString() + "\n" +
            AMilk.ToString() + "\n" +
            AFish.ToString() + "\n" +
            ASoap.ToString() + "\n" +
            APencil.ToString() + "\n" +
            AClock.ToString() + "\n" +
            ASocks.ToString() + "\n" +
            APlush.ToString() + "\n" +
            ABattery.ToString() + "\n" +
            ATv.ToString() + "\n" +
            ADryer.ToString() + "\n" +
            AMicrowave.ToString() + "\n" +
            AWasher.ToString();

        if (DataManager.Instance.PoketMoneyCurrent >= 0)
        {
            TotalScoreText.text =
                (DataManager.Instance.PoketMoneyMax - DataManager.Instance.PoketMoneyCurrent).ToString() + "\n" +
                DataManager.Instance.PoketMoneyMax.ToString() + "\n" +
                DataManager.Instance.PoketMoneyCurrent.ToString() + "\n" +
                DataManager.Instance.Score.ToString() + "\n" +
                DataManager.Instance.BestScore.ToString();
        } else
        {
            TotalScoreText.text =
                (DataManager.Instance.PoketMoneyMax - DataManager.Instance.PoketMoneyCurrent).ToString() + "\n" +
                DataManager.Instance.PoketMoneyMax.ToString() + "\n" +
                DataManager.Instance.PoketMoneyCurrent.ToString() + "\n" +
                DataManager.Instance.Score.ToString() + "\n" +
                "0";
        }
    }

    //ㅎ;; 귀찮아서 그냥 불러오지않고 입력함..
    int AApple = DataManager.Instance.AppleCount * 200;
    int ASnack = DataManager.Instance.AppleCount * 100;
    int AMilk = DataManager.Instance.AppleCount * 100;
    int AFish = DataManager.Instance.AppleCount * 300;
    int ASoap = DataManager.Instance.AppleCount * 400;
    int APencil = DataManager.Instance.AppleCount * 200;
    int AClock = DataManager.Instance.AppleCount * 600;
    int ASocks = DataManager.Instance.AppleCount * 400;
    int APlush = DataManager.Instance.AppleCount * 600;
    int ABattery = DataManager.Instance.AppleCount * 300;
    int ATv = DataManager.Instance.AppleCount * 1000;
    int ADryer = DataManager.Instance.AppleCount * 600;
    int AMicrowave = DataManager.Instance.AppleCount * 900;
    int AWasher = DataManager.Instance.AppleCount * 4000;
}
