using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class parallaxMovement : MonoBehaviour
{
    [SerializeField]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);

        //if (direction == true)
        //{

          //  TraslateToRandomDirectionForward();
        //}

        //if (direction == false)
        //{
        //    TraslateToRandomDirectionBack();
        //}
    }
}
