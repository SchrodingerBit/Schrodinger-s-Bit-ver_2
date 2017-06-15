using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CConfigChenger : MonoBehaviour
{
    public void SceneChanger()
    {
        CFadeManager.Instance.LoadScene("Config", 2.0f);
    }
}
