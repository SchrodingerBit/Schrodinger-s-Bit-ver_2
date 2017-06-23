using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyHit : MonoBehaviour
{

    SpriteRenderer MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする
    public Sprite StandbySprite;
    public Sprite HoldSprite;
    public Sprite SlashSprite;

    void Start()
    {
        // このobjectのSpriteRendererを取得
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }


    void OnCollisionEnter2D(Collision2D hit)
    {


        if (hit.gameObject.CompareTag("sand"))
        {

            OpenDoor();
            Destroy(hit.gameObject);
        }

    }
    void OpenDoor()
    {
        //スプライト切り替え
        MainSpriteRenderer.sprite = HoldSprite;
    }
}