using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager3 : MonoBehaviour
{
    public GameObject Ah, Nyeong, Ha, Se, Yo, AhAns, NyeongAns, HaAns, SeAns, YoAns;
    Vector2 AhInitialPos, NyeongInitialPos, HaInitialPos, SeInitialPos, YoInitialPos;

    
    public AudioSource source;
    public AudioClip[] Ahcorrect;
    public AudioClip[] Nyeongcorrect;
    public AudioClip[] Hacorrect;
    public AudioClip[] Secorrect;
    public AudioClip[] Yocorrect;
    public AudioClip incorrect;

    bool AhCorrect, NyeongCorrect, HaCorrect, SeCorrect, YoCorrect = false;
    void Start()
    {
        AhInitialPos = Ah.transform.position;
        NyeongInitialPos = Nyeong.transform.position;
        HaInitialPos = Ha.transform.position;
        SeInitialPos = Se.transform.position;
        YoInitialPos = Yo.transform.position;

    }

    public void DragAh()
    {
        Ah.transform.position = Input.mousePosition;
    }

    public void DragNyeong()
    {
        Nyeong.transform.position = Input.mousePosition;
    }

    public void DragHa()
    {
        Ha.transform.position = Input.mousePosition;
    }

    public void DragSe()
    {
        Se.transform.position = Input.mousePosition;
    }

    public void DragYo()
    {
        Yo.transform.position = Input.mousePosition;
    }

    public void DropAh()
    {
        float Distance = Vector3.Distance(Ah.transform.position, AhAns.transform.position);
        if (Distance < 50)
        {
            Ah.transform.position = AhAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Ahcorrect[Random.Range(0, Ahcorrect.Length)];
            source.Play();
            AhCorrect = true;
        }
        else
        {
            Ah.transform.position = AhInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Nyeong.transform.position = NyeongInitialPos;
            Ha.transform.position = HaInitialPos;
            Se.transform.position = SeInitialPos;
            Yo.transform.position = YoInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropNyeong()
    {
        float Distance = Vector3.Distance(Nyeong.transform.position, NyeongAns.transform.position); //returns the distance between the characters, original position and new position
        if (Distance < 50) ///drag function
        {
            Nyeong.transform.position = NyeongAns.transform.position; //allows character to drop to new defined position
            DBManager.scoreValue += 2;
            source.clip = Nyeongcorrect[Random.Range(0, Nyeongcorrect.Length)];
            source.Play();
            NyeongCorrect = true;
        }
        else //character moves back to original position
        {
            Nyeong.transform.position = NyeongInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Ah.transform.position = AhInitialPos;
            Ha.transform.position = HaInitialPos;
            Se.transform.position = SeInitialPos;
            Yo.transform.position = YoInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropHa()
    {
        float Distance = Vector3.Distance(Ha.transform.position, HaAns.transform.position);
        if (Distance < 50)
        {
            Ha.transform.position = HaAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Hacorrect[Random.Range(0, Hacorrect.Length)];
            source.Play();
            HaCorrect = true;
        }
        else
        {
            Ha.transform.position = HaInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Ah.transform.position = AhInitialPos;
            Nyeong.transform.position = NyeongInitialPos;
            Se.transform.position = SeInitialPos;
            Yo.transform.position = YoInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropSe()
    {
        float Distance = Vector3.Distance(Se.transform.position, SeAns.transform.position);
        if (Distance < 50) 
        {
            Se.transform.position = SeAns.transform.position; 
            DBManager.scoreValue += 2; //adds 2 to the score value
            source.clip = Secorrect[Random.Range(0, Secorrect.Length)];
            source.Play();
            SeCorrect = true;
        }
        else 
        {
            Se.transform.position = SeInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1; //subtracts 1 from the score value
            Ah.transform.position = AhInitialPos;
            Nyeong.transform.position = NyeongInitialPos;
            Ha.transform.position = HaInitialPos;
            Yo.transform.position = YoInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropYo()
    {
        float Distance = Vector3.Distance(Yo.transform.position, YoAns.transform.position);
        if (Distance < 50) 
        {
            Yo.transform.position = YoAns.transform.position;
            DBManager.scoreValue += 2; //adds 2 to the score value
            source.clip = Yocorrect[Random.Range(0, Yocorrect.Length)];
            source.Play();
            YoCorrect = true;
        }
        else 
        {
            Yo.transform.position = YoInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1; //subtracts 1 from the score value
            Ah.transform.position = AhInitialPos;
            Nyeong.transform.position = NyeongInitialPos;
            Ha.transform.position = HaInitialPos;
            Se.transform.position = SeInitialPos;
            GameControlScript.health -= 1;
        }
    }
    void Update()
    {
        if (AhCorrect && NyeongCorrect && HaCorrect && SeCorrect && YoCorrect) //checks if all answers are correct
        {
            Debug.Log("You Win");

        }
    }

    public void Display()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    

    
}

