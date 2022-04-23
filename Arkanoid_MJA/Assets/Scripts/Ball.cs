using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigiBody2D;

    public float speed = 300;

    private Vector2 velocity;

    Vector2 starPosition;
  
    void Start()
    {
        starPosition = transform.position;
        ResetBall();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dead"))
        {
            FindObjectOfType<GameManager>().LoseHealth();
        }
    }

    public void ResetBall()
    {
        transform.position = starPosition;

        rigiBody2D.velocity = Vector2.zero;

        velocity.x = Random.Range(-1f, 1f);

        velocity.y = 1;

        rigiBody2D.AddForce(velocity * speed);
    }
}
