﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScollingObject : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        if ( !GameManager.instance.isGameover)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}