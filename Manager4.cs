using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager4 : MonoBehaviour
{
    public GameObject Empty, Ae, G, Yoo, EmptyAns, AeAns, GAns, YooAns;
    Vector2 EmptyInitialPos, AeInitialPos, GInitialPos, YooInitialPos;

   

    public AudioSource source;
    public AudioClip[] Emptycorrect;
    public AudioClip[] Aecorrect;
    public AudioClip[] Gcorrect;
    public AudioClip[] Yoocorrect;
    public AudioClip incorrect;

    bool EmptyCorrect, AeCorrect, GCorrect, YooCorrect = false;
    void Start()
    {
        EmptyInitialPos = Empty.transform.position;
        AeInitialPos = Ae.transform.position;
        GInitialPos = G.transform.position;
        YooInitialPos = Yoo.transform.position;

    }

    public void DragEmpty()
    {
        Empty.transform.position = Input.mousePosition;
    }

    public void DragAe()
    {
        Ae.transform.position = Input.mousePosition;
    }

    public void DragG()
    {
        G.transform.position = Input.mousePosition;
    }

    public void DragYoo()
    {
        Yoo.transform.position = Input.mousePosition;
    }

    
    public void DropEmpty()
    {
        float Distance = Vector3.Distance(Empty.transform.position, EmptyAns.transform.position);
        if (Distance < 50)
        {
            Empty.transform.position = EmptyAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Emptycorrect[Random.Range(0, Emptycorrect.Length)];
            source.Play();
            EmptyCorrect = true;
        }
        else
        {
            Empty.transform.position = EmptyInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Ae.transform.position = AeInitialPos;
            G.transform.position = GInitialPos;
            Yoo.transform.position = YooInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropAe()
    {
        float Distance = Vector3.Distance(Ae.transform.position, AeAns.transform.position);
        if (Distance < 50)
        {
            Ae.transform.position = AeAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Aecorrect[Random.Range(0, Aecorrect.Length)];
            source.Play();
            AeCorrect = true;
        }
        else
        {
            Ae.transform.position = AeInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Empty.transform.position = EmptyInitialPos;
            G.transform.position = GInitialPos;
            Yoo.transform.position = YooInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropG()
    {
        float Distance = Vector3.Distance(G.transform.position, GAns.transform.position);
        if (Distance < 50)
        {
            G.transform.position = GAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Gcorrect[Random.Range(0, Gcorrect.Length)];
            source.Play();
            GCorrect = true;
        }
        else
        {
            G.transform.position = GInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Empty.transform.position = EmptyInitialPos;
            Ae.transform.position = AeInitialPos;
            Yoo.transform.position = YooInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropYoo()
    {
        float Distance = Vector3.Distance(Yoo.transform.position, YooAns.transform.position);
        if (Distance < 50)
        {
            Yoo.transform.position = YooAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Yoocorrect[Random.Range(0, Yoocorrect.Length)];
            source.Play();
            YooCorrect = true;
        }
        else
        {
            Yoo.transform.position = YooInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Empty.transform.position = EmptyInitialPos;
            Ae.transform.position = AeInitialPos;
            G.transform.position = GInitialPos;
            GameControlScript.health -= 1;
        }
    }

    
    void Update()
    {
        if (EmptyCorrect && AeCorrect && GCorrect && YooCorrect)
        {
            Debug.Log("You Win");
            
        }
    }

    
    
}
