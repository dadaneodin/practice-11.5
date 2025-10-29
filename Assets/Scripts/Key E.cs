using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyE : MonoBehaviour
{
    public bool ePressed;
    public Animator animator;

    void Start()
    {
        
    }

    void Update()
    {
        ePressed = Input.GetKeyDown(KeyCode.E);
        Debug.Log("KeyE::Update(); -- ePressed:" + ePressed);
        if (ePressed == true)
        {
            animator.SetBool("ToOpen", !animator.GetBool("ToOpen"));
            // animator.SetBool("ToOpen", true);
        }
        
    }
}
