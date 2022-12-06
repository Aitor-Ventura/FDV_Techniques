using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float _speed;

    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    
    private void Update()
    {
        renderer.material.SetTextureOffset($"_MainTex", new Vector2(Time.time * _speed, 0));
    }
}
