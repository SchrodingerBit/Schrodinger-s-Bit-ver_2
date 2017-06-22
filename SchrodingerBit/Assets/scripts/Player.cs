using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //使用する画像の定義
    public Sprite devil;
    public Sprite human;
    public Sprite NUMELA;

     public static bool m_downFlg = false;
     public static bool m_upFlg = false;
     public static bool m_rigthFlg = false;
     public static bool m_leftFlg = false;

    public static int m_imageStatus;

    public float speed = 2;//疑似重力
    public float MSpeed = 1;//移動速度

    //移動ベクトル
    Vector3 velocity;

    //Rigidbody2Dコンポーネント
    Rigidbody2D rigidbody2d;

    //変身の判定
    float ChangeFlug = 0;

    //地面に着いているか
    bool isGrounded;

    //走行中か
    bool isRunning;

    // Use this for initialization
    void Start()
    {
        //Rigibody2Dコンポーネントの取得
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //地面に接しているかを算出
        isGrounded = Physics2D.Raycast(
            transform.position, Vector2.down,
            0.8f, 1 << LayerMask.NameToLayer("Ground"));


        //疑似重力(常に下向きの力)
        //GetComponent<Rigidbody2D>().velocity = transform.up * -speed;

        if (ChangeFlug == 0)
        {
            //疑似重力(常に下向きの力)
            GetComponent<Rigidbody2D>().velocity = transform.up * -speed;
            MSpeed = 0.1f;
            Run();
        }
        else if (ChangeFlug == 1)
        {
            MSpeed = 0.1f;
            Fly();
        }
        else if (ChangeFlug == 2)
        {
            //疑似重力(常に下向きの力)
            GetComponent<Rigidbody2D>().velocity = transform.up * -speed;
            MSpeed = 0.05f;
            ClubRun();
        }

        if (CImage.m_imageStatus == 0 && ChangeFlug != 0)
        {
            HumanTrance();
        }
        if (CImage.m_imageStatus == 1 && ChangeFlug != 1)
        {
            KuwagataTrance();
        }
        if (CImage.m_imageStatus == 2 && ChangeFlug != 2)
        {
            CulubTrance();
        }

    }

    void Run()
    {
        //ベクトルを０に初期化
        velocity = Vector3.zero;

        //キー入力によりベクトルを加算
        if (CPushbutton.m_rigthFlg == true)
        {
            velocity.x += MSpeed;
        }
        if (CPushbutton.m_leftFlg == true)
        {
            velocity.x += -MSpeed;
        }

        //座標更新
        transform.position += velocity;

        //velocityの長さが０以外であれば移動している
        isRunning = !(velocity.magnitude == 0);

        //スペースキーでジャンプ
        if (CPushbutton.m_upFlg == true)
        {

            //地面についているときだけジャンプ
            if (isGrounded)
            {
                Jump();
            }
        }
    }

    void Fly()
    {
        //ベクトルを０に初期化
        velocity = Vector3.zero;

        //キー入力によりベクトルを加算
        if (CPushbutton.m_rigthFlg == true)
        {
            velocity.x += MSpeed;
        }
        if (CPushbutton.m_leftFlg == true)
        {
            velocity.x += -MSpeed;
        }
        if (CPushbutton.m_upFlg == true)
        {
            velocity.y += MSpeed;
        }
        if (CPushbutton.m_downFlg == true)
        {
            velocity.y += -MSpeed;
        }

        //座標更新
        transform.position += velocity;

    }

    void ClubRun()
    {
        //ベクトルを０に初期化
        velocity = Vector3.zero;

        //キー入力によりベクトルを加算
        if (CPushbutton.m_rigthFlg == true)
        {
            velocity.x += MSpeed;
        }
        if (CPushbutton.m_leftFlg == true)
        {
            velocity.x += -MSpeed;
        }

        //座標更新
        transform.position += velocity;

        //velocityの長さが０以外であれば移動している
        isRunning = !(velocity.magnitude == 0);

    }


    void KuwagataTrance()
    {
        Debug.Log("InTrance");
        //クワガタに変身
        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer.sprite = devil;
        ChangeFlug = 1;
        Debug.Log(ChangeFlug);
    }
    void HumanTrance()
    {
        //人間に変身
        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer.sprite = human;
        ChangeFlug = 0;
        Debug.Log(ChangeFlug);
    }
    void CulubTrance()
    {
        //カニに変身
        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer.sprite = NUMELA;
        ChangeFlug = 2;
        Debug.Log(ChangeFlug);
    }

    void Jump()
    {
        //上方向に力を加える
        rigidbody2d.AddForce(Vector2.up * 2500);
    }

    public bool IsRunning()
    {
        return isRunning;
    }

    public Vector3 GetDirection()
    {
        //ベクトルの向きだけが欲しいので、正規化します。
        return velocity.normalized;
    }

    public bool IsGrounded()
    {
        return isGrounded;
    }
    
}
