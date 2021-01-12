using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager77 : MonoBehaviour
{

    public GameObject u, o, d, b, uBlack, oBlack, dBlack, bBlack;

    Vector2 uInitialPos, oInitialPos, dInitialPos, bInitialPos;

    public AudioSource source;
    public AudioClip[] ucorrect;
    public AudioClip[] ocorrect;
    public AudioClip[] dcorrect;
    public AudioClip[] bcorrect;
    public AudioClip incorrect;

    bool uCorrect, oCorrect, dCorrect, bCorrect = false;
    void Start()
    {
        uInitialPos = u.transform.position;
        oInitialPos = o.transform.position;
        dInitialPos = d.transform.position;
        bInitialPos = b.transform.position;
    }
    public void Dragu()
    {
        u.transform.position = Input.mousePosition;
    }

    public void Drago()
    {
        o.transform.position = Input.mousePosition;
    }

    public void Dragd()
    {
        d.transform.position = Input.mousePosition;
    }
    public void Dragb()
    {
        b.transform.position = Input.mousePosition;
    }

    public void Dropu()
    {
        float Distance = Vector3.Distance(u.transform.position, uBlack.transform.position);
        if (Distance < 50)
        {

            u.transform.position = uBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = ucorrect[Random.Range(0, ucorrect.Length)];
            source.Play();
            uCorrect = true;
        }

        else
        {

            u.transform.position = uInitialPos;
            o.transform.position = oInitialPos;
            d.transform.position = dInitialPos;
            b.transform.position = bInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropo()
    {
        float Distance = Vector3.Distance(o.transform.position, oBlack.transform.position);
        if (Distance < 50)
        {

            o.transform.position = oBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = ocorrect[Random.Range(0, ocorrect.Length)];
            source.Play();
            oCorrect = true;
        }
        else
        {
            o.transform.position = oInitialPos;
            u.transform.position = uInitialPos;
            d.transform.position = dInitialPos;
            b.transform.position = bInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropd()
    {
        float Distance = Vector3.Distance(d.transform.position, dBlack.transform.position);
        if (Distance < 50)
        {

            d.transform.position = dBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = dcorrect[Random.Range(0, dcorrect.Length)];
            source.Play();
            dCorrect = true;
        }
        else
        {
            d.transform.position = dInitialPos;
            u.transform.position = uInitialPos;
            o.transform.position = oInitialPos;
            b.transform.position = bInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropb()
    {
        float Distance = Vector3.Distance(b.transform.position, bBlack.transform.position);
        if (Distance < 50)
        {

            b.transform.position = bBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = bcorrect[Random.Range(0, bcorrect.Length)];
            source.Play();
            bCorrect = true;
        }
        else
        {
            b.transform.position = bInitialPos;
            u.transform.position = uInitialPos;
            o.transform.position = oInitialPos;
            d.transform.position = dInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    void Update()
    {
        if (uCorrect && oCorrect && dCorrect && bCorrect)
        {
            Debug.Log("You Win");

        }
    }
}
