using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager6 : MonoBehaviour
{
    public GameObject Ban, Gap, Sum, Ni, Da, BanAns, GapAns, SumAns, NiAns, DaAns;
    Vector2 BanInitialPos, GapInitialPos, SumInitialPos, NiInitialPos, DaInitialPos;

    public AudioSource source;
    public AudioClip[] Anscorrect;
    public AudioClip[] Bancorrect;
    public AudioClip[] Gapcorrect;
    public AudioClip[] Sumcorrect;
    public AudioClip[] Nicorrect;
    public AudioClip[] Dacorrect;
    public AudioClip incorrect;

    bool BanCorrect, GapCorrect, SumCorrect, NiCorrect, DaCorrect = false;
    void Start()
    {
        BanInitialPos = Ban.transform.position;
        GapInitialPos = Gap.transform.position;
        SumInitialPos = Sum.transform.position;
        NiInitialPos = Ni.transform.position;
        DaInitialPos = Da.transform.position;

    }

    public void DragBan()
    {
        Ban.transform.position = Input.mousePosition;
    }

    public void DragGap()
    {
        Gap.transform.position = Input.mousePosition;
    }

    public void DragSum()
    {
        Sum.transform.position = Input.mousePosition;
    }

    public void DragNi()
    {
        Ni.transform.position = Input.mousePosition;
    }

    public void DragDa()
    {
        Da.transform.position = Input.mousePosition;
    }


    public void DropBan()
    {
        float Distance = Vector3.Distance(Ban.transform.position, BanAns.transform.position);
        if (Distance < 50)
        {
            Ban.transform.position = BanAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Bancorrect[Random.Range(0, Bancorrect.Length)];
            source.Play();
            BanCorrect = true;
        }
        else
        {
            Ban.transform.position = BanInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Gap.transform.position = GapInitialPos;
            Sum.transform.position = SumInitialPos;
            Ni.transform.position = NiInitialPos;
            Da.transform.position = DaInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropGap()
    {
        float Distance = Vector3.Distance(Gap.transform.position, GapAns.transform.position);
        if (Distance < 50)
        {
            Gap.transform.position = GapAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Gapcorrect[Random.Range(0, Gapcorrect.Length)];
            source.Play();
            GapCorrect = true;
        }
        else
        {
            Gap.transform.position = GapInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Ban.transform.position = BanInitialPos;
            Sum.transform.position = SumInitialPos;
            Ni.transform.position = NiInitialPos;
            Da.transform.position = DaInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropSum()
    {
        float Distance = Vector3.Distance(Sum.transform.position, Sum.transform.position);
        if (Distance < 50)
        {
            Sum.transform.position = SumAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Sumcorrect[Random.Range(0, Sumcorrect.Length)];
            source.Play();
            SumCorrect = true;
        }
        else
        {
            Sum.transform.position = SumInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Ban.transform.position = BanInitialPos;
            Gap.transform.position = GapInitialPos;
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
            Ban.transform.position = BanInitialPos;
            Gap.transform.position = GapInitialPos;
            Sum.transform.position = SumInitialPos;
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
            Ban.transform.position = BanInitialPos;
            Gap.transform.position = GapInitialPos;
            Sum.transform.position = SumInitialPos;
            Ni.transform.position = NiInitialPos;
            GameControlScript.health -= 1;
        }
    }


    void Update()
    {
        if (BanCorrect && GapCorrect && SumCorrect && NiCorrect && DaCorrect)
        {
            Debug.Log("You Win"); 
            source.clip = Anscorrect[Random.Range(0, Anscorrect.Length)];
            source.Play();
            
        }
    }
}
