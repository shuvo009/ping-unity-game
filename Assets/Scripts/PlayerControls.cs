using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public KeyCode MoveUp;
    public KeyCode MoveDown;
    public float Speed = 10;

    private Rigidbody2D _player;

    void Start()
    {
        _player = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKey(MoveUp))
        {
            _player.velocity = new Vector2(0, Speed);
        }
        else if (Input.GetKey(MoveDown))
        {
            _player.velocity = new Vector2(0, Speed * -1);
        }
        else
        {
            _player.velocity = new Vector2(0, 0);
        }
    }
}
