using UnityEngine;
using System.Collections;

public class ShootPlayer : MonoBehaviour {
    public float bulletForceMin;
    public float bulletForceMax;
    public TorretController shootA;
    public GameObject bullet;
    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


    }



    public void ShootPrimary()
    {
       
        GameObject insBullet = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
     
        insBullet.GetComponent<Rigidbody2D>().AddForce(transform.right * -Random.RandomRange(bulletForceMin, bulletForceMax) * Time.deltaTime);
    }

}
