using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class text_blinkerdetection : MonoBehaviour {

    public Text text;
	
    void Update()
    {
        if (DefaultTrackableEventHandler.carMake == "chevrolet")
            text.text = "This is the blinker switch. Push it " +
                    "\nupwards to signal the right side or push it " +
                    "\ndownward to signal the left side. This" +
                    "\nis also the headlights switch; in order" +
                    "\nto turn them on, rotate the switch " +
                    "\ncounter-clock wise twice. To turn" +
                    "\nthem off, rotate the switch clock-wise" +
                    "\ntwice.";
        else
            text.text = "This is the blinker switch. Push it " +
                "\nupwards to signal the right side or push it " +
                "\ndownward to signal the left side. The " +
                "\nheadlights switch is placed below the vent" +
                "\nthat is placed to the left of this switch";
    }
}
