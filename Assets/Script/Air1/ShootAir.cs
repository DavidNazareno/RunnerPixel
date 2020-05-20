using UnityEngine;
using System.Collections;

public class ShootAir : MonoBehaviour {
    public GameObject bulletTorret;
    public GameObject bulletBomb;
    public bool airTorret;
  
    
    void Start () {
        if (airTorret)
        {
            AirTorret();
        }
  
    }
	
	
	void Update () {
	
	}

    void OnTriggerEnter2D (Collider2D c)
    {

    }

    public void AirBomb()
    {
        Debug.LogError("shoooooot");
        GameObject insBomb = (GameObject)Instantiate(bulletBomb, transform.position, transform.localRotation);
        Invoke("AirBomb", Random.RandomRange(0,50) * Time.deltaTime);
        SoundController BombGround = GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>();
        BombGround.BoomFall();
    }

   public void AirTorret()
    {
        GameObject insTorret = (GameObject)Instantiate(bulletTorret, transform.position, transform.localRotation);
        insTorret.GetComponent<Rigidbody2D>().AddForce(new Vector3(20, 0, 0)*Time.deltaTime);
    }
}
