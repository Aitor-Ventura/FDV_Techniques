using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject _controller;

    private void Start()
    {
        _controller = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        transform.position = new Vector3(_controller.transform.position.x, transform.position.y, transform.position.z);
    }
}
