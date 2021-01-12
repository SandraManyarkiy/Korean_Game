using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager2 : MonoBehaviour
{
    public GameObject Park, Chan, Yeol, ParkAns, ChanAns, YeolAns;
    Vector2 ParkInitialPos, ChanInitialPos, YeolInitialPos;

    
    

    public AudioSource source;
    public AudioClip[] Parkcorrect;
    public AudioClip[] Chancorrect;
    public AudioClip[] Yeolcorrect;
    public AudioClip incorrect;

    bool ParkCorrect, ChanCorrect, YeolCorrect = false;
    void Start()
    {
        ParkInitialPos = Park.transform.position;
        ChanInitialPos = Chan.transform.position;
        YeolInitialPos = Yeol.transform.position;

    }

    public void DragPark()
    {
        Park.transform.position = Input.mousePosition;
    }

    public void DragChan()
    {
        Chan.transform.position = Input.mousePosition;
    }

    public void DragYeol()
    {
        Yeol.transform.position = Input.mousePosition;
    }

    public void DropPark()
    {
        float Distance = Vector3.Distance(Park.transform.position, ParkAns.transform.position);
        if (Distance < 50)
        {
            Park.transform.position = ParkAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Parkcorrect[Random.Range(0, Parkcorrect.Length)];
            source.Play();
            ParkCorrect = true;
        }
        else
        {
            Park.transform.position = ParkInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Chan.transform.position = ChanInitialPos;
            Yeol.transform.position = YeolInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropChan()
    {
        float Distance = Vector3.Distance(Chan.transform.position, ChanAns.transform.position);
        if (Distance < 50)
        {
            Chan.transform.position = ChanAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Chancorrect[Random.Range(0, Chancorrect.Length)];
            source.Play();
            ChanCorrect = true;
        }
        else
        {
            Chan.transform.position = ChanInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Park.transform.position = ParkInitialPos;
            Yeol.transform.position = YeolInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropYeol()
    {
        float Distance = Vector3.Distance(Yeol.transform.position, YeolAns.transform.position);
        if (Distance < 50)
        {
            Yeol.transform.position = YeolAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Yeolcorrect[Random.Range(0, Yeolcorrect.Length)];
            source.Play();
            YeolCorrect = true;
        }
        else
        {
            Yeol.transform.position = YeolInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Park.transform.position = ParkInitialPos;
            Chan.transform.position = ChanInitialPos;
            GameControlScript.health -= 1;
        }
    }
    void Update()
    {
        if (ParkCorrect && ChanCorrect && YeolCorrect)
        {
            Debug.Log("You Win");
            
        }
    }

    
}

