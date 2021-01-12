using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager66 : MonoBehaviour
{

    public GameObject eo, ya, t, m, eoBlack, yaBlack, tBlack, mBlack;

    Vector2 eoInitialPos, yaInitialPos, tInitialPos, mInitialPos;

    public AudioSource source;
    public AudioClip[] eocorrect;
    public AudioClip[] yacorrect;
    public AudioClip[] tcorrect;
    public AudioClip[] mcorrect;
    public AudioClip incorrect;

    bool eoCorrect, yaCorrect, tCorrect, mCorrect = false;
    void Start()
    {
        eoInitialPos = eo.transform.position;
        yaInitialPos = ya.transform.position;
        tInitialPos = t.transform.position;
        mInitialPos = m.transform.position;
    }
    public void Drageo()
    {
        eo.transform.position = Input.mousePosition;
    }

    public void Dragya()
    {
        ya.transform.position = Input.mousePosition;
    }

    public void Dragt()
    {
        t.transform.position = Input.mousePosition;
    }
    public void Dragm()
    {
        m.transform.position = Input.mousePosition;
    }

    public void Dropeo()
    {
        float Distance = Vector3.Distance(eo.transform.position, eoBlack.transform.position);
        if (Distance < 50)
        {

            eo.transform.position = eoBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = eocorrect[Random.Range(0, eocorrect.Length)];
            source.Play();
            eoCorrect = true;
        }

        else
        {

            eo.transform.position = eoInitialPos;
            ya.transform.position = yaInitialPos;
            t.transform.position = tInitialPos;
            m.transform.position = mInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropya()
    {
        float Distance = Vector3.Distance(ya.transform.position, yaBlack.transform.position);
        if (Distance < 50)
        {

            ya.transform.position = yaBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = yacorrect[Random.Range(0, yacorrect.Length)];
            source.Play();
            yaCorrect = true;
        }
        else
        {
            ya.transform.position = yaInitialPos;
            eo.transform.position = eoInitialPos;
            t.transform.position = tInitialPos;
            m.transform.position = mInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropt()
    {
        float Distance = Vector3.Distance(t.transform.position, tBlack.transform.position);
        if (Distance < 50)
        {

            t.transform.position = tBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = tcorrect[Random.Range(0, tcorrect.Length)];
            source.Play();
            tCorrect = true;
        }
        else
        {
            t.transform.position = tInitialPos;
            eo.transform.position = eoInitialPos;
            ya.transform.position = yaInitialPos;
            m.transform.position = mInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropm()
    {
        float Distance = Vector3.Distance(m.transform.position, mBlack.transform.position);
        if (Distance < 50)
        {

            m.transform.position = mBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = mcorrect[Random.Range(0, mcorrect.Length)];
            source.Play();
            mCorrect = true;
        }
        else
        {
            m.transform.position = mInitialPos;
            eo.transform.position = eoInitialPos;
            ya.transform.position = yaInitialPos;
            t.transform.position = tInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    void Update()
    {
        if (eoCorrect && yaCorrect && tCorrect && mCorrect)
        {
            Debug.Log("You Win");

        }
    }
}
