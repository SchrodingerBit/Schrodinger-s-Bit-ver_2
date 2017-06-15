using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CStageSelectButton : MonoBehaviour
{

    


	public void OnClick(int number)
    {

        switch (number)
        {

            case 1:
                CActibStage.stageID = 1;
                break;
            case 2:
                CActibStage.stageID = 2;
                break;
            case 3:
                CActibStage.stageID = 3;
                break;
            case 4:
                CActibStage.stageID = 4;
                break;
            case 5:
                CActibStage.stageID = 5;
                break;
            case 6:
                CActibStage.stageID = 6;
                break;
            default:
                break;
            

        }
    }
}