using UnityEngine;
using System.Collections;

public class TorretController : MonoBehaviour {
    Vector3 MousePo;
    public Animator shoot;
    public ShootPlayer[] shootAc;
    public CameraShake CShake;
    public int rotF = 90;
  
  
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
   

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            TorretRotate();
            ShootPrimaryAnim();


        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            TorretRotate();
            ShootSecundary();
        }

        

    }

    void TorretRotate()
    {
        Vector3 TorretM = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        TorretM.Normalize();
        float z = Mathf.Atan2(-TorretM.y, -TorretM.x) * Mathf.Rad2Deg;
    
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(0f,0f,Mathf.Clamp(z,-35,2)+rotF),1);

    }

    public void ShootPrimaryAnim()
    {
        shoot.SetTrigger("Primary");
        SoundController Shoot = GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>();
        Shoot.PlayerShootPrimary();


    }
    void ShootSecundary()
    {
        SoundController Shoot = GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>();
        Shoot.PlayerShootSecundary();
        CShake.ShakeCam();
        shoot.SetTrigger("Secundary");
    }

    void ShootPrimaryAc()
    {
        for (int i = 0; i < shootAc.Length; i++)
        {
            shootAc[i].ShootPrimary();
        }
       
    }
}
