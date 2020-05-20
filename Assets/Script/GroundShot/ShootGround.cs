using UnityEngine;
using System.Collections;

public class ShootGround : MonoBehaviour {
    public GameObject BulletScar;
    public float Speed;
  
	// Use this for initialization
	void Start () {
    
  

    }
	
	// Update is called once per frame
	void Update () {


    }


    public void ShootScar()
    {
        SoundController Shoot = GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>();
        Shoot.EscarabajoShoot();
        GameObject insScar = (GameObject)Instantiate(BulletScar, transform.position, transform.rotation=(transform.localRotation));
        insScar.GetComponent<Rigidbody2D>().AddForce(new Vector2(Speed, 0) * Time.deltaTime);
        Invoke("ShootScar", Random.RandomRange(50, 100)*Time.deltaTime);
    }
}
