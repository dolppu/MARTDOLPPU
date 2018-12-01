using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float MapSpeed = 8f;

    private void Update()
    {
        if(DataManager.Instance.DolppuPay == false)
        {
            gameObject.transform.Translate(-MapSpeed * Time.deltaTime, 0, 0);
        }
    }
}
