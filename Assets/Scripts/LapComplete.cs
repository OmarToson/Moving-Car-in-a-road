using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

    public GameObject MinuteBest;
    public GameObject SecondBest;
    public GameObject MilliBest;

    public GameObject LapCompleteTri;
    public GameObject HalfLapTri;

    public GameObject LapCounter;
    private int LapDone;

    public GameObject car;


    void OnTriggerEnter()
    {
        LapDone += 1;
        MilliBest.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;

        if (LapTimeManager.SecondCount <= 9)
        {
            SecondBest.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
        }
        else
        {
            SecondBest.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
        }

        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteBest.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ":";
        }
        else
        {
            MinuteBest.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ":";
        }

        LapTimeManager.MilliCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MinuteCount = 0;

        LapCounter.GetComponent<Text>().text = "" + LapDone;

        if (LapDone == 2)
        {
            car.SetActive(false);
        }

        HalfLapTri.SetActive(true);
        LapCompleteTri.SetActive(false);
        
    }

}
