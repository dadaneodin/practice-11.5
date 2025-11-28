using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class FInishTrigger1 : MonoBehaviour
{
    public GameObject ObjectToActivate;
    public GameObject ObjectToActivate2;
    private bool isPaused = false;
    // public void OnTriggerEnter(Collision other)
    // {
    //     if (other.gameObject.CompareTag("Player"))
    //     {
    //         ObjectToActivate.SetActive(true);
    //     }
    // }
    
    void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.CompareTag("Player"))
        {
            ObjectToActivate.SetActive(true);
            ObjectToActivate2.SetActive(true);
            // TogglePause();

        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
    }
}
