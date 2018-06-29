using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn_click : MonoBehaviour {

    public GameObject imagePanel;
    public Text text;
    public Text content;
    public int counter=0;
	// Use this for initialization
	void Start () {
        imagePanel.SetActive(false);
	}
	
    public void swap_context()
    {
        counter++;
        if (counter % 2 == 1)
        {
            //text.text = "Hide";
            imagePanel.SetActive(true);
        }
        else
        {
            //text.text = content.text.ToString();
            imagePanel.SetActive(false);
        }
    }
}
