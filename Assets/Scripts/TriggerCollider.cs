using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerColeder : MonoBehaviour
{
    public GameObject Canvas;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Canvas.SetActive(true);
            
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Canvas.SetActive(false);
        }
    }
}

