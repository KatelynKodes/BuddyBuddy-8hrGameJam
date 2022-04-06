using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _endGamePanel;
    [SerializeField]
    private TextMeshProUGUI _timerText;

    private bool _friendCaught;
    private MovementBehavior _playerMovement;
    private MovementBehavior _buddyMovement;
    private InputBehavior _inputBehavior;

    public bool FriendCaught { get { return _friendCaught; } set { _friendCaught = value; } }

    private void Awake()
    {
        _friendCaught = false;
        _playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<MovementBehavior>();
        _buddyMovement = GameObject.FindGameObjectWithTag("Buddy").GetComponent<MovementBehavior>();
    }

    private void Update()
    {
        if (FriendCaught)
        {
            _playerMovement.enabled = false;
            _buddyMovement.enabled = false;
            ShowEndScreen();
        }
        else
        {

        }
    }

    private void ShowEndScreen()
    {
        _endGamePanel.SetActive(true);
    }
}
