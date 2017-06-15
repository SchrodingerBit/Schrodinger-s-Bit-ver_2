using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSlectChenger : MonoBehaviour
{
    public void SceneChanger()
    {
        CFadeManager.Instance.LoadScene("StageSlect", 2.0f);
    }

}
