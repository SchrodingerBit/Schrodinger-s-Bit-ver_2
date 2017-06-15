using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPushbutton : MonoBehaviour {

    // 初期化
    public static bool m_downFlg  = false;
    public static bool m_upFlg    = false;
    public static bool m_rigthFlg = false;
    public static bool m_leftFlg  = false;

    // ↑ キーが押された時
    public void UppushDown()
    {
        if (m_upFlg == false) m_upFlg = true;
    }
    // ↓ キーが押された時
    public void DownpushDown()
    {
        if (m_downFlg == false) m_downFlg = true;
    }
    // → キーが押された時
    public void RigthpushDown()
    {
        if (m_rigthFlg == false) m_rigthFlg = true;
    }
    // ← キーが押された時
    public void LeftpushDown()
    {
        if (m_leftFlg == false) m_leftFlg = true;
    }


    // ↑ キーが押されてない時
    public void UppushUp()
    {
        if (m_upFlg == true) m_upFlg = false;
    }
    // ↓ キーが押されてない時
    public void DownpushUp()
    {
        if (m_downFlg == true) m_downFlg = false;
    }
    // → キーが押されてない時
    public void RigthpushUp()
    {
        if (m_rigthFlg == true) m_rigthFlg = false;
    }
    // ← キーが押されてない時
    public void LeftpushUp()
    {
        if (m_leftFlg == true) m_leftFlg = false;
    }



    //デバック用
    void Update()
    {
        if (m_upFlg == true)
        {
            Debug.Log("up");
        }
        if (m_downFlg == true)
        {
            Debug.Log("down");
        }
        if (m_rigthFlg == true)
        {
            Debug.Log("rigth");
        }
        if (m_leftFlg == true)
        {
            Debug.Log("left");
        }

    }
}
