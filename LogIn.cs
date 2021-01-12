using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogIn : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;

    public Button submitButton;

    [System.Obsolete]
    public void CallLogin()
    {
        StartCoroutine(Login());
    }

    [System.Obsolete]
    IEnumerator Login()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("http://localhost/sqlconnect/login.php", form);
        yield return www;
        if (www.text[0] == '0')
        {
            DBManager.username = nameField.text;
            DBManager.scoreValue = int.Parse(www.text.Split('\t')[1]);
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("User Log In Failed. Error #" + www.text);
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 3 && passwordField.text.Length >= 3);
    }
}
