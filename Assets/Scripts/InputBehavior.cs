using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehavior : MonoBehaviour
{
    MovementBehavior _playerMovement;
    MovementBehavior _buddyMovement;

    private void Awake()
    {
        _playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<MovementBehavior>();
        _buddyMovement = GameObject.FindGameObjectWithTag("Buddy").GetComponent<MovementBehavior>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        else
        {
            _playerMovement.MoveDirection = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
            _buddyMovement.MoveDirection = new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));
        }
    }
}
