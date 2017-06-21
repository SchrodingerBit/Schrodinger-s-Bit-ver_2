/*
GetComponent<Text>().text = m_time.ToString("f1");
()内は表示したい小数点以下
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CTime : MonoBehaviour {

    public static float m_timeSeconds;                      // 秒
    public static float m_timeMinute;                       // 分
    public float m_TimeChange;                              // 残り時間
    public bool m_MinuteFlg;                                // 秒が[0]になった時に[true]
    public bool m_SecondsFlg;                               // 分が[0]になったら[true]

    private float a;    // デバッグ 遊び


    void Start () {
        m_timeMinute  = (m_TimeChange / 60) - 1;            // 分
       // m_timeSeconds = (m_TimeChange - 1) % 60;            // 秒
    }
	

	void Update () {
        timer();
    }


    void timer()
    {
        //Debug.Log("Time:"+m_TimeChange);
        m_timeSeconds -= (Time.deltaTime);                // 時間減らすところ

        if (m_timeSeconds < 0)                              // 秒が0になったら59秒から再スタート
        {
            m_MinuteFlg = true;                             // 秒が0になったらon

            m_timeSeconds = (m_TimeChange - 1) % 60;    // 59秒表示
        }


        if (m_MinuteFlg == true)
        {
            m_timeMinute -= 1;                              // 分を減らす
            m_MinuteFlg = false;

            if (m_timeMinute < 0)                               // 分が0未満にならない
            {
                m_timeMinute = 0;
            }

        }



        Debug.Log(m_SecondsFlg);


        GetComponent<Text>().text = m_timeMinute.ToString("f0") +":"+ m_timeSeconds.ToString("f0"); // [分　:　秒]で表示

        a += (Time.deltaTime);    // デバッグ 数値加算 遊び
        //Debug.Log(a);           // デバッグ 遊び
    }
}
