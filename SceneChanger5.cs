using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger5 : MonoBehaviour
{

    public void Scene6Hangul()
    {
        SceneManager.LoadScene("Scene6Hangul");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Scene5Hangul");
    }
}
