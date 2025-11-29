using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasOffAfterTime : MonoBehaviour
{

    private bool isPause = false;
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
        isPause = !isPause;
        Time.timeScale = isPause ? 0 : 1;
    }
}
