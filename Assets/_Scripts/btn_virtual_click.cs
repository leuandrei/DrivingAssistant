using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btn_virtual_click : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject VirtualButton;
    public GameObject Panel;

	// Use this for initialization
	void Start () {
        VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Panel.SetActive(false);
	}
	
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Panel.SetActive(true);
        Debug.Log("VB Pressed");
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Panel.SetActive(false);
        Debug.Log("VB Released");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
