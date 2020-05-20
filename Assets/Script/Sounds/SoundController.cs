using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundController : MonoBehaviour {
    public AudioSource[] Sounds;
    
	// Use this for initialization
	void Start () {
        Sounds[8].mute = (false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale == 0 )
        {
            for (int i = 0; i < 7; i++)
            {
                Sounds[i].mute = true;
            }


        }else
        {
            for (int i = 0; i < 7; i++)
            {
                Sounds[i].mute = false;
            }
        }
	}

    public void VolumenC (float Vol)
    {
        for (int i = 0; i < 7; i++)
        {
            Sounds[i].volume = Vol;
        }
      
       
       
    }

  
    public void BombExplosionGround()
    {
        Sounds[0].Play();
    }

    public void BoomFall()
    {
        Sounds[1].Play();
    }

    public void PlayerShootPrimary()
    {
        Sounds[2].Play();

    }
    public void EscarabajoDead()
    {
        Sounds[3].Play();
    }
    public void EscarabajoShoot()
    {
        Sounds[4].Play();
    }
    public void PlayerShootSecundary()
    {
        Sounds[5].Play();

    }

    public void AirDead()
    {
        Sounds[6].Play();
    }
    public void PlayerDead()
    {
        Sounds[8].mute=(true);
        Sounds[7].Play();
    }
    public void MusicController(float volM)
    {
        Sounds[8].volume = volM;
    }

}
