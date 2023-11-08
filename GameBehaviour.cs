using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameBehaviour : MonoBehaviour
{
    public string LabelText = "Find the 5 hidden treasures scattered throughout the world!";
    public int maxItems = 5;
    private int itemsCollected = 0;
    public float timeLeft
    {
        get { return timeLeft; }
        set 
        {   
            timeLeft = value;
            if (timeLeft < 0f)
            {

            }
        }
    }
    public int Items
    {
        get { return itemsCollected; }
        set
        {
            itemsCollected = value;
            if (itemsCollected >= maxItems)
            {
                LabelText = "You have found all the treasures! Congratulations!";
            }
            else
            {
                LabelText = "Treasures found, only " + (maxItems - itemsCollected) +
                " left.";
            }
        }
    }
    public void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 20;
        myStyle.normal.textColor = Color.yellow;
        GUI.Box(new Rect(20, 50, 150, 25), "Treasure Collected: " + itemsCollected, myStyle);
        GUI.Label(new Rect(Screen.width / 2, 50, 300, 50), LabelText, myStyle);

    }
}