using System;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class CharacterController2DParallax : MonoBehaviour
{
    public delegate void Movement(Vector3 movement);
    public event Movement OnMovement;
    
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _jumpForce = 250f;
    
    private Rigidbody2D _rigidbody;
    private Vector3 movement;

    private void Start(){
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement = Vector3.right * Input.GetAxis("Horizontal");

        transform.Translate(movement * (_speed * Time.deltaTime));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(_jumpForce * Vector2.up);
        }

        if (OnMovement != null && movement.magnitude > 0.0f)
        {
            OnMovement(movement);
        }
    }
}