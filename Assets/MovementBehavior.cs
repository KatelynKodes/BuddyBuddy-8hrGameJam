using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;

    private Vector3 _moveDir;

    public Vector3 MoveDirection { get { return _moveDir; } set { _moveDir = value; } }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(transform.position + MoveDirection * _speed * Time.fixedDeltaTime);
    }
}
