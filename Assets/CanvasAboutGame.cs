using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasAboutGame : MonoBehaviour
{
    public GameObject GameObject;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.SetActive(true);
            
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.SetActive(false);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
