using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerVsComputer()
    {
        SceneManager.LoadScene("PlayerVsComputer");
    }

    public void PlayerVsPlayer()
    {
        SceneManager.LoadScene("PlayerVsPlayer");
    }
}
