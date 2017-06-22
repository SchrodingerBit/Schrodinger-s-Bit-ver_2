using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CGauge : MonoBehaviour {

    Slider slider;                  // InspectorのSliderを引っ張る
    float time;                     // 制限時間


    void Start () {
        slider = GameObject.Find("Slider").GetComponent<Slider>();

        time = slider.maxValue; // ゲージの最大値セット
    }


    void Update () {
        Timegauge();
        /*
        // デバッグ用　ループ
        if(time < slider.minValue)  // 0になったら
        {
          time = slider.maxValue;   // 最大値を代入
        }
        */

    }

    void Timegauge()
    {
        time -= Time.deltaTime;     // 制限時間カウント　最大値から減らす

        slider.value = time;        // timeゲージに値を設定  
    }

}