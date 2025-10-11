using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyE : MonoBehaviour
{
    public bool ePressed;
    void Start()
    {
        
    }

    void Update()
    {
        ePressed = Input.GetKey(KeyCode.E);
    }
}
