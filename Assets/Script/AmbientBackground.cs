using UnityEngine;
using System.Collections;

public class AmbientBackground : MonoBehaviour {
    public float BackgroundCal;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Renderer render = GetComponent<Renderer>();
        render.material.mainTextureOffset = new Vector2(Time.time * BackgroundCal, 0);
	}
}
