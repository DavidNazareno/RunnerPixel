using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class UIControlller : MonoBehaviour {
    //public GameObject menuPause;
    public Animator pauseAnim;
    public Animator optionsAnim;
    public Animator creditsAnim;
    public GameObject[] instanceDisable;
	void Start () {
      
	}
	
	
	void Update () {
	
	}
  

   
  
    public  void Paused()
    {
        

        Time.timeScale = 0;
        pauseAnim.SetTrigger("EnterPause");
       
    }
    public void PauseBack()
    {
    
        Time.timeScale = 1;
        pauseAnim.SetTrigger("BackPause");

    }

    public void Options()
    {
        pauseAnim.SetTrigger("BackPause");
        optionsAnim.SetTrigger("EnterOptions");
    }

    public void OptionsBack()
    {
        pauseAnim.SetTrigger("EnterPause");
        optionsAnim.SetTrigger("BackOptions");
    }
    public void OptionsMenu()
    {
     
        optionsAnim.SetTrigger("EnterOptions");
    }

    public void OptionsBackMenu()
    {
     
        optionsAnim.SetTrigger("BackOptions");
    }

    public void CreditsEnter()
    {
        creditsAnim.SetTrigger("EnterCredits");
    }
    public void CreditsExit()
    {
        creditsAnim.SetTrigger("ExitCredits");
    }
}
