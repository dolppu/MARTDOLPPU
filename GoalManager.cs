using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    private void Awake()
    {
        switch (DataManager.Instance.ShoppingSuccess)
        {
            case 0 : Goal_1(); break;
            case 1 : Goal_2(); break;
            case 2 : Goal_3(); break;
            case 3 : Goal_4(); break;
            case 4 : Goal_5(); break;
            case 5 : Goal_6(); break;

            default : Goal_Random(); break;
        }
    }

    void Goal_1()
    {
        DataManager.Instance.GoalNumber = 1;    //골넘버도 달았단애~
        DataManager.Instance.GoalApple = true;
        DataManager.Instance.GoalSnack = true;
        DataManager.Instance.GoalMilk = true;
        DataManager.Instance.GoalFish = true;
        DataManager.Instance.GoalPencil = true;
    }
    void Goal_2()
    {
        DataManager.Instance.GoalNumber = 2;
        DataManager.Instance.GoalApple = true;
        DataManager.Instance.GoalMilk = true;
        DataManager.Instance.GoalFish = true;
        DataManager.Instance.GoalSoap = true;
        DataManager.Instance.GoalClock = true;
    }
    void Goal_3()
    {
        DataManager.Instance.GoalNumber = 3;
        DataManager.Instance.GoalSnack = true;
        DataManager.Instance.GoalMilk = true;
        DataManager.Instance.GoalPencil = true;
        DataManager.Instance.GoalSocks = true;
        DataManager.Instance.GoalBattery = true;
    }
    void Goal_4()
    {
        DataManager.Instance.GoalNumber = 4;
        DataManager.Instance.GoalApple = true;
        DataManager.Instance.GoalSoap = true;
        DataManager.Instance.GoalClock = true;
        DataManager.Instance.GoalSocks = true;
        DataManager.Instance.GoalDryer = true;
    }
    void Goal_5()
    {
        DataManager.Instance.GoalNumber = 5;
        DataManager.Instance.GoalMilk = true;
        DataManager.Instance.GoalPencil = true;
        DataManager.Instance.GoalPlush = true;
        DataManager.Instance.GoalBattery = true;
        DataManager.Instance.GoalMicrowave = true;
    }
    void Goal_6()
    {
        DataManager.Instance.GoalNumber = 6;
        DataManager.Instance.GoalClock = true;
        DataManager.Instance.GoalPlush = true;
        DataManager.Instance.GoalDryer = true;
        DataManager.Instance.GoalMicrowave = true;
        DataManager.Instance.GoalTv = true;
    }

    void Goal_Washer()   //세탁기
    {
        DataManager.Instance.GoalNumber = 0;
        DataManager.Instance.GoalWasher = true;
    }

    void Goal_Random()   //랜덤돌리기
    {
        //으으 좀만기둘리~ 저 위에다 만들어도되지만 이게 보기편할듯?
        switch (Random.Range(0, 7))
        {
            case 0: Goal_1(); break;
            case 1: Goal_2(); break;
            case 2: Goal_3(); break;
            case 3: Goal_4(); break;
            case 4: Goal_5(); break;
            case 5: Goal_6(); break;

            default: Goal_Washer(); break;
        }
    }

}
