using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal2 : MonoBehaviour
{
    public bool Player2Goal;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (!Player2Goal)
        {
            Debug.Log("Player2 Scored");
            GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
        }

    }
}
