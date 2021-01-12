using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager22 : MonoBehaviour
{
    public GameObject j, yo, l, jBlack, yoBlack, lBlack;

    Vector2 jInitialPos, yoInitialPos, lInitialPos;

    public AudioSource source;
    public AudioClip[] jcorrect;
    public AudioClip[] yocorrect;
    public AudioClip[] lcorrect;
    public AudioClip incorrect;

    bool jCorrect, yoCorrect, lCorrect = false;
    void Start()
    {
        jInitialPos = j.transform.position;
        yoInitialPos = yo.transform.position;
        lInitialPos = l.transform.position;
    }
    public void Dragj()
    {
        j.transform.position = Input.mousePosition;
    }

    public void Dragyo()
    {
        yo.transform.position = Input.mousePosition;
    }

    public void Dragl()
    {
        l.transform.position = Input.mousePosition;
    }

    public void Dropj()
    {
        float Distance = Vector3.Distance(j.transform.position, jBlack.transform.position);
        if (Distance < 50)
        {

            j.transform.position = jBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = jcorrect[Random.Range(0, jcorrect.Length)];
            source.Play();
            jCorrect = true;
        }

        else
        {

            j.transform.position = jInitialPos;
            yo.transform.position = yoInitialPos;
            l.transform.position = lInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropyo()
    {
        float Distance = Vector3.Distance(yo.transform.position, yoBlack.transform.position);
        if (Distance < 50)
        {

            yo.transform.position = yoBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = yocorrect[Random.Range(0, yocorrect.Length)];
            source.Play();
            yoCorrect = true;
        }
        else
        {
            yo.transform.position = yoInitialPos;
            j.transform.position = jInitialPos;
            l.transform.position = lInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropl()
    {
        float Distance = Vector3.Distance(l.transform.position, lBlack.transform.position);
        if (Distance < 50)
        {

            l.transform.position = lBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = lcorrect[Random.Range(0, lcorrect.Length)];
            source.Play();
            lCorrect = true;
        }
        else
        {
            l.transform.position = lInitialPos;
            j.transform.position = jInitialPos;
            yo.transform.position = yoInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    void Update()
    {
        if (jCorrect && yoCorrect && lCorrect)
        {
            Debug.Log("You Win");

        }
    }
}
