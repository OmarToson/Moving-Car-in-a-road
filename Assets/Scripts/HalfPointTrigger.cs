using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour {

    public GameObject LabCompleteTri;
    public GameObject HalfCompleteTri;

    void OnTriggerEnter()
    {
        LabCompleteTri.SetActive(true);
        HalfCompleteTri.SetActive(false);
    }
}
