using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool player2;

    public float speed;

    public Rigidbody2D rb;

    public float movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("VerticalPlayer1");

        rb.velocity = new Vector2(0 , movement*speed);
    }
}
