﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public GameObject Planet;       //기준행성 (토성)
    public float speed;             //회전 속도

    private void Update()
    {
        OrbitAround();
    }

    void OrbitAround()
    {
        transform.RotateAround(Planet.transform.position, Vector3.down, speed * Time.deltaTime);
    }
}
