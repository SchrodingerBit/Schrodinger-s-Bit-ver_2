using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLogo : MonoBehaviour
{

    SpriteRenderer MainSpriteRenderer;
    //publicで宣言し、inspectorで設定可能にする
    public Sprite StandbySprite;
    public Sprite HoldSprite;
    public Sprite SlashSprite;
    public static bool logoflg =true; //true…クリア成功　false…クリア失敗
    //Vector3 logoPos;

    void Start()
    {
        // このobjectのSpriteRendererを取得
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = StandbySprite;
        transform.SetAsFirstSibling();
        Debug.Log("CLogo:" + logoflg);
    }


    void Update()
    {
        if (logoflg)
        {
            Success();
        }
        if (!logoflg)
        {
            Failure();
        }
    }
    void Failure()
    {
        //スプライト切り替え
        MainSpriteRenderer.sprite = HoldSprite;
        CClearTime.logoflg = false;
       
    }
    void Success()
    {
        //スプライト切り替え
        MainSpriteRenderer.sprite = StandbySprite;
        CClearTime.logoflg = true;
    }
}