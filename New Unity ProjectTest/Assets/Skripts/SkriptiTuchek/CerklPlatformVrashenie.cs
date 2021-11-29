using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerklPlatformVrashenie : MonoBehaviour
{


    [SerializeField]
    Transform center;

    [SerializeField]
    float radius = 2f, angularSpeed = 2f;

    float posicionX, posicionY, angle = 0f;






    void Update()
    {

        posicionX = center.position.x + Mathf.Cos(angle) * radius;
        posicionY = center.position.y + Mathf.Sin(angle) * radius;
        transform.position = new Vector2(posicionX, posicionY);
        angle = angle + Time.deltaTime * angularSpeed;

        if(angle >= 360f)
        {
            angle = 0f;
        }

    }




}
