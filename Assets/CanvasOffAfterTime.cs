using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasOffAfterTime : MonoBehaviour
{

    private bool isPaused = false;
    IEnumerator MyDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        TogglePause(); // или что там тебе надо
    }
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
    }
}
