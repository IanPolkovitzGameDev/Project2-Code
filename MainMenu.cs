using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public Button start_button;

    void Start()
    {
        Button start = start_button.GetComponent<Button>();
    }

    public void game_start()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PirateGame");
    }
}
