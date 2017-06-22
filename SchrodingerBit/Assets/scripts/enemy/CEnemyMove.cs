using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyMove : MonoBehaviour
{

    Rigidbody2D rb;
    Vector3 pos;

    public bool m_moveVectorFlag;

    public int m_moveSpeed;

    private bool m_vectorFlag;
    private int m_cnt;
    private float speed;

    void Start()
    {
        // コンポーネントの取得
        rb = GetComponent<Rigidbody2D>();
        m_vectorFlag = true;// true : right　false : left
        m_cnt = 0;
        speed = -0.08f;
    }

    void FixedUpdate()
    {
        // フラグによってスピードを変える
        if (m_vectorFlag) m_moveSpeed = 1;
        if (!m_vectorFlag) m_moveSpeed = -1;

        // true : Vertical false : Horizontal
        if (m_moveVectorFlag)
        {
            // velocity : 速度
            //rb.velocity = new Vector2(m_moveSpeed, rb.velocity.y);
            transform.position = new Vector2(transform.position.x + speed, transform.position.y);
        }
        if (!m_moveVectorFlag)
        {
            // velocity : 速度
            //rb.velocity = new Vector2(rb.velocity.x, m_moveSpeed);
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);

        }
        m_cnt++;
        
        if (m_cnt >= 100)
        {
             if(m_vectorFlag == true) speed = -0.08f;
             if (m_vectorFlag == false) speed = 0.08f;
            m_vectorFlag = !m_vectorFlag;
            m_cnt = 0;
        }
        
    }
}