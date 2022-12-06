using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackgroundParallax : MonoBehaviour
{
    public CharacterController2DParallax _controller;
    public float _speed;

    public Renderer[] renderer;

    private void Start()
    {
        _controller = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController2DParallax>();
        _controller.OnMovement += UpdateBackground;
    }
    
    private void UpdateBackground(Vector3 movement)
    {
        for (int i = 0; i < renderer.Length; i++)
        {
            renderer[i].material.SetTextureOffset($"_MainTex", renderer[i].material.GetTextureOffset("_MainTex") + (_speed * (Vector2) movement) / (i + 2f));
        }
    }
}
