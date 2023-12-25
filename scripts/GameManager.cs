using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject ball;

    public GameObject player1;
    public GameObject player1Goal;

    public GameObject player2;
    public GameObject player2Goal;

    public GameObject PaddleComputer;

    public GameObject player1Text;
    public GameObject player2Text;

    private int Player1Score;
    private int Player2Score;

    public int VictoryScore = 10;


    public void Player1Scored()
    {
        Player1Score++;
        player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        //PaddleComputer.GetComponent<PaddleComputer>().speed = PaddleComputer.GetComponent<PaddleComputer>().speed + 1;
        ResetPosition();
    }

    public void Player2Scored()
    {
        Player2Score++;
        player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        //PaddleComputer.GetComponent<PaddleComputer>().speed = PaddleComputer.GetComponent<PaddleComputer>().speed + 1;
        ResetPosition();
    }

    public void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        
    }
}
