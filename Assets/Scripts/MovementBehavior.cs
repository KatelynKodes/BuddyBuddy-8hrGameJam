using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;
    private GameManager _manager;

    private Vector3 _moveDir;

    public Vector3 MoveDirection { get { return _moveDir; } set { _moveDir = value; } }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(transform.position + MoveDirection * _speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Buddy") && !other.gameObject == this)
        {
            _manager.FriendCaught = true;
        }
    }
}
