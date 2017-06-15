using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Sprite devil;
    public Sprite human;
    public Sprite NUMELA;

   /* public static bool m_downFlg = false;
    public static bool m_upFlg = false;
    public static bool m_rightFlg = false;
    public static bool m_leftFlg = false;*/

    //移動速度
    //[SerializeField]
    //float speed;

    //double GravitySpeed = -3;
    public float speed = 5;
    public float MSpeed = 0;

    //移動ベクトル
    Vector3 velocity;

    //Rigidbody2Dコンポーネント
    Rigidbody2D rigidbody2d;

    //変身の判定
    float ChangeFlug = 0;

    //地面に着いているか
    bool isGrounded;

    // Use this for initialization
    void Start () {
        //Rigibody2Dコンポーネントの取得
        rigidbody2d = GetComponent<Rigidbody2D>();
        //GetComponent<Rigidbody2D>().velocity = transform.up * -speed;
    }
	
	// Update is called once per frame
	void Update () {
        //地面に接しているかを算出
        /*isGrounded = Physics2D.Raycast(
            transform.position, Vector2.down,
            1.6f, 1 << LayerMask.NameToLayer("culoud"));
        
        //地面についてい無いときに下向きの力
        if (!isGrounded)
        {
            velocity.y += 0.5f;
        }*/

        GetComponent<Rigidbody2D>().velocity = transform.up * -speed;

        if (ChangeFlug == 0)
        {
            Run();
        }
        else if (ChangeFlug == 1)
        {
            Fly();
        }
        else if (ChangeFlug == 2)
        {
            Run();
        }

        if (Input.GetKeyDown(KeyCode.Z) && ChangeFlug != 0)
        {
            HumanTrance();
        }
        if (Input.GetKeyDown(KeyCode.X) && ChangeFlug != 1)
        {
            KuwagataTrance();
        }
        if (Input.GetKeyDown(KeyCode.C) && ChangeFlug != 2)
        {
            CulubTrance();
        }

    }

    void Run()
    {
        //ベクトルを０に初期化
        velocity = Vector3.zero;

        //キー入力によりベクトルを加算
        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x += MSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x += -MSpeed;
        }

        //座標更新
        transform.position += velocity;

    }

    void Fly()
    {
        //ベクトルを０に初期化
        velocity = Vector3.zero;

        //キー入力によりベクトルを加算
        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x += MSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x += -MSpeed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity.y += 0.15f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity.y += -MSpeed;
        }

        //座標更新
        transform.position += velocity;

    }


    void KuwagataTrance()
    {
        Debug.Log("InTrance");
        //クワガタに変身
        //if (Input.GetKeyDown(KeyCode.Space) && ChangeFlug == 0)
        //{
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
            renderer.sprite = devil;
            ChangeFlug = 1;
            Debug.Log(ChangeFlug);
        //}
        //人間に変身
       /* if (Input.GetKeyDown(KeyCode.Space) && ChangeFlug == 1)
        {
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
            renderer.sprite = human;
            ChangeFlug = 0;
            Debug.Log(ChangeFlug);
        }*/
    }
    void HumanTrance()
    {
        //人間に変身
        //if (Input.GetKeyDown(KeyCode.Space) && ChangeFlug == 1)
        //{
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
            renderer.sprite = human;
            ChangeFlug = 0;
            Debug.Log(ChangeFlug);
        //}
    }
    void CulubTrance()
    {
        //カニに変身
        //if (Input.GetKeyDown(KeyCode.Space) && ChangeFlug == 1)
        //{
        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer.sprite = NUMELA;
        ChangeFlug = 2;
        Debug.Log(ChangeFlug);
        //}
    }


}
