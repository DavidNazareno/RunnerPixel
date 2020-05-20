using UnityEngine;
using System.Collections;

public class BulletCollider : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Enemy" || c.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
