using UnityEngine;
using System.Collections;

public class OnAndOff : MonoBehaviour {
 public TorretController disableScript;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale == 0)
        {
            disableScript.enabled=(false);
        }else
        {
            disableScript.enabled = (true);
        }
	}
}
