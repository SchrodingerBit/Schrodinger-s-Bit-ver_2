using UnityEngine;
using System.Collections;

public class CClearImage : MonoBehaviour
{
    public float fadeTime = 1f;

    private float currentRemainTime;
    private SpriteRenderer spRenderer;
    private bool fadeFlag;

    // Use this for initialization
    void Start()
    {
        // 初期化
        currentRemainTime = fadeTime;
        spRenderer = GetComponent<SpriteRenderer>();
        fadeFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentRemainTime);
        if (fadeFlag)
        {
            FadeIn();
        }
        else
        {
            FadeOut();
        }
    }

    void FadeIn()
    {
        // 残り時間を更新
        currentRemainTime += Time.deltaTime;

        if (currentRemainTime >= 5f)
        {
            fadeFlag = !fadeFlag;
            return;
        }

        // フェードイン
        float alpha = currentRemainTime / fadeTime;
        var color = spRenderer.color;
        color.a = alpha;
        spRenderer.color = color;
    }
    void FadeOut()
    {
        // 残り時間を更新
        currentRemainTime -= Time.deltaTime;

        if (currentRemainTime <= 0f)
        {
            // 残り時間が無くなったら自分自身を消滅
            GameObject.Destroy(gameObject);
            return;
        }

        // フェードアウト
        float alpha = currentRemainTime / fadeTime;
        var color = spRenderer.color;
        color.a = alpha;
        spRenderer.color = color;
    }
}

