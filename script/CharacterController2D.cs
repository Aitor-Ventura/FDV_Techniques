using System;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _jumpForce = 250f;
    
    private Rigidbody2D _rigidbody;

    private void Start(){
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.Translate(Vector3.right * (Input.GetAxis("Horizontal") * _speed * Time.deltaTime));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(_jumpForce * Vector2.up);
        }
    }
}