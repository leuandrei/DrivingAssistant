using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_controller : MonoBehaviour {

	public void FullAR()
    {
        SceneManager.LoadScene("scene_4");
    }

    public void PartialAR()
    {
        SceneManager.LoadScene("scene_headlights");
    }

    public void Quit()
    {
        Debug.Log("Successfully quit");
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

}
