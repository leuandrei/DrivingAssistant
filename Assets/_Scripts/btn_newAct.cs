using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btn_newAct : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject btn;
    public GameObject panel;
    public GameObject make;
    public GameObject[] makes;
    // Use this for initialization

    void Start()
    {
        make = GameObject.Find("Make");
        btn = make.transform.Find("Button").gameObject;
        panel = make.transform.Find("Text").gameObject;
        panel.SetActive(true);
        panel.SetActive(false);
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
    void Update()
    {

    }
}
