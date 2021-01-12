using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager33 : MonoBehaviour
{

    public GameObject a, yu, ch, aBlack, yuBlack, chBlack;

    Vector2 aInitialPos, yuInitialPos, chInitialPos;

    public AudioSource source;
    public AudioClip[] acorrect;
    public AudioClip[] yucorrect;
    public AudioClip[] chcorrect;
    public AudioClip incorrect;

    bool aCorrect, yuCorrect, chCorrect = false;
    void Start()
    {
        aInitialPos = a.transform.position;
        yuInitialPos = yu.transform.position;
        chInitialPos = ch.transform.position;
    }
    public void Draga()
    {
        a.transform.position = Input.mousePosition;
    }

    public void Dragyu()
    {
        yu.transform.position = Input.mousePosition;
    }

    public void Dragch()
    {
        ch.transform.position = Input.mousePosition;
    }

    public void Dropa()
    {
        float Distance = Vector3.Distance(a.transform.position, aBlack.transform.position);
        if (Distance < 50)
        {

            a.transform.position = aBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = acorrect[Random.Range(0, acorrect.Length)];
            source.Play();
            aCorrect = true;
        }

        else
        {

            a.transform.position = aInitialPos;
            yu.transform.position = yuInitialPos;
            ch.transform.position = chInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropyu()
    {
        float Distance = Vector3.Distance(yu.transform.position, yuBlack.transform.position);
        if (Distance < 50)
        {

            yu.transform.position = yuBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = yucorrect[Random.Range(0, yucorrect.Length)];
            source.Play();
            yuCorrect = true;
        }
        else
        {
            yu.transform.position = yuInitialPos;
            a.transform.position = aInitialPos;
            ch.transform.position = chInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropch()
    {
        float Distance = Vector3.Distance(ch.transform.position, chBlack.transform.position);
        if (Distance < 50)
        {

            ch.transform.position = chBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = chcorrect[Random.Range(0, chcorrect.Length)];
            source.Play();
            chCorrect = true;
        }
        else
        {
            ch.transform.position = chInitialPos;
            a.transform.position = aInitialPos;
            yu.transform.position = yuInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    void Update()
    {
        if (aCorrect && yuCorrect && chCorrect)
        {
            Debug.Log("You Win");

        }
    }
}
