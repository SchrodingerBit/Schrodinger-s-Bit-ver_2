using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSceneChanger : MonoBehaviour {

    public void SceneChanger()
    {
        CFadeManager.Instance.LoadScene("Menu", 2.0f);
    }
}
