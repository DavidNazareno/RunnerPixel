using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour {
    public float SpeedAirBomb=10;
    public bool airTorret;
    public bool airBomb;
    public int HealtBombarder;
    public Rigidbody2D bombarder;
    void Awake()
    {
      
    }
    void Start () {

    
    }
	

	void Update () {
        if (airTorret)
        {
            AirTorret();
        }
        if (airBomb)
        {
            
            AirBomb();
        }
        if (HealtBombarder == 0)
        {
            bombarder.constraints = RigidbodyConstraints2D.None;
           
        }
       
    }

    public void AirBomb()
    {

      bombarder.velocity = (new Vector2(SpeedAirBomb, 0)*Time.deltaTime);
       

    }
    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "bullet")
        {
            HealtBombarder = HealtBombarder - 1;
            Debug.LogError("bullet");
        }
        if (c.gameObject.tag == "ground")
        {
            CameraShake vcm = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraShake>();
            vcm.ShakeCam();
            SoundController Dead = GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>();
            Dead.AirDead();
            Destroy(gameObject);
            Score.ScoreUp();

        }
        if (c.gameObject.tag == "ActShootbom")
        {
            ShootAir shootBomb = GameObject.FindGameObjectWithTag("BoomAir").GetComponent<ShootAir>();
            shootBomb.AirBomb();
        }

        if (c.gameObject.tag== "AirDestroid")
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerStay2D(Collider2D c)
    {
        if (c.gameObject.tag == "KPause")
        {
            bombarder.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else
        {
   
           
        }
    }
    public void AirTorret()
    {
       
    }

}
