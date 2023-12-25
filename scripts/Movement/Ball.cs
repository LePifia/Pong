using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ball;

    public float speed;

    float aceleration = 1.025f;

    public Rigidbody2D rb;

    public Vector3 startPosition;

    public Vector2 normal = new Vector2(1, 1);

    float x;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        
        startPosition = new Vector3 (0, 0, 0);
        Launch();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity *= aceleration;
    }


    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

    private void Launch()
    {
        float x = Random.Range(0.5f, 2);
        float y = Random.Range(0.5f, 2);

        rb.velocity = new Vector2(speed * x, speed * y);
    }

    

}
