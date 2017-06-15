using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CStageChanger : MonoBehaviour {

    public int m_cameraPositionFlag;
    public static int cameraPositionFlag;

    public void SceneChanger()
    {

            CFadeManager.Instance.LoadScene("Game", 2.0f);  

    }
}
