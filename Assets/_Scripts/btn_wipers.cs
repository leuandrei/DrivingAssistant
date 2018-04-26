using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btn_wipers : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject btn;
    public GameObject panel;
    public GameObject make;
	// Use this for initialization

	void Start () {
        btn = GameObject.Find("Button").gameObject;
        panel = GameObject.Find("ButtonText").gameObject;
	}

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

    // Update is called once per frame
    void Update () {
		
	}
}
