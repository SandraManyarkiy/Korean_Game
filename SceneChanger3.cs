using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger3 : MonoBehaviour
{

    public void Scene4Hangul()
    {
        SceneManager.LoadScene("Scene4Hangul");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Scene3Hangul");
    }
}
