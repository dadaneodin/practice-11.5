using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class FInishTrigger1 : MonoBehaviour
{
    public GameObject ObjectToActivate;
    public GameObject ObjectToActivate2;
    public MonoBehaviour targetScript;
    public MonoBehaviour targetScript2;
    // private bool isPaused = false;

    


    // IEnumerator MyDelay(float delay)
    // {
    //     yield return new WaitForSeconds(delay);
    //     TogglePause(); // или что там тебе надо
    // }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ObjectToActivate.SetActive(true);
            ObjectToActivate2.SetActive(true);
            // StartCoroutine(MyDelay(3f));
            // // TogglePause();
            DesableScript();

        }
    }
    void DesableScript()
    {
        targetScript.enabled = false;
        targetScript2.enabled = false;
    }
    // public void TogglePause()
    // {
    //     isPaused = !isPaused;
    //     Time.timeScale = isPaused ? 0 : 1;
    // }
}
