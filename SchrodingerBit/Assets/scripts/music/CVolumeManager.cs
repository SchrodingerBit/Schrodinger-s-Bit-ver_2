
using UnityEngine;
using System.Collections;


public class CVolumeManager : MonoBehaviour
{


    [SerializeField]
    UnityEngine.Audio.AudioMixer m_mixer; // 音量調整用変数

    public float masterVolume
    {
        set { m_mixer.SetFloat("BGM", Mathf.Lerp(-80, 0, value)); }
    }
}