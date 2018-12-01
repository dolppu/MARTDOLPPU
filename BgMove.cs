using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMove : MonoBehaviour
{
    public float BgMoveSpped = 0.2f;

    private void Update()
    {
        if (DataManager.Instance.DolppuPay == false)
        {
            gameObject.transform.Translate(-BgMoveSpped * Time.deltaTime, 0, 0);
        }
    }
}
