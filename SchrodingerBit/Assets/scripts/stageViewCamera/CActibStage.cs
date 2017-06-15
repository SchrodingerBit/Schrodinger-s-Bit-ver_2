using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CActibStage : MonoBehaviour
{

    public static int stageID;
    private GameObject stage;
    private GameObject stage_1;
    private GameObject stage_2;
    private GameObject stage_3;
    private GameObject stage_4;
    private GameObject stage_5;
    private GameObject stage_6;

    
    void Start()
    {
   
        stage_1 = GameObject.Find("Stage_1");
        stage_2 = GameObject.Find("Stage_2");
        stage_3 = GameObject.Find("Stage_3");
        stage_4 = GameObject.Find("Stage_4");
        stage_5 = GameObject.Find("Stage_5");
        stage_6 = GameObject.Find("Stage_6");
        stage_1.SetActive(false);
        stage_2.SetActive(false);
        stage_3.SetActive(false);
        stage_4.SetActive(false);
        stage_5.SetActive(false);
        stage_6.SetActive(false);
        
    }
    void Update()
    {
        switch (stageID)
        {


            case 1:
                stage_1.SetActive(true);
                break;
            case 2:
                stage_2.SetActive(true);
                break;
            case 3:
                stage_3.SetActive(true);
                break;
            case 4:
                stage_4.SetActive(true);
                break;
            case 5:
                stage_5.SetActive(true);
                break;
            case 6:
                stage_6.SetActive(true);
                break;
            default:
                break;



        }
    }
}