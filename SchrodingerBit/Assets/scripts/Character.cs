using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public Sprite devil;

    //移動速度
    [SerializeField]
    float speed;

    //移動ベクトル
    Vector3 velocity;

    //
    float ChangeFlug = 0;


    //Rigidbody2Dコンポーネント
    Rigidbody2D rigidbody2d;

    // Use this for initialization
    void Start()
    {
        //Rigibody2Dコンポーネントの取得
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (ChangeFlug == 0)
        {
            Run();
        }
        else if (ChangeFlug == 1)
        {
            Fly();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
            renderer.sprite = devil;
            ChangeFlug = 1;
        }

    }

    void Fly()
    {
        //ベクトルを０に初期化
        velocity = Vector3.zero;

        //キー入力によりベクトルを加算
        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x += speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x += -speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity.y += 0.5f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity.y += -speed;
        }

        //座標更新
        transform.position += velocity;

    }

    void Run()
    {
        //ベクトルを０に初期化
        velocity = Vector3.zero;

        //キー入力によりベクトルを加算
        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x += speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x += -speed;
        }

        //座標更新
        transform.position += velocity;

    }

}
