using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class text_makeDetection : MonoBehaviour {

    public Text text;
	
	// Update is called once per frame
	void Update () {
        text.text = "This " + DefaultTrackableEventHandler.carMake + " has \nbeen detected";
	}
}
