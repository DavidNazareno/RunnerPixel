using UnityEngine;
using System.Collections;

public class BoomCollider : MonoBehaviour {
    public Animator boomAnim;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D (Collider2D c)
    {
        if (c.gameObject.tag== "ground"|| c.gameObject.tag == "Player")
        {
            boomAnim.SetTrigger("Boom");
            GetComponent<Rigidbody2D>().isKinematic = true;
            CameraShake vcam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraShake>();
            vcam.ShakeCam();
           
            SoundController BombGround = GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>();
            BombGround.BombExplosionGround();
        }
    }

    void DestroidBoom()
    {
        Destroy(gameObject);
    }
}
