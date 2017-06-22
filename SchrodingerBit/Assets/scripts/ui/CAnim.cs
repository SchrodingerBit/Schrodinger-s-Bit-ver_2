using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAnim : MonoBehaviour {

    [SerializeField]

    void Start()
    {
        transform.SetAsFirstSibling();
    }

    void Update () {
        Animator anim = GetComponent<Animator>();

        AnimatorStateInfo animInfo = anim.GetCurrentAnimatorStateInfo(0);

        if (animInfo.normalizedTime > 1.0f)
        {
            Destroy(gameObject);    
        }
    }
}
