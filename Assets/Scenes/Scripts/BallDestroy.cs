﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour

{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy (gameObject, 0.1f);
    }
}