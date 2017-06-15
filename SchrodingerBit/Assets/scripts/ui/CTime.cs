/*
m_time = (120 / 60);は分を出すため

GetComponent<Text>().text = m_time.ToString("f1");
表示するのにはm_time.ToString("f1")で分でやってるように見せる

 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CTime : MonoBehaviour {

    public static float m_time = (120 / 60);
    private float a;    // デバッグ


    void Start () {
        GetComponent<Text>().text = m_time.ToString();
    }
	

	void Update () {
        m_time -= (Time.deltaTime / 60);
        if (m_time < 0) m_time = 0;
        GetComponent<Text>().text = m_time.ToString("f2");
        a += (Time.deltaTime);    // デバッグ 数値加算
        //Debug.Log(a);           // デバッグ
    }
}
