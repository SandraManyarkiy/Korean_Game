using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float TimeStart = 5;
    public Text textBox;
    // Start is called before the first frame update
    void Start()
    {
        textBox.text = TimeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        TimeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(TimeStart).ToString();
    }
}
