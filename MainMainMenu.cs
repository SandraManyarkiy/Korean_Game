using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMainMenu : MonoBehaviour
{
    public Button RegisterButton;
    public Button LogInButton;
    public Button playButton;

    public Text playerDisplay;
    private void Start()
    {
        if (DBManager.LoggedIn)
        {
            playerDisplay.text = "Player: " + DBManager.username;
        }

        RegisterButton.interactable = !DBManager.LoggedIn;
        LogInButton.interactable = !DBManager.LoggedIn;
        playButton.interactable = DBManager.LoggedIn;
    }
    public void GoToRegister()
    {

        SceneManager.LoadScene(1);

     }

    public void GoToLogIn()
    {

        SceneManager.LoadScene(2);

    }

    public void GoToGame()
    {

        SceneManager.LoadScene(4);

    }
}
