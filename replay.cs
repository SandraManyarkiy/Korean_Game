using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replay : MonoBehaviour
{
    public void EndGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ReplayLevel()
    {

        SceneManager.LoadScene("Scene1Hangul");

    }
}
