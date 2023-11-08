using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnTreasure : MonoBehaviour
{
    public GameObject treasure1;
    public GameObject treasure2;
    public GameObject treasure3;
    // Start is called before the first frame update
    void Start()
    {
        Vector3[] spawns = { new Vector3(0.77f, -.5f, -15.3f), new Vector3(-6.7f, 19.2f, 176.4f), new Vector3(-18.4f, 9f, 217f), new Vector3(49f, 2f, 77.6f), new Vector3(-9.6f, 9f, 43.7f) };
        GameObject[] treasures = { treasure1, treasure2, treasure3, null, null };
        Randomize(treasures);
        for (int i = 0; i < treasures.Length; i++)
        {
            if (treasures[i] != null)
            {
                treasures[i].transform.position = spawns[i];
            }
        }
    }

    public static void Randomize<GameObject>(GameObject[] items)
    {
        System.Random rand = new System.Random();

        // For each spot in the array, pick
        // a random item to swap into that spot.
        for (int i = 0; i < items.Length - 1; i++)
        {
            int j = rand.Next(i, items.Length);
            GameObject temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}