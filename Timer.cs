using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public string LabelText = "Time";
    public string displayedText;
    public float totalTime = 300.0f;
    private string displayedTime;
    //public float positionX;
    public float positionXscale;
    public float positionY;
    public float positionYscale;

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        if (totalTime <= 0.0f)
        {
            timerEnded();
        }
        else
        {
            displayTimeCalculator(totalTime);
            LabelText = ("Current time remaining: " + displayedTime);
            displayedText = LabelText;
        }
    }
    public void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 20;
        myStyle.normal.textColor = Color.yellow;
        GUI.Label(new Rect(Screen.width / 2, positionXscale, positionY, positionYscale), displayedText, myStyle);

    }
    void displayTimeCalculator(float time)
    {
        string minutes = "" + (int)time / 60;
        string seconds = "00";
        if ((int)time % 60 != 0)
        {
            seconds = "" + (int)time % 60;
        }
        if ((int)time % 60 < 10)
        {
            displayedTime = minutes + ":0" + seconds;
        }
        else
        {
            displayedTime = minutes + ":" + seconds;
        }
    }
    void timerEnded()
    {
        displayedText = "OUT OF TIME!!!!";
    }
}