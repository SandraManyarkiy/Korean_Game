using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger4 : MonoBehaviour
{

    public void Scene5Hangul()
    {

        SceneManager.LoadScene("Scene5Hangul");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Scene4Hangul");
    }
}
