using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _playerSpeed;
    private Rigidbody2D _rigidbody;
    private Vector2 _direcrin;

    void Start()
    {
        _rigidbody = GetComponentInChildren<Rigidbody2D>();
    }
    void Update()
    {
        float direcionX = Input.GetAxisRaw("Horizontal");
        float direcionY = Input.GetAxisRaw("Vertical");

        _direcrin = new Vector2(direcionX, direcionY).normalized;
    }
    void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_direcrin.x * _playerSpeed, _direcrin.y * _playerSpeed);
    }
}
