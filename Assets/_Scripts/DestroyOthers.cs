using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOthers : MonoBehaviour {

    public GameObject[] makes;
    public GameObject make;
    // Use this for initialization
    void Start () {
        make = GameObject.Find("Make");
        makes = GameObject.FindGameObjectsWithTag("Make");
        foreach (GameObject iterator in makes)
        {
            if (iterator.name != make.name)
                Destroy(iterator);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
