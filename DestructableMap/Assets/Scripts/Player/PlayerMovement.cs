using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private int _Speed = 10;
    private Rigidbody2D _Rb;
    private Vector2 _MoveVelocity;

    private void Start()
    {
        _Rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 MovementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        _MoveVelocity = MovementInput * _Speed;
    }

    private void FixedUpdate()
    {
        _Rb.MovePosition(_Rb.position + _MoveVelocity * Time.deltaTime);
    }
}
