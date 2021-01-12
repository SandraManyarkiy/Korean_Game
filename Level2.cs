using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level2 : MonoBehaviour
{
    
    public void NextLevel()
    {
        SceneManager.LoadScene("Scene1Hangul");

    }

    public void Replay()
    {
        SceneManager.LoadScene("Main");

    }
}
