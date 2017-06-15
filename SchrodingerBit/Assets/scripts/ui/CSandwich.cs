using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CSandwich : MonoBehaviour
{
    public static Image m_changeHito;    // 表示される画像
    public static SpriteState m_a;

    public GameObject obj;               // 画像の入ったオブジェクト(プレハブなど)

    public static bool m_sandFlg = false;



    void Start()
    {
        m_changeHito = obj.GetComponent<Image>();
    }


    void Update()
    {

    }


    public void ButtonPush()
    {
        if (m_sandFlg == false)
        {
            m_sandFlg = true;
            Debug.Log("はさむ");
        }
        else if (m_sandFlg == true)
        {
            m_sandFlg = false;
            Debug.Log("置く");
        }
        //Debug.Log(m_sandFlg);

    }
}
