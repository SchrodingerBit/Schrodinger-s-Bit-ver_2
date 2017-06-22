using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CReinGimmick : MonoBehaviour
{

    void Update()
    {
        if (Player.ChangeFlug == 2)
        {
            gameObject.layer = LayerMask.NameToLayer("kani");
        }
        else
        {
            gameObject.layer = LayerMask.NameToLayer("player");
        }
    }
}
