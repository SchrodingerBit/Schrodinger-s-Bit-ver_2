using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CClearSceneChange : MonoBehaviour
{
    public static bool clearFlag;

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.CompareTag("player"))
        {
            clearFlag = true;
            CFadeManager.Instance.LoadScene("Result", 2.0f);
        }


    }
}
