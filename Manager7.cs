using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager7 : MonoBehaviour
{
    public GameObject Kam, Sa, Ham, Ni, Da, KamAns, SaAns, HamAns, NiAns, DaAns;
    Vector2 KamInitialPos, SaInitialPos, HamInitialPos, NiInitialPos, DaInitialPos;

    public AudioSource source;
    public AudioClip[] Kamcorrect;
    public AudioClip[] Sacorrect;
    public AudioClip[] Hamcorrect;
    public AudioClip[] Nicorrect;
    public AudioClip[] Dacorrect;
    public AudioClip incorrect;

    bool KamCorrect, SaCorrect, HamCorrect, NiCorrect, DaCorrect = false;
    void Start()
    {
        KamInitialPos = Kam.transform.position;
        SaInitialPos = Sa.transform.position;
        HamInitialPos = Ham.transform.position;
        NiInitialPos = Ni.transform.position;
        DaInitialPos = Da.transform.position;

    }

    public void DragKam()
    {
        Kam.transform.position = Input.mousePosition;
    }

    public void DragSa()
    {
        Sa.transform.position = Input.mousePosition;
    }

    public void DragHam()
    {
        Ham.transform.position = Input.mousePosition;
    }

    public void DragNi()
    {
        Ni.transform.position = Input.mousePosition;
    }

    public void DragDa()
    {
        Da.transform.position = Input.mousePosition;
    }


    public void DropKam()
    {
        float Distance = Vector3.Distance(Kam.transform.position, KamAns.transform.position);
        if (Distance < 50)
        {
            Kam.transform.position = KamAns.transform.position;
            ScoreScript.scoreValue += 2;
            source.clip = Kamcorrect[Random.Range(0, Kamcorrect.Length)];
            source.Play();
            KamCorrect = true;
        }
        else
        {
            Kam.transform.position = KamInitialPos;
            source.clip = incorrect;
            source.Play();
            Kam.transform.position = KamInitialPos;
            Sa.transform.position = SaInitialPos;
            Ham.transform.position = HamInitialPos;
            Ni.transform.position = NiInitialPos;
            Da.transform.position = DaInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropSa()
    {
        float Distance = Vector3.Distance(Sa.transform.position, SaAns.transform.position);
        if (Distance < 50)
        {
            Sa.transform.position = SaAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Sacorrect[Random.Range(0, Sacorrect.Length)];
            source.Play();
            SaCorrect = true;
        }
        else
        {
            Sa.transform.position = SaInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Kam.transform.position = KamInitialPos;
            Ham.transform.position = HamInitialPos;
            Ni.transform.position = NiInitialPos;
            Da.transform.position = DaInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropHam()
    {
        float Distance = Vector3.Distance(Ham.transform.position, Ham.transform.position);
        if (Distance < 50)
        {
            Ham.transform.position = HamAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Hamcorrect[Random.Range(0, Hamcorrect.Length)];
            source.Play();
            HamCorrect = true;
        }
        else
        {
            Ham.transform.position = HamInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Kam.transform.position = KamInitialPos;
            Sa.transform.position = SaInitialPos;
            Ni.transform.position = NiInitialPos;
            Da.transform.position = DaInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropNi()
    {
        float Distance = Vector3.Distance(Ni.transform.position, NiAns.transform.position);
        if (Distance < 50)
        {
            Ni.transform.position = NiAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Nicorrect[Random.Range(0, Nicorrect.Length)];
            source.Play();
            NiCorrect = true;
        }
        else
        {
            Ni.transform.position = NiInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Kam.transform.position = KamInitialPos;
            Sa.transform.position = SaInitialPos;
            Ham.transform.position = HamInitialPos;
            Da.transform.position = DaInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropDa()
    {
        float Distance = Vector3.Distance(Da.transform.position, DaAns.transform.position);
        if (Distance < 50)
        {
            Da.transform.position = DaAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Dacorrect[Random.Range(0, Dacorrect.Length)];
            source.Play();
            DaCorrect = true;
        }
        else
        {
            Da.transform.position = DaInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Kam.transform.position = KamInitialPos;
            Sa.transform.position = SaInitialPos;
            Ham.transform.position = HamInitialPos;
            Ni.transform.position = NiInitialPos;
            GameControlScript.health -= 1;
        }
    }


    void Update()
    {
        if (KamCorrect && SaCorrect && HamCorrect && NiCorrect && DaCorrect)
        {
            Debug.Log("You Win");
            

        }
    }
}

