using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text playerDisplay;
    public Text scoreDisplay;
   

    public static int scoreValue = 0;
    
    
    private void Awake()
    {
        scoreDisplay = GetComponent<Text>();

        if (DBManager.username == null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }

        playerDisplay.text = "Player: " + DBManager.username;
        scoreDisplay.text = "Score: " + DBManager.scoreValue;
    }

    public void CallSaveData()
    {
        StartCoroutine(SavePlayerData());
    }

    IEnumerator SavePlayerData()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", DBManager.username);
        form.AddField("score", DBManager.scoreValue);

        WWW www = new WWW("http://localhost/sqlconnect/savedata.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("Game Saved");
        }
        else
        {
            Debug.Log("Save failed. Error #" + www.text);
        }

        DBManager.Logout();
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);

    }

    void Update()
    {
        try{
            scoreDisplay.text = "Score:" + DBManager.scoreValue;
        }
        catch (System.NullReferenceException ex)
        {
            Debug.Log("Object Not found");
        }


    }

}
