using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollect : MonoBehaviour
{
    public GameBehaviour gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            gameManager.Items++;
        }
    }
}
