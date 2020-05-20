using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    float mt = 0.05f;
    float lenght = 0.04f;
    float shakeAmount = 0;

    Vector3 camPos;
    void Start()
    {
      

    }

 
  public  void  ShakeCam ()
    {
        shakeAmount = mt;
        InvokeRepeating("ShakeR", 0, 0.01f);
        Invoke("StopShake", lenght);
    }
    void Update()
    {
       
    }
    void ShakeR()
    {
        if (shakeAmount > 0)
        {
          camPos = Camera.main.transform.position;
            float shakemtX = Random.value * shakeAmount * 2 - shakeAmount;
            float shakemtY = Random.value * shakeAmount * 2 - shakeAmount;
            camPos.x += shakemtX;
            camPos.y += shakemtY;

            Camera.main.transform.position = camPos;
        }
    }

  
    void StopShake()
    {
        CancelInvoke("ShakeR");
        Camera.main.transform.localPosition = new Vector3 (-0.23f,-0.28f, -1.141144f);
    }

}