using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager44 : MonoBehaviour
{
    public GameObject k, n, h, kBlack, nBlack, hBlack;

    Vector2 kInitialPos, nInitialPos, hInitialPos;

    public AudioSource source;
    public AudioClip[] kcorrect;
    public AudioClip[] ncorrect;
    public AudioClip[] hcorrect;
    public AudioClip incorrect;

    bool kCorrect, nCorrect, hCorrect = false;
    void Start()
    {
        kInitialPos = k.transform.position;
        nInitialPos = n.transform.position;
        hInitialPos = h.transform.position;
    }
    public void Dragk()
    {
        k.transform.position = Input.mousePosition;
    }

    public void Dragn()
    {
        n.transform.position = Input.mousePosition;
    }

    public void Dragh()
    {
        h.transform.position = Input.mousePosition;
    }

    public void Dropk()
    {
        float Distance = Vector3.Distance(k.transform.position, kBlack.transform.position);
        if (Distance < 50)
        {

            k.transform.position = kBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = kcorrect[Random.Range(0, kcorrect.Length)];
            source.Play();
            kCorrect = true;
        }

        else
        {

            k.transform.position = kInitialPos;
            n.transform.position = nInitialPos;
            h.transform.position = hInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropn()
    {
        float Distance = Vector3.Distance(n.transform.position, nBlack.transform.position);
        if (Distance < 50)
        {

            n.transform.position = nBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = ncorrect[Random.Range(0, ncorrect.Length)];
            source.Play();
            nCorrect = true;
        }
        else
        {
            n.transform.position = nInitialPos;
            k.transform.position = kInitialPos;
            h.transform.position = hInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Droph()
    {
        float Distance = Vector3.Distance(h.transform.position, hBlack.transform.position);
        if (Distance < 50)
        {

            h.transform.position = hBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = hcorrect[Random.Range(0, hcorrect.Length)];
            source.Play();
            hCorrect = true;
        }
        else
        {
            h.transform.position = hInitialPos;
            k.transform.position = kInitialPos;
            n.transform.position = nInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    void Update()
    {
        if (kCorrect && nCorrect && hCorrect)
        {
            Debug.Log("You Win");

        }
    }
}
