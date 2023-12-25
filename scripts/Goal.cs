using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool Player1Goal;
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            if (!Player1Goal)
            {
                Debug.Log("Player1 Scored");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
            
        
    }

}
