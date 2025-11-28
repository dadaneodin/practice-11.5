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

    IEnumerator MyDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        TogglePause(); // или что там тебе надо
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ObjectToActivate.SetActive(true);
            ObjectToActivate2.SetActive(true);
            StartCoroutine(MyDelay(3f));
            // TogglePause();

        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
    }
}
