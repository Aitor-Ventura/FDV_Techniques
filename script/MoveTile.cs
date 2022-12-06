using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTile : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        transform.Translate(Vector3.left * (speed * Time.deltaTime));
    }
}
