using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class FuntionsButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ResetScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void Home()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
