using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveGroundEnemy : MonoBehaviour
{
    public Rigidbody2D Escar;
    public int healthEnemy = 50;
    public Text healtText;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Escar.velocity = new Vector2(200, 0) * Time.deltaTime;
        healtText.text = ("20/" + healthEnemy.ToString());
        if (healthEnemy <= 0)
        {
            SoundController Dead = GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>();
            Dead.EscarabajoDead();
            Destroy(gameObject);
            Score.ScoreUp();
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "bullet")
        {
            healthEnemy = healthEnemy - 1;
        }
      

        if (c.gameObject.tag == "ActShootbom")
        {
           ShootGround mg = GameObject.FindGameObjectWithTag("EscarShoot").GetComponent<ShootGround>();
            mg.ShootScar();
        }

    }

}
