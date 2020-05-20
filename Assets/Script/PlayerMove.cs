using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
    public Rigidbody2D movePlayer;
    public float speed;
    public Transform cameraMove;

    float positionCamera = -7.51f;
	// Use this for initialization
	void Start () {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update() {
        MovePlayer();
        cameraMove.position = new Vector3(positionCamera, cameraMove.position.y,cameraMove.position.z);
    }
    void LerpSpeed() {
        speed = Random.RandomRange(Mathf.Lerp(-speed, -450, 0.1f), Mathf.Lerp(speed,500, 0.1f));
    }

    void OnTriggerStay2D (Collider2D c)
    {
        if (c.gameObject.tag == "PlayerStop")
        {

            speed = 0;

            if (positionCamera <0)
            {
                positionCamera = positionCamera + 0.2f;
            }


        }
    }



    void  MovePlayer()
    {
       movePlayer.velocity = (new Vector2(speed, 0) * Time.deltaTime);
    }
}
