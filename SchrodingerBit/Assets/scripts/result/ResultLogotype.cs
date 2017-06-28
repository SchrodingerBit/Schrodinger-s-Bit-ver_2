using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultLogotype : MonoBehaviour
{

    public float logocnt = 0.001f;
    private static int i;

	// Use this for initialization
	void Start ()
    {
        Transform Logo = this.GetComponent<Transform>();
        Vector3 pos = Logo.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //transform.SetAsLastSibling();
        if (i <= 10) 
        {
            i++;
        }
        if (i >= 10 && i <= 40 )
        {
            if (i % 2 == 0)
            {
                gameObject.transform.localScale += new Vector3(0.002f+(logocnt), 0.002f+(logocnt), 0);
            }
            i++;
        }
    }
}
