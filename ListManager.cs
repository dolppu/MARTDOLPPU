using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListManager : MonoBehaviour
{
    public GameObject List1;
    public GameObject List2;
    public GameObject List3;
    public GameObject List4;
    public GameObject List5;
    public GameObject List6;
    public GameObject List0;

    public GameObject G11;
    public GameObject G12;
    public GameObject G13;
    public GameObject G14;
    public GameObject G15;

    public GameObject G21;
    public GameObject G22;
    public GameObject G23;
    public GameObject G24;
    public GameObject G25;

    public GameObject G31;
    public GameObject G32;
    public GameObject G33;
    public GameObject G34;
    public GameObject G35;

    public GameObject G41;
    public GameObject G42;
    public GameObject G43;
    public GameObject G44;
    public GameObject G45;

    public GameObject G51;
    public GameObject G52;
    public GameObject G53;
    public GameObject G54;
    public GameObject G55;

    public GameObject G61;
    public GameObject G62;
    public GameObject G63;
    public GameObject G64;
    public GameObject G65;

    public GameObject G01;


    private void Start()
    {
        switch (DataManager.Instance.GoalNumber)
        {
            case 1: List1.SetActive(true); break;
            case 2: List2.SetActive(true); break;
            case 3: List3.SetActive(true); break;
            case 4: List4.SetActive(true); break;
            case 5: List5.SetActive(true); break;
            case 6: List6.SetActive(true); break;
            default: List0.SetActive(true); break;
        }
    }

    private void Update()
    {
        switch (DataManager.Instance.GoalNumber)
        {
            case 1: OnOffLix1(); break;
            case 2: OnOffLix2(); break;
            case 3: OnOffLix3(); break;
            case 4: OnOffLix4(); break;
            case 5: OnOffLix5(); break;
            case 6: OnOffLix6(); break;
            default: OnOffLix0(); break;
        }
    }

    void OnOffLix1()
    {
        if(G11.activeSelf == true)
        {
            if (DataManager.Instance.AppleCount >= 1)
                G11.SetActive(false);
        }
        if (G12.activeSelf == true)
        {
            if (DataManager.Instance.SnackCount >= 1)
                G12.SetActive(false);
        }
        if (G13.activeSelf == true)
        {
            if (DataManager.Instance.MilkCount >= 1)
                G13.SetActive(false);
        }
        if (G14.activeSelf == true)
        {
            if (DataManager.Instance.FishCount >= 1)
                G14.SetActive(false);
        }
        if (G15.activeSelf == true)
        {
            if (DataManager.Instance.PencilCount >= 1)
                G15.SetActive(false);
        }
    }

    void OnOffLix2()
    {
        if (G21.activeSelf == true)
        {
            if (DataManager.Instance.AppleCount >= 1)
                G21.SetActive(false);
        }
        if (G22.activeSelf == true)
        {
            if (DataManager.Instance.MilkCount >= 1)
                G22.SetActive(false);
        }
        if (G23.activeSelf == true)
        {
            if (DataManager.Instance.FishCount >= 1)
                G23.SetActive(false);
        }
        if (G24.activeSelf == true)
        {
            if (DataManager.Instance.SoapCount >= 1)
                G24.SetActive(false);
        }
        if (G25.activeSelf == true)
        {
            if (DataManager.Instance.ClockCount >= 1)
                G25.SetActive(false);
        }
    }

    void OnOffLix3()
    {
        if (G31.activeSelf == true)
        {
            if (DataManager.Instance.SnackCount >= 1)
                G31.SetActive(false);
        }
        if (G32.activeSelf == true)
        {
            if (DataManager.Instance.MilkCount >= 1)
                G32.SetActive(false);
        }
        if (G33.activeSelf == true)
        {
            if (DataManager.Instance.PencilCount >= 1)
                G33.SetActive(false);
        }
        if (G34.activeSelf == true)
        {
            if (DataManager.Instance.SocksCount >= 1)
                G34.SetActive(false);
        }
        if (G35.activeSelf == true)
        {
            if (DataManager.Instance.BatteryCount >= 1)
                G35.SetActive(false);
        }
    }

    void OnOffLix4()
    {
        if (G41.activeSelf == true)
        {
            if (DataManager.Instance.AppleCount >= 1)
                G41.SetActive(false);
        }
        if (G42.activeSelf == true)
        {
            if (DataManager.Instance.SoapCount >= 1)
                G42.SetActive(false);
        }
        if (G43.activeSelf == true)
        {
            if (DataManager.Instance.ClockCount >= 1)
                G43.SetActive(false);
        }
        if (G44.activeSelf == true)
        {
            if (DataManager.Instance.SocksCount >= 1)
                G44.SetActive(false);
        }
        if (G45.activeSelf == true)
        {
            if (DataManager.Instance.DryerCount >= 1)
                G45.SetActive(false);
        }
    }

    void OnOffLix5()
    {
        if (G51.activeSelf == true)
        {
            if (DataManager.Instance.MilkCount >= 1)
                G51.SetActive(false);
        }
        if (G52.activeSelf == true)
        {
            if (DataManager.Instance.PencilCount >= 1)
                G52.SetActive(false);
        }
        if (G53.activeSelf == true)
        {
            if (DataManager.Instance.PlushCount >= 1)
                G53.SetActive(false);
        }
        if (G54.activeSelf == true)
        {
            if (DataManager.Instance.BatteryCount >= 1)
                G54.SetActive(false);
        }
        if (G55.activeSelf == true)
        {
            if (DataManager.Instance.MicrowaveCount >= 1)
                G55.SetActive(false);
        }
    }

    void OnOffLix6()
    {
        if (G61.activeSelf == true)
        {
            if (DataManager.Instance.ClockCount >= 1)
                G61.SetActive(false);
        }
        if (G62.activeSelf == true)
        {
            if (DataManager.Instance.PlushCount >= 1)
                G62.SetActive(false);
        }
        if (G63.activeSelf == true)
        {
            if (DataManager.Instance.DryerCount >= 1)
                G63.SetActive(false);
        }
        if (G64.activeSelf == true)
        {
            if (DataManager.Instance.MicrowaveCount >= 1)
                G64.SetActive(false);
        }
        if (G65.activeSelf == true)
        {
            if (DataManager.Instance.TvCount >= 1)
                G65.SetActive(false);
        }
    }

    void OnOffLix0()
    {
        if (G01.activeSelf == true)
        {
            if (DataManager.Instance.WasherCount >= 1)
                G01.SetActive(false);
        }
    }
}
