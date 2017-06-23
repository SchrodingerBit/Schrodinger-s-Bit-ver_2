using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSanderGimmik : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            CClearSceneChange.clearFlag = false;
            CFadeManager.Instance.LoadScene("Result", 2.0f);
        }


    }
}
