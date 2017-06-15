using UnityEngine;
using System.Collections;

public class SE : MonoBehaviour
{

    public AudioClip audioClip;
    AudioSource audioSource;



    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            // Aを押すとSEを再生
            audioSource.Play();
        }
    }
}