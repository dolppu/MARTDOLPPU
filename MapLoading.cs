using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLoading : MonoBehaviour
{
    public GameObject Floor1_1;
    public GameObject Floor1_2;
    public GameObject Floor1_3;
    public GameObject Floor2_1;
    public GameObject Floor2_2;
    public GameObject Floor2_3;
    public GameObject Floor3_1;
    public GameObject Floor3_2;
    public GameObject Floor3_3;

    private void Awake()
    {
        switch (Random.Range(1, 4))     //1층
        {
            case 1 : Floor1_1.SetActive(true); break;
            case 2 : Floor1_2.SetActive(true); break;
            default : Floor1_3.SetActive(true); break;
        }
        switch (Random.Range(1, 4))     //2층
        {
            case 1: Floor2_1.SetActive(true); break;
            case 2: Floor2_2.SetActive(true); break;
            default: Floor2_3.SetActive(true); break;
        }
        switch (Random.Range(1, 4))     //3층
        {
            case 1: Floor3_1.SetActive(true); break;
            case 2: Floor3_2.SetActive(true); break;
            default: Floor3_3.SetActive(true); break;
        }
    }
}
