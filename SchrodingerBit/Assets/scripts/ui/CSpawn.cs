using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSpawn : MonoBehaviour
{
    public GameObject Trans;    // 生成するオブジェ
    public GameObject supon;    // 

    Vector2 pos;

    // Use this for initialization
    void Start()
    {
        pos = supon.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Ppushanim()
    {
        Instantiate(Trans,pos, Quaternion.identity);
    }
}
