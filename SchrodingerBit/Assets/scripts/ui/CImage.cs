using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CImage : MonoBehaviour {

    public static Image m_changeHito;   // 表示される画像
    public static int m_imageStatus;


    // 変身の切り替え用
    /* 0:人　1:クワガタ　2:かに */
    public static int m_kuwagataChangeFlg;
    public static int m_kaniChangeFlg;

    // 表示画像
    private Image m_kuwagataImage;
    private Image m_kaniImage;

    // 変身ボタンの画像
    public Sprite m_imageHito;
    public Sprite m_imageKuwagata;
    public Sprite m_imageKani;

    // 挟むボタンの画像
    public Sprite m_imagePlayerkani;
    public Sprite m_imagePlayerkuwagata;
    public Sprite m_imagePlayerhito;


    void Start () {
        m_kuwagataChangeFlg = 0;
        m_kaniChangeFlg = 0;

        /* 0:人  1:かに  2:クワガタ */
        m_imageStatus = 0;

        m_kuwagataImage = GameObject.Find("kuwagata").GetComponent<Image>();
        m_kaniImage = GameObject.Find("kani").GetComponent<Image>();



        m_hasamu = GameObject.Find("hasamu").GetComponent<Button>();

    }


    void Update()
    {
       // Debug.Log("CImage:"+m_imageStatus);
    }

    // クワガタ
    public void KuwagataButtonPush()
    {
        // 初期化
        m_kaniImage.sprite = m_imageKani;
        m_kaniChangeFlg = 0;


        if (m_kuwagataChangeFlg == 0)
        {
            m_kuwagataChangeFlg = 1;
            m_imageStatus = 1;

            CSandwich.m_changeHito.sprite = m_imagePlayerkuwagata;
            m_kuwagataImage.sprite = m_imageHito;
        }
        else if (m_kuwagataChangeFlg == 1)
        {
            m_kuwagataChangeFlg = 0;
            m_imageStatus = 0;

            CSandwich.m_changeHito.sprite = m_imagePlayerhito;
            m_kuwagataImage.sprite = m_imageKuwagata;
        }
    }


    // 蟹
    public void KaniButtonPush()
    {
        // 初期化
        m_kuwagataImage.sprite = m_imageKuwagata;
        m_kuwagataChangeFlg = 0;


        if (m_kaniChangeFlg == 0)
        {
            m_kaniChangeFlg = 2;
            m_imageStatus = 2;

            CSandwich.m_changeHito.sprite = m_imagePlayerkani;
            m_kaniImage.sprite = m_imageHito;
        }
        else if (m_kaniChangeFlg == 2)
        {
            m_kaniChangeFlg = 0;
            m_imageStatus = 0;

            CSandwich.m_changeHito.sprite = m_imagePlayerhito;
            m_kaniImage.sprite = m_imageKani;
        }
    }

    
    
    // 切り替えの時にラグがありこっちじゃないと最初に前の画像が残る
    private Button m_hasamu;

    public char hito;       // 区切りで入れてる
    public SpriteState m_SandImagehito;
    public char kuwagata;   // 区切りで入れてる
    public SpriteState m_SandImagekuwagata;
    public char kani;       // 区切りで入れてる
    public SpriteState m_SandImageKani;


    public void ChangeButton()
    {
        // 人の時のはさむ
        if (m_imageStatus == 0)
        {
            m_hasamu.spriteState = m_SandImagehito;
           // Debug.Log("hito:" + m_imageStatus);
        }
        // クワガタの時の
        if (CImage.m_imageStatus == 1)
        {
            m_hasamu.spriteState = m_SandImagekuwagata;
           // Debug.Log("kuwagata:" + m_imageStatus);
        }
        // カニの時のはさむ
        if (CImage.m_imageStatus == 2)
        {
            m_hasamu.spriteState = m_SandImageKani;
           // Debug.Log("kani:" + m_imageStatus);
        }
    }
    
}
