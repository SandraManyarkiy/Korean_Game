using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager1 : MonoBehaviour
{
    

    public GameObject Han, Guk, Ah, HanAns, GukAns, AhAns; //defines game object to be used in the inspector
       Vector2 HanInitialPos, GukInitialPos, AhInitialPos;


    //audio files
    public AudioSource source;
    public AudioClip[] Hancorrect;
    public AudioClip[] Gukcorrect;
    public AudioClip[] Ahcorrect;
    public AudioClip incorrect;

    bool HanCorrect, GukCorrect, AhCorrect = false;

    public void ChangeScene(int Changethesecene) //next button
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene (Changethesecene);
    }

    void Start() //positions game objects
    {
        HanInitialPos = Han.transform.position;
        GukInitialPos = Guk.transform.position;
        AhInitialPos = Ah.transform.position;
        
        

    }

    
    public void dragHan()
    {
        Han.transform.position = Input.mousePosition; //reads the the current mouse position.
    }

    public void dragGuk()
    {
        Guk.transform.position = Input.mousePosition;
    }

    public void dragAh()
    {
        Ah.transform.position = Input.mousePosition;
    }

    public void DropHan()
    {
        float Distance = Vector3.Distance(Han.transform.position, HanAns.transform.position); //returns the distance between the two characters, original position and new position
        if (Distance < 50) //checks distance then allows character to drop to new defined position 
        {
            Han.transform.position = HanAns.transform.position; 
            DBManager.scoreValue += 2; //adds 2 to the score value in the DB script
            source.clip = Hancorrect[Random.Range(0, Hancorrect.Length)];
            source.Play();
            HanCorrect = true;
        }
        else //character moves back to original position
        {
            Han.transform.position = HanInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Guk.transform.position = GukInitialPos;
            Ah.transform.position = AhInitialPos;
            GameControlScript.health -= 1;

        }
    }

    public void DropGuk()
    {
        float Distance = Vector3.Distance(Guk.transform.position, GukAns.transform.position);
        if (Distance < 50)
        {
            Guk.transform.position = GukAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Gukcorrect[Random.Range(0, Gukcorrect.Length)];
            source.Play();
            GukCorrect = true;
        }
        else
        {
            Guk.transform.position = GukInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Han.transform.position = HanInitialPos;
            Ah.transform.position = AhInitialPos;
            GameControlScript.health -= 1;

        }
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
            Han.transform.position = HanInitialPos;
            Guk.transform.position = GukInitialPos;
            GameControlScript.health -= 1;

        }
    }
    void Update()
    {
        if(HanCorrect && GukCorrect && AhCorrect) 
        {
            Debug.Log("You Win");
            

        }
    }
}
