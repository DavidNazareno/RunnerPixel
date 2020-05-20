using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealtPlayer : MonoBehaviour {
    public int healt = 100;
    public Text healttText;
    public GameObject gameOver;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        healttText.text = ("100/" + healt.ToString());
        if (healt <= 0)
        {
            SoundController Dead = GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>();
            Dead.PlayerDead();
            gameOver.SetActive(true);
            Destroy(gameObject);
            Time.timeScale = 0.03f;
        }else
        {
            gameOver.SetActive(false);
        }
	}

    void OnTriggerEnter2D ( Collider2D c)
    {
        if (c.gameObject.tag == "Bomb")
        {
            healt = healt - 5;
        }
        if (c.gameObject.tag == "BulletEscar")
        {
            healt = healt - 3;
        }
    }
}
