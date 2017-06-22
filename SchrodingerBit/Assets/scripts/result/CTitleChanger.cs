using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTitleChanger : MonoBehaviour
{

    public void SceneChanger()
    {
        CFadeManager.Instance.LoadScene("Title", 2.0f);
    }
}
