using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleComputer : MonoBehaviour
{
    public GameObject computerPlayer;

    public GameObject ball;

    public Rigidbody2D Circle;

    public float speed;

    public Rigidbody2D rb;

    public float movement;

    public Vector2 targetPosition;

    
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        targetPosition = ball.transform.position;

        if (transform.position.y > targetPosition.y)
        {
            
            transform.position += new Vector3(0, -speed*Time.deltaTime, 0);

            
        }

        if (transform.position.y < targetPosition.y)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
    }
}
