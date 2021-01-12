using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager11 : MonoBehaviour
{
    public GameObject s, g, sBlack, gBlack;
   

    Vector2 ngInitialPos, sInitialPos, gInitialPos;

    public AudioSource source;
    public AudioClip[] scorrect;
    public AudioClip[] gcorrect;
    public AudioClip incorrect;

    bool sCorrect, gCorrect = false;

    void Start()
    {
        sInitialPos = s.transform.position;
        gInitialPos = g.transform.position;
    }
    

    public void Drags()
    {
        s.transform.position = Input.mousePosition;
    }

    public void Dragg()
    {
        g.transform.position = Input.mousePosition;
    }

    
    public void Drops()
    {
        float Distance = Vector3.Distance(s.transform.position, sBlack.transform.position);
        if (Distance < 50)
        {

            s.transform.position = sBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = scorrect[Random.Range(0, scorrect.Length)];
            source.Play();
            sCorrect = true;
        }
        else
        {
            s.transform.position = sInitialPos;
            g.transform.position = gInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Dropg()
    {
        float Distance = Vector3.Distance(g.transform.position, gBlack.transform.position);
        if (Distance < 50)
        {

            g.transform.position = gBlack.transform.position;
            DBManager.scoreValue += 2;
            source.clip = gcorrect[Random.Range(0, gcorrect.Length)];
            source.Play();
            gCorrect = true;
        }
        else
        {
            g.transform.position = gInitialPos;
            s.transform.position = sInitialPos;
            DBManager.scoreValue -= 1;
            GameControlScript.health -= 1;
            source.clip = incorrect;
            source.Play();
        }
    }
    void Update()
    {
        if(sCorrect && gCorrect)
        {
            Debug.Log("You Win");

        }
    }
}