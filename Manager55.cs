 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager55 : MonoBehaviour
{
    public GameObject p, yeo, eu, i, pBlack, yeoBlack, euBlack, iBlack;

    Vector2 pInitialPos, yeoInitialPos, euInitialPos, iInitialPos;

    public AudioSource source;
    public AudioClip[] pcorrect;
    public AudioClip[] yeocorrect;
    public AudioClip[] eucorrect;
    public AudioClip[] icorrect;
    public AudioClip incorrect;

    bool pCorrect, yeoCorrect, euCorrect, iCorrect = false;
    void Start()
    {
        pInitialPos = p.transform.position;
        yeoInitialPos = yeo.transform.position;
        euInitialPos = eu.transform.position;
        iInitialPos = i.transform.position;
    }
    public void Dragp()
    {
        p.transform.position = Input.mousePosition;
    }

    public void Dragyeo()
    {
        yeo.transform.position = Input.mousePosition;
    }

    public void Drageu()
    {
        eu.transform.position = Input.mousePosition;
    }
    public void Dragi()
    {
        i.transform.position = Input.mousePosition;
    }

    public void Dropp()
    {
        float Distance = Vector3.Distance(p.transform.position, pBlack.transform.position);
        if (Distance < 50)
        {

            p.transform.position = pBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = pcorrect[Random.Range(0, pcorrect.Length)];
            source.Play();
            pCorrect = true;
        }

        else
        {

            p.transform.position = pInitialPos;
            yeo.transform.position = yeoInitialPos;
            eu.transform.position = euInitialPos;
            i.transform.position = iInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropyeo()
    {
        float Distance = Vector3.Distance(yeo.transform.position, yeoBlack.transform.position);
        if (Distance < 50)
        {

            yeo.transform.position = yeoBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = yeocorrect[Random.Range(0, yeocorrect.Length)];
            source.Play();
            yeoCorrect = true;
        }
        else
        {
            yeo.transform.position = yeoInitialPos;
            p.transform.position = pInitialPos;
            eu.transform.position = euInitialPos;
            i.transform.position = iInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropeu()
    {
        float Distance = Vector3.Distance(eu.transform.position, euBlack.transform.position);
        if (Distance < 50)
        {

            eu.transform.position = euBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = eucorrect[Random.Range(0, eucorrect.Length)];
            source.Play();
            euCorrect = true;
        }
        else
        {
            eu.transform.position = euInitialPos;
            p.transform.position = pInitialPos;
            yeo.transform.position = yeoInitialPos;
            i.transform.position = iInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropi()
    {
        float Distance = Vector3.Distance(i.transform.position, iBlack.transform.position);
        if (Distance < 50)
        {

            i.transform.position = iBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = icorrect[Random.Range(0, icorrect.Length)];
            source.Play();
            iCorrect = true;
        }
        else
        {
            i.transform.position = iInitialPos;
            p.transform.position = pInitialPos;
            yeo.transform.position = yeoInitialPos;
            eu.transform.position = euInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    void Update()
    {
        if (pCorrect && yeoCorrect && euCorrect && iCorrect)
        {
            Debug.Log("You Win");

        }
    }
}
