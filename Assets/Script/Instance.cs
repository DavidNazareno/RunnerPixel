using UnityEngine;
using System.Collections;

public class Instance : MonoBehaviour
{
    public GameObject[] airEnemy;
    public GameObject[] groundEnemy;
    public GameObject[] ground;
    public bool airEnemyActivated;
    public bool groundEnemyActivated;
    public bool groundInstanceActivated;
    public float min, max;

 
    // Use this for initialization
    void Start()
    {
        if (airEnemyActivated)
        {
            AirEnemy();
        }
        if (groundEnemyActivated)
        {
            GroundEnemy();
        }
        if (groundInstanceActivated)
        {
            InstanceGround();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AirEnemy()
    {
        GameObject insAirEnemy = (GameObject)Instantiate(airEnemy[Random.RandomRange(0, airEnemy.Length)], transform.position, transform.rotation);
        Invoke("AirEnemy", Random.RandomRange(120, 550) * Time.deltaTime);
        Destroy(insAirEnemy, 10);
    }
    public void GroundEnemy()
    {
        GameObject insgroundEnemy = (GameObject)Instantiate(groundEnemy[Random.RandomRange(0, groundEnemy.Length)], transform.position, transform.rotation);
        Invoke("GroundEnemy", Random.RandomRange(min, max) * Time.deltaTime);
    }

    void InstanceGround()
    {
        GameObject insGround = (GameObject)Instantiate(ground[Random.RandomRange(0, ground.Length)], transform.position, transform.rotation);
    
        Invoke("InstanceGround",10 * Time.fixedDeltaTime);
        Destroy(insGround,200 * Time.deltaTime);
    }


}
