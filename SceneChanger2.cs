using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger2 : MonoBehaviour
{
    public void Scene3Hangul()
    {

        SceneManager.LoadScene("Scene3Hangul");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Scene2Hangul");
    }
}
