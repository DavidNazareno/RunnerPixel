using UnityEngine;
using System.Collections;

public class MoveGround : MonoBehaviour
{
    public Rigidbody2D rocks;
    public Rigidbody2D ground;
    public bool MoveRockAc;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MoveRockAc == true)
        {
            RocksMove();
        }

        ground.velocity = (new Vector2(-500, 0) * Time.deltaTime);
    }


    void RocksMove()
    {
        rocks.velocity = (new Vector2(-2f, 0) * Time.deltaTime);

    }


}
