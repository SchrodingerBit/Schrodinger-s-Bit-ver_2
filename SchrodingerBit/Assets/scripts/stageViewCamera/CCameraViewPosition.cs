using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCameraViewPosition : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (CStageChanger.cameraPositionFlag == 1)
        {
            this.transform.position = new Vector3(5, 0, -10);
        }
        else
        {
            this.transform.position = new Vector3(0, 0, -10);
        }
	}
}
