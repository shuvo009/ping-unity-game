using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallControll : MonoBehaviour
{
    private Rigidbody2D ball;
    private AudioSource audioSource;
    public float BallSpreed = 100;
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        new WaitForSeconds(2f);
        GoBall();
    }

    // Update is called once per frame
    void Update()
    {
        var xVel = ball.velocity.x;
        if (xVel < 18 && xVel > -18 && xVel != 0)
        {
            if (xVel > 0)
            {
                ball.velocity = new Vector2(20, ball.velocity.y);
            }
            else
            {
                ball.velocity = new Vector2(-20, ball.velocity.y);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.collider.tag == "Player")
        {
            var velY = ball.velocity.y / 2 + collision2D.collider.GetComponent<Rigidbody2D>().velocity.y / 3;
            ball.velocity = new Vector2(ball.velocity.x, velY);
            audioSource.Play(0);
        }
    }

    void ResetBall()
    {
        ball.velocity = new Vector2(0, 0);
        ball.transform.position = new Vector3(0, 0, 0);
        new WaitForSeconds(0.5f);
        GoBall();
    }

    void GoBall()
    {
        var randomNumber = Random.Range(0, 2);
        if (randomNumber <= 0.5)
        {
            ball.AddForce(new Vector2(BallSpreed, 10));
        }
        else
        {
            ball.AddForce(new Vector2(-BallSpreed, -10));
        }
    }
}
