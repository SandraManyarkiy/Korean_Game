using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
   
    public void Scene2Hangul()
    {

        SceneManager.LoadScene("Scene2Hangul");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Scene1Hangul");
    }
}
