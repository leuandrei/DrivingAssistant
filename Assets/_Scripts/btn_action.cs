using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btn_action : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject button;
    public GameObject panel;
    public GameObject carModel;
    // Use this for initialization

    void Start()
    {
        button = GameObject.Find("Button").gameObject;
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(false);
        foreach (Renderer component in rendererComponents)
        {
            if (component.CompareTag("Make"))
                component.enabled = true;
        }
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
        foreach (Renderer component in rendererComponents)
        {
            if (component.CompareTag("Make"))
                component.enabled = false;
        }
        Debug.Log("Button released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
