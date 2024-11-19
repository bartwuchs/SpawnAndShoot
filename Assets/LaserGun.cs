using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour
{

    public Transform FirePoint;
    public LayerMask WhatIsShootable;

    public float MaxDistance = 10;
    
    // Update is called once per frame
    void Update()
    {
        Shoot();
      
    }

    

    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(FirePoint.position, FirePoint.forward,
            out hit,
            MaxDistance,
            WhatIsShootable))
        {
            Debug.Log(hit.transform.name + " " + hit.point);
        }
    }
}
