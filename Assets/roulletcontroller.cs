using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roulletcontroller : MonoBehaviour
{
    float rotspeed = 0;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotspeed = 10.0f;
        }
        if (Input.GetMouseButtonDown(1))
        {
            this.rotspeed = 0;
        }
        transform.Rotate(0, 0, this.rotspeed);
        this.rotspeed *= 0.978f;
    }
}
