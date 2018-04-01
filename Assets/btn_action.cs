using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btn_action : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vbBtnObj;
    public GameObject panel;

    // Use this for initialization
    void Start () {
        vbBtnObj = GameObject.Find("logo_button");
        panel = GameObject.Find("Plane");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        panel.SetActive(true);
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        panel.SetActive(false);
        Debug.Log("Button released");
    }

    void Update()
    {

    }

}
